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
    // 018 Point                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 01C State                                    000186622610 ModelEnumType MissionGaugeState MissionGaugeState MissionGaugeState Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 020 Product                                  0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class MissionGaugeRewardStatus
    {
        public int                                      Point                                   { get; set; }
        public MissionGaugeState                        State                                   { get; set; }
        public ProductWithAmountStatus?                 Product                                 { get; set; }

        public static MissionGaugeRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionGaugeRewardStatus();

            value.Point                                     = GetInt32(new IntPtr(p + 0x018)); // 0270D22F0A18 0x18 Point                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (MissionGaugeState)GetInt32(new IntPtr(p + 0x01C)); // 0270D22F0A58 0x1C State                       ( 000186622610 ModelEnumType MissionGaugeState MissionGaugeState MissionGaugeState Int32 )
            value.Product                                   = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D22F0A98 0x20 Product                     ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
