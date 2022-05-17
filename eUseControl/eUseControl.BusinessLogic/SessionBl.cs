using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUserControl.BusinessLogic.Core;
using eUserControl.BusinessLogic.Interfaces;
using eUserControl.Domain.Entities.User;

namespace eUserControl.BusinessLogic
{
     public class SessionBL : UserApi, ISession
     {
          private readonly UserApi userApi = new UserApi();

          public string GenCookieByUser(ULoginData data)
          {
               throw new NotImplementedException();
          }

          public ULoginResp UserLogin(ULoginData data)
          { return userApi.UserLoginAction(data); }

          public ULoginResp UserRegister(URegisterData data)
          { return userApi.UserRegisterAction(data); }

     }
}