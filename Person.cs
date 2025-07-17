using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Five
{
    struct Person
    {
        #region Attributes
        public int Age;
        public string Name;
        #endregion
        #region Constructors
           public Person(int _age,string _name)
        {
            Age = _age;
            Name = _name;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"The age is {Age} meanwhile your name is {Name}";
        }
        #endregion

    }
}
