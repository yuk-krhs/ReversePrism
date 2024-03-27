using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IconViewModel                            0001866A84A0 ModelClassType SCharaEditSDCharaIconViewModel SCharaEditSDCharaIconViewModel SCharaEditSDCharaIconViewModel Pointer
    // 018 IsExerted                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class InProduceSupportEffectSDCharaIconViewModel
    {
        public SCharaEditSDCharaIconViewModel?          IconViewModel                           { get; set; }
        public bool                                     IsExerted                               { get; set; }

        public static InProduceSupportEffectSDCharaIconViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectSDCharaIconViewModel();

            value.IconViewModel                             = GetObject<SCharaEditSDCharaIconViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SCharaEditSDCharaIconViewModel.FromPointer); // 0270D64F6BA0 0x10 IconViewModel               ( 0001866A84A0 ModelClassType SCharaEditSDCharaIconViewModel SCharaEditSDCharaIconViewModel SCharaEditSDCharaIconViewModel Pointer )
            value.IsExerted                                 = GetBool(new IntPtr(p + 0x018)); // 0270D64F6BC0 0x18 IsExerted                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
