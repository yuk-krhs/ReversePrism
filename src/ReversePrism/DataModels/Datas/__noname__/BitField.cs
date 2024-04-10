using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 M_EnumType                               000186692850 ModelClassType Type Type Type Pointer
    public partial class BitField : DataModel
    {
        public Type?                                    M_EnumType                              { get; set; }

        public static BitField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitField() { Pointer= p0 };

            value.M_EnumType                                = GetObject<Type>(new IntPtr(p + 0x070), ReversePrism.DataModels.Type.FromPointer); // 0246691DF398 0x70 M_EnumType                  ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
