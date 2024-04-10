using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultValueType                         0001866936B0 ModelClassType Type Type Type Pointer
    public partial class GetValueOrDefault : DataModel
    {
        public Type?                                    DefaultValueType                        { get; set; }

        public static GetValueOrDefault? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetValueOrDefault() { Pointer= p0 };

            value.DefaultValueType                          = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02466A0A5268 0x10 DefaultValueType            ( 0001866936B0 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
