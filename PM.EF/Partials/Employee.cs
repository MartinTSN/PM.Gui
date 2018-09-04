using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    /// <summary>
    /// A Partial class Employee that contains Fields, Constructors and Properties
    /// </summary>
    /// <remarks>Is made of a String name</remarks>
    public partial class Employee
    {
        #region Fields
        /// <summary>
        /// Protected Field name
        /// </summary>
        protected string name;
        #endregion
        #region Constructors
        /// <summary>
        /// The default constructor
        /// </summary>
        /// <remarks>Sets ContactInfo to default</remarks>
        /// <param name="name">A string Name</param>
        /// <exception cref="ArgumentNullException">Thrown when a value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when a value is out of range (2-100)</exception>
        public Employee(string name)
        {
            Name = name;
            ContactInfo = ContactInfo.Default;
        }
        #endregion
        #region Properties
        /// <summary>
        /// The property Name
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when the value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is out of range (2-100)</exception>
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
                if (value.Length > 100 || value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The name must be over 2 chars and under 100");
                }
                name = value;
            }
        }
        #endregion
    }
}