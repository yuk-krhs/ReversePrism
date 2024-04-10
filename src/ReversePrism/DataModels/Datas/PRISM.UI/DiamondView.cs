using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DiamondImage                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class DiamondView : DataModel
    {
        public UIImage?                                 DiamondImage                            { get; set; }

        public static DiamondView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DiamondView() { Pointer= p0 };

            value.DiamondImage                              = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0245A5B23598 0x20 DiamondImage                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
