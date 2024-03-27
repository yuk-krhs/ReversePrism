using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 UnitNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 FesUnitRankingIconImage                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 FesUnitRankingTotalText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileFriendUserFesUnitRankListViewCell
    {
        public UITextMeshProUGUI?                       UnitNameText                            { get; set; }
        public UIImage?                                 FesUnitRankingIconImage                 { get; set; }
        public UITextMeshProUGUI?                       FesUnitRankingTotalText                 { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileFriendUserFesUnitRankListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserFesUnitRankListViewCell();

            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB734818 0x40 UnitNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FesUnitRankingIconImage                   = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB734838 0x48 FesUnitRankingIconImage     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FesUnitRankingTotalText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB734858 0x50 FesUnitRankingTotalText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x058)); // 0270DB734878 0x58 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
