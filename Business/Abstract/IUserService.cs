//Created By Engin Yenice
//enginyenice2626@gmail.com

using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User entity);

        IResult Update(User entity);

        IResult Delete(User entity);

        IDataResult<List<User>> GetAll();

        IDataResult<User> GetByEmail(string email);

        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}