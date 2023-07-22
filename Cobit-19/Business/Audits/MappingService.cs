using Cobit_19.Shared.Dtos;
using Microsoft.IdentityModel.Tokens;

namespace Cobit_19.Business.Audits
{
    public static class MappingService
    {
        public static List<ObjectiveValueDto> Calculate(DesignFactorDto designFactorDto, List<ObjectiveDto> objectives)
        {
            List<ObjectiveValueDto> objectiveValues = new List<ObjectiveValueDto>();

            foreach (var objective in objectives)
            {
                var objectiveValue = new ObjectiveValueDto()
                {
                    Objective = objective.Name,
                    Score = 0,
                    BaselineScore = 0,
                    RelativeInportance = 0
                };

                foreach (var question in designFactorDto.Questions)
                { 
                    if (question.Maps.IsNullOrEmpty())
                    {
                        return null;
                    }
                    double weight = question.Maps.Where(m => m.ObjectiveID == objective.ID).First().Weight;
                    double answer = question.Answers.First().Answer;
                    double baseline = question.BaseAnswer;

                    objectiveValue.Score += weight * answer;
                    objectiveValue.BaselineScore += weight * baseline;

                    // If odds is not 0, multiply the value by the odds
                    if(question.Answers.First().Odds != 0)
                    {
                        objectiveValue.Score *= question.Answers.First().Odds;
                        objectiveValue.BaselineScore *= question.Answers.First().Odds;
                    }
                }

                objectiveValue.RelativeInportance = objectiveValue.Score - objectiveValue.BaselineScore;

                objectiveValues.Add(objectiveValue);
            }

            return objectiveValues;
        }
    }
}
