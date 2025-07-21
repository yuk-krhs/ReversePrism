using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 MarshalAs                                ModelClassType MarshalAsAttribute MarshalAsAttribute MarshalAsAttribute Pointer
    public partial class RuntimeParameterInfo : DataModel
    {
        public MarshalAsAttribute?                      MarshalAs                               { get; set; }

        public static RuntimeParameterInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeParameterInfo() { Pointer= p0 };

            value.MarshalAs                                 = GetObject<MarshalAsAttribute>(new IntPtr(p + 0x040), ReversePrism.DataModels.MarshalAsAttribute.FromPointer); // 0x40 MarshalAs                   ( ModelClassType MarshalAsAttribute MarshalAsAttribute MarshalAsAttribute Pointer )

            return value;
        }
    }
}
