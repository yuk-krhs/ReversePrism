using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 140 CharacterBaseSelect                      SavableJsonObject`1<CharacterBaseSelectPermanentData> IL2CPP_TYPE_GENERICINST
    // 148 CharacterSelectPI                        SavableJsonObject`1<CharacterSelectPIPermanentData> IL2CPP_TYPE_GENERICINST
    // 150 CharacterSelectSC                        SavableJsonObject`1<CharacterSelectSCPermanentData> IL2CPP_TYPE_GENERICINST
    // 158 CharacterSelectPIUpgradingFilter         SavableJsonObject`1<CharacterSelectPIUpgradingFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 160 CharacterSelectSCUpgradingFilter         SavableJsonObject`1<CharacterSelectSCUpgradingFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 168 IdolList                                 SavableJsonObject`1<IdolListPermanentData> IL2CPP_TYPE_GENERICINST
    // 170 IdolListFISortFilter                     SavableJsonObject`1<IdolListFISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 178 IdolListFUSortFilter                     SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 180 IdolListPISortFilter                     SavableJsonObject`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 188 IdolListSCSortFilter                     SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 190 IdolBaseDetail                           SavableJsonObject`1<IdolBaseDetailPermanentData> IL2CPP_TYPE_GENERICINST
    // 198 LiveUnitEdit                             SavableJsonObject`1<LiveUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 1A0 ProduceUnitEdit                          SavableJsonObject`1<ProduceUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 1A8 ProduceIdolSelect                        SavableJsonObject`1<ProduceIdolSelectPermanentData> IL2CPP_TYPE_GENERICINST
    // 1B0 FriendListSortFilter                     SavableJsonObject`1<FriendListSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 1B8 MobileNotification                       SavableJsonObject`1<MobileNotificationPermanentData> IL2CPP_TYPE_GENERICINST
    // 1C0 ProduceAutoSetting                       SavableJsonObject`1<ProduceAutoSettingModel> IL2CPP_TYPE_GENERICINST
    // 1C8 ProduceStaminaUsage                      SavableJsonObject`1<ProduceStaminaUsageSaveData> IL2CPP_TYPE_GENERICINST
    // 1D0 ChallengeTourStageFilter                 SavableJsonObject`1<ChallengeTourStageFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 1D8 LiveEventSaveData                        SavableJsonObject`1<LiveEventSaveData> IL2CPP_TYPE_GENERICINST
    // 1E0 MedalGashaSaveData                       SavableJsonObject`1<MedalGashaSaveData> IL2CPP_TYPE_GENERICINST
    // 1E8 SeasonMissionFilter                      SavableJsonObject`1<SeasonMissionFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 1F0 EventList                                SavableJsonObject`1<EventListSaveData> IL2CPP_TYPE_GENERICINST
    // 1F8 ChallengeTourFUSortFilter                SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 200 ChallengeTourSelectUnitStage             SavableJsonObject`1<ChallengeTourSelectUnitStageSaveData> IL2CPP_TYPE_GENERICINST
    // 208 DressUpRoom                              SavableJsonObject`1<DressUpRoomSaveData> IL2CPP_TYPE_GENERICINST
    // 210 AppReviewSaveData                        SavableJsonObject`1<AppReviewSaveData> IL2CPP_TYPE_GENERICINST
    // 218 ProfileIdolListFavoritePISortFilter      SavableJsonObject`1<IdolListPISortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 220 AchievementSortFilter                    SavableJsonObject`1<ProfileAchievementSortFilterSaveData> IL2CPP_TYPE_GENERICINST
    // 228 AchievementUI                            SavableJsonObject`1<ProfileAchievementIsNewSaveData> IL2CPP_TYPE_GENERICINST
    // 230 ProfileIdolListSCSortFilter              SavableJsonObject`1<IdolListSCSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 238 PvpFUSortFilter                          SavableJsonObject`1<IdolListFUSortFilterPermanentData> IL2CPP_TYPE_GENERICINST
    public partial class SaveDataContainer
    {

        public static SaveDataContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SaveDataContainer();


            return value;
        }
    }
}
