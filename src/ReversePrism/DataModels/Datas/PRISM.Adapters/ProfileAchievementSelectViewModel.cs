using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AchievementIconModels                    ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer
    // 018 DisplayAchievementIconModels             ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer
    // 020 SlotPanelViewModels                      ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer
    // 028 SortFilterModel                          ModelClassType ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel Pointer
    // 030 SelectedTabType                          ModelEnumType AchievementType AchievementType AchievementType Int32
    // 038 IsTabBadges                              ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 040 UserSelfPanelViewModel                   ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer
    // 048 CurrentSlotIndex                         ModelPrimitiveType int int int Int32
    // 050 LastSelectedViewModel                    ModelClassType AchievementIconViewModel AchievementIconViewModel AchievementIconViewModel Pointer
    // 058 isNewSaveData                            SavableJsonObject`1<ProfileAchievementIsNewSaveData> IL2CPP_TYPE_GENERICINST
    // 060 SettingsAchievementIds                   ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ProfileAchievementSelectViewModel : DataModel
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
            var value   = new ProfileAchievementSelectViewModel() { Pointer= p0 };

            value.AchievementIconModels                     = GetObjectList<AchievementIconViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0x10 AchievementIconModels       ( ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer )
            value.DisplayAchievementIconModels              = GetObjectList<AchievementIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0x18 DisplayAchievementIconModels ( ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer )
            value.SlotPanelViewModels                       = GetObjectList<AchievementIconViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0x20 SlotPanelViewModels         ( ModelClassListType AchievementIconViewModel[] AchievementIconViewModel[] List<AchievementIconViewModel> Pointer )
            value.SortFilterModel                           = GetObject<ProfileAchievementSortFilterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProfileAchievementSortFilterModel.FromPointer); // 0x28 SortFilterModel             ( ModelClassType ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel ProfileAchievementSortFilterModel Pointer )
            value.SelectedTabType                           = (AchievementType)GetInt32(new IntPtr(p + 0x030)); // 0x30 SelectedTabType             ( ModelEnumType AchievementType AchievementType AchievementType Int32 )
            value.IsTabBadges                               = GetBoolList(new IntPtr(p + 0x038)); // 0x38 IsTabBadges                 ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.UserSelfPanelViewModel                    = GetObject<ProfileUserSelfPanelViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProfileUserSelfPanelViewModel.FromPointer); // 0x40 UserSelfPanelViewModel      ( ModelClassType ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel ProfileUserSelfPanelViewModel Pointer )
            value.CurrentSlotIndex                          = GetInt32(new IntPtr(p + 0x048)); // 0x48 CurrentSlotIndex            ( ModelPrimitiveType int int int Int32 )
            value.LastSelectedViewModel                     = GetObject<AchievementIconViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.AchievementIconViewModel.FromPointer); // 0x50 LastSelectedViewModel       ( ModelClassType AchievementIconViewModel AchievementIconViewModel AchievementIconViewModel Pointer )
            value.SettingsAchievementIds                    = GetInt32List(new IntPtr(p + 0x060)); // 0x60 SettingsAchievementIds      ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
