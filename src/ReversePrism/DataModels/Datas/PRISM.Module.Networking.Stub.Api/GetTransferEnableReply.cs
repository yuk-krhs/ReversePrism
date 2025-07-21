using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetTransferEnableReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsTransferEnableFieldNumber              int IL2CPP_TYPE_I4
    // 018 IsTransferEnable                         ModelPrimitiveType bool bool bool Bool
    public partial class GetTransferEnableReply : DataModel
    {
        public bool                                     IsTransferEnable                        { get; set; }

        public static GetTransferEnableReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetTransferEnableReply() { Pointer= p0 };

            value.IsTransferEnable                          = GetBool(new IntPtr(p + 0x018)); // 0x18 IsTransferEnable            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
