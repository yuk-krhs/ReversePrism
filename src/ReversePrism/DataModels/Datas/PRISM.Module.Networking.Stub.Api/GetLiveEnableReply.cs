using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetLiveEnableReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 IsLiveEnableFieldNumber                  int IL2CPP_TYPE_I4
    // 018 IsLiveEnable                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GetLiveEnableReply : DataModel
    {
        public bool                                     IsLiveEnable                            { get; set; }

        public static GetLiveEnableReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetLiveEnableReply() { Pointer= p0 };

            value.IsLiveEnable                              = GetBool(new IntPtr(p + 0x018)); // 024662178BE8 0x18 IsLiveEnable                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
