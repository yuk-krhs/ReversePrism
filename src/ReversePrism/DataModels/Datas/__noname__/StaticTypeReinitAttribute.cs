using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ReinitType                               000186693B90 ModelClassType Type Type Type Pointer
    public partial class StaticTypeReinitAttribute : DataModel
    {
        public Type?                                    ReinitType                              { get; set; }

        public static StaticTypeReinitAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaticTypeReinitAttribute() { Pointer= p0 };

            value.ReinitType                                = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02466A90BB50 0x10 ReinitType                  ( 000186693B90 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
