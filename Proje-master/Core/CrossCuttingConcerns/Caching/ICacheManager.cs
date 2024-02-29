using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public  interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key,object value ,int duration);
        //cache'de var mı?
        //cacheden silme
        void Remove(string key);
        //cacheden belirli bir yeri uçurma("içinde get olanlar v.b")
       void RemoveByPattern(string pattern);
        bool IsAdd(string key);
    }
}
