using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 018 Message                                  000186672F10 ModelPrimitiveType string string string String
    public partial class ErrorMemoryPackFormatter : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public string                                   Message                                 { get; set; }

        public static ErrorMemoryPackFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorMemoryPackFormatter() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02466AF70788 0x10 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.Message                                   = GetString(new IntPtr(p + 0x018)); // 02466AF707A8 0x18 Message                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
