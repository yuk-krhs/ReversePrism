using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    public partial class MobileStandbyScreenView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }

        public static MobileStandbyScreenView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileStandbyScreenView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DB145810 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
