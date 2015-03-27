using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSkillsLevel
{
    class Program
    {

      static void Main(string[] args)
        {

            QuestionsAndResults();
            


        }

        private static void QuestionsAndResults()
        {
            Console.WriteLine("Let's Assign your skills level !!");
            //input
            Console.Write("Enter student name : ");
            string studentName=Console.ReadLine();
            Console.Write("How many Programs did you complete?: ");
            int programPoints = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Peers did you help today: ");
            int peerPoints = Convert.ToInt32(Console.ReadLine());

            StudentCollection.Add(new Student(studentName, 0, programPoints, peerPoints));
            Student level = new Student(studentName,0, programPoints, peerPoints);
            string Display = level.CurrentLevel;
            //Answers
            
            Console.Write("You Helped: {0} ", peerPoints);

            Console.WriteLine("You achieved level: {0} ", Display );
        }
    }
}
