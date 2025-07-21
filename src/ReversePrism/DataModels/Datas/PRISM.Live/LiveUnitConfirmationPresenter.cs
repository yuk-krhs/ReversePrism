using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 View                                     ModelClassType LiveUnitConfirmationView LiveUnitConfirmationView LiveUnitConfirmationView Pointer
    // 080 LiveBonusContent                         ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer
    // 088 UnitEditView                             ModelClassType LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView Pointer
    // 090 UnitListWindow                           ModelClassType LiveUnitListWindow LiveUnitListWindow LiveUnitListWindow Pointer
    // 098 SettingPopupCaller                       ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer
    // 0A0 LbPopupCaller                            ModelClassType LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller Pointer
    // 0A8 StageDetailPopupCaller                   ModelClassType LiveStageDetailPopupCaller LiveStageDetailPopupCaller LiveStageDetailPopupCaller Pointer
    // 0B0 UseRecommendedPopupCaller                ModelClassType LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller Pointer
    // 0B8 TotalParameterDetailPopupCaller          ModelClassType LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller Pointer
    // 0C0 SkipLiveConfirmationPopupCaller          ModelClassType SkipLiveConfirmationPopupCaller SkipLiveConfirmationPopupCaller SkipLiveConfirmationPopupCaller Pointer
    // 0C8 LimitedVoiceSeparateDetailPopupCaller    ModelClassType LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller Pointer
    // 0D0 EventBreakTimePopupCaller                ModelClassType ILiveEventBreakTimePopupCaller ILiveEventBreakTimePopupCaller ILiveEventBreakTimePopupCaller Pointer
    // 0D8 Model                                    ModelClassType LiveUnitConfirmationModel LiveUnitConfirmationModel LiveUnitConfirmationModel Pointer
    // 0E0 Canceller                                ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 0E8 JumpParameter                            ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    public partial class LiveUnitConfirmationPresenter : DataModel
    {
        public LiveUnitConfirmationView?                View                                    { get; set; }
        public LiveBonusContent?                        LiveBonusContent                        { get; set; }
        public LiveUnitConfirmationUnitEditView?        UnitEditView                            { get; set; }
        public LiveUnitListWindow?                      UnitListWindow                          { get; set; }
        public LiveSettingPopupCaller?                  SettingPopupCaller                      { get; set; }
        public LiveBonusUsageSettingPopupCaller?        LbPopupCaller                           { get; set; }
        public LiveStageDetailPopupCaller?              StageDetailPopupCaller                  { get; set; }
        public LiveUnitEditUseRecommendedPopupCaller?   UseRecommendedPopupCaller               { get; set; }
        public LiveUnitTotalParameterDetailPopupCaller? TotalParameterDetailPopupCaller         { get; set; }
        public SkipLiveConfirmationPopupCaller?         SkipLiveConfirmationPopupCaller         { get; set; }
        public LimitedVoiceSeparateDetailPopupCaller?   LimitedVoiceSeparateDetailPopupCaller   { get; set; }
        public ILiveEventBreakTimePopupCaller?          EventBreakTimePopupCaller               { get; set; }
        public LiveUnitConfirmationModel?               Model                                   { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public JumpParameter?                           JumpParameter                           { get; set; }

        public static LiveUnitConfirmationPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationPresenter() { Pointer= p0 };

            value.View                                      = GetObject<LiveUnitConfirmationView>(new IntPtr(p + 0x078), ReversePrism.DataModels.LiveUnitConfirmationView.FromPointer); // 0x78 View                        ( ModelClassType LiveUnitConfirmationView LiveUnitConfirmationView LiveUnitConfirmationView Pointer )
            value.LiveBonusContent                          = GetObject<LiveBonusContent>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveBonusContent.FromPointer); // 0x80 LiveBonusContent            ( ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer )
            value.UnitEditView                              = GetObject<LiveUnitConfirmationUnitEditView>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveUnitConfirmationUnitEditView.FromPointer); // 0x88 UnitEditView                ( ModelClassType LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView Pointer )
            value.UnitListWindow                            = GetObject<LiveUnitListWindow>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveUnitListWindow.FromPointer); // 0x90 UnitListWindow              ( ModelClassType LiveUnitListWindow LiveUnitListWindow LiveUnitListWindow Pointer )
            value.SettingPopupCaller                        = GetObject<LiveSettingPopupCaller>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveSettingPopupCaller.FromPointer); // 0x98 SettingPopupCaller          ( ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer )
            value.LbPopupCaller                             = GetObject<LiveBonusUsageSettingPopupCaller>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.LiveBonusUsageSettingPopupCaller.FromPointer); // 0xA0 LbPopupCaller               ( ModelClassType LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller Pointer )
            value.StageDetailPopupCaller                    = GetObject<LiveStageDetailPopupCaller>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.LiveStageDetailPopupCaller.FromPointer); // 0xA8 StageDetailPopupCaller      ( ModelClassType LiveStageDetailPopupCaller LiveStageDetailPopupCaller LiveStageDetailPopupCaller Pointer )
            value.UseRecommendedPopupCaller                 = GetObject<LiveUnitEditUseRecommendedPopupCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveUnitEditUseRecommendedPopupCaller.FromPointer); // 0xB0 UseRecommendedPopupCaller   ( ModelClassType LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller Pointer )
            value.TotalParameterDetailPopupCaller           = GetObject<LiveUnitTotalParameterDetailPopupCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.LiveUnitTotalParameterDetailPopupCaller.FromPointer); // 0xB8 TotalParameterDetailPopupCaller ( ModelClassType LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller Pointer )
            value.SkipLiveConfirmationPopupCaller           = GetObject<SkipLiveConfirmationPopupCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.SkipLiveConfirmationPopupCaller.FromPointer); // 0xC0 SkipLiveConfirmationPopupCaller ( ModelClassType SkipLiveConfirmationPopupCaller SkipLiveConfirmationPopupCaller SkipLiveConfirmationPopupCaller Pointer )
            value.LimitedVoiceSeparateDetailPopupCaller     = GetObject<LimitedVoiceSeparateDetailPopupCaller>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.LimitedVoiceSeparateDetailPopupCaller.FromPointer); // 0xC8 LimitedVoiceSeparateDetailPopupCaller ( ModelClassType LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller LimitedVoiceSeparateDetailPopupCaller Pointer )
            value.EventBreakTimePopupCaller                 = GetObject<ILiveEventBreakTimePopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ILiveEventBreakTimePopupCaller.FromPointer); // 0xD0 EventBreakTimePopupCaller   ( ModelClassType ILiveEventBreakTimePopupCaller ILiveEventBreakTimePopupCaller ILiveEventBreakTimePopupCaller Pointer )
            value.Model                                     = GetObject<LiveUnitConfirmationModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.LiveUnitConfirmationModel.FromPointer); // 0xD8 Model                       ( ModelClassType LiveUnitConfirmationModel LiveUnitConfirmationModel LiveUnitConfirmationModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 Canceller                   ( ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.JumpParameter.FromPointer); // 0xE8 JumpParameter               ( ModelClassType JumpParameter JumpParameter JumpParameter Pointer )

            return value;
        }
    }
}
