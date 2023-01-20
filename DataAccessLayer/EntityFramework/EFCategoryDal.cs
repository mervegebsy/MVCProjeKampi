using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositeries;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    //Generic Repo içindeki değerleri tutuyor
    //access modifier
    //Katmanları ve katmanlar içindeki sınıfları birbiriyle haberleştirerek her katmanın ya da her sınıfın her metodun içindeki komut sadece kendi işlemlerini gerçekleştirecek
    public class EFCategoryDal:GenericRepository<Category>, ICategoryDal
    {


    }
}
