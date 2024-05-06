﻿namespace Domain
{
    public class GetFacultyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null;
        public FacultyStatus Status { get; set; }
    }
}
