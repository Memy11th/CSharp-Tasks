using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Five
{
    struct PersonAge
    {
        #region Attributes
        public int Age { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
            public PersonAge(int age , string name)
        {
            Age = age;
            Name = name;
        }
        #endregion


    }
}
