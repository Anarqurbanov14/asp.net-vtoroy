﻿namespace HomeWork2.Data.Entity;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public string Surname { get; set; }=string.Empty;
    public string? Address { get; set; } = string.Empty;
}
