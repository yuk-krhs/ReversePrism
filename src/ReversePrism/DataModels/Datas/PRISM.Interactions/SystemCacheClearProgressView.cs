using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 FadeDelay                                0001866656B0 ModelPrimitiveType float float float Single
    public partial class SystemCacheClearProgressView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public float                                    FadeDelay                               { get; set; }

        public static SystemCacheClearProgressView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SystemCacheClearProgressView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DBCA5A60 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDelay                                 = GetSingle(new IntPtr(p + 0x028)); // 0270DBCA5A80 0x28 FadeDelay                   ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
