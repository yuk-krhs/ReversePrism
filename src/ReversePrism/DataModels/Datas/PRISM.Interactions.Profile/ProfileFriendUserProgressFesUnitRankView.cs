using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FesUnitRankingIconImage                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 028 FesUnitRankingText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 FesRankingDetailButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class ProfileFriendUserProgressFesUnitRankView
    {
        public UIImage?                                 FesUnitRankingIconImage                 { get; set; }
        public UITextMeshProUGUI?                       FesUnitRankingText                      { get; set; }
        public UIButton?                                FesRankingDetailButton                  { get; set; }

        public static ProfileFriendUserProgressFesUnitRankView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserProgressFesUnitRankView();

            value.FesUnitRankingIconImage                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB7411F8 0x20 FesUnitRankingIconImage     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.FesUnitRankingText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB741218 0x28 FesUnitRankingText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FesRankingDetailButton                    = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB741238 0x30 FesRankingDetailButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
