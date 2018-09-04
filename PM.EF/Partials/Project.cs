using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    /// <summary>
    /// A Partial class Project that contains Fields, Constructors and Properties
    /// </summary>
    /// <remarks>Is made out of a String name, String description and a ICollection Team teams</remarks>
    public partial class Project
    {
        #region Fields
        /// <summary>
        /// Protected String name
        /// </summary>
        protected string name;
        /// <summary>
        /// Protected string description
        /// </summary>
        protected string description;
        /// <summary>
        /// protected ICollection Team teams
        /// </summary>
        protected ICollection<Team> teams;
        #endregion

        #region Constructors
        /// <summary>
        /// The Default constructor Without teams
        /// </summary>
        /// <param name="name">A string name</param>
        /// <param name="description">A string description</param>
        /// <exception cref="ArgumentNullException">Thrown when a value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when a value is out of range</exception>
        public Project(string name, string description)
            : this(name, description, null)
        {

        }
        /// <summary>
        /// The Default constructor With teams
        /// </summary>
        /// <param name="name">A string name</param>
        /// <param name="description">A string description</param>
        /// <param name="teams">A List Team teams</param>
        /// <exception cref="ArgumentNullException">Thrown when a value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when a value is out of range</exception>
        public Project(string name, string description, List<Team> teams)
        {
            Name = name;
            Description = description;
            Teams = Teams;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The property string Name
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is out of range (2-50)</exception>
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
        /// <summary>
        /// The property string Description
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when value is out of range (when under 2)</exception>
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
        /// <summary>
        /// The property ICollection Team Teams
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when value is null</exception>
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