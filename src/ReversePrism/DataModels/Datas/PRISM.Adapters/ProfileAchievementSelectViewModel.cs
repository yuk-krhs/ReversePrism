using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AchievementIconModels                    000185B6F360 ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer
    // 018 DisplayAchievementIconModels             000185B6F360 ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer
    // 020 SlotPanelViewModels                      000185B6F360 ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer
    // 028 SortFilterModel                          0001865A9B90 ModelClassType ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel Pointer
    // 030 SelectedTabType                          00018666A8C0 ModelEnumType AchievementType AchievementType AchievementType Int32
    // 038 IsTabBadges                              000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 040 UserSelfPanelViewModel                   0001865C7B80 ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer
    // 048 CurrentSlotIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 LastSelectedViewModel                    000186676180 ModelClassType AchievementIconViewModel AchievementIconViewModel AchievementIconViewModel Pointer
    // 058 isNewSaveData                            SavableJsonObject`1<ProfileAchievementIsNewSaveData> IL2CPP_TYPE_GENERICINST
    // 060 SettingsAchievementIds                   000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ProfileAchievementSelectViewModel
    {
        public List<AchievementIconViewModel>?          AchievementIconModels                   { get; set; }
        public List<AchievementIconViewModel>?          DisplayAchievementIconModels            { get; set; }
        public List<AchievementIconViewModel>?          SlotPanelViewModels                     { get; set; }
        public ProfileAchievementSortFilterModel?       SortFilterModel                         { get; set; }
        public AchievementType                          SelectedTabType                         { get; set; }
        public List<bool>?                              IsTabBadges                             { get; set; }
        public ProfileUserSelfPanelViewModel?           UserSelfPanelViewModel                  { get; set; }
        public int                                      CurrentSlotIndex                        { get; set; }
        public AchievementIconViewModel?                LastSelectedViewModel                   { get; set; }
        public List<int>?                               SettingsAchievementIds                  { get; set; }

        public static ProfileAchievementSelectViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProfileAchievementSelectViewModel();

            value.AchievementIconModels                     = GetObjectList<AchievementIconViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0270D6675BB8 0x10 AchievementIconModels       ( 000185B6F360 ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer )
            value.DisplayAchievementIconModels              = GetObjectList<AchievementIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0270D6675BD8 0x18 DisplayAchievementIconModels ( 000185B6F360 ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer )
            value.SlotPanelViewModels                       = GetObjectList<AchievementIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0270D6675BF8 0x20 SlotPanelViewModels         ( 000185B6F360 ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer )
            value.SortFilterModel                           = GetObject<ProfileAchievementSortFilterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileAchievementSortFilterModel.FromPointer); // 0270D6675C18 0x28 SortFilterModel             ( 0001865A9B90 ModelClassType ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel Pointer )
            value.SelectedTabType                           = (AchievementType)GetInt32(new IntPtr(p + 0x030)); // 0270D6675C38 0x30 SelectedTabType             ( 00018666A8C0 ModelEnumType AchievementType AchievementType AchievementType Int32 )
            value.IsTabBadges                               = GetBoolList(new IntPtr(p + 0x038)); // 0270D6675C58 0x38 IsTabBadges                 ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.UserSelfPanelViewModel                    = GetObject<ProfileUserSelfPanelViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileUserSelfPanelViewModel.FromPointer); // 0270D6675C78 0x40 UserSelfPanelViewModel      ( 0001865C7B80 ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer )
            value.CurrentSlotIndex                          = GetInt32(new IntPtr(p + 0x048)); // 0270D6675C98 0x48 CurrentSlotIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastSelectedViewModel                     = GetObject<AchievementIconViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0270D6675CB8 0x50 LastSelectedViewModel       ( 000186676180 ModelClassType AchievementIconViewModel AchievementIconViewModel AchievementIconViewModel Pointer )
            value.SettingsAchievementIds                    = GetInt32List(new IntPtr(p + 0x060)); // 0270D6675CF8 0x60 SettingsAchievementIds      ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
