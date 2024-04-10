using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CreateArchiveIndexRequest> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StreamingIdFieldNumber                   int IL2CPP_TYPE_I4
    // 018 StreamingId                              000186671910 ModelPrimitiveType string string string String
    public partial class CreateArchiveIndexRequest : DataModel
    {
        public string                                   StreamingId                             { get; set; }

        public static CreateArchiveIndexRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateArchiveIndexRequest() { Pointer= p0 };

            value.StreamingId                               = GetString(new IntPtr(p + 0x018)); // 024664BEA3B8 0x18 StreamingId                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
