using System;
namespace API
{
    public class Resources
    {
        public static T GetResource<T>() where T : class
        {
            var page = (T)Activator.CreateInstance(typeof(T));
            return page;
        }
        public InfoResource InfoResource => GetResource<InfoResource>();
    }
}