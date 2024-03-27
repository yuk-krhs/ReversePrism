using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 0001866A7D90 ModelClassType SCharaEditSDCharaIconView SCharaEditSDCharaIconView SCharaEditSDCharaIconView Pointer
    // 028 GrayOutController                        0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    public partial class InProduceSupportEffectSDCharaIconView
    {
        public SCharaEditSDCharaIconView?               IconView                                { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }

        public static InProduceSupportEffectSDCharaIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectSDCharaIconView();

            value.IconView                                  = GetObject<SCharaEditSDCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaEditSDCharaIconView.FromPointer); // 0270DA0FF508 0x20 IconView                    ( 0001866A7D90 ModelClassType SCharaEditSDCharaIconView SCharaEditSDCharaIconView SCharaEditSDCharaIconView Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA0FF528 0x28 GrayOutController           ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )

            return value;
        }
    }
}
