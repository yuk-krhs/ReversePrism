using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaExchangeRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 GashaExchangeRewardIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 GashaExchangeRewardId                    ModelPrimitiveType string string string String
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Point                                    ModelPrimitiveType int int int Int32
    // 000 ValueFieldNumber                         int IL2CPP_TYPE_I4
    // 028 Value                                    ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 030 SortId                                   ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Product                                  ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 PickupBonusFieldNumber                   int IL2CPP_TYPE_I4
    // 040 PickupBonus                              ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ExtraListFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_extraList_codec                FieldCodec`1<GashaExtraRewardProductStatus> IL2CPP_TYPE_GENERICINST
    // 048 ExtraList                                ModelClassListType RepeatedField`1<GashaExtraRewardProductStatus> RepeatedField`1<GashaExtraRewardProductStatus> List<GashaExtraRewardProductStatus> Pointer
    public partial class GashaExchangeRewardStatus : DataModel
    {
        public string                                   GashaExchangeRewardId                   { get; set; }
        public int                                      Point                                   { get; set; }
        public LimitedValueStatus?                      Value                                   { get; set; }
        public int                                      SortId                                  { get; set; }
        public ProductWithAmountStatus?                 Product                                 { get; set; }
        public ProductWithAmountStatus?                 PickupBonus                             { get; set; }
        public List<GashaExtraRewardProductStatus>?     ExtraList                               { get; set; }

        public static GashaExchangeRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaExchangeRewardStatus() { Pointer= p0 };

            value.GashaExchangeRewardId                     = GetString(new IntPtr(p + 0x018)); // 0x18 GashaExchangeRewardId       ( ModelPrimitiveType string string string String )
            value.Point                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Point                       ( ModelPrimitiveType int int int Int32 )
            value.Value                                     = GetObject<LimitedValueStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.LimitedValueStatus.FromPointer); // 0x28 Value                       ( ModelClassType LimitedValueStatus LimitedValueStatus LimitedValueStatus Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x38 Product                     ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.PickupBonus                               = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x40 PickupBonus                 ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.ExtraList                                 = GetObjectList<GashaExtraRewardProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.GashaExtraRewardProductStatus.FromPointer); // 0x48 ExtraList                   ( ModelClassListType RepeatedField`1<GashaExtraRewardProductStatus> RepeatedField`1<GashaExtraRewardProductStatus> List<GashaExtraRewardProductStatus> Pointer )

            return value;
        }
    }
}
