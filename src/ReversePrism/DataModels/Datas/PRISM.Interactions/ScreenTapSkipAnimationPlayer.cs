using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SkipButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 IsSkip                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 SkipCancellationTokenSource              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 IsSetuped                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ScreenTapSkipAnimationPlayer
    {
        public UIButton?                                SkipButton                              { get; set; }
        public bool                                     IsSkip                                  { get; set; }
        public CancellationTokenSource?                 SkipCancellationTokenSource             { get; set; }
        public bool                                     IsSetuped                               { get; set; }

        public static ScreenTapSkipAnimationPlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenTapSkipAnimationPlayer();

            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1D4300 0x20 SkipButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x028)); // 0270DA1D4320 0x28 IsSkip                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SkipCancellationTokenSource               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270DA1D4340 0x30 SkipCancellationTokenSource ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsSetuped                                 = GetBool(new IntPtr(p + 0x038)); // 0270DA1D4360 0x38 IsSetuped                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
