using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 UnitNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 FesUnitRankingIconImage                  ModelClassType UIImage UIImage UIImage Pointer
    // 050 FesUnitRankingTotalText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileFriendUserFesUnitRankListViewCell : DataModel
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
            var value   = new ProfileFriendUserFesUnitRankListViewCell() { Pointer= p0 };

            value.UnitNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 UnitNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FesUnitRankingIconImage                   = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0x48 FesUnitRankingIconImage     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FesUnitRankingTotalText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 FesUnitRankingTotalText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x058)); // 0x58 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
