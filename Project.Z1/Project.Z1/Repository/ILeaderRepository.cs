using Project.Z1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Z1.Repository
{
    public interface ILeaderRepository
    {

        IEnumerable<Leader> GetUsers();
        Leader GetUser(int userId);
        bool AddUser(Leader User);
        bool UpdateUser(Leader User);
        bool DeleteUser(int UserId);






    }
}
