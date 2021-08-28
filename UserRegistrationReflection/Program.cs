using System;

namespace UserRegistrationReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserDetails validate = new ValidateUserDetails();
            validate.ValidateUser();
        }
    }
}