using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IconRect                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 018 CharaIcon                                ModelClassType UIImage UIImage UIImage Pointer
    // 020 FriendMark                               ModelClassType GameObject GameObject GameObject Pointer
    public partial class SDCharaIconInfo : DataModel
    {
        public RectTransform?                           IconRect                                { get; set; }
        public UIImage?                                 CharaIcon                               { get; set; }
        public GameObject?                              FriendMark                              { get; set; }

        public static SDCharaIconInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SDCharaIconInfo() { Pointer= p0 };

            value.IconRect                                  = GetObject<RectTransform>(new IntPtr(p + 0x010), ReversePrism.DataModels.RectTransform.FromPointer); // 0x10 IconRect                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CharaIcon                                 = GetObject<UIImage>(new IntPtr(p + 0x018), ReversePrism.DataModels.UIImage.FromPointer); // 0x18 CharaIcon                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.FriendMark                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 FriendMark                  ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
