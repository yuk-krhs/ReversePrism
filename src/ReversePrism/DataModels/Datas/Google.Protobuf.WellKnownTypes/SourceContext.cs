using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SourceContext> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FileNameFieldNumber                      int IL2CPP_TYPE_I4
    // 018 FileName                                 000186671910 ModelPrimitiveType string string string String
    public partial class SourceContext : DataModel
    {
        public string                                   FileName                                { get; set; }

        public static SourceContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SourceContext() { Pointer= p0 };

            value.FileName                                  = GetString(new IntPtr(p + 0x018)); // 02466A4C4D88 0x18 FileName                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
