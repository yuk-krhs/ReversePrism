using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  TypeConverterAttribute IL2CPP_TYPE_CLASS
    // 010 ConverterTypeName                        000186672F10 ModelPrimitiveType string string string String
    public partial class TypeConverterAttribute : DataModel
    {
        public string                                   ConverterTypeName                       { get; set; }

        public static TypeConverterAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeConverterAttribute() { Pointer= p0 };

            value.ConverterTypeName                         = GetString(new IntPtr(p + 0x010)); // 0245A60053E0 0x10 ConverterTypeName           ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
