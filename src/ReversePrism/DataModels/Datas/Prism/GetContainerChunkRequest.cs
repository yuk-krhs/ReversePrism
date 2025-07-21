using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetContainerChunkRequest> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StreamingIdFieldNumber                   int IL2CPP_TYPE_I4
    // 018 StreamingId                              ModelPrimitiveType string string string String
    // 000 ResumeSequenceNumberFieldNumber          int IL2CPP_TYPE_I4
    // 020 ResumeSequenceNumber                     ModelPrimitiveType int int int Int32
    public partial class GetContainerChunkRequest : DataModel
    {
        public string                                   StreamingId                             { get; set; }
        public int                                      ResumeSequenceNumber                    { get; set; }

        public static GetContainerChunkRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetContainerChunkRequest() { Pointer= p0 };

            value.StreamingId                               = GetString(new IntPtr(p + 0x018)); // 0x18 StreamingId                 ( ModelPrimitiveType string string string String )
            value.ResumeSequenceNumber                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 ResumeSequenceNumber        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
