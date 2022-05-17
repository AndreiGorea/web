using eUserControl.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUserControl.BusinessLogic.Interfaces
{
     public interface ISession
     {
          ULoginResp UserLogin(ULoginData data);

          string GenCookieByUser(ULoginData data);
          ULoginResp UserRegister(URegisterData login);
     }
}