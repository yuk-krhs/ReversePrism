using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataType                                 000186671910 ModelPrimitiveType string string string String
    // 018 Type                                     000186692850 ModelClassType Type Type Type Pointer
    public partial class XmlTextAttribute : DataModel
    {
        public string                                   DataType                                { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static XmlTextAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTextAttribute() { Pointer= p0 };

            value.DataType                                  = GetString(new IntPtr(p + 0x010)); // 0246675184C8 0x10 DataType                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0246675184E8 0x18 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
