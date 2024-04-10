using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SupportSkillSlotViewModels               000185D111B8 ModelClassListType List`1<SupportSkillSlotViewModel> List`1<SupportSkillSlotViewModel> List<SupportSkillSlotViewModel> Pointer
    // 018 ProduceBaseInfo                          0001865E3840 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 020 SelfSupportCharacters                    000185CFF058 ModelClassListType IReadOnlyList`1<IInProduceSupportCharacterStatus> IReadOnlyList`1<IInProduceSupportCharacterStatus> List<IInProduceSupportCharacterStatus> Pointer
    // 028 FriendSupportCharacter                   00018657E840 ModelClassType IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus Pointer
    // 030 SupportEffectViewModels                  000185CFF2A8 ModelClassListType IReadOnlyList`1<IInProduceSupportEffectContentViewModel> IReadOnlyList`1<IInProduceSupportEffectContentViewModel> List<IInProduceSupportEffectContentViewModel> Pointer
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

            value.SupportSkillSlotViewModels                = GetObjectList<SupportSkillSlotViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.SupportSkillSlotViewModel.FromPointer); // 024666551D90 0x10 SupportSkillSlotViewModels  ( 000185D111B8 ModelClassListType List`1<SupportSkillSlotViewModel> List`1<SupportSkillSlotViewModel> List<SupportSkillSlotViewModel> Pointer )
            value.ProduceBaseInfo                           = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 024666551DB0 0x18 ProduceBaseInfo             ( 0001865E3840 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.SelfSupportCharacters                     = GetObjectList<IInProduceSupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IInProduceSupportCharacterStatus.FromPointer); // 024666551DD0 0x20 SelfSupportCharacters       ( 000185CFF058 ModelClassListType IReadOnlyList`1<IInProduceSupportCharacterStatus> IReadOnlyList`1<IInProduceSupportCharacterStatus> List<IInProduceSupportCharacterStatus> Pointer )
            value.FriendSupportCharacter                    = GetObject<IInProduceSupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IInProduceSupportCharacterStatus.FromPointer); // 024666551DF0 0x28 FriendSupportCharacter      ( 00018657E840 ModelClassType IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus IInProduceSupportCharacterStatus Pointer )
            value.SupportEffectViewModels                   = GetObjectList<IInProduceSupportEffectContentViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.IInProduceSupportEffectContentViewModel.FromPointer); // 024666551E10 0x30 SupportEffectViewModels     ( 000185CFF2A8 ModelClassListType IReadOnlyList`1<IInProduceSupportEffectContentViewModel> IReadOnlyList`1<IInProduceSupportEffectContentViewModel> List<IInProduceSupportEffectContentViewModel> Pointer )

            return value;
        }
    }
}
