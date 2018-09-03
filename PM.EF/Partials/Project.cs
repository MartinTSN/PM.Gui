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
                    throw new ArgumentNullException();
                }
                name = value;
            }

        }
        #endregion
    }
}
