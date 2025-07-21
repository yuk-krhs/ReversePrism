using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 ButtonImage                              ModelClassType Image Image Image Pointer
    // 030 ButtonImages                             ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    public partial class FastForwardButton : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public Image?                                   ButtonImage                             { get; set; }
        public List<Sprite>?                            ButtonImages                            { get; set; }

        public static FastForwardButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FastForwardButton() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonImage                               = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 ButtonImage                 ( ModelClassType Image Image Image Pointer )
            value.ButtonImages                              = GetObjectList<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 0x30 ButtonImages                ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )

            return value;
        }
    }
}
