using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    public partial class Team
    {
        #region Fields
        protected string name;
        protected ICollection<Employee> employees;
        #endregion
        #region Constructors
        public Team(string name)
            : this(name, new List<Employee>(0))
        {

        }
        public Team(string name, ICollection<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
        #endregion
        #region Properties
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The name must be set");
                }
                if (value.Length > 50 || value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The name must be over 2 chars and under 50");
                }
                name = value;
            }
        }
        public virtual ICollection<Employee> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The employees must be set");
                }
                employees = value.ToList();
            }
        }
        #endregion
    }
}
