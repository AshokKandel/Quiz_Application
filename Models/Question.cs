﻿namespace Quiz_Application.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Quiz_Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
    }
    
}
