using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 lockObject                               <object> IL2CPP_TYPE_OBJECT
    // 008 algorithms                               Dictionary`2<string, Type> IL2CPP_TYPE_GENERICINST
    public partial class CryptoConfig : DataModel
    {

        public static CryptoConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CryptoConfig() { Pointer= p0 };


            return value;
        }
    }
}
