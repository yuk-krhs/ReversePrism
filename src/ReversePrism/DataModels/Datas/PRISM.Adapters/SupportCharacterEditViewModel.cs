using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SelfSupportCharacters                    ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 018 SupportEffectViewModels                  ModelClassListType IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> List<SCharaEditSupportEffectContentViewModel> Pointer
    // 020 PotentialSupportSkillViewModels          ModelClassListType IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> List<SCharaEditPotentialSupportSkillContentViewModel> Pointer
    // 028 UnitId                                   ModelPrimitiveType int int int Int32
    // 030 FriendSupportCharacter                   ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 038 UnitName                                 ModelPrimitiveType string string string String
    public partial class SupportCharacterEditViewModel : DataModel
    {
        public List<ISupportCharacterStatus>?           SelfSupportCharacters                   { get; set; }
        public List<SCharaEditSupportEffectContentViewModel>? SupportEffectViewModels                 { get; set; }
        public List<SCharaEditPotentialSupportSkillContentViewModel>? PotentialSupportSkillViewModels         { get; set; }
        public int                                      UnitId                                  { get; set; }
        public ISupportCharacterStatus?                 FriendSupportCharacter                  { get; set; }
        public string                                   UnitName                                { get; set; }

        public static SupportCharacterEditViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharacterEditViewModel() { Pointer= p0 };

            value.SelfSupportCharacters                     = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x10 SelfSupportCharacters       ( ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.SupportEffectViewModels                   = GetObjectList<SCharaEditSupportEffectContentViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCharaEditSupportEffectContentViewModel.FromPointer); // 0x18 SupportEffectViewModels     ( ModelClassListType IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> IReadOnlyList`1<SCharaEditSupportEffectContentViewModel> List<SCharaEditSupportEffectContentViewModel> Pointer )
            value.PotentialSupportSkillViewModels           = GetObjectList<SCharaEditPotentialSupportSkillContentViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaEditPotentialSupportSkillContentViewModel.FromPointer); // 0x20 PotentialSupportSkillViewModels ( ModelClassListType IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> IReadOnlyList`1<SCharaEditPotentialSupportSkillContentViewModel> List<SCharaEditPotentialSupportSkillContentViewModel> Pointer )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.FriendSupportCharacter                    = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x30 FriendSupportCharacter      ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.UnitName                                  = GetString(new IntPtr(p + 0x038)); // 0x38 UnitName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
