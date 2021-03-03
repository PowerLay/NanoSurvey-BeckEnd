﻿using System.Collections.Generic;

namespace NanoSurvey_BackEnd.Survey
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
    }
}