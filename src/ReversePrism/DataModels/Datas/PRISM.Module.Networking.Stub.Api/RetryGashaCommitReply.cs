using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<RetryGashaCommitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Gasha                                    ModelClassType GashaStatus GashaStatus GashaStatus Pointer
    // 000 HavingGroupFieldNumber                   int IL2CPP_TYPE_I4
    // 020 HavingGroup                              ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer
    // 000 DrawProductListFieldNumber               int IL2CPP_TYPE_I4
    // 008 _repeated_drawProductList_codec          FieldCodec`1<GashaRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 028 DrawProductList                          ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer
    // 000 GashaStateFieldNumber                    int IL2CPP_TYPE_I4
    // 030 GashaState                               ModelEnumType GashaState GashaState GashaState Int32
    public partial class RetryGashaCommitReply : DataModel
    {
        public GashaStatus?                             Gasha                                   { get; set; }
        public HavingProductGroupStatus?                HavingGroup                             { get; set; }
        public List<GashaRewardProductStatus>?          DrawProductList                         { get; set; }
        public GashaState                               GashaState                              { get; set; }

        public static RetryGashaCommitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RetryGashaCommitReply() { Pointer= p0 };

            value.Gasha                                     = GetObject<GashaStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.GashaStatus.FromPointer); // 0x18 Gasha                       ( ModelClassType GashaStatus GashaStatus GashaStatus Pointer )
            value.HavingGroup                               = GetObject<HavingProductGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.HavingProductGroupStatus.FromPointer); // 0x20 HavingGroup                 ( ModelClassType HavingProductGroupStatus HavingProductGroupStatus HavingProductGroupStatus Pointer )
            value.DrawProductList                           = GetObjectList<GashaRewardProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaRewardProductStatus.FromPointer); // 0x28 DrawProductList             ( ModelClassListType RepeatedField`1<GashaRewardProductStatus> RepeatedField`1<GashaRewardProductStatus> List<GashaRewardProductStatus> Pointer )
            value.GashaState                                = (GashaState)GetInt32(new IntPtr(p + 0x030)); // 0x30 GashaState                  ( ModelEnumType GashaState GashaState GashaState Int32 )

            return value;
        }
    }
}
