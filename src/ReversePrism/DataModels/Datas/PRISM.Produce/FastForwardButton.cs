using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ButtonImage                              0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 ButtonImages                             000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
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

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 024665B69820 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonImage                               = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 024665B69840 0x28 ButtonImage                 ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.ButtonImages                              = GetObjectList<Sprite>(new IntPtr(p + 0x030), ReversePrism.DataModels.Sprite.FromPointer); // 024665B69860 0x30 ButtonImages                ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )

            return value;
        }
    }
}
