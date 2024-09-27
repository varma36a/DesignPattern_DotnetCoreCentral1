using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP11
{
    public class NewStudent
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public int Age { get; private set; }

        // Private constructor to restrict direct object creation.
        private NewStudent() { }

        // Nested Builder class
        public class NewStudentBuilder
        {
            private string firstName;
            private string lastName;
            private string email;
            private string phone;
            private string address;

            public NewStudentBuilder SetFirstName(string firstName)
            {
                this.firstName = firstName;
                return this;
            }

            public NewStudentBuilder SetLastName(string lastName)
            {
                this.lastName = lastName;
                return this;
            }

            public NewStudentBuilder SetEmail(string email)
            {
                this.email = email;
                return this;
            }

            public NewStudentBuilder SetPhone(string phone)
            {
                this.phone = phone;
                return this;
            }

            public NewStudentBuilder SetAddress(string address)
            {
                this.address = address;
                return this;
            }

            // Step 4 - Validation method
            private bool Validate()
            {
                // Example validation: Ensure first and last name are not null
                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                {
                    return false;
                }

                return true;
            }

            // Step 2 - Build method to create NewStudent instance
            public NewStudent Build()
            {
                // Perform validation
                if (!Validate())
                {
                    throw new InvalidOperationException("Invalid student: First name and last name are required.");
                }

                // Create a new NewStudent instance and assign values from builder
                NewStudent student = new NewStudent
                {
                    FirstName = this.firstName,
                    LastName = this.lastName,
                    Email = this.email,
                    Phone = this.phone,
                    Address = this.address
                };

                return student;
            }
        }
    }
}
