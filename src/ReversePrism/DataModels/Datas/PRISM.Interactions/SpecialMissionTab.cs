using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NewIcon                                  ModelClassType Image Image Image Pointer
    // 028 LockIcon                                 ModelClassType Image Image Image Pointer
    // 030 SelectedCompleteIcon                     ModelClassType Image Image Image Pointer
    // 038 NormalCompleteIcon                       ModelClassType Image Image Image Pointer
    // 040 SelectedBadge                            ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer
    // 048 NormalBadge                              ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer
    // 050 TabButton                                ModelClassType UITabButton UITabButton UITabButton Pointer
    public partial class SpecialMissionTab : DataModel
    {
        public Image?                                   NewIcon                                 { get; set; }
        public Image?                                   LockIcon                                { get; set; }
        public Image?                                   SelectedCompleteIcon                    { get; set; }
        public Image?                                   NormalCompleteIcon                      { get; set; }
        public BadgeNumber?                             SelectedBadge                           { get; set; }
        public BadgeNumber?                             NormalBadge                             { get; set; }
        public UITabButton?                             TabButton                               { get; set; }

        public static SpecialMissionTab? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionTab() { Pointer= p0 };

            value.NewIcon                                   = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 NewIcon                     ( ModelClassType Image Image Image Pointer )
            value.LockIcon                                  = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 LockIcon                    ( ModelClassType Image Image Image Pointer )
            value.SelectedCompleteIcon                      = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 SelectedCompleteIcon        ( ModelClassType Image Image Image Pointer )
            value.NormalCompleteIcon                        = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 NormalCompleteIcon          ( ModelClassType Image Image Image Pointer )
            value.SelectedBadge                             = GetObject<BadgeNumber>(new IntPtr(p + 0x040), ReversePrism.DataModels.BadgeNumber.FromPointer); // 0x40 SelectedBadge               ( ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer )
            value.NormalBadge                               = GetObject<BadgeNumber>(new IntPtr(p + 0x048), ReversePrism.DataModels.BadgeNumber.FromPointer); // 0x48 NormalBadge                 ( ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer )
            value.TabButton                                 = GetObject<UITabButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITabButton.FromPointer); // 0x50 TabButton                   ( ModelClassType UITabButton UITabButton UITabButton Pointer )

            return value;
        }
    }
}
