using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionId                                ModelPrimitiveType int int int Int32
    // 014 StageId                                  ModelPrimitiveType int int int Int32
    // 018 IsClear                                  ModelPrimitiveType bool bool bool Bool
    // 019 IsGetNow                                 ModelPrimitiveType bool bool bool Bool
    // 020 Product                                  ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 028 Master                                   ModelClassType MstChallengeTourMission MstChallengeTourMission MstChallengeTourMission Pointer
    // 030 Status                                   ModelClassType IChallengeTourStageRewardStatus IChallengeTourStageRewardStatus IChallengeTourStageRewardStatus Pointer
    public partial class ChallengeTourRewardViewModel : DataModel
    {
        public int                                      MissionId                               { get; set; }
        public int                                      StageId                                 { get; set; }
        public bool                                     IsClear                                 { get; set; }
        public bool                                     IsGetNow                                { get; set; }
        public IProductWithAmountStatus?                Product                                 { get; set; }
        public MstChallengeTourMission?                 Master                                  { get; set; }
        public IChallengeTourStageRewardStatus?         Status                                  { get; set; }

        public static ChallengeTourRewardViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourRewardViewModel() { Pointer= p0 };

            value.MissionId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MissionId                   ( ModelPrimitiveType int int int Int32 )
            value.StageId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 StageId                     ( ModelPrimitiveType int int int Int32 )
            value.IsClear                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 IsClear                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsGetNow                                  = GetBool(new IntPtr(p + 0x019)); // 0x19 IsGetNow                    ( ModelPrimitiveType bool bool bool Bool )
            value.Product                                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x20 Product                     ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.Master                                    = GetObject<MstChallengeTourMission>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstChallengeTourMission.FromPointer); // 0x28 Master                      ( ModelClassType MstChallengeTourMission MstChallengeTourMission MstChallengeTourMission Pointer )
            value.Status                                    = GetObject<IChallengeTourStageRewardStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IChallengeTourStageRewardStatus.FromPointer); // 0x30 Status                      ( ModelClassType IChallengeTourStageRewardStatus IChallengeTourStageRewardStatus IChallengeTourStageRewardStatus Pointer )

            return value;
        }
    }
}
