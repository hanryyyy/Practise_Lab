﻿using System;
    public static void Main()
    {
        IList<Student> studentList = new List<Student>() {
        var distinctStudents = studentList.Distinct(new StudentComparer());
        foreach (var std in distinctStudents)
            Console.WriteLine(std.StudentName);
    }
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public bool Equals(Student x, Student y)
    {
        if (x.StudentID == y.StudentID
        && x.StudentName.ToLower() == y.StudentName.ToLower())
            return true;
        return false;
    }
    public int GetHashCode(Student obj)
    {
        return obj.StudentID.GetHashCode();
    }
}