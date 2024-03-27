using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemIcon                                 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 028 GetIcon                                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 PIdolDetailPopupCaller                   000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 038 SCharaDetailPopupCaller                  0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    public partial class ChallengeTourRewardIcon
    {
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public GameObject?                              GetIcon                                 { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetailPopupCaller                  { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetailPopupCaller                 { get; set; }

        public static ChallengeTourRewardIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourRewardIcon();

            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0270DA1B4F40 0x20 ItemIcon                    ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.GetIcon                                   = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1B4F60 0x28 GetIcon                     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PIdolDetailPopupCaller                    = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x030), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 0270DA1B4F80 0x30 PIdolDetailPopupCaller      ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetailPopupCaller                   = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 0270DA1B4FA0 0x38 SCharaDetailPopupCaller     ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}
