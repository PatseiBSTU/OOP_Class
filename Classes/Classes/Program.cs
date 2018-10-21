using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //первый студент
            Student ivanov = new Student();
            ivanov.FirstName = "Николай";
            ivanov.SecondName = "Иванов";
            ivanov.Course = 1;
            ivanov.BirthDay = new DateTime(2000, 3, 12);
            Console.WriteLine(ivanov.ToString());
            Console.WriteLine("Age :" + ivanov.GetAge());
            Console.WriteLine("----------------------------------------");

           // второй студент
           Student petrov = new Student("Олег", "Петров", new DateTime(1999, 4, 23), 2, "Гомель");
            Console.WriteLine(petrov.ToString());
            Console.WriteLine("Хэш код: " + petrov.GetHashCode());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Зачислено студентов: " + Student.countOfStudents);
            //третий студент
            Student sidorov = new Student("Олег", "Петров", new DateTime(1998, 3, 3), 2);
            Console.WriteLine(sidorov.ToString());
            Console.WriteLine("Хэш код: " + sidorov.GetHashCode());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Зачислено студентов: " + Student.countOfStudents);
            Console.WriteLine("Проверка на равенство: ");
            if (petrov.Equals(sidorov)) Console.WriteLine(" Студенты равны");
            else Console.WriteLine(" Студенты не равны");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Введите новый курс для студента " + sidorov.SecondName );
            sidorov.Course = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(sidorov.ToString());
            // четвертый студент
            Console.WriteLine("----------------------------------------");
            Student kozlova = new Student(2);
            kozlova.FirstName = "Ольга";
            Console.WriteLine(kozlova.ToString());
            Console.WriteLine("Зачислено студентов: " + Student.countOfStudents);
            // пятый студент
            Console.WriteLine("----------------------------------------");
            { // определение блока
                Student danilov = new Student { FirstName = "Дмитрий", SecondName = "Данилов", Course = 1 };//инициализатор
                Console.WriteLine(danilov.ToString());
                Console.WriteLine("Зачислено студентов: " + Student.countOfStudents);
            }
           Console.WriteLine("----------------------------------------");
            // работа с индексатором
            ivanov[0] = 4;
            ivanov[1] = 9;
            Console.WriteLine($" Оценки {ivanov.SecondName}: {ivanov[0]} {ivanov[1]} {ivanov[2]} {ivanov[3]}");
            Console.WriteLine("----------------------------------------");
            Student [] allstudents = { ivanov, petrov, sidorov, kozlova };
            Student[] courseOne = { };
            Student[] courseTwo = { };

            Console.WriteLine($"Список студентов:  {allstudents.Length}");
            foreach (Student current in allstudents)
                Console.WriteLine(current);

            foreach (Student current in allstudents)
            {
                if (current.isCourse(1))
                {
                    Array.Resize(ref courseOne, courseOne.Length + 1);
                    Array.Copy(allstudents, courseOne, 1);
                }
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Первый курс: {courseOne.Length}");
            foreach (Student current in courseOne)
                Console.WriteLine(current);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Втрой курс: ");
            foreach (Student current in allstudents)
            {
                if (current.isCourse(2))
                {
                    Array.Resize(ref courseTwo, courseTwo.Length + 1);
                    Array.Copy(allstudents, courseTwo, 1);
                    Console.WriteLine(current);
                }
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}
