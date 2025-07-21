using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ChallengeTourStageRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MissionIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MissionId                                ModelPrimitiveType int int int Int32
    // 000 RewardTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 01C RewardType                               ModelEnumType ChallengeTourRewardType ChallengeTourRewardType ChallengeTourRewardType Int32
    // 000 IsClearFieldNumber                       int IL2CPP_TYPE_I4
    // 020 IsClear                                  ModelPrimitiveType bool bool bool Bool
    // 000 RewardFieldNumber                        int IL2CPP_TYPE_I4
    // 028 Reward                                   ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    public partial class ChallengeTourStageRewardStatus : DataModel
    {
        public int                                      MissionId                               { get; set; }
        public ChallengeTourRewardType                  RewardType                              { get; set; }
        public bool                                     IsClear                                 { get; set; }
        public ProductWithAmountStatus?                 Reward                                  { get; set; }

        public static ChallengeTourStageRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageRewardStatus() { Pointer= p0 };

            value.MissionId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MissionId                   ( ModelPrimitiveType int int int Int32 )
            value.RewardType                                = (ChallengeTourRewardType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C RewardType                  ( ModelEnumType ChallengeTourRewardType ChallengeTourRewardType ChallengeTourRewardType Int32 )
            value.IsClear                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsClear                     ( ModelPrimitiveType bool bool bool Bool )
            value.Reward                                    = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x28 Reward                      ( ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )

            return value;
        }
    }
}
