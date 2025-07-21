using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DecideReactiveProperty                   ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 018 SCharaIcons                              ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer
    // 020 SCharaIconViewModels                     ModelClassListType ProfileSupportCharaIconViewModel[] ProfileSupportCharaIconViewModel[] List<ProfileSupportCharaIconViewModel> Pointer
    // 028 sortFilterSaveData                       SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 030 sortFilterModel                          SupportCharacterSelectModel`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 038 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 040 CursorSelectedSChara                     ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer
    // 048 SettingsCharaId                          ModelPrimitiveType int int int Int32
    public partial class ProfileSupportCharaSelectViewModel : DataModel
    {
        public BoolReactiveProperty?                    DecideReactiveProperty                  { get; set; }
        public List<SCharaIcon>?                        SCharaIcons                             { get; set; }
        public List<ProfileSupportCharaIconViewModel>?  SCharaIconViewModels                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public SCharaIcon?                              CursorSelectedSChara                    { get; set; }
        public int                                      SettingsCharaId                         { get; set; }

        public static ProfileSupportCharaSelectViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileSupportCharaSelectViewModel() { Pointer= p0 };

            value.DecideReactiveProperty                    = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x10 DecideReactiveProperty      ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SCharaIcons                               = GetObjectList<SCharaIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x18 SCharaIcons                 ( ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer )
            value.SCharaIconViewModels                      = GetObjectList<ProfileSupportCharaIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProfileSupportCharaIconViewModel.FromPointer); // 0x20 SCharaIconViewModels        ( ModelClassListType ProfileSupportCharaIconViewModel[] ProfileSupportCharaIconViewModel[] List<ProfileSupportCharaIconViewModel> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CursorSelectedSChara                      = GetObject<SCharaIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0x40 CursorSelectedSChara        ( ModelClassType SCharaIcon SCharaIcon SCharaIcon Pointer )
            value.SettingsCharaId                           = GetInt32(new IntPtr(p + 0x048)); // 0x48 SettingsCharaId             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
