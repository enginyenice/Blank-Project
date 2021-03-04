//Created By Engin Yenice
//enginyenice2626@gmail.com

using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [CacheRemoveAspect("Get")]
        public IResult Add(User entity)
        {
            _userDal.Add(entity);
            return new SuccessResult(message: Messages.AddUser);
        }

        public IResult Update(User entity)
        {
            _userDal.Update(entity);
            return new SuccessResult(message: Messages.UpdateUser);
        }

        public IResult Delete(User entity)
        {
            _userDal.Delete(entity);
            return new SuccessResult(message: Messages.DeleteUser);
        }

        [CacheAspect]
        [TransactionAspect]
        [PerformanceAspect(-1)]
        [SecuredOperation("user.getall")]
        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            if (result.Count == 0)
            {
                return new ErrorDataResult<List<User>>(message: Messages.GetAllErrorUser);
            }

            return new SuccessDataResult<List<User>>(data: result, message: Messages.GetAllSuccessUser);
        }

        public IDataResult<User> GetByEmail(string email)
        {
            var result = _userDal.Get(p => p.Email == email);
            if (result == null)
            {
                return new ErrorDataResult<User>(message: Messages.GetByEmailErrorUser);
            }

            return new SuccessDataResult<User>(data: result, message: Messages.GetByEmailSuccessUser);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var result = _userDal.GetClaims(user);
            return new SuccessDataResult<List<OperationClaim>>(result);
        }
    }
}