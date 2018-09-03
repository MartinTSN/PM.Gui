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
        protected Team team;
        #endregion
        #region Constructors
        public Employee(int id, string name, ICollection<ContactInfo> contactInfos, Team team)
            : this(name, contactInfos, team)
        {
            Id = id;
        }
        public Employee(string name, ICollection<ContactInfo> contactInfos, Team team)
        {
            Name = name;
            ContactInfos = contactInfos;
            Team = team;
        }
        #endregion
        #region Properties
        public string Name
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
        public ICollection<ContactInfo> ContactInfos
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
        public Team Team
        {
            get
            {
                return team;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The team must be set");
                }
                team = value;
            }
        }
        #endregion
    }
}
