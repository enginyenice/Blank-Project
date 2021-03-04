//Created By Engin Yenice
//enginyenice2626@gmail.com

using Castle.DynamicProxy;
using Core.CrossCuttingResolvers.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Linq;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validationType;

        public ValidationAspect(Type validationType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validationType))
            {
                throw new Exception("Doğrulama sınıfı değildir.");
            }

            _validationType = validationType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validationType);
            var entityType = _validationType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}