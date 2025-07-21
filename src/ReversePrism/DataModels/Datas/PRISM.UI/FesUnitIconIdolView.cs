using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TrIdolOffset                             ModelClassType Transform Transform Transform Pointer
    // 028 CgSeparatorLeft                          ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 CgSeparatorRight                         ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 038 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class FesUnitIconIdolView : DataModel
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
            var value   = new FesUnitIconIdolView() { Pointer= p0 };

            value.TrIdolOffset                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 TrIdolOffset                ( ModelClassType Transform Transform Transform Pointer )
            value.CgSeparatorLeft                           = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 CgSeparatorLeft             ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSeparatorRight                          = GetObject<CanvasGroup>(new IntPtr(p + 0x030), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x30 CgSeparatorRight            ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
