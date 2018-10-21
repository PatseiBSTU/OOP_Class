using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        private string placeOfBirth;
        private int course = 1;
        private   DateTime birthDay;
        private int[] marks = new int[4];

        public static int countOfStudents;
        public const string university = "БГТУ";

        #region Constructors
        static Student() => countOfStudents = 0;
     
      public  Student()
        {
            FirstName = "noName";
            birthDay = new DateTime(DateTime.Now.Year-18, 12,1);
            placeOfBirth = "Минск";
            countOfStudents++;
        }
        public Student(string fName, string sName, DateTime bDay , int course, string pOBirth = " Минск")
        {
            FirstName = fName;
            SecondName = sName;
            birthDay = bDay;
            this.course = course;
            placeOfBirth = pOBirth;
            countOfStudents++;

        }
        
        public Student (int course):this() =>   this.course = course;
        
        #endregion

        ~ Student () =>    Console.WriteLine("Студент " +SecondName +" уничтожен  ");
        
        #region Propertes
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDay
        {
            get => birthDay; 
            set {
                if (value < DateTime.Now)
                    birthDay = value;
                else birthDay = new DateTime(2000,1,1);
            }

        }
        public int Course
        {
            get => course; 
            set
            {
                if (value > 2 && value < 5)
                    course = value;
                else course = 1;
            }
        }
        #endregion
        #region Index
        public int this [int index]
        {
            get
            {
                if (index >= 0 && index < marks.Length) return marks[index];
                else return -1;
            }
            set
            {
                if (index >= 0 && index < marks.Length && value > 0 && value < 11)
                    marks[index] = value;

            }
        }
        #endregion


        #region Methods
        public int GetAge() => DateTime.Now.Year - birthDay.Year;
        public String GetMarks()
        {
            String marksStr = null;
            for (int i = 0; i<marks.Length; i++)
            {
                marksStr += marks[i];
            }
            return marksStr;
        }

        public bool isCourse(int course) => this.Course == course;

        public override string ToString() => $"Студент: {FirstName}  {SecondName}  {birthDay.ToShortDateString()}, {placeOfBirth}  курс {course}  {university}";

        public override int GetHashCode() => this.FirstName.GetHashCode() + this.SecondName.GetHashCode() + this.course.GetHashCode() + this.birthDay.GetHashCode();


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student temp = obj as Student;

            if (temp == null) return false;
            else
            {
                return FirstName == temp.FirstName && SecondName == temp.SecondName && course == temp.course;
            }
        }
        #endregion
    }
}
