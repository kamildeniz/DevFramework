using DevFramework.Core.CrossCuttingConcerns.Caching;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DevFramework.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheAspect : MethodInterceptionAspect
    {
        private Type _cacheType;
        private int _cacheByMinute;
        private ICacheManager _cacheManager;

        public CacheAspect(Type cacheType, int cacheByMinute)
        {
            _cacheType = cacheType;
            _cacheByMinute = cacheByMinute;
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("wrong new Manager");
            }
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);
            base.RuntimeInitialize(method);

        }
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var methodName = string.Format("{0},{1},{2}",
                args.Method.ReflectedType.Namespace,
                args.Method.ReflectedType.Name,
                args.Method.Name);
            base.OnInvoke(args);
        }
    }
}
