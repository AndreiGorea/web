
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUserControl.BusinessLogic.DBModel;
using eUserControl.Domain.Entities.User;
using eUserControl.Domain.Enums;

namespace eUserControl.BusinessLogic.Core
{
     public class UserApi
     {
          internal ULoginResp UserLoginAction(ULoginData data)
          {
               UDbTable result;
               using (var db = new UserContext())
               {
                    result = db.Users.FirstOrDefault(u => u.Username == data.Credential && u.Password
                    == data.Password);
               }
               if (result == null)
               {
                    return new ULoginResp
                    {
                         Status = false,
                         StatusMsg = "The username or password is incorrect"
                    };
               }
               return new ULoginResp { Status = true };
          }
          internal ULoginResp UserRegisterAction(URegisterData data)
          {
               UDbTable result;
               var user = new UDbTable();
               user.Email = data.Email;
               user.Username = data.Username;
               user.Password = data.Password;
               user.LastLogin = data.RegisterDateTime;
               user.Level = URole.Guest;
               try
               {
                    using (var db = new UserContext())
                    {
                         result = db.Users.FirstOrDefault(u => u.Username == data.Username);
                         if (result == null)
                         {
                              db.Users.Add(user);
                              db.SaveChanges();
                              return new ULoginResp { Status = true };
                         }
                         else
                         {
                              return new ULoginResp
                              {
                                   Status = false,
                                   StatusMsg = "Invalid Username."
                              };
                         }
                    }
               }
               catch (DbEntityValidationException)
               {
                    throw;
               }
          }
     }
}