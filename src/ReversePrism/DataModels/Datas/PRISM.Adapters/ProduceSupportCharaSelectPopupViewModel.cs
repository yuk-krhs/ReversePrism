using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 ChangeTargetStatus                       ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 020 FriendSupportCharacter                   ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 028 SettingSCharaStatus                      ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 030 pIdolIds                                 IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 038 SCharaIcons                              ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer
    // 040 SortedSCharaIcons                        ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer
    // 048 sortFilterSaveData                       SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 050 sortFilterModel                          SupportCharacterSelectModel`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 058 CellViewModelList                        ModelClassListType List`1<ProduceSupportCharaSelectGridViewCellViewModel> List`1<ProduceSupportCharaSelectGridViewCellViewModel> List<ProduceSupportCharaSelectGridViewCellViewModel> Pointer
    public partial class ProduceSupportCharaSelectPopupViewModel : DataModel
    {
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ISupportCharacterStatus?                 ChangeTargetStatus                      { get; set; }
        public ISupportCharacterStatus?                 FriendSupportCharacter                  { get; set; }
        public List<ISupportCharacterStatus>?           SettingSCharaStatus                     { get; set; }
        public List<SCharaIcon>?                        SCharaIcons                             { get; set; }
        public List<SCharaIcon>?                        SortedSCharaIcons                       { get; set; }
        public List<ProduceSupportCharaSelectGridViewCellViewModel>? CellViewModelList                       { get; set; }

        public static ProduceSupportCharaSelectPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceSupportCharaSelectPopupViewModel() { Pointer= p0 };

            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x10 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ChangeTargetStatus                        = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x18 ChangeTargetStatus          ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.FriendSupportCharacter                    = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x20 FriendSupportCharacter      ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.SettingSCharaStatus                       = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x28 SettingSCharaStatus         ( ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.SCharaIcons                               = GetObjectList<SCharaIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x38 SCharaIcons                 ( ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer )
            value.SortedSCharaIcons                         = GetObjectList<SCharaIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x40 SortedSCharaIcons           ( ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer )
            value.CellViewModelList                         = GetObjectList<ProduceSupportCharaSelectGridViewCellViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProduceSupportCharaSelectGridViewCellViewModel.FromPointer); // 0x58 CellViewModelList           ( ModelClassListType List`1<ProduceSupportCharaSelectGridViewCellViewModel> List`1<ProduceSupportCharaSelectGridViewCellViewModel> List<ProduceSupportCharaSelectGridViewCellViewModel> Pointer )

            return value;
        }
    }
}
