using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NullableType                             ModelClassType Type Type Type Pointer
    // 018 UnderlyingType                           ModelClassType Type Type Type Pointer
    // 020 UnderlyingTypeConverter                  ModelClassType TypeConverter TypeConverter TypeConverter Pointer
    public partial class NullableConverter : DataModel
    {
        public Type?                                    NullableType                            { get; set; }
        public Type?                                    UnderlyingType                          { get; set; }
        public TypeConverter?                           UnderlyingTypeConverter                 { get; set; }

        public static NullableConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NullableConverter() { Pointer= p0 };

            value.NullableType                              = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 NullableType                ( ModelClassType Type Type Type Pointer )
            value.UnderlyingType                            = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 UnderlyingType              ( ModelClassType Type Type Type Pointer )
            value.UnderlyingTypeConverter                   = GetObject<TypeConverter>(new IntPtr(p + 0x020), ReversePrism.DataModels.TypeConverter.FromPointer); // 0x20 UnderlyingTypeConverter     ( ModelClassType TypeConverter TypeConverter TypeConverter Pointer )

            return value;
        }
    }
}
