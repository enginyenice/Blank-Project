//Created By Engin Yenice
//enginyenice2626@gmail.com

using Core.DataAccess;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}