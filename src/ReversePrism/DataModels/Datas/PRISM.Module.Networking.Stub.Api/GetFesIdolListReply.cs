using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetFesIdolListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesIdolListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_fesIdolList_codec              FieldCodec`1<FesIdolStatus> IL2CPP_TYPE_GENERICINST
    // 018 FesIdolList                              000185CD7D58 ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer
    public partial class GetFesIdolListReply
    {
        public List<FesIdolStatus>?                     FesIdolList                             { get; set; }

        public static GetFesIdolListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFesIdolListReply();

            value.FesIdolList                               = GetObjectList<FesIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FesIdolStatus.FromPointer); // 0270D12A4A88 0x18 FesIdolList                 ( 000185CD7D58 ModelClassListType RepeatedField`1<FesIdolStatus> RepeatedField`1<FesIdolStatus> List<FesIdolStatus> Pointer )

            return value;
        }
    }
}
