using System;

namespace DesignPatterns.Singleton
{
    public sealed class Log
    {
        private static volatile ILog instance;
        private static object syncRoot = new Object();

        public Log() { }

        public static ILog Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(syncRoot)
                    {
                        if(instance == null)
                        {
                            instance = DependencyResolver.Current.GetService<ILog>();
                        }
                    }
                }
                return instance;
            }
        }
    }
}