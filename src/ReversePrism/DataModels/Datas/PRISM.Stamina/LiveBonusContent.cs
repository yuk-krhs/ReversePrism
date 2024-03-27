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
    // 038 JewelModel                               00018674B3C0 ModelClassType JewelModel JewelModel JewelModel Pointer
    // 040 onClosePostProcessingEvent               Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class LiveBonusContent
    {
        public StaminaContentView?                      View                                    { get; set; }
        public IDisposable?                             IntervalDisposable                      { get; set; }
        public StaminaModel?                            StaminaModel                            { get; set; }
        public JewelModel?                              JewelModel                              { get; set; }

        public static LiveBonusContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveBonusContent();

            value.View                                      = GetObject<StaminaContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaContentView.FromPointer); // 027004F46268 0x20 View                        ( 000186564630 ModelClassType StaminaContentView StaminaContentView StaminaContentView Pointer )
            value.IntervalDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.IDisposable.FromPointer); // 027004F46288 0x28 IntervalDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.StaminaModel                              = GetObject<StaminaModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.StaminaModel.FromPointer); // 027004F462A8 0x30 StaminaModel                ( 000186564B10 ModelClassType StaminaModel StaminaModel StaminaModel Pointer )
            value.JewelModel                                = GetObject<JewelModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.JewelModel.FromPointer); // 027004F462C8 0x38 JewelModel                  ( 00018674B3C0 ModelClassType JewelModel JewelModel JewelModel Pointer )

            return value;
        }
    }
}
