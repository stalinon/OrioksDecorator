﻿namespace OrioksDecorator.Models.Disciplines
{
    public sealed class Resourses
    {
        public int DisId { get; set; }
        public int SciId { get; set; }
        public string DisName { get; set; }
        public IEnumerable<Resourse> ResoursesList { get; set; }
    }
}
