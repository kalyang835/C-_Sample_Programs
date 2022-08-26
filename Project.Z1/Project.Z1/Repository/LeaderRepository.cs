using Project.Z1.Data;
using Project.Z1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Z1.Repository
{
    public class LeaderRepository : ILeaderRepository
    {
        private readonly LDbContext dbContext;
        public LeaderRepository(LDbContext ApplicationDb)

        {
            dbContext = ApplicationDb;
        }

        public IEnumerable<Leader> GetUsers()
        {
            List<Leader> result = new List<Leader>();
            if (dbContext != null)
            {
                result = dbContext.Leader.ToList();
            }
            return result;
        }

        public Leader GetUser(int userId)
        {
            Leader result = new Leader();
            if (dbContext != null)
            {
                result = dbContext.Leader.FirstOrDefault(L => L.Id == userId);
            }
            return result;
        }

        public bool AddUser(Leader User)
        {
            if (dbContext != null)
            {
                dbContext.Leader.Add(User);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateUser(Leader User)
        {
            if (dbContext != null)
            {
                dbContext.Leader.Update(User);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteUser(int UserId)
        {
            if (dbContext != null)
            {
                Leader obj = dbContext.Leader.FirstOrDefault(L => L.Id == UserId);

                if (obj.Id > 0)
                {
                    dbContext.Leader.Remove(obj);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            return false;
        }

    }
}
