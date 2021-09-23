using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_code
{
   public class FakeAppUserRespository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> Users;

        public FakeAppUserRespository()
        {

            if(Users == null)
            {
                Users = new Dictionary<string, AppUser>();

                Users.Add("1", new AppUser
                {
                    UserName = "rajeepsubedi",
                    Password = "password",
                    FirstName = "Rajeep",
                    LastName = "Subedi",
                    EmailAddress = "rajeep.subedi@trojans.dsu.edu",
                    IsAuthenticated = true
                });

            }
        }

        public bool Login(string UserName, string Password)
        {
            AppUser user = GetByUserName(UserName);
            if (user != null)
            {
                if (user.Password == Password)
                {
                    SetAuthentication(UserName, true);
                    return true;

                }
                else
                {
                    return false;

                }

            }
            else
            {
                return false;
            }
        }

        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();
            foreach (KeyValuePair<string, AppUser> user in Users)
            {
                users.Add(user.Value);

            }
            return users;
           
        }
        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            AppUser user = GetByUserName(UserName);
            if(user != null)
            {
                user.IsAuthenticated = IsAuthenticated;
            }
        }
        public AppUser GetByUserName(string UserName)
        {
            List<AppUser> allUsers = GetAll();
            AppUser user;
            bool userExists = allUsers.Exists(x => x.UserName == UserName);
            if(userExists)
            {
                user = allUsers.Find(x => x.UserName == UserName);
                return user;
            }
            else
            {
                return null;
            }

        }
    }
}
