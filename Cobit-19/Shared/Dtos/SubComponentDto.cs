﻿namespace Cobit_19.Shared.Dtos
{
    public class SubComponentDto
    {
        public string subComponentName { get; set; }
        public string subComponentDescription { get; set; }
        public List<ComponentQuestionDto> questions { get; set; }
    }
}
