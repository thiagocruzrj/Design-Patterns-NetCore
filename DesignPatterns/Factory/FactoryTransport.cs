using System;

namespace DesignPatterns.Factory
{
    public static class FactoryTransport
    {
        public static ITransport CreateInstance(string name)
        {
            return Activator.CreateInstance(Type.GetType($"{name}")) as ITransport;
        }
    }
}