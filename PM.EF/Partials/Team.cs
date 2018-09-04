using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    /// <summary>
    /// A Partial class Team that contains Fields, Constructors and Properties
    /// </summary>
    /// <remarks>Is made out of a String name and a ICollection Employee employees</remarks>
    public partial class Team
    {
        #region Fields
        /// <summary>
        /// Protected string name
        /// </summary>
        protected string name;
        /// <summary>
        /// Protected ICollection Employee employees
        /// </summary>
        protected ICollection<Employee> employees;
        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor Team
        /// </summary>
        /// <remarks>Makes a new employee list</remarks>
        /// <param name="name">A string name</param>
        /// <exception cref="ArgumentNullException">Thrown when a value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when a value is out of range (2-50)</exception>
        public Team(string name)
            : this(name, new List<Employee>(0))
        {

        }
        /// <summary>
        /// A constructor which takes a string name and a ICollection Employee employees
        /// </summary>
        /// <param name="name">A string name</param>
        /// <param name="employees">A ICollection Employee employees</param>
        /// <exception cref="ArgumentNullException">Thrown when a value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when a value is out of range (2-50)</exception>
        public Team(string name, ICollection<Employee> employees)
        {
            Name = name;
            Employees = employees;
        }
        #endregion
        #region Properties
        /// <summary>
        /// The property Name
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is out of range (2-50)</exception>
        public virtual string Name
        {
            get => name;
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
        /// <summary>
        /// The ICollection Employees
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when value is null</exception>
        public virtual ICollection<Employee> Employees
        {
            get => employees;
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
