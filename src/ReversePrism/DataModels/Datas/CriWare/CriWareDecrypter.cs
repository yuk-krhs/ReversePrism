using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 temporalStorage                          ulong IL2CPP_TYPE_U8
    public partial class CriWareDecrypter : DataModel
    {

        public static CriWareDecrypter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriWareDecrypter() { Pointer= p0 };


            return value;
        }
    }
}
