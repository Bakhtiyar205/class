using System;
using System.Collections.Generic;
using System.Text;

namespace class_inheritance
{
    class Plane:Passenger
    {
        public string company;
        public string takeof;
        public string landing;

        public Plane()
        {
        }

        public Plane(string c, string t,string l,string n, string sr, string s,int a )
        {
            this.company = c;
            takeof = t;
            landing = l;
            name = n;
            surname = sr;
            sex = s;
            age = a;

        }
    }
}
