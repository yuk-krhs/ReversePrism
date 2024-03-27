using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PotentialSupportSkillId                  0001865F4940 ModelPrimitiveType int int int Int32
    // 018 SDCharaIconViewModels                    000185D158E8 ModelClassListType IReadOnlyList`1<SCharaEditSDCharaIconViewModel> IReadOnlyList`1<SCharaEditSDCharaIconViewModel> List<SCharaEditSDCharaIconViewModel> Pointer
    public partial class SCharaEditPotentialSupportSkillContentViewModel
    {
        public int                                      PotentialSupportSkillId                 { get; set; }
        public List<SCharaEditSDCharaIconViewModel>?    SDCharaIconViewModels                   { get; set; }

        public static SCharaEditPotentialSupportSkillContentViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditPotentialSupportSkillContentViewModel();

            value.PotentialSupportSkillId                   = GetInt32(new IntPtr(p + 0x010)); // 0270D6203ED0 0x10 PotentialSupportSkillId     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.SDCharaIconViewModels                     = GetObjectList<SCharaEditSDCharaIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCharaEditSDCharaIconViewModel.FromPointer); // 0270D6203EF0 0x18 SDCharaIconViewModels       ( 000185D158E8 ModelClassListType IReadOnlyList`1<SCharaEditSDCharaIconViewModel> IReadOnlyList`1<SCharaEditSDCharaIconViewModel> List<SCharaEditSDCharaIconViewModel> Pointer )

            return value;
        }
    }
}
