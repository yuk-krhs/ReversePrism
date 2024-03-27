using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BackgroundImage                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class MobileScreenBackground
    {
        public UIImage?                                 BackgroundImage                         { get; set; }

        public static MobileScreenBackground? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileScreenBackground();

            value.BackgroundImage                           = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0270DB0E3818 0x20 BackgroundImage             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
