using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 fadeDuration                             float IL2CPP_TYPE_R4
    // 010 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 018 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    public partial class ScrollResetButton : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }

        public static ScrollResetButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScrollResetButton() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x010), ReversePrism.DataModels.UIButton.FromPointer); // 0x10 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x018), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x18 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
