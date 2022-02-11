using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScors
{
    public class Student : ICloneable
    {
        public Student() { }
        public Student(string Name, List<decimal> Scores)
        {
            this.name = Name;
            this.scores = Scores;
        }
        public string name { get; set; }
        public List<decimal> scores = new List<decimal>();
        public override string ToString()
        {
            string listOfScores = "";
            foreach (decimal score in scores)
            {
                listOfScores += score.ToString() + " | ";
            }
            return name + "\t" + listOfScores;
        }
        public object Clone()
        {
            Student clonedStudent = new Student();
            clonedStudent.name = this.name;
            clonedStudent.scores = this.scores;
            return clonedStudent;
        }
    }
}
