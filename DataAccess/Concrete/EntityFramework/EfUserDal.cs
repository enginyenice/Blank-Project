//Created By Engin Yenice
//enginyenice2626@gmail.com

using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, DatabaseContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new DatabaseContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join operationClaim in context.OperationClaims on userOperationClaim.OperationClaimId equals
                                 operationClaim.Id
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim()
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}