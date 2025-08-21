using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>: IResult
    {
        T Data { get; }
        //IDataResult<T> Data { get; } // Bu satır, IDataResult arayüzünün Data özelliğini tanımlar.
        //Bu özellik, IDataResult<T> türünde bir veri döndürür.
        //Bu, IDataResult<T> arayüzünün uygulandığı sınıflarda kullanılabilir.
    }
}
