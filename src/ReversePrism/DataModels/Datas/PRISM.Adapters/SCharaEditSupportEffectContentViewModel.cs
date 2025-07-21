using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportEffectContentViewModel            ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer
    // 018 SDCharaIconViewModels                    ModelClassListType IReadOnlyList`1<SCharaEditSDCharaIconViewModel> IReadOnlyList`1<SCharaEditSDCharaIconViewModel> List<SCharaEditSDCharaIconViewModel> Pointer
    public partial class SCharaEditSupportEffectContentViewModel : DataModel
    {
        public SupportEffectContentViewModel?           SupportEffectContentViewModel           { get; set; }
        public List<SCharaEditSDCharaIconViewModel>?    SDCharaIconViewModels                   { get; set; }

        public static SCharaEditSupportEffectContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditSupportEffectContentViewModel() { Pointer= p0 };

            value.SupportEffectContentViewModel             = GetObject<SupportEffectContentViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SupportEffectContentViewModel.FromPointer); // 0x10 SupportEffectContentViewModel ( ModelClassType SupportEffectContentViewModel SupportEffectContentViewModel SupportEffectContentViewModel Pointer )
            value.SDCharaIconViewModels                     = GetObjectList<SCharaEditSDCharaIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCharaEditSDCharaIconViewModel.FromPointer); // 0x18 SDCharaIconViewModels       ( ModelClassListType IReadOnlyList`1<SCharaEditSDCharaIconViewModel> IReadOnlyList`1<SCharaEditSDCharaIconViewModel> List<SCharaEditSDCharaIconViewModel> Pointer )

            return value;
        }
    }
}
