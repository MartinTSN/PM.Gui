using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.EF
{
    /// <summary>
    /// A Partial class Contactinfo that contains Fields, Constructors and Properties
    /// </summary>
    /// <remarks>Is made out of a String email and a string phone(number)</remarks>
    public partial class ContactInfo
    {
        #region Fields
        /// <summary>
        /// A protected string email
        /// </summary>
        protected string email;
        /// <summary>
        /// A protected string phone(number)
        /// </summary>
        protected string phone;
        #endregion
        #region Constructors
        /// <summary>
        /// The Default constructor
        /// </summary>
        /// <param name="email">A string email</param>
        /// <param name="phone">A string phone(number)</param>
        /// <exception cref="ArgumentNullException">Thrown when A value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when A value is out of range</exception>
        /// <exception cref="FormatException">Thrown when A value is formatted incorrectly</exception>
        public ContactInfo(string email, string phone)
        {
            Email = email;
            Phone = phone;
        }
        #endregion
        #region Properties
        /// <summary>
        /// A property string Email
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when the value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is out of range (10-50)</exception>
        /// <exception cref="FormatException">Thrown when the value is formatted incorrectly</exception>
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
        /// <summary>
        /// A property String Phone(number)
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when the value is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is out of range (8-25)</exception>
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
        /// <summary>
        /// A property ContactInfo Default
        /// </summary>
        public static ContactInfo Default
        => new ContactInfo("", "");
        #endregion
    }
}