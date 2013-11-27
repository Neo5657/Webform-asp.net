using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Employee
    {
        public String Name { get; set; }
        public long Id { get; set; }
        public String HomeCity { get; set; }
        public String Department  { get; set; }
        public String Company { get; set; }



        public Employee(String _name, long _id, String _homeCity, String _department, String _company)
        {
            Name = _name;
            Id = _id;
            HomeCity = _homeCity;
            Department = _department;
            Company = _company;
        }

        /*private string _name;
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string value)
        {
            _name = value;
        }

        public string Name
        {
            get{return _name;}
            set
            {
                if (value == "aaa")
                    _name = value;
            }
        }

        public void DOSOMETHING()
        {
            SetName("");
            string a = GetName();


            Name = "";
            var b = Name;
        }*/
    }
}