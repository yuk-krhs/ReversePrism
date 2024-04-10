using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsExerted                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 SdCharaIconViewModels                    000185CEB588 ModelClassListType List`1<InProduceSupportEffectSDCharaIconViewModel> List`1<InProduceSupportEffectSDCharaIconViewModel> List<InProduceSupportEffectSDCharaIconViewModel> Pointer
    // 020 SupportEffectContentViewModel            0001865EFBC0 ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer
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

            value.IsExerted                                 = GetBool(new IntPtr(p + 0x010)); // 0246665634A8 0x10 IsExerted                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SdCharaIconViewModels                     = GetObjectList<InProduceSupportEffectSDCharaIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.InProduceSupportEffectSDCharaIconViewModel.FromPointer); // 0246665634C8 0x18 SdCharaIconViewModels       ( 000185CEB588 ModelClassListType List`1<InProduceSupportEffectSDCharaIconViewModel> List`1<InProduceSupportEffectSDCharaIconViewModel> List<InProduceSupportEffectSDCharaIconViewModel> Pointer )
            value.SupportEffectContentViewModel             = GetObject<SupportEffectContentViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0246665634E8 0x20 SupportEffectContentViewModel ( 0001865EFBC0 ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer )

            return value;
        }
    }
}
