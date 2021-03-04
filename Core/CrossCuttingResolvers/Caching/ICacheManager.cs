//Created By Engin Yenice
//enginyenice2626@gmail.com

namespace Core.CrossCuttingResolvers.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        object Get(string key);

        void Add(string key, object value, int duration);

        bool IsAdd(string key);

        void Remove(string key);

        void RemoveByPattern(string pattern);
    }
}