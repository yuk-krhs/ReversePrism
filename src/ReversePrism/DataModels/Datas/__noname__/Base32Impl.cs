using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _digits                                  char[] IL2CPP_TYPE_SZARRAY
    // 000 _mask                                    int IL2CPP_TYPE_I4
    // 000 _shift                                   int IL2CPP_TYPE_I4
    public partial class Base32Impl : DataModel
    {

        public static Base32Impl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Base32Impl() { Pointer= p0 };


            return value;
        }
    }
}
