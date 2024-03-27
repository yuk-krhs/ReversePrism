using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 FesUnitRankIcon                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 FesUnitRankText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class ProfileProgressFesUnitRankDetailListViewCell
    {
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UIImage?                                 FesUnitRankIcon                         { get; set; }
        public UITextMeshProUGUI?                       FesUnitRankText                         { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static ProfileProgressFesUnitRankDetailListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileProgressFesUnitRankDetailListViewCell();

            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB741510 0x40 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FesUnitRankIcon                           = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB741530 0x48 FesUnitRankIcon             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FesUnitRankText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB741550 0x50 FesUnitRankText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x058)); // 0270DB741570 0x58 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
