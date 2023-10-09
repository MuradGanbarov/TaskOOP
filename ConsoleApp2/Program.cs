//using System.Drawing;
//using System.Dynamic;
//using System.Globalization;
//using System.IO.Pipes;
//using System.Net;
//using System.Security.Cryptography;

//TASK 1
//namespace Task_OOP
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Student student = new Student("Murad", "Qanbarov", 19, 51);
//            student.GetInfo();
//            student.CheckGraduated();
//            student.GetDiplomDegree();

//        }
//    }
//    public class Student
//    {

//        public string Name;
//        public string Surname;
//        public byte Age;
//        public byte Point;
//        public bool answer;


//        public Student(string name, string surname, byte age, byte point)
//        {
//            Name = name;
//            Surname = surname;
//            Age = age;
//            Point = point;
//            answer = (point >= 65);
//        }

//        public void CheckGraduated()
//        {
//            if (answer == false)
//            {
//                Console.WriteLine("Is not Graduated");
//            }
//            else
//            {
//                Console.WriteLine("Graduated");
//            }
//        }
//        public void GetDiplomDegree()
//        {
//            if (Point < 65)
//            {
//                Console.WriteLine("Student has no diplom");
//            }
//            if (Point >= 65 && Point < 80)
//            {
//                Console.WriteLine("Diplom is simple");
//            }
//            if (Point >= 80)
//            {
//                Console.WriteLine("Diplom with honors");
//            }
//        }

//        public void GetInfo()
//        {


//            Console.WriteLine($"Name:{Name}");
//            Console.WriteLine($"Surname:{Surname}");
//            Console.WriteLine($"Age: {Age}");
//            Console.WriteLine($"Point of diplom: {Point}");
//            Console.WriteLine($"{answer}");

//        }
//    }

//}

//TASK2  (With methods and classes)
//namespace TaskOOP
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Student rashad = new Student("Rashad", 40, 90, 30);
//            Student aydan = new Student("Aydan", 60, 70, 40);

//            static void CompareSport1(Student rashad, Student aydan)
//            {
//                if (rashad.Sport1 > aydan.Sport1)
//                {
//                    rashad.Degree += 1;
//                }
//                else if (aydan.Sport1 > rashad.Sport1)
//                {
//                    aydan.Degree += 1;
//                }
//            }

//            static void CompareSport2 (Student rashad, Student aydan)
//            {
//                if(rashad.Sport2 > aydan.Sport2)
//                {
//                    rashad.Degree += 1;
//                }
//                else
//                {
//                    aydan.Degree += 1;
//                }
//            }

//            static void CompareSport3 (Student rashad, Student aydan)
//            {
//                if(rashad.Sport3 > aydan.Sport3)
//                {
//                    rashad.Degree += 1;
//                }
//                else
//                {
//                    aydan.Degree += 1;
//                }
//            }

//            CompareSport1(rashad, aydan);
//            rashad.GetInfo();
//            aydan.GetInfo();
//            CompareSport2(rashad, aydan);
//            rashad.GetInfo();
//            aydan.GetInfo();
//            CompareSport3(rashad, aydan);
//            rashad.GetInfo();
//            aydan.GetInfo();
//        }
//        public class Student
//        {
//            public string Name;
//            public int Sport1;
//            public int Sport2;
//            public int Sport3;
//            public int Degree = 0;

//            public Student(string name, int sport1, int sport2, int sport3)
//            {
//                Name = name;
//                Sport1 = sport1;
//                Sport2 = sport2;
//                Sport3 = sport3;


//            }


//            public void GetInfo()
//            {
//                Console.WriteLine($"name: {Name}, sport1: {Sport1}, sport2: {Sport2} , sport3: {Sport3}, degree: {Degree}");
//            }
//        }
//    }
//}


//TASK 3 axra qeder getire bilmedim. Sadece bir shablon idi.


//string text = Console.ReadLine();

//string word = "";
//string[] arr = new string[text.Length];
//int counter = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    Console.WriteLine(i);

//    if (text[i] != ' ')
//    {
//        word = word + text[i];
//    }

//    if (text[i] == ' ' && word.Length > 0 || i == text.Length - 1)
//    {
//        arr[counter] = word;
//        counter++;
//        word = "";
//    }
//}
//string[] copy = new string[counter];

//for (int i = 0; i < copy.Length; i++)
//{
//    copy[i] = arr[i];
//}
//foreach (string s in copy)
//{
//    Console.WriteLine(s + " aarray element");
//}

//TASK 4
//namespace Task4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(TrimStart("            0000abc000"));
//        }

//        static string TrimStart(string text)
//        {
//            if (text[0] != ' ') return text;

//            else
//            {
//                string newText = "";

//                for (int i = 1; i < text.Length; i++)
//                {
//                    if (text[i] == ' ')
//                    {
//                        continue;
//                    }

//                    newText += text[i];

//                }

//                return newText;
//            }

//        }

//namespace Task4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Trim("            0000abc000        "));
//        }

//        static string Trim(string text)
//        {
//            if (text[0] != ' ') return text;
//            string newText = "";

//            for (int i = 1; i < text.Length; i++)
//            {
//                if (text[i] == ' ')
//                {
//                    continue;
//                }

//                newText += text[i];

//            }

//            if (newText[newText.Length - 1] != ' ') return newText;
//            int counter = 0;
//            string DeleteSpaces = "";
//            int j = newText.Length - 1;

//            while (newText[j] == ' ')
//            {
//                counter++;
//                j--;
//            }

//            for (int i = 0; i < newText.Length - counter; i++)
//            {
//                DeleteSpaces += newText[i];
                
//            }
//            return DeleteSpaces;
//        }








//    }


//}

// 
