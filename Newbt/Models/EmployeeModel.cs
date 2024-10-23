using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbt.Models
{
    internal class EmployeeModel : IModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

        public string role { get; set; }

        public bool IsValidate()
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password)
                || string.IsNullOrWhiteSpace(role))
            {
                return false;
            }

            return true;

        }
    }

}
