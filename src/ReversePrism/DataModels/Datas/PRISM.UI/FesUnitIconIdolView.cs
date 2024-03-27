using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TrIdolOffset                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 CgSeparatorLeft                          000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 CgSeparatorRight                         000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class FesUnitIconIdolView
    {
        public Transform?                               TrIdolOffset                            { get; set; }
        public CanvasGroup?                             CgSeparatorLeft                         { get; set; }
        public CanvasGroup?                             CgSeparatorRight                        { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }

        public static FesUnitIconIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FesUnitIconIdolView();

            value.TrIdolOffset                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 027005B21E40 0x20 TrIdolOffset                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CgSeparatorLeft                           = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21E60 0x28 CgSeparatorLeft             ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSeparatorRight                          = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21E80 0x30 CgSeparatorRight            ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 027005B21EA0 0x38 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
