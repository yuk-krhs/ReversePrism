using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SkipButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 028 IsSkip                                   ModelPrimitiveType bool bool bool Bool
    // 030 SkipCancellationTokenSource              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 IsSetuped                                ModelPrimitiveType bool bool bool Bool
    public partial class ScreenTapSkipAnimationPlayer : DataModel
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
            var value   = new ScreenTapSkipAnimationPlayer() { Pointer= p0 };

            value.SkipButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 SkipButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x028)); // 0x28 IsSkip                      ( ModelPrimitiveType bool bool bool Bool )
            value.SkipCancellationTokenSource               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 SkipCancellationTokenSource ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsSetuped                                 = GetBool(new IntPtr(p + 0x038)); // 0x38 IsSetuped                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
