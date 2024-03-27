using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportEffectContentViewModel            0001865EFDE0 ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer
    // 018 SDCharaIconViewModels                    000185D158E8 ModelClassListType IReadOnlyList`1<SCharaEditSDCharaIconViewModel> IReadOnlyList`1<SCharaEditSDCharaIconViewModel> List<SCharaEditSDCharaIconViewModel> Pointer
    public partial class SCharaEditSupportEffectContentViewModel
    {
        public SupportEffectContentViewModel?           SupportEffectContentViewModel           { get; set; }
        public List<SCharaEditSDCharaIconViewModel>?    SDCharaIconViewModels                   { get; set; }

        public static SCharaEditSupportEffectContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSupportEffectContentViewModel();

            value.SupportEffectContentViewModel             = GetObject<SupportEffectContentViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0270D620FCB0 0x10 SupportEffectContentViewModel ( 0001865EFDE0 ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer )
            value.SDCharaIconViewModels                     = GetObjectList<SCharaEditSDCharaIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCharaEditSDCharaIconViewModel.FromPointer); // 0270D620FCD0 0x18 SDCharaIconViewModels       ( 000185D158E8 ModelClassListType IReadOnlyList`1<SCharaEditSDCharaIconViewModel> IReadOnlyList`1<SCharaEditSDCharaIconViewModel> List<SCharaEditSDCharaIconViewModel> Pointer )

            return value;
        }
    }
}
