namespace lab2;

using System;
using System.Collections.Generic;

public class SingletonBase<T> where T : class, new()
{
    private static readonly Dictionary<Type, object> Instances = new ();

    public static T CreateInstance()
    {
        if (Instances.TryGetValue(typeof(T), out object instance))
        {
            return (T)instance;
        }

        var newInstance = new T();

        Instances.Add(typeof(T), newInstance);

        return newInstance;
    }
}
