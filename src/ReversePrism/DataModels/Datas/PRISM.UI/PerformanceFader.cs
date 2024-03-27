using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgWhite                                  000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 FadeDuration                             0001866656B0 ModelPrimitiveType float float float Single
    public partial class PerformanceFader
    {
        public CanvasGroup?                             CgWhite                                 { get; set; }
        public float                                    FadeDuration                            { get; set; }

        public static PerformanceFader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceFader();

            value.CgWhite                                   = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5408EC0 0x20 CgWhite                     ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x028)); // 0270D5408EE0 0x28 FadeDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
