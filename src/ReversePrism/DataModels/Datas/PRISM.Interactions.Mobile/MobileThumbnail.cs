using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Image                                    ModelClassType UIImage UIImage UIImage Pointer
    // 028 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 030 Pictogram                                ModelClassType GameObject GameObject GameObject Pointer
    public partial class MobileThumbnail : DataModel
    {
        public UIImage?                                 Image                                   { get; set; }
        public UIButton?                                Button                                  { get; set; }
        public GameObject?                              Pictogram                               { get; set; }

        public static MobileThumbnail? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileThumbnail() { Pointer= p0 };

            value.Image                                     = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 Image                       ( ModelClassType UIImage UIImage UIImage Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Pictogram                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 Pictogram                   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
