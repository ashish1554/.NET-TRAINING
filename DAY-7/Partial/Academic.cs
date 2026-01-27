using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
namespace MyApp
{
    public partial class Student
    {
        private int id;
        private string division;
        private double cgpa;
        private string clg;

        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Division
        {
            get { return division; } 
            set { division = value; }
        }
        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public string Clg
        {
            get { return clg; }
            set { clg = value; }
        }
    }
}
