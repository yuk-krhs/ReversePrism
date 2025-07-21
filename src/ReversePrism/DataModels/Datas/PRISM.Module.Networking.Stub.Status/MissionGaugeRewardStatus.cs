using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MissionGaugeRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PointFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Point                                    ModelPrimitiveType int int int Int32
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 01C State                                    ModelEnumType MissionGaugeState MissionGaugeState MissionGaugeState Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Product                                  ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class MissionGaugeRewardStatus : DataModel
    {
        public int                                      Point                                   { get; set; }
        public MissionGaugeState                        State                                   { get; set; }
        public ProductWithAmountStatus?                 Product                                 { get; set; }

        public static MissionGaugeRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGaugeRewardStatus() { Pointer= p0 };

            value.Point                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Point                       ( ModelPrimitiveType int int int Int32 )
            value.State                                     = (MissionGaugeState)GetInt32(new IntPtr(p + 0x01C)); // 0x1C State                       ( ModelEnumType MissionGaugeState MissionGaugeState MissionGaugeState Int32 )
            value.Product                                   = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x20 Product                     ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
