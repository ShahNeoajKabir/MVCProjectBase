using StudentPortalMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortalMVC.BLL
{
    public class UserBLLManager: IUserBLLManager
    {
        private readonly StudentPortalDbContext _dbContext;
        public UserBLLManager(StudentPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
    public interface IUserBLLManager
    {

    }
}
