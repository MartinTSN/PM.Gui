using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    public partial class Employee
    {
        #region Fields
        protected string name;
        protected ICollection<ContactInfo> contactInfos;
        #endregion
        #region Constructors
        public Employee(string name)
            : this(name, new List<ContactInfo>(0))
        {
        }
        public Employee(string name, ICollection<ContactInfo> contactInfos)
        {
            Name = name;
            ContactInfos = contactInfos;
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
                if (value.Length > 100 || value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The name must be over 2 chars and under 100");
                }
                name = value;
            }
        }
        public virtual ICollection<ContactInfo> ContactInfos
        {
            get
            {
                return contactInfos;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The contactInfo must not be null");
                }
                contactInfos = value.ToList();
            }
        }
        #endregion
    }
}
