using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     000186564630 ModelClassType StaminaContentView StaminaContentView StaminaContentView Pointer
    // 028 IntervalDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 030 StaminaModel                             000186564B10 ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 038 onClosePostProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class StaminaContent
    {
        public StaminaContentView?                      View                                    { get; set; }
        public IDisposable?                             IntervalDisposable                      { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }

        public static StaminaContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaContent();

            value.View                                      = GetObject<StaminaContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaContentView.FromPointer); // 027004F46198 0x20 View                        ( 000186564630 ModelClassType StaminaContentView StaminaContentView StaminaContentView Pointer )
            value.IntervalDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 027004F461B8 0x28 IntervalDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StaminaModel.FromPointer); // 027004F461D8 0x30 StaminaModel                ( 000186564B10 ModelClassType StaminaModel StaminaModel StaminaModel Pointer )

            return value;
        }
    }
}
