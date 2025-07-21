using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FesUnitRankingIconImage                  ModelClassType UIImage UIImage UIImage Pointer
    // 028 FesUnitRankingText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 FesRankingDetailButton                   ModelClassType UIButton UIButton UIButton Pointer
    public partial class ProfileFriendUserProgressFesUnitRankView : DataModel
    {
        public UIImage?                                 FesUnitRankingIconImage                 { get; set; }
        public UITextMeshProUGUI?                       FesUnitRankingText                      { get; set; }
        public UIButton?                                FesRankingDetailButton                  { get; set; }

        public static ProfileFriendUserProgressFesUnitRankView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileFriendUserProgressFesUnitRankView() { Pointer= p0 };

            value.FesUnitRankingIconImage                   = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 FesUnitRankingIconImage     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FesUnitRankingText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 FesUnitRankingText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FesRankingDetailButton                    = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 FesRankingDetailButton      ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
