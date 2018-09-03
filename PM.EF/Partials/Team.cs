﻿using System;
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
        protected Project project;
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
                    throw new ArgumentOutOfRangeException("The name must be over 2 chars and under 50");
                }
                name = value;
            }
        }
        public ICollection<Employee> Employees
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
        public Project Project
        {
            get
            {
                return project;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The project must be set");
                }
                project = value;
            }
        }
        #endregion
    }
}
