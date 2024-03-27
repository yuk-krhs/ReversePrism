using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGashaExchangePointListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PointListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_pointList_codec                FieldCodec`1<GashaExchangePointStatus> IL2CPP_TYPE_GENERICINST
    // 018 PointList                                000185CDB1C8 ModelClassListType RepeatedField`1<GashaExchangePointStatus> RepeatedField`1<GashaExchangePointStatus> List<GashaExchangePointStatus> Pointer
    public partial class GetGashaExchangePointListReply
    {
        public List<GashaExchangePointStatus>?          PointList                               { get; set; }

        public static GetGashaExchangePointListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGashaExchangePointListReply();

            value.PointList                                 = GetObjectList<GashaExchangePointStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaExchangePointStatus.FromPointer); // 0270D1A122B0 0x18 PointList                   ( 000185CDB1C8 ModelClassListType RepeatedField`1<GashaExchangePointStatus> RepeatedField`1<GashaExchangePointStatus> List<GashaExchangePointStatus> Pointer )

            return value;
        }
    }
}
