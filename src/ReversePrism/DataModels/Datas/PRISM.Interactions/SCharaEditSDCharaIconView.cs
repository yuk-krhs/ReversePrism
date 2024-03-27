using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootRect                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 SelfCharaIcon                            0001866F3FB0 ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer
    // 030 FriendCharaIcon                          0001866F3FB0 ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer
    public partial class SCharaEditSDCharaIconView
    {
        public RectTransform?                           RootRect                                { get; set; }
        public SDCharaIconInfo?                         SelfCharaIcon                           { get; set; }
        public SDCharaIconInfo?                         FriendCharaIcon                         { get; set; }

        public static SCharaEditSDCharaIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSDCharaIconView();

            value.RootRect                                  = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA1042F0 0x20 RootRect                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SelfCharaIcon                             = GetObject<SDCharaIconInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.SDCharaIconInfo.FromPointer); // 0270DA104310 0x28 SelfCharaIcon               ( 0001866F3FB0 ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer )
            value.FriendCharaIcon                           = GetObject<SDCharaIconInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.SDCharaIconInfo.FromPointer); // 0270DA104330 0x30 FriendCharaIcon             ( 0001866F3FB0 ModelClassType SDCharaIconInfo SDCharaIconInfo SDCharaIconInfo Pointer )

            return value;
        }
    }
}
