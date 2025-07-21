using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 DefaultTextImage                         ModelClassType UIImage UIImage UIImage Pointer
    // 030 SkipBeforeChoiceTextImage                ModelClassType UIImage UIImage UIImage Pointer
    public partial class AdvForceSkipButton : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public UIImage?                                 DefaultTextImage                        { get; set; }
        public UIImage?                                 SkipBeforeChoiceTextImage               { get; set; }

        public static AdvForceSkipButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvForceSkipButton() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.DefaultTextImage                          = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 DefaultTextImage            ( ModelClassType UIImage UIImage UIImage Pointer )
            value.SkipBeforeChoiceTextImage                 = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 SkipBeforeChoiceTextImage   ( ModelClassType UIImage UIImage UIImage Pointer )

            return value;
        }
    }
}
