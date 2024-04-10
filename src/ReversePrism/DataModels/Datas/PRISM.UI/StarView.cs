using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StarImage                                0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    public partial class StarView : DataModel
    {
        public UIImage?                                 StarImage                               { get; set; }

        public static StarView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StarView() { Pointer= p0 };

            value.StarImage                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0245A5B23A40 0x20 StarImage                   ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
