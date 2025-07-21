using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 FadeDelay                                ModelPrimitiveType float float float Single
    // 030 <OnCloseRequested>k__BackingField        IObservable`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class SystemCacheClearProgressView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    FadeDelay                               { get; set; }

        public static SystemCacheClearProgressView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemCacheClearProgressView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDelay                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 FadeDelay                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
