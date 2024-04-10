using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     000186692850 ModelClassType Type Type Type Pointer
    public partial class SwitchLevelAttribute : DataModel
    {
        public Type?                                    Type                                    { get; set; }

        public static SwitchLevelAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchLevelAttribute() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 024667A0A480 0x10 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
