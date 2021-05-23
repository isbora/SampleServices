using System;

namespace WebApi.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public decimal Grade { get; set; }
    }
}
