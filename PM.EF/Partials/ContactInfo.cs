using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    public partial class ContactInfo
    {
        #region Fields
        protected string email;
        protected string phone;
        #endregion
        #region Constructors
        public ContactInfo(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }
        #endregion
        #region Properties
        public virtual string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The email must not be empty.");
                }
                if (value.Length < 10 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The Mail must be over 10 and under 50 chars.");
                }

                if (!value.EndsWith(".com") && !value.EndsWith(".net") && !value.EndsWith(".dk"))
                {
                    throw new FormatException("The mail must end with .com, .net or .dk");
                }
                if (value.EndsWith("@.com") || value.EndsWith("@.net") || value.EndsWith("@.dk"))
                {
                    throw new FormatException("You must write something between the @ and the domain ending");
                }
                if (!value.Contains("@"))
                {
                    throw new FormatException("There must be an at (@) symbol in the mail.");
                }
                email = value;
            }
        }
        public virtual string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("The number must be set");
                }
                if (value.Length > 25 || value.Length < 8)
                {
                    throw new ArgumentOutOfRangeException("The number must be under 25 and over 8");
                }
                phone = value;
            }
        }
        #endregion
    }
}
