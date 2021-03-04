//Created By Engin Yenice
//enginyenice2626@gmail.com

using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Transactions;

namespace Core.Aspects.Autofac.Transaction
{
    public class TransactionAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    scope.Complete();
                }
                catch (Exception e)
                {
                    scope.Dispose();
                    throw;
                }
            }
        }
    }
}