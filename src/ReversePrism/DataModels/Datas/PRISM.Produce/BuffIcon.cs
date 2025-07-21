using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _BuffIcon                                ModelClassType UIImage UIImage UIImage Pointer
    // 028 IconButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 030 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    public partial class BuffIcon : DataModel
    {
        public UIImage?                                 _BuffIcon                               { get; set; }
        public UIButton?                                IconButton                              { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }

        public static BuffIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuffIcon() { Pointer= p0 };

            value._BuffIcon                                 = GetObject<UIImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIImage.FromPointer); // 0x20 _BuffIcon                   ( ModelClassType UIImage UIImage UIImage Pointer )
            value.IconButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 IconButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
