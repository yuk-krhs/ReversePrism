using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ItemIcon                                 00018657D9E0 ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer
    // 048 StarObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 DescriptionText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ChallengeTourStageMissionListViewCell
    {
        public ChallengeTourRewardIcon?                 ItemIcon                                { get; set; }
        public GameObject?                              StarObject                              { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }

        public static ChallengeTourStageMissionListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageMissionListViewCell();

            value.ItemIcon                                  = GetObject<ChallengeTourRewardIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChallengeTourRewardIcon.FromPointer); // 0270DA1CCC30 0x40 ItemIcon                    ( 00018657D9E0 ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer )
            value.StarObject                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1CCC50 0x48 StarObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1CCC70 0x50 DescriptionText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
