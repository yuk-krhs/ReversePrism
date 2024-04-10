using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DateTimeFormatString                     string IL2CPP_TYPE_STRING
    // 010 textWriterProvider                       Func`1<TextWriter> IL2CPP_TYPE_GENERICINST
    // 018 ForType                                  0001866936B0 ModelClassType Type Type Type Pointer
    // 020 ForTypeString                            000186672F10 ModelPrimitiveType string string string String
    public partial class TextWriterLogger : DataModel
    {
        public Type?                                    ForType                                 { get; set; }
        public string                                   ForTypeString                           { get; set; }

        public static TextWriterLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextWriterLogger() { Pointer= p0 };

            value.ForType                                   = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0245A40AD8D0 0x18 ForType                     ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.ForTypeString                             = GetString(new IntPtr(p + 0x020)); // 0245A40AD8F0 0x20 ForTypeString               ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
