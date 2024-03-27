using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 WindowBits_Min                           int IL2CPP_TYPE_I4
    // 000 WindowBits_Default                       int IL2CPP_TYPE_I4
    // 000 WindowBits_Max                           int IL2CPP_TYPE_I4
    // 000 Quality_Min                              int IL2CPP_TYPE_I4
    // 000 Quality_Default                          int IL2CPP_TYPE_I4
    // 000 Quality_Max                              int IL2CPP_TYPE_I4
    // 000 MaxInputSize                             int IL2CPP_TYPE_I4
    public partial class BrotliUtils
    {

        public static BrotliUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliUtils();


            return value;
        }
    }
}
