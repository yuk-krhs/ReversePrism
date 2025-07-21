using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetServerEnableReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsServerEnableFieldNumber                int IL2CPP_TYPE_I4
    // 018 IsServerEnable                           ModelPrimitiveType bool bool bool Bool
    public partial class GetServerEnableReply : DataModel
    {
        public bool                                     IsServerEnable                          { get; set; }

        public static GetServerEnableReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetServerEnableReply() { Pointer= p0 };

            value.IsServerEnable                            = GetBool(new IntPtr(p + 0x018)); // 0x18 IsServerEnable              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
