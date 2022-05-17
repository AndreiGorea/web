using System.Collections.Generic;

namespace eUserControl.Web.Models
{
     public class UserData
     {
          public string Username { get; set; }
          public List<string> Products { get; set; }
          public string SingleProduct { get; set; }
     }
}