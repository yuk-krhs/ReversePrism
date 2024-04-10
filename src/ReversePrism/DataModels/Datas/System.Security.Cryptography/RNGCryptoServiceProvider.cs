using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _lock                                    <object> IL2CPP_TYPE_OBJECT
    // 010 _handle                                  <int> IL2CPP_TYPE_I
    public partial class RNGCryptoServiceProvider : DataModel
    {

        public static RNGCryptoServiceProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RNGCryptoServiceProvider() { Pointer= p0 };


            return value;
        }
    }
}
