using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetDocumentReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Body                                     000186671910 ModelPrimitiveType string string string String
    public partial class GetDocumentReply : DataModel
    {
        public string                                   Body                                    { get; set; }

        public static GetDocumentReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetDocumentReply() { Pointer= p0 };

            value.Body                                      = GetString(new IntPtr(p + 0x018)); // 024662733590 0x18 Body                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
