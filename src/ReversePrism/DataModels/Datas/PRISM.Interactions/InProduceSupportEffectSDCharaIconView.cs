using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 ModelClassType SCharaEditSDCharaIconView SCharaEditSDCharaIconView SCharaEditSDCharaIconView Pointer
    // 028 GrayOutController                        ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    public partial class InProduceSupportEffectSDCharaIconView : DataModel
    {
        public SCharaEditSDCharaIconView?               IconView                                { get; set; }
        public UIGrayOutController?                     GrayOutController                       { get; set; }

        public static InProduceSupportEffectSDCharaIconView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectSDCharaIconView() { Pointer= p0 };

            value.IconView                                  = GetObject<SCharaEditSDCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaEditSDCharaIconView.FromPointer); // 0x20 IconView                    ( ModelClassType SCharaEditSDCharaIconView SCharaEditSDCharaIconView SCharaEditSDCharaIconView Pointer )
            value.GrayOutController                         = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x28 GrayOutController           ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )

            return value;
        }
    }
}
