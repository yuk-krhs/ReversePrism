using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Icon                                     0001866EFB70 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 SkillClickButton                         0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer
    // 030 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class SkillIcon
    {
        public UIRawImage?                              Icon                                    { get; set; }
        public UIButton?                                SkillClickButton                        { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }

        public static SkillIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SkillIcon();

            value.Icon                                      = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270D5A20870 0x20 Icon                        ( 0001866EFB70 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.SkillClickButton                          = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A20890 0x28 SkillClickButton            ( 0001866E11C0 ModelClassType UIButton UIButton UIButton Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x030)); // 0270D5A208B0 0x30 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
