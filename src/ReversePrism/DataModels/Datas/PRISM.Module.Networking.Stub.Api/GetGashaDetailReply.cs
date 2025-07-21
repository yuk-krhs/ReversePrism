using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaDetailReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Body                                     ModelPrimitiveType string string string String
    // 000 DetailListFieldNumber                    int IL2CPP_TYPE_I4
    // 008 _repeated_detailList_codec               FieldCodec`1<GashaDetailStatus> IL2CPP_TYPE_GENERICINST
    // 020 DetailList                               ModelClassListType RepeatedField`1<GashaDetailStatus> RepeatedField`1<GashaDetailStatus> List<GashaDetailStatus> Pointer
    public partial class GetGashaDetailReply : DataModel
    {
        public string                                   Body                                    { get; set; }
        public List<GashaDetailStatus>?                 DetailList                              { get; set; }

        public static GetGashaDetailReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaDetailReply() { Pointer= p0 };

            value.Body                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Body                        ( ModelPrimitiveType string string string String )
            value.DetailList                                = GetObjectList<GashaDetailStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaDetailStatus.FromPointer); // 0x20 DetailList                  ( ModelClassListType RepeatedField`1<GashaDetailStatus> RepeatedField`1<GashaDetailStatus> List<GashaDetailStatus> Pointer )

            return value;
        }
    }
}
