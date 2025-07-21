using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootRect                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 SelfCharaIcon                            ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer
    // 030 FriendCharaIcon                          ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer
    public partial class SCharaEditSDCharaIconView : DataModel
    {
        public RectTransform?                           RootRect                                { get; set; }
        public SDCharaIconInfo?                         SelfCharaIcon                           { get; set; }
        public SDCharaIconInfo?                         FriendCharaIcon                         { get; set; }

        public static SCharaEditSDCharaIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSDCharaIconView() { Pointer= p0 };

            value.RootRect                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 RootRect                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelfCharaIcon                             = GetObject<SDCharaIconInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.SDCharaIconInfo.FromPointer); // 0x28 SelfCharaIcon               ( ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer )
            value.FriendCharaIcon                           = GetObject<SDCharaIconInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.SDCharaIconInfo.FromPointer); // 0x30 FriendCharaIcon             ( ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer )

            return value;
        }
    }
}
