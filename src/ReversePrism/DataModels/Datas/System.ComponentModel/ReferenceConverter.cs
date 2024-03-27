using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_none                                   string IL2CPP_TYPE_STRING
    // 010 Type                                     000186692850 ModelClassType Type Type Type Pointer
    public partial class ReferenceConverter
    {
        public Type?                                    Type                                    { get; set; }

        public static ReferenceConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReferenceConverter();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0270D7B393D0 0x10 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
