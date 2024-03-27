using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MissionId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 014 StageId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 IsClear                                  0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 019 IsGetNow                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 Product                                  0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 028 Master                                   00018661AD50 ModelClassType MstChallengeTourMission MstChallengeTourMission MstChallengeTourMission Pointer
    public partial class ChallengeTourRewardViewModel
    {
        public int                                      MissionId                               { get; set; }
        public int                                      StageId                                 { get; set; }
        public bool                                     IsClear                                 { get; set; }
        public bool                                     IsGetNow                                { get; set; }
        public IProductWithAmountStatus?                Product                                 { get; set; }
        public MstChallengeTourMission?                 Master                                  { get; set; }

        public static ChallengeTourRewardViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourRewardViewModel();

            value.MissionId                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D64A63E8 0x10 MissionId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StageId                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D64A6408 0x14 StageId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsClear                                   = GetBool(new IntPtr(p + 0x018)); // 0270D64A6428 0x18 IsClear                     ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsGetNow                                  = GetBool(new IntPtr(p + 0x019)); // 0270D64A6448 0x19 IsGetNow                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.Product                                   = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D64A6468 0x20 Product                     ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.Master                                    = GetObject<MstChallengeTourMission>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstChallengeTourMission.FromPointer); // 0270D64A6488 0x28 Master                      ( 00018661AD50 ModelClassType MstChallengeTourMission MstChallengeTourMission MstChallengeTourMission Pointer )

            return value;
        }
    }
}
