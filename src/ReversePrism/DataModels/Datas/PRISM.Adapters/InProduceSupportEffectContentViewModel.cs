using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsExerted                                ModelPrimitiveType bool bool bool Bool
    // 018 SdCharaIconViewModels                    ModelClassListType List`1<InProduceSupportEffectSDCharaIconViewModel> List`1<InProduceSupportEffectSDCharaIconViewModel> List<InProduceSupportEffectSDCharaIconViewModel> Pointer
    // 020 SupportEffectContentViewModel            ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer
    public partial class InProduceSupportEffectContentViewModel : DataModel
    {
        public bool                                     IsExerted                               { get; set; }
        public List<InProduceSupportEffectSDCharaIconViewModel>? SdCharaIconViewModels                   { get; set; }
        public SupportEffectContentViewModel?           SupportEffectContentViewModel           { get; set; }

        public static InProduceSupportEffectContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InProduceSupportEffectContentViewModel() { Pointer= p0 };

            value.IsExerted                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 IsExerted                   ( ModelPrimitiveType bool bool bool Bool )
            value.SdCharaIconViewModels                     = GetObjectList<InProduceSupportEffectSDCharaIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.InProduceSupportEffectSDCharaIconViewModel.FromPointer); // 0x18 SdCharaIconViewModels       ( ModelClassListType List`1<InProduceSupportEffectSDCharaIconViewModel> List`1<InProduceSupportEffectSDCharaIconViewModel> List<InProduceSupportEffectSDCharaIconViewModel> Pointer )
            value.SupportEffectContentViewModel             = GetObject<SupportEffectContentViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0x20 SupportEffectContentViewModel ( ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer )

            return value;
        }
    }
}
