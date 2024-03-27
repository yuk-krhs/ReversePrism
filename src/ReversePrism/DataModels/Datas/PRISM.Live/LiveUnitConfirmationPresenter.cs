using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 View                                     00018658C410 ModelClassType LiveUnitConfirmationView LiveUnitConfirmationView LiveUnitConfirmationView Pointer
    // 088 LiveBonusContent                         000186540AD0 ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer
    // 090 UnitEditView                             00018658B970 ModelClassType LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView Pointer
    // 098 UnitListWindow                           000186595110 ModelClassType LiveUnitListWindow LiveUnitListWindow LiveUnitListWindow Pointer
    // 0A0 SettingPopupCaller                       000186579570 ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer
    // 0A8 LbPopupCaller                            0001865412D0 ModelClassType LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller Pointer
    // 0B0 StageDetailPopupCaller                   000186580640 ModelClassType LiveStageDetailPopupCaller LiveStageDetailPopupCaller LiveStageDetailPopupCaller Pointer
    // 0B8 UseRecommendedPopupCaller                000186590890 ModelClassType LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller Pointer
    // 0C0 TotalParameterDetailPopupCaller          000186599130 ModelClassType LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller Pointer
    // 0C8 Model                                    000186588FF0 ModelClassType LiveUnitConfirmationModel LiveUnitConfirmationModel LiveUnitConfirmationModel Pointer
    // 0D0 Canceller                                000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    // 0D8 JumpParameter                            0001866D66F0 ModelClassType JumpParameter JumpParameter JumpParameter Pointer
    public partial class LiveUnitConfirmationPresenter
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
        public LiveUnitConfirmationModel?               Model                                   { get; set; }
        public AutoCancellationTokenSource              Canceller                               { get; set; }
        public JumpParameter?                           JumpParameter                           { get; set; }

        public static LiveUnitConfirmationPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationPresenter();

            value.View                                      = GetObject<LiveUnitConfirmationView>(new IntPtr(p + 0x080), ReversePrism.DataModels.LiveUnitConfirmationView.FromPointer); // 0270D52924D8 0x80 View                        ( 00018658C410 ModelClassType LiveUnitConfirmationView LiveUnitConfirmationView LiveUnitConfirmationView Pointer )
            value.LiveBonusContent                          = GetObject<LiveBonusContent>(new IntPtr(p + 0x088), ReversePrism.DataModels.LiveBonusContent.FromPointer); // 0270D52924F8 0x88 LiveBonusContent            ( 000186540AD0 ModelClassType LiveBonusContent LiveBonusContent LiveBonusContent Pointer )
            value.UnitEditView                              = GetObject<LiveUnitConfirmationUnitEditView>(new IntPtr(p + 0x090), ReversePrism.DataModels.LiveUnitConfirmationUnitEditView.FromPointer); // 0270D5292518 0x90 UnitEditView                ( 00018658B970 ModelClassType LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView LiveUnitConfirmationUnitEditView Pointer )
            value.UnitListWindow                            = GetObject<LiveUnitListWindow>(new IntPtr(p + 0x098), ReversePrism.DataModels.LiveUnitListWindow.FromPointer); // 0270D5292538 0x98 UnitListWindow              ( 000186595110 ModelClassType LiveUnitListWindow LiveUnitListWindow LiveUnitListWindow Pointer )
            value.SettingPopupCaller                        = GetObject<LiveSettingPopupCaller>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.LiveSettingPopupCaller.FromPointer); // 0270D5292558 0xA0 SettingPopupCaller          ( 000186579570 ModelClassType LiveSettingPopupCaller LiveSettingPopupCaller LiveSettingPopupCaller Pointer )
            value.LbPopupCaller                             = GetObject<LiveBonusUsageSettingPopupCaller>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.LiveBonusUsageSettingPopupCaller.FromPointer); // 0270D5292578 0xA8 LbPopupCaller               ( 0001865412D0 ModelClassType LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller LiveBonusUsageSettingPopupCaller Pointer )
            value.StageDetailPopupCaller                    = GetObject<LiveStageDetailPopupCaller>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.LiveStageDetailPopupCaller.FromPointer); // 0270D5292598 0xB0 StageDetailPopupCaller      ( 000186580640 ModelClassType LiveStageDetailPopupCaller LiveStageDetailPopupCaller LiveStageDetailPopupCaller Pointer )
            value.UseRecommendedPopupCaller                 = GetObject<LiveUnitEditUseRecommendedPopupCaller>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.LiveUnitEditUseRecommendedPopupCaller.FromPointer); // 0270D52925B8 0xB8 UseRecommendedPopupCaller   ( 000186590890 ModelClassType LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller LiveUnitEditUseRecommendedPopupCaller Pointer )
            value.TotalParameterDetailPopupCaller           = GetObject<LiveUnitTotalParameterDetailPopupCaller>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.LiveUnitTotalParameterDetailPopupCaller.FromPointer); // 0270D52925D8 0xC0 TotalParameterDetailPopupCaller ( 000186599130 ModelClassType LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller LiveUnitTotalParameterDetailPopupCaller Pointer )
            value.Model                                     = GetObject<LiveUnitConfirmationModel>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.LiveUnitConfirmationModel.FromPointer); // 0270D52925F8 0xC8 Model                       ( 000186588FF0 ModelClassType LiveUnitConfirmationModel LiveUnitConfirmationModel LiveUnitConfirmationModel Pointer )
            value.Canceller                                 = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x0D0)); // 0270D5292618 0xD0 Canceller                   ( 000186724470 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )
            value.JumpParameter                             = GetObject<JumpParameter>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.JumpParameter.FromPointer); // 0270D5292638 0xD8 JumpParameter               ( 0001866D66F0 ModelClassType JumpParameter JumpParameter JumpParameter Pointer )

            return value;
        }
    }
}
