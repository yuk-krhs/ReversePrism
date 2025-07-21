using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LiveBonusSettingBackgroundImage          ModelClassType Image Image Image Pointer
    // 028 LiveBonusSettingBackgroundColors         ModelEnumListType Color[] Color[] List<Color> Pointer
    // 030 LiveBonusMultiplierText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 MoneyText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class LiveRewardLBMoneyView : DataModel
    {
        public Image?                                   LiveBonusSettingBackgroundImage         { get; set; }
        public List<Color>?                             LiveBonusSettingBackgroundColors        { get; set; }
        public UITextMeshProUGUI?                       LiveBonusMultiplierText                 { get; set; }
        public UITextMeshProUGUI?                       MoneyText                               { get; set; }

        public static LiveRewardLBMoneyView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveRewardLBMoneyView() { Pointer= p0 };

            value.LiveBonusSettingBackgroundImage           = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 LiveBonusSettingBackgroundImage ( ModelClassType Image Image Image Pointer )
            value.LiveBonusSettingBackgroundColors          = GetEnumList<Color>(new IntPtr(p + 0x028)); // 0x28 LiveBonusSettingBackgroundColors ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.LiveBonusMultiplierText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 LiveBonusMultiplierText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MoneyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 MoneyText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
