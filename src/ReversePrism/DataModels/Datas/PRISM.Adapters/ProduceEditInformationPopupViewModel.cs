using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportSkillSlotViewModels               ModelClassListType List`1<SupportSkillSlotViewModel> List`1<SupportSkillSlotViewModel> List<SupportSkillSlotViewModel> Pointer
    // 018 ProduceBaseInfo                          ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 SelfSupportCharacters                    ModelClassListType IReadOnlyList`1<IInProduceSupportCharacterStatus> IReadOnlyList`1<IInProduceSupportCharacterStatus> List<IInProduceSupportCharacterStatus> Pointer
    // 028 FriendSupportCharacter                   ModelClassType IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus Pointer
    // 030 SupportEffectViewModels                  ModelClassListType IReadOnlyList`1<IInProduceSupportEffectContentViewModel> IReadOnlyList`1<IInProduceSupportEffectContentViewModel> List<IInProduceSupportEffectContentViewModel> Pointer
    public partial class ProduceEditInformationPopupViewModel : DataModel
    {
        public List<SupportSkillSlotViewModel>?         SupportSkillSlotViewModels              { get; set; }
        public IProduceBaseInfoStatus?                  ProduceBaseInfo                         { get; set; }
        public List<IInProduceSupportCharacterStatus>?  SelfSupportCharacters                   { get; set; }
        public IInProduceSupportCharacterStatus?        FriendSupportCharacter                  { get; set; }
        public List<IInProduceSupportEffectContentViewModel>? SupportEffectViewModels                 { get; set; }

        public static ProduceEditInformationPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceEditInformationPopupViewModel() { Pointer= p0 };

            value.SupportSkillSlotViewModels                = GetObjectList<SupportSkillSlotViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SupportSkillSlotViewModel.FromPointer); // 0x10 SupportSkillSlotViewModels  ( ModelClassListType List`1<SupportSkillSlotViewModel> List`1<SupportSkillSlotViewModel> List<SupportSkillSlotViewModel> Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x18 ProduceBaseInfo             ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.SelfSupportCharacters                     = GetObjectList<IInProduceSupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IInProduceSupportCharacterStatus.FromPointer); // 0x20 SelfSupportCharacters       ( ModelClassListType IReadOnlyList`1<IInProduceSupportCharacterStatus> IReadOnlyList`1<IInProduceSupportCharacterStatus> List<IInProduceSupportCharacterStatus> Pointer )
            value.FriendSupportCharacter                    = GetObject<IInProduceSupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceSupportCharacterStatus.FromPointer); // 0x28 FriendSupportCharacter      ( ModelClassType IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus Pointer )
            value.SupportEffectViewModels                   = GetObjectList<IInProduceSupportEffectContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.IInProduceSupportEffectContentViewModel.FromPointer); // 0x30 SupportEffectViewModels     ( ModelClassListType IReadOnlyList`1<IInProduceSupportEffectContentViewModel> IReadOnlyList`1<IInProduceSupportEffectContentViewModel> List<IInProduceSupportEffectContentViewModel> Pointer )

            return value;
        }
    }
}
