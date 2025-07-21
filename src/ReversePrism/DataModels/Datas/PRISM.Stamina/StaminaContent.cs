using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType StaminaContentView StaminaContentView StaminaContentView Pointer
    // 028 PopupCaller                              ModelClassType StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller Pointer
    // 030 IntervalDisposable                       ModelClassType IDisposable IDisposable IDisposable Pointer
    // 038 StaminaModel                             ModelClassType StaminaModel StaminaModel StaminaModel Pointer
    // 040 onClosePostProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class StaminaContent : DataModel
    {
        public StaminaContentView?                      View                                    { get; set; }
        public StaminaRecoveryPopupCaller?              PopupCaller                             { get; set; }
        public IDisposable?                             IntervalDisposable                      { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }

        public static StaminaContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaContent() { Pointer= p0 };

            value.View                                      = GetObject<StaminaContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaContentView.FromPointer); // 0x20 View                        ( ModelClassType StaminaContentView StaminaContentView StaminaContentView Pointer )
            value.PopupCaller                               = GetObject<StaminaRecoveryPopupCaller>(new IntPtr(p + 0x028), ReversePrism.DataModels.StaminaRecoveryPopupCaller.FromPointer); // 0x28 PopupCaller                 ( ModelClassType StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller StaminaRecoveryPopupCaller Pointer )
            value.IntervalDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.IDisposable.FromPointer); // 0x30 IntervalDisposable          ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.StaminaModel.FromPointer); // 0x38 StaminaModel                ( ModelClassType StaminaModel StaminaModel StaminaModel Pointer )

            return value;
        }
    }
}
