using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
    interface IEmployeeDashBoard
    {
        List<Person> GetAll();
        Person Find(int? id);
        Person Add(Person employee);
        Person Update(Person employee);
        void Remove(int id);
    }
}
