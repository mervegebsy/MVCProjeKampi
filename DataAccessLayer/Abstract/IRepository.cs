using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Generic Repo içinde yer alan metodların imzasını tutuyor
    public interface IRepository<T> 
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        //id si 5 olan yazar dediğim an bunu kullanırım
        T Get(Expression<Func<T, bool>> filter);
        //Burada komple bir liste yazarlar içerisinde ismi ali olanalrı bununla bulabilirim
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
