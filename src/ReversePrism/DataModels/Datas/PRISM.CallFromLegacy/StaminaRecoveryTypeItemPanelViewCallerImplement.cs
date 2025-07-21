using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PanelView                                ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer
    public partial class StaminaRecoveryTypeItemPanelViewCallerImplement : DataModel
    {
        public StaminaRecoveryTypeItemPanelView?        PanelView                               { get; set; }

        public static StaminaRecoveryTypeItemPanelViewCallerImplement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StaminaRecoveryTypeItemPanelViewCallerImplement() { Pointer= p0 };

            value.PanelView                                 = GetObject<StaminaRecoveryTypeItemPanelView>(new IntPtr(p + 0x020), ReversePrism.DataModels.StaminaRecoveryTypeItemPanelView.FromPointer); // 0x20 PanelView                   ( ModelClassType StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView StaminaRecoveryTypeItemPanelView Pointer )

            return value;
        }
    }
}
