using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMH_Desktop
{
    class Repair
    {
        private DateTime finishDate;
        private float timeSpent;
        private Boolean solved;
        private String difficulty;
        private Boolean notEnoughKnowledge;
        private Boolean notEnoughMaterial;
        private String instructions;

        public DateTime FinishDate
        {
            get { return finishDate; }
            set { finishDate = value; }
        }

       

        public float TimeSpent
        {
            get { return timeSpent; }
            set { timeSpent = value; }
        }
       

        public Boolean Solved
        {
            get { return solved; }
            set { solved = value; }
        }

       

        public String Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }
        

        public Boolean NotEnoughKnowledge
        {
            get { return notEnoughKnowledge; }
            set { notEnoughKnowledge = value; }
        }
        

        public Boolean NotEnoughMaterial
        {
            get { return notEnoughMaterial; }
            set { notEnoughMaterial = value; }
        }
       

        public String Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }


    }
}
