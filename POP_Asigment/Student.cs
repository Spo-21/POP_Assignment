using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_Asigment
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public Address Adsress { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int[] Scores { get; set; }
        public double AverageScore {
            get
            {
                return Math.Round(Scores.Average());
            }
        }

        public Student(string studentNumber, int age, Address adsress, int[] scores)
        {
            StudentNumber = studentNumber;
            Age = age;
            Adsress = adsress;
            Scores = scores;
        }

        public Student() {}

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Student number: {StudentNumber}");
            stringBuilder.AppendLine($"Full name: {FullName}");
            stringBuilder.AppendLine($"Age: {Age}");
            stringBuilder.AppendLine("Scores: ");
            foreach (var item in Scores)
            {
                stringBuilder.Append($"{item} ");
            }
            stringBuilder.AppendLine($"Averege score: {AverageScore}");
            stringBuilder.AppendLine($"Full address: {this.Adsress.FullAddress}");
            return stringBuilder.ToString();
        }

    }
}
