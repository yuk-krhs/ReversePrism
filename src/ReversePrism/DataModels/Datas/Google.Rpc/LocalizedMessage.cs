using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LocalizedMessage> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 LocaleFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Locale                                   ModelPrimitiveType string string string String
    // 000 MessageFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Message                                  ModelPrimitiveType string string string String
    public partial class LocalizedMessage : DataModel
    {
        public string                                   Locale                                  { get; set; }
        public string                                   Message                                 { get; set; }

        public static LocalizedMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalizedMessage() { Pointer= p0 };

            value.Locale                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Locale                      ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Message                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
