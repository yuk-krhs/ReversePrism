using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 ComponentType                            000186692850 ModelClassType Type Type Type Pointer
    // 090 PropertyType                             000186692850 ModelClassType Type Type Type Pointer
    public partial class SimplePropertyDescriptor : DataModel
    {
        public Type?                                    ComponentType                           { get; set; }
        public Type?                                    PropertyType                            { get; set; }

        public static SimplePropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimplePropertyDescriptor() { Pointer= p0 };

            value.ComponentType                             = GetObject<Type>(new IntPtr(p + 0x088), ReversePrism.DataModels.Type.FromPointer); // 024667B7D0B8 0x88 ComponentType               ( 000186692850 ModelClassType Type Type Type Pointer )
            value.PropertyType                              = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 024667B7D0D8 0x90 PropertyType                ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
