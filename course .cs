using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid
{
    class course
    {
        private int cId;

        public int num
        {

            set { cId = value; }
        }


        private string cName;

        public string cId
        {
            get { return cName; }


            set { cName = value; }
        }

        public string cName
        {
            get { return cName; }



            set { cName = value; }
        }
        private int cCredit;

        public int cCredit
        {
            get { return cCredit; }

            set { cCredit = value; }
        }
        private double courseTHours;

        public double CourseTHours
        {
            get { return courseTHours; }




            set { coursTHours = value; }
        }


        private section[] sections;

        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }

            set { sectionCount = value; }
        }

        public course()
        {
            sections = new section[10];

            sectionCount = 0;
        }
        public course(string cName, int cId, int cCredit, double courseTHours)
        {
            this.cName = cName;

            this.cId = cId;

            this.cCredit = cCredit;

            this.cTHours = courseTHours;

            sections = new section[10];

            sectionCount = 0;
        }
        public course(string cName, int cId, int cCredit, double courseTHours, int Number)
        {
            this.courseName = cName;
            this.courseId = cId;
            this.courseCredit = cCredit;
            this.courseTHours = cTHours;
            this.num = num;
            sections = new section[10];
            sectionCount = 0;
        }
        public void AddScetion(params section[] sections)
        {
            foreach (var a in sections)
            {
                if (sectionCount < 20)
                {
                    this.sections[sectionCount++] = a;
                }
                else
                {
                    Console.WriteLine("Cannot Add Any More Section For This Course : " + a.CourseId);
                }
            }
        }
        public void ShowAllTheSections()
        {
            for (int i = 0; i < section Count; i++)
            {
                sections[i].ShowInfo();
            }
        }
        public section SearchSection(int sectionNumber)
        {
            section a = null;
            for (int i = 0; i < sectionCount; i++)
            {
                if (sections[i].cId.Equals(sectionNumber))
                {
                    a = sections[i];
                    break;
                }
            }
            return a;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name: " + cName);
            Console.WriteLine("Course Id Number: " + cId);
            Console.WriteLine("Course Credit Number: " + cCredit);
            Console.WriteLine("Course Teaching Hours: " + cTHours);

        }
        public void AddCourseNumber(int x)
        {
            num += x;
        }

    }
}