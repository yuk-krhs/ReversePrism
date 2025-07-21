using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 Image                                    ModelClassType Image Image Image Pointer
    // 030 EmptyObject                              ModelClassType GameObject GameObject GameObject Pointer
    public partial class SimpleAchievementIcon : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public Image?                                   Image                                   { get; set; }
        public GameObject?                              EmptyObject                             { get; set; }

        public static SimpleAchievementIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleAchievementIcon() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Image                                     = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 Image                       ( ModelClassType Image Image Image Pointer )
            value.EmptyObject                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EmptyObject                 ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
