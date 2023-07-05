﻿using AutoMapper;
using Cobit_19.Data;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;
using Cobit_19.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Cobit_19.Business.Audits
{
    public class AuditProvider : AppProvider<AuditModel, int>
    {
        private readonly IMapper _mapper;
        public AuditProvider(IMapper mapper, AppDbContext dbContext) : base(dbContext)
        {
            _mapper = mapper;
        }

        // Get audit by id with focus area and design factors
        public async Task<AuditDto> getAsync(int id)
        {
            var quary = await _dbContext.Audits
            .Include(a => a.FocusArea)
            .ThenInclude(a => a.DesignFactors)
                .ThenInclude(df => df.Questions)
                    .ThenInclude(q => q.Answers)
            .FirstOrDefaultAsync(a => a.ID == id);
            return _mapper.Map<AuditDto>(quary);
        }

        // Get all audits
        public async Task<IEnumerable<AuditDto>> getAllAsync()
        {
            var quary = await _dbContext.Audits
                .ToListAsync();
            return _mapper.Map<IEnumerable<AuditDto>>(quary);
        }

        public async Task<IEnumerable<AuditDto>> getAllByUserAsync(int userId)
        {
            var quary = await _dbContext.Audits
                .Where(a => a.UserID == userId)
                .ToListAsync();
            return _mapper.Map<IEnumerable<AuditDto>>(quary);
        }

        public async Task<IEnumerable<AuditDto>> getAllByFocusAreaAsync(int focusAreaId)
        {
            var quary = await _dbContext.Audits
                .Where(a => a.FocusAreaID == focusAreaId)
                .ToListAsync();
            return _mapper.Map<IEnumerable<AuditDto>>(quary);
        }

        public async Task<IEnumerable<DesignFactorDto>> getDesignFactorsAsync(int auditId)
        {
            var DesignFactors = await _dbContext.FocusAreas
                .Where(f => f.Audits.Any(a => a.ID == auditId))
                .SelectMany(f => f.DesignFactors)
                .Include(df => df.Questions)
                    .ThenInclude(q => q.Answers)
                .ToListAsync();

            return _mapper.Map<IEnumerable<DesignFactorDto>>(DesignFactors);
        }

        public async Task<DesignFactorDto> getDesignFactorFullAsync(int auditId, int designFactorId)
        {
            var DesignFactor = await _dbContext.FocusAreas
                .Where(f => f.Audits.Any(a => a.ID == auditId))
                .SelectMany(f => f.DesignFactors)
                .Include(df => df.Questions)
                    .ThenInclude(q => q.Answers)
                .Include(df => df.Questions)
                    .ThenInclude(q => q.Maps)
                        .ThenInclude(m => m.Objective)
                .FirstOrDefaultAsync(df => df.ID == designFactorId);

            return _mapper.Map<DesignFactorDto>(DesignFactor);
        }

        public async Task<AuditEditorDto> createAsync(AuditEditorDto auditEditorDto)
        {
            // Create Audit
            var audit = new AuditModel
            {
                Name = auditEditorDto.Name,
                FocusAreaID = auditEditorDto.FocusAreaID,
                UserID = auditEditorDto.UserID,
                Status = auditEditorDto.Status,
                DateCreated = auditEditorDto.DateCreated,
            };

            await AddAsync(audit);

            // Create Answers
            var DesignFactors = await getDesignFactorsAsync(audit.ID);
            foreach (var DF in DesignFactors)
            {
                foreach (var question in DF.Questions)
                {
                    var answer = new AnswerModel
                    {
                        AuditID = audit.ID,
                        QuestionID = question.ID,
                    };
                    _dbContext.Answers.Add(answer);
                }
            }

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<AuditEditorDto>(audit);
        }

        public async Task<AuditDto> deleteAsync(int id)
        {
            var audit = await getAsync(id);
            // Remove answers
            foreach (var answer in _dbContext.Answers.Where(a => a.AuditID == id))
            {
                _dbContext.Answers.Remove(answer);
            }
            await _dbContext.SaveChangesAsync();

            await DeleteAsync(id);

            return audit;
        }

        public async Task<AuditDto> updateAsync(AuditEditorDto auditEditorDto)
        {
            var audit = _dbContext.Audits
                .Where(a => a.ID == auditEditorDto.ID)
                .First();

            _mapper.Map(auditEditorDto, audit);

            // Update DateCompleted
            if (audit.Status == AuditStatus.InProgress)
            {
                audit.DateCompleted = null;
            }
            else if (audit.Status == AuditStatus.Completed)
            {
                audit.DateCompleted = DateTime.Now;
            }
            _dbContext.Audits.Update(audit);

            await _dbContext.SaveChangesAsync();

            return _mapper.Map<AuditDto>(audit);
        }
    }
}