using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("University Management System ");

            Console.WriteLine("Developer At Kuratoli Software Solutions");
            Console.WriteLine("Develop by Mehedi");

            Console.WriteLine("\n Valid sections :- \n");

            course cr 1 = new course("java", 2, 3, 4.0, 5);
            section sec1 = new section("x", "OOP2", 5, 2, 4.0);
            section sec2 = new section("y", "OOP2", 5, 3, 3.0);
            section sec3 = new section("d", "dcom", 3, 3, 4.0);
            section sec4 = new section("J", "c++", 4, 6, 3.0);
            section sec5 = new section("o", "c", 3, 1, 3.0);
            section sec6 = new section("u", "OOAD", 4, 3, 7.0);
            section sec7 = new section("i", "OOAD", 2, 7, 4.0);



            cr1.ShowInfo();

            sec2.ShowInfo();

            dept d1 = new departments("FST");
            dept  d2 = new departments("FBA");
            dept d3 = new departments("FASS");
            dept d4 = new departments("FE");

            d1.AddCourse(crs1);

            d1.ShowAllCourses();

            Console.WriteLine("\nAdding Courses\n");
            d1.AddCourse(sec1, sec2, sec3, sec4, sec5, sec5,sec6);
            d1.ShowAllCourses();

            Console.WriteLine("\nFaculty Name\n");
            faculty f1 = new faculty("mk", "");
            faculty f2 = new faculty("nb", "");
            faculty f3 = new faculty("hg", "");
            faculty f4 = new faculty("yr", "");


            Thour t1 = new Thour("C++", 3, d1);
            Thour t2 = new Thour("c", 3, d1);
            Thour t3 = new Thour("java", 3, d1);


            f1.AddCredit(t1, t2, t3);
            f1.ShowAllCredits();

        }
    }
}