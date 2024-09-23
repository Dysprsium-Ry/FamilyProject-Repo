using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
namespace FamilyProject
{
[StructLayout(LayoutKind.Sequential)]
#pragma warning disable
    class Program
    {
        public static void Main(string[] args)
        {
            string n, g;
            int a, count;
            List<Parents> parents = new List<Parents>();
            List<Children> children = new List<Children>();

            Console.Write("What's your name: ");
            n = Console.ReadLine();
            Console.Write("Please input your age: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Classify your gender: ");
            g = Console.ReadLine();

            Console.WriteLine("");

            You you = new You(n, a, g);

            Console.Write("Number of sibling: ");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Sibling {i + 1}'s name: ");
                n = Console.ReadLine();
                Console.Write("Age: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Gender: ");
                g = Console.ReadLine();
                Console.WriteLine();

                Children sibling = new Children(n, a, g);
                children.Add(sibling);
            }

            Console.Write("Your mothers name: ");
            n = Console.ReadLine();
            Console.Write("Age: ");
            a = Convert.ToInt32(Console.ReadLine());
            Parents mother = new Parents(n, a, "Mother");
            parents.Add(mother);

            Console.Write("Your father name: ");
            n = Console.ReadLine();
            Console.Write("Age: ");
            a = Convert.ToInt32(Console.ReadLine());
            Parents father = new Parents(n, a, "Father");
            parents.Add(father);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"The name is {you.name} currently {you.age} years old, and is a {you.gender} ");
            Console.WriteLine("");

            foreach (var item in parents)
            {
                Console.WriteLine("The information of your parents: ");
                Console.WriteLine($"Parent name: {item.name} Parents role: {item.role} Parents age: {item.age}");
            }
            Console.WriteLine("");
            foreach (var item in children)
            {
                Console.WriteLine("The information of your siblings: ");
                Console.WriteLine($"Name: {item.name} Age: {item.age} Gender {item.gender}");
            }
        }

        class Family
        {
            public string name, gender;
            public int age;
        }

        class You : Family
        {
            public string name, gender;
            public int age;

            public You(string name, int age, string gender)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
            }
        }

        class Parents : Family
        {
            public string name, role;
            public int age;

            public Parents(string name , int age, string role)
            {
                this.name = name;
                this.role = role;
                this.age = age;
            }
        }

        class Children : Family
        {
            public string name, gender;
            public int age;

            public Children(string name, int age, string gender)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
            }
        }
    }
}