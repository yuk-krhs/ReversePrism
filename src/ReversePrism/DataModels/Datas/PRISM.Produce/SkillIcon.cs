using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 SkillClickButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 030 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class SkillIcon : DataModel
    {
        public UIRawImage?                              Icon                                    { get; set; }
        public UIButton?                                SkillClickButton                        { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static SkillIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillIcon() { Pointer= p0 };

            value.Icon                                      = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x20 Icon                        ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SkillClickButton                          = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 SkillClickButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x030)); // 0x30 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
