using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NewIcon                                  0001866CCDB0 ModelClassType Image Image Image Pointer
    // 028 Badge                                    000186735E80 ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer
    // 030 TabButton                                0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer
    public partial class SeasonMissionTab
    {
        public Image?                                   NewIcon                                 { get; set; }
        public BadgeNumber?                             Badge                                   { get; set; }
        public UITabButton?                             TabButton                               { get; set; }

        public static SeasonMissionTab? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SeasonMissionTab();

            value.NewIcon                                   = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270DBD23898 0x20 NewIcon                     ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Badge                                     = GetObject<BadgeNumber>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeNumber.FromPointer); // 0270DBD238B8 0x28 Badge                       ( 000186735E80 ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer )
            value.TabButton                                 = GetObject<UITabButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITabButton.FromPointer); // 0270DBD238D8 0x30 TabButton                   ( 0001866F4F80 ModelClassType UITabButton UITabButton UITabButton Pointer )

            return value;
        }
    }
}
