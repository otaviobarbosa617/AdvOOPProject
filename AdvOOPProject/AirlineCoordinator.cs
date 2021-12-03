using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvOOPProject
{
    class AirlineCoordinator
    {

        public CustomerManager custManager { get; set; }

        public AirlineCoordinator()
        {
            custManager = new CustomerManager(100);
        }

    }
}
