using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUserControl.BusinessLogic.Interfaces;

namespace eUserControl.BusinessLogic
{
     public class MyBusinessLogic
     {
          public ISession GetSessionBl()
          {
               return new SessionBL();
          }
     }
}