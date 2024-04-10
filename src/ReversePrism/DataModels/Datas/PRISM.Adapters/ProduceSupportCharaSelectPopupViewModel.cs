using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 ChangeTargetStatus                       00018666A290 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 020 SettingSCharaStatus                      000185D0D8A8 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 028 pIdolIds                                 IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 030 SCharaIcons                              000185CA2588 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer
    // 038 SortedSCharaIcons                        000185CA2588 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer
    // 040 sortFilterSaveData                       SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 048 sortFilterModel                          SupportCharacterSelectModel`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 050 CellViewModelList                        000185CFCEB8 ModelClassListType List`1<ProduceSupportCharaSelectGridViewCellViewModel> List`1<ProduceSupportCharaSelectGridViewCellViewModel> List<ProduceSupportCharaSelectGridViewCellViewModel> Pointer
    public partial class ProduceSupportCharaSelectPopupViewModel : DataModel
    {
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ISupportCharacterStatus?                 ChangeTargetStatus                      { get; set; }
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

            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466658B870 0x10 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ChangeTargetStatus                        = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 02466658B890 0x18 ChangeTargetStatus          ( 00018666A290 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.SettingSCharaStatus                       = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 02466658B8B0 0x20 SettingSCharaStatus         ( 000185D0D8A8 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.SCharaIcons                               = GetObjectList<SCharaIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIcon.FromPointer); // 02466658B8F0 0x30 SCharaIcons                 ( 000185CA2588 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer )
            value.SortedSCharaIcons                         = GetObjectList<SCharaIcon>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaIcon.FromPointer); // 02466658B910 0x38 SortedSCharaIcons           ( 000185CA2588 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer )
            value.CellViewModelList                         = GetObjectList<ProduceSupportCharaSelectGridViewCellViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceSupportCharaSelectGridViewCellViewModel.FromPointer); // 02466658B970 0x50 CellViewModelList           ( 000185CFCEB8 ModelClassListType List`1<ProduceSupportCharaSelectGridViewCellViewModel> List`1<ProduceSupportCharaSelectGridViewCellViewModel> List<ProduceSupportCharaSelectGridViewCellViewModel> Pointer )

            return value;
        }
    }
}
