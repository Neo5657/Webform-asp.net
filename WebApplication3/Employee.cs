using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Employee
    {
        public String name { get; set; }
        public long id { get; set; }
        public String homeCity { get; set; }
        public String department  { get; set; }
        public String company { get; set; }

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