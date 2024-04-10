using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultKeyOptions                        KeyOptions IL2CPP_TYPE_VALUETYPE
    public partial class VariantExtension : DataModel
    {

        public static VariantExtension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VariantExtension() { Pointer= p0 };


            return value;
        }
    }
}
