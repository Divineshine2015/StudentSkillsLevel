using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSkillsLevel
{
    class Student
    {
        
            public enum SkillsLevel {Beginner,Grasshopper,Journeyman,RockStar, Ninja, Jedi}
            public SkillsLevel CurrentLevelStatus
        {
            get { return currentLevelStatus; }
            // set { bladeSharpness = value;  }
        }
            private SkillsLevel currentLevelStatus;
            
            public int ProgramCompleted { get; set; }
            public int PeersHelped { get; set; }
            public int CurrentPoints { get; set; }
            public int HelperPoints { get; set; }
            public string CurrentLevel { get; set; }
            public string StudentName { get; set; }
            
    

            public Student (int currentPoints, int numOfPrograms,int numOfPeersHelp)
            {
                int peerToPoints=numOfPeersHelp*10;
                CurrentPoints = currentPoints + numOfPrograms + peerToPoints;
                //currentLevelStatus = SkillsLevel.Grasshopper;
                //int currentLevelToPoints=(int) currentLevelStatus;
                CalcStudentLevel();
                CurrentLevel = CurrentLevelStatus.ToString();
            }
        //public void GetStudentNames()
        //    {
        //    StudentCollection newStudent= 


        //    }



   
            public void CalcStudentLevel()
            {
                int LevelPoints = CurrentPoints;

                AssignLevelName(LevelPoints);

            }
            
            private void AssignLevelName(int LevelPoints)
            {
                currentLevelStatus = SkillsLevel.Grasshopper;
                if (((LevelPoints >= 0 && LevelPoints <= 25)))
                {
                    currentLevelStatus = SkillsLevel.Grasshopper;

                }
                else if (((LevelPoints >= 25 && LevelPoints <= 50)))
                {
                    currentLevelStatus = SkillsLevel.Journeyman;
                }
                else if (((LevelPoints >= 50 && LevelPoints <= 75)))
                {
                    currentLevelStatus = SkillsLevel.RockStar;

                }
                else if (((LevelPoints >= 75 && LevelPoints <= 100)))
                {
                    currentLevelStatus = SkillsLevel.Ninja;

                }
                else if (((LevelPoints >= 100)))
                {
                    currentLevelStatus = SkillsLevel.Jedi;

                }
            }
            

        }
    }

