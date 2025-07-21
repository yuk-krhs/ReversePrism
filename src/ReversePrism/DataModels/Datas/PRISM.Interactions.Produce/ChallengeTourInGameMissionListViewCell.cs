using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 ItemIcon                                 ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer
    // 048 StarObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 050 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 ClearText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class ChallengeTourInGameMissionListViewCell : DataModel
    {
        public ChallengeTourRewardIcon?                 ItemIcon                                { get; set; }
        public GameObject?                              StarObject                              { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public UITextMeshProUGUI?                       ClearText                               { get; set; }

        public static ChallengeTourInGameMissionListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourInGameMissionListViewCell() { Pointer= p0 };

            value.ItemIcon                                  = GetObject<ChallengeTourRewardIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChallengeTourRewardIcon.FromPointer); // 0x40 ItemIcon                    ( ModelClassType ChallengeTourRewardIcon ChallengeTourRewardIcon ChallengeTourRewardIcon Pointer )
            value.StarObject                                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 StarObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 ClearText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
