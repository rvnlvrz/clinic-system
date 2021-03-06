﻿namespace CSLabProject
{
    public struct Name
    {
        string fName;
        string lName;
        string mInitial;

        public Name(string f, string l, string init)
        {
            fName = f;
            lName = l;
            mInitial = init;
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string FLame
        {
            get { return lName; }
            set { lName = value; }
        }
        public string MInitial
        {
            get { return mInitial; }
            set { mInitial = value; }
        }
    }

    public struct Height
    {
        int feet;
        int inches;

        public Height(int ft, int inchy)
        {
            feet = ft;
            inches = inchy;
        }
    }

    /// <summary>
    /// Contains all basic and common attributes of a 'Person' model.
    /// </summary>
    public abstract class Person
    {
        private Name name;
        private int age;
        private double weight;
        private Height height;
        private string gender;
        private int systole, diastole; //for blood pressure


        public Person()
        { }

        /// <summary>
        /// Creates a 'Person' object with complete details.
        /// </summary>
        /// <param name="uName">Name of the person, uses struct 'Name'.</param>
        /// <param name="uAge">Age of the person.</param>
        /// <param name="uWeight">Weight of the person.</param>
        /// <param name="uHt">Height of the person, uses struct 'Height'.</param>
        /// <param name="uGend">GEnder of the person.</param>
        public Person(Name uName, int uAge, double uWeight, Height uHt, string uGend)
        {
            name = uName; age = uAge; weight = uWeight; height = uHt; gender = uGend;
        }

        public Name Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Height Height
        {
            get { return height; }
            set { height = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Systole
        {
            get { return systole; }
            set { systole = value; }
        }

        public int Diastole
        {
            get { return diastole; }
            set { diastole = value; }
        }
    }

    /// <summary>
    /// Contains all atributes of a 'Student' model.
    /// </summary>
    public class Student : Person
    {
        private string studentNumber;
        private string program;
        private int yearLevel;
        private Guardian guardian;
        private string cellNo;
        private string landLine;

        /// <summary>
        /// Creates a 'Student' derived from 'Person' class.
        /// </summary>
        /// <param name="name">Student name, uses struct 'Name'.</param>
        /// <param name="age">Sudent age.</param>
        /// <param name="wght">Student weight.</param>
        /// <param name="ht">Student height, uses struct 'Height'.</param>
        /// <param name="gender">Student gender.</param>
        /// <param name="num">Student ID number.</param>
        /// <param name="prog">Student program.</param>
        /// <param name="yr">Student year level.</param>
        /// <param name="cellnum">Student cell number.</param>
        /// <param name="landl">Student landline number.</param>
        /// <param name="grdn">Student guarian, uses the 'Guardian' class.</param>
        public Student(Name name, int age, double wght, Height ht, string gender, string num, string prog, int yr, string cellnum, string landl, Guardian grdn)
            : base(name, age, wght, ht, gender)
        {
            studentNumber = num;
            program = prog;
            yearLevel = yr;
            guardian = grdn;
        }

        public Name GetName()
        {
            return base.Name;
        }

        public void SetName(Name val)
        {
            base.Name = val;
        }

        public int GetAge()
        {
            return base.Age;
        }

        public void SetAge(int val)
        {
            base.Age = val;
        }

        public double GetWeight()
        {
            return base.Weight;
        }

        public void SetWeight(double val)
        {
            base.Weight = val;
        }
        public Height GetHeight()
        {
            return base.Height;
        }
        public void SetHeight(Height val)
        {
            base.Height = val;
        }

        public string GetGender()
        {
            return base.Gender;
        }

        public void SetGender(string val)
        {
            base.Gender = val;
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public int YearLevel
        {
            get { return yearLevel; }
            set { YearLevel = value; }
        }

        public Guardian Guardian
        {
            get { return guardian; }
            set { guardian = value; }
        }

        public string CellNo
        {
            get { return cellNo; }
            set { cellNo = value; }
        }

        public string LandLine
        {
            get { return landLine; }
            set { landLine = value; }
        }

        public int GetDiastole()
        {
            return base.Diastole;
        }

        public void SetDiastole(int val)
        {
            base.Diastole = val;
        }

        public int GetSystole()
        {
            return base.Systole;
        }

        public void SetSystole(int val)
        {
            base.Systole = val;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Employee : Person
    {
        private string employeeNumber;
        private string position;

        /// <summary>
        /// Creates an 'Employee' derived from the 'Person' class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="wght"></param>
        /// <param name="ht"></param>
        /// <param name="gender"></param>
        /// <param name="num"></param>
        /// <param name="pos"></param>

        public Employee(Name name, int age, double wght, Height ht, string gender, string num, string pos)
            : base(name, age, wght, ht, gender)
        {
            employeeNumber = num;
            position = pos;
        }

        public Name GetName()
        {
            return base.Name;
        }

        public void SetName(Name val)
        {
            base.Name = val;
        }

        public int GetAge()
        {
            return base.Age;
        }

        public void SetAge(int val)
        {
            base.Age = val;
        }

        public double GetWeight()
        {
            return base.Weight;
        }

        public void SetWeight(double val)
        {
            base.Weight = val;
        }

        public Height GetHeight()
        {
            return base.Height;
        }
        public void SetHeight(Height val)
        {
            base.Height = val;
        }

        public string GetGender()
        {
            return base.Gender;
        }

        public void SetGender(string val)
        {
            base.Gender = val;
        }

        public string EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }

    public class Guardian
    {
        private Name name;
        private string cellNo;
        private string landLine;

        /// <summary>
        /// Creates a 'Guardian' object
        /// </summary>
        /// <param name="nm">Name of Guardian, uses 'Name' struct.</param>
        /// <param name="cell">Cellular number.</param>
        /// <param name="line">Landline number.</param>
        public Guardian(Name nm, string cell, string line)
        {
            name = nm;
            cellNo = cell;
            landLine = line;
        }

        public Name Name
        {
            get { return name; }
            set { name = value; }
        }

        public string CellNo
        {
            get { return CellNo; }
            set { cellNo = value; }
        }

        public string LandLine
        {
            get { return landLine; }
            set { landLine = value; }
        }
    }
}