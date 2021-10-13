using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace TreinamentoXamarin.ViewModels
{
	public abstract class ExtendedBindableObject : BindableObject
    {
        public void RaisePropertyChanged<T>(Expression<Func<T>> property)
        {
            var name = GetMemberInfo(property).Name;
            OnPropertyChanged(name);
        }

        public void SetProperty<T>(Expression<Func<T>> property)
        {
            var name = GetMemberInfo(property).Name;
            OnPropertyChanged(name);
        }

        protected bool SetProperty<T>(ref T oldValue, T newValue, [CallerMemberName] string propertyName = "")
        {
            if (null != newValue &&
                null != oldValue &&
                oldValue.Equals(newValue))
            {
                return false;
            }

            oldValue = newValue;

            OnPropertyChanged(propertyName);

            return true;
        }

        private MemberInfo GetMemberInfo(Expression expression)
        {
            MemberExpression operand;
            LambdaExpression lambdaExpression = (LambdaExpression)expression;
            if (lambdaExpression.Body as UnaryExpression != null)
            {
                UnaryExpression body = (UnaryExpression)lambdaExpression.Body;
                operand = (MemberExpression)body.Operand;
            }
            else
            {
                operand = (MemberExpression)lambdaExpression.Body;
            }
            return operand.Member;
        }
    }
}
