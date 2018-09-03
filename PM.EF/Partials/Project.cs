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
        #endregion

        #region Constructors

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
                if (value.Length > 50 || value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The name must be over 2 chars");
                }
                name = value;
            }
        }

        public string Description
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
        #endregion
    }
}
