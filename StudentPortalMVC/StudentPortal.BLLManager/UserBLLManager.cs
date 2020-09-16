using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.BLLManager
{
   public class UserBLLManager: IUserBLLManager
    {
        private readonly StudentPortalDbContext _dbContext;
        public UserBLLManager(StudentPortalDbContex dbContex)
        {
            _dbContext = dbContex;
        }
        public User AddUser(User user)
        {

        }
    }


    public interface IUserBLLManager
    {

    }


}
