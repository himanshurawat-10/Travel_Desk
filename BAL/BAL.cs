using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDesk_Entities;

namespace BAL
{
    public class Bal

    {
        DAL.Dal dal = new DAL.Dal();
        public int AddUser(User user)
        {
            dal.AddUser(user);
            return 0;
        }

        public Role GetRole()
        {
            return dal.GetRole();
        }
    }
}
