using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 018 FadeDurationSeconds                      ModelPrimitiveType float float float Single
    // 020 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class FadeHandler : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    FadeDurationSeconds                     { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static FadeHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FadeHandler() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x010), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x10 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDurationSeconds                       = GetSingle(new IntPtr(p + 0x018)); // 0x18 FadeDurationSeconds         ( ModelPrimitiveType float float float Single )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
