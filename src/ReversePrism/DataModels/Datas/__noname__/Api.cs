using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Api> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ServiceFieldNumber                       int IL2CPP_TYPE_I4
    // 018 Service                                  ModelPrimitiveType string string string String
    // 000 OperationFieldNumber                     int IL2CPP_TYPE_I4
    // 020 Operation                                ModelPrimitiveType string string string String
    // 000 ProtocolFieldNumber                      int IL2CPP_TYPE_I4
    // 028 Protocol                                 ModelPrimitiveType string string string String
    // 000 VersionFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Version                                  ModelPrimitiveType string string string String
    public partial class Api : DataModel
    {
        public string                                   Service                                 { get; set; }
        public string                                   Operation                               { get; set; }
        public string                                   Protocol                                { get; set; }
        public string                                   Version                                 { get; set; }

        public static Api? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Api() { Pointer= p0 };

            value.Service                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Service                     ( ModelPrimitiveType string string string String )
            value.Operation                                 = GetString(new IntPtr(p + 0x020)); // 0x20 Operation                   ( ModelPrimitiveType string string string String )
            value.Protocol                                  = GetString(new IntPtr(p + 0x028)); // 0x28 Protocol                    ( ModelPrimitiveType string string string String )
            value.Version                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Version                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
