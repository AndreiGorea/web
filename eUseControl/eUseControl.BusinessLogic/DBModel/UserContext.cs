using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUserControl.Domain.Entities.User;

namespace eUserControl.BusinessLogic.DBModel
{
     class UserContext : DbContext
     {
          public UserContext() :
               base("name=eUserControl") // connectionstring name define in your web.config 
          {
          }

          public virtual DbSet<UDbTable> Users { get; set; }
     }
}