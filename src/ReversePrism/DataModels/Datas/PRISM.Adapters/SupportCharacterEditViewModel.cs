using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 018 SelfSupportCharacters                    000185D0D958 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 020 FriendSupportCharacter                   00018666A290 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 028 SupportEffectViewModels                  000185D15B08 ModelClassListType IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> List<SCharaEditSupportEffectContentViewModel> Pointer
    // 030 PotentialSupportSkillViewModels          000185D15698 ModelClassListType IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> List<SCharaEditPotentialSupportSkillContentViewModel> Pointer
    // 038 UnitName                                 0001866736C0 ModelPrimitiveType string string string String
    public partial class SupportCharacterEditViewModel
    {
        public int                                      UnitId                                  { get; set; }
        public List<ISupportCharacterStatus>?           SelfSupportCharacters                   { get; set; }
        public ISupportCharacterStatus?                 FriendSupportCharacter                  { get; set; }
        public List<SCharaEditSupportEffectContentViewModel>? SupportEffectViewModels                 { get; set; }
        public List<SCharaEditPotentialSupportSkillContentViewModel>? PotentialSupportSkillViewModels         { get; set; }
        public string                                   UnitName                                { get; set; }

        public static SupportCharacterEditViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterEditViewModel();

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D6227990 0x10 UnitId                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.SelfSupportCharacters                     = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D62279B0 0x18 SelfSupportCharacters       ( 000185D0D958 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.FriendSupportCharacter                    = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D62279D0 0x20 FriendSupportCharacter      ( 00018666A290 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.SupportEffectViewModels                   = GetObjectList<SCharaEditSupportEffectContentViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaEditSupportEffectContentViewModel.FromPointer); // 0270D62279F0 0x28 SupportEffectViewModels     ( 000185D15B08 ModelClassListType IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> List<SCharaEditSupportEffectContentViewModel> Pointer )
            value.PotentialSupportSkillViewModels           = GetObjectList<SCharaEditPotentialSupportSkillContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaEditPotentialSupportSkillContentViewModel.FromPointer); // 0270D6227A10 0x30 PotentialSupportSkillViewModels ( 000185D15698 ModelClassListType IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> List<SCharaEditPotentialSupportSkillContentViewModel> Pointer )
            value.UnitName                                  = GetString(new IntPtr(p + 0x038)); // 0270D6227A30 0x38 UnitName                    ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
