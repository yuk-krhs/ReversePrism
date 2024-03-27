using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RewardItemIcon                           00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 LockIconObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 BadgeObject                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 AcquiredImageObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 048 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class SeasonMissionRewardIcon
    {
        public RewardItemIcon?                          RewardItemIcon                          { get; set; }
        public GameObject?                              LockIconObject                          { get; set; }
        public GameObject?                              BadgeObject                             { get; set; }
        public GameObject?                              AcquiredImageObject                     { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }

        public static SeasonMissionRewardIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionRewardIcon();

            value.RewardItemIcon                            = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270DBD23798 0x20 RewardItemIcon              ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.LockIconObject                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBD237B8 0x28 LockIconObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeObject                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBD237D8 0x30 BadgeObject                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AcquiredImageObject                       = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DBD237F8 0x38 AcquiredImageObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x040), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DBD23818 0x40 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x048), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270DBD23838 0x48 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
