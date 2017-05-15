using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMVVM.Storage;

namespace XMVVM.Model
{
    public class Student: IKeyObject
    {
        private string name;
        private string lastName;
        private string group;
        private string studentNumber;
        private double average;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }

        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }

            set
            {
                studentNumber = value;
            }
        }

        public double Average
        {
            get
            {
                return average;
            }

            set
            {
                average = value;
            }
        }

        [SQLite.PrimaryKey]
        public string Key
        {
            get;
            set;
        }
    }
}
