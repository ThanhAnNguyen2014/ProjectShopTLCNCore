using System;
using System.Collections.Generic;

namespace ProjectShopTLCNCore.Models
{
    public partial class SurveyAnswers
    {
        public int Id { get; set; }
        public int? SurveyQuestionId { get; set; }
        public string AnswerContent { get; set; }

        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
