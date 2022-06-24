using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        private List<Student> students;

        public int Capacity { get; set; }
        public int Count => students.Count;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return "No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Any(x => x.FirstName == firstName && x.LastName == lastName))
            {
                Student studentToRemove = students.Where(x => x.FirstName == firstName && x.LastName == lastName).First();
                students.Remove(studentToRemove);
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> studentsInSubject = students.Where(x => x.Subject == subject).ToList();
            StringBuilder sb = new StringBuilder();

            if (studentsInSubject.Count == 0)
            {
                return "No students enrolled for the subject";
            }

            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            foreach (Student student in studentsInSubject)
            {
                sb.AppendLine(student.FirstName + " " + student.LastName);
            }

            return sb.ToString().Trim();
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.Where(x => x.FirstName == firstName && x.LastName == lastName).First();
            return student;
        }
    }
}
