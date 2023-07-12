using System;
using System.Collections.Generic;

namespace AcademyProject_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            personList.Add(new Person() // 1
            {
                Name = "Fehruz",
                Surname = "Panahaliyev",
                Age = 17,
            });

            personList.Add(new Person() // 2
            {
                Name = "Huseyn",
                Surname = "Farzali",
                Age = 19,
            });

            personList.Add(new Person() // 3
            {
                Name = "Revan",
                Surname = "Guluzada",
                Age = 20,
            });

            personList.Add(new Person() // 4
            {
                Name = "Ali",
                Surname = "Guluzada",
                Age = 18,
            });

            personList.Add(new Person() // 5
            {
                Name = "Aliheydar",
                Surname = "Heydarov",
                Age = 21,
            });

            personList.Add(new Person() // 6
            {
                Name = "Heydar",
                Surname = "Aliyev",
                Age = 17,
            });

            personList.Add(new Person() // 7
            {
                Name = "Taryel",
                Surname = "Mammadli",
                Age = 22,
            });

            personList.Add(new Person() // 8
            {
                Name = "Farid",
                Surname = "Cabrayilzada",
                Age = 18,
            });

            personList.Add(new Person() // 9
            {
                Name = "Farid",
                Surname = "Cavadov",
                Age = 16,
            });

            personList.Add(new Person() // 10
            {
                Name = "Ibrahim",
                Surname = "Ibrahimxanli",
                Age = 24,
            });

            Console.Write("Enter the name of the person for search (optional*[, surname, age]): ");
            string data = Console.ReadLine();

            char[] splitters = { ',', ' ', '.', '-', '_' };
            string[] tokens = data.Split(splitters, options: StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(tokens.Length);
            foreach(var item in tokens)
            {
                Console.Write("," + item);
            }

            if (tokens.Length < 0 || tokens.Length > 3)
                throw new ArgumentException($"Cannot enter more than 3 parameter for search. {tokens.Length} parameters entered.");

            string searchName = tokens[0];
            string? searchSurname = null;
            int searchAge = -1;

            if (tokens.Length >= 2)
            {
                searchSurname = tokens[1];

                if (tokens.Length == 3)
                {
                    searchAge = Int32.Parse(tokens[2]);
                }
            }

            bool found = false;

            foreach (var person in personList)
            {
                if (person.Name == searchName)
                {
                    if (person.Surname == searchSurname && searchSurname != null)
                    {
                        if (person.Age == searchAge && searchAge != -1)
                        {
                            found = true;
                            Console.WriteLine("Found:");
                            Console.WriteLine($"\t {person}");
                        }

                        else if (searchAge == -1)
                        {
                            found = true;
                            Console.WriteLine("Found:");
                            Console.WriteLine($"\t {person}");
                        }
                    }

                    else if (searchSurname == null)
                    {
                        found = true;
                        Console.WriteLine("Found:");
                        Console.WriteLine($"\t {person}");
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
