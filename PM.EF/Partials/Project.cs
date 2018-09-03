using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    public partial class Project
    {
        #region Fields
        protected string name;
        protected string description;
        protected ICollection<Team> teams;
        #endregion

        #region Constructors
        public Project(string name, string description)
            : this(name, description, null)
        {

        }
        public Project(string name, string description, List<Team> teams)
        {
            Name = name;
            Description = description;
            Teams = Teams;
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
        public virtual string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The description  must be set");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The description must be over 2 chars");
                }
                description = value;
            }
        }
        public virtual ICollection<Team> Teams
        {
            get
            {
                return teams;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("the team must be set");
                }
                teams = value ?? new List<Team>(0);
            }
        }
        #endregion
    }
}
