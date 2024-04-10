using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ErrorInfo> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ReasonFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Reason                                   000186671910 ModelPrimitiveType string string string String
    // 000 DomainFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Domain                                   000186671910 ModelPrimitiveType string string string String
    // 000 MetadataFieldNumber                      int IL2CPP_TYPE_I4
    // 008 _map_metadata_codec                      Codec<string, string> IL2CPP_TYPE_GENERICINST
    // 028 metadata_                                MapField`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ErrorInfo : DataModel
    {
        public string                                   Reason                                  { get; set; }
        public string                                   Domain                                  { get; set; }

        public static ErrorInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorInfo() { Pointer= p0 };

            value.Reason                                    = GetString(new IntPtr(p + 0x018)); // 02466A72ADD0 0x18 Reason                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Domain                                    = GetString(new IntPtr(p + 0x020)); // 02466A72AE10 0x20 Domain                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
