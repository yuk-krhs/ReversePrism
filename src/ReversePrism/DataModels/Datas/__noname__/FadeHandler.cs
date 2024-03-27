using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanvasGroup                              000186541650 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 018 Duration                                 000186666CB0 ModelPrimitiveType float float float Single
    // 020 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class FadeHandler
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    Duration                                { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static FadeHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FadeHandler();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x010), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D5DDDB10 0x10 CanvasGroup                 ( 000186541650 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x018)); // 0270D5DDDB30 0x18 Duration                    ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5DDDB50 0x20 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
