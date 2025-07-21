using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RevertGashaExchangePointReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 RevertPointListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_revertPointList_codec          FieldCodec`1<GashaRevertExchangePointStatus> IL2CPP_TYPE_GENERICINST
    // 018 RevertPointList                          ModelClassListType RepeatedField`1<GashaRevertExchangePointStatus> RepeatedField`1<GashaRevertExchangePointStatus> List<GashaRevertExchangePointStatus> Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    public partial class RevertGashaExchangePointReply : DataModel
    {
        public List<GashaRevertExchangePointStatus>?    RevertPointList                         { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }

        public static RevertGashaExchangePointReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RevertGashaExchangePointReply() { Pointer= p0 };

            value.RevertPointList                           = GetObjectList<GashaRevertExchangePointStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaRevertExchangePointStatus.FromPointer); // 0x18 RevertPointList             ( ModelClassListType RepeatedField`1<GashaRevertExchangePointStatus> RepeatedField`1<GashaRevertExchangePointStatus> List<GashaRevertExchangePointStatus> Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x20 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )

            return value;
        }
    }
}
