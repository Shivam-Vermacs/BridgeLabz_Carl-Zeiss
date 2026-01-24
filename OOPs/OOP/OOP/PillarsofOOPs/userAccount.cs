    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OOP.OOPs_Basics;

    namespace OOP.PillarsofOOPs
    {
        internal class userAccount
        {
        class UserAccount
        {
            private readonly string Username;
            private string Password;
            private string Email;
            private DateTime AccountCreationDate;

            public UserAccount(string username, string password, string email)
            {
                if (username != "")
                {
                    Username = username;
                }
                //do the validation later its so fking boring

                
                    string passPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
                if (Regex.IsMatch(password, passPattern))
                {
                    Password = password;
                }
               
                    string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (Regex.IsMatch(email, emailPattern))
                {
                    Email = email;
                }

            }
            public void ChangePassword(string oldpassword, string newpassword)
            {
                if (Password != oldpassword)
                {
                    Console.WriteLine("Old Password is Incorrect");
                    return;
                }
                string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";

                if (Regex.IsMatch(Password, passwordPattern))
                {
                    Password = newpassword;

                }
                else
                {
                    Console.WriteLine("new password doesnt meet the security requirements");
                    return;
                }
                Console.WriteLine("New Password Created Successfully");

            }
            public void VerifyPassword(string input)
            {
                if(input!=Password)
                {
                    Console.WriteLine("Login Attempt With Wrong Password");
                }
                else
                {
                    Console.WriteLine("Login Executed Successfully");
                }
            }
            public void DisplayAccount()
            {
                Console.WriteLine($"Username: {Username}, Email : {Email}, Account Created on : {AccountCreationDate}");
            }
        }
        public static void Main(string[] args)
        {
            UserAccount acc1 = new UserAccount("Itadori","Megumi@32","jjk2026@gmail.com");
            acc1.ChangePassword("Megumi@32","Nobara@123");
        }

        }
    }
