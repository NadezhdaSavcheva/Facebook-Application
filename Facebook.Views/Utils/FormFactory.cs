using Autofac;
using System;

namespace Facebook.Views.Utils
{
    class FormFactory
    {
        private static ILifetimeScope scope;

        public static T GetFormInstance<T>()
        {
            return scope is null ? throw new ArgumentException("scope") : scope.Resolve<T>();
        }
    }
}
