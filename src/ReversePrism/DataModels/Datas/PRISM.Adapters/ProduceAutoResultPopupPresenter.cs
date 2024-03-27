using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865E2390 ModelClassType IProduceAutoResultPopupView IProduceAutoResultPopupView IProduceAutoResultPopupView Pointer
    // 018 ViewModel                                0001865302E0 ModelClassType ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel Pointer
    // 020 SettingModel                             000186530F50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    // 028 AutoExecModel                            00018652A440 ModelClassType ProduceAutoExecModel ProduceAutoExecModel ProduceAutoExecModel Pointer
    // 030 StrategySelectModel                      000186584160 ModelClassType ProduceStrategySelectModel ProduceStrategySelectModel ProduceStrategySelectModel Pointer
    // 038 ScheduleSelectionAIModel                 0001866D82A0 ModelClassType ScheduleSelectionAIModel ScheduleSelectionAIModel ScheduleSelectionAIModel Pointer
    // 040 CardSelectModel                          0001865471B0 ModelClassType CardSeceltModel CardSeceltModel CardSeceltModel Pointer
    // 048 SelectSupportSkillModel                  00018671E390 ModelClassType SelectSupportSkill SelectSupportSkill SelectSupportSkill Pointer
    // 050 AutoInGameModel                          000186725CF0 ModelClassType AutoIngameModel AutoIngameModel AutoIngameModel Pointer
    // 058 UnitCommunityModel                       00018670B460 ModelClassType UnitCommunityModel UnitCommunityModel UnitCommunityModel Pointer
    // 060 SubSeasonSelectModel                     0001865D7B10 ModelClassType SubSeasonSelectModel SubSeasonSelectModel SubSeasonSelectModel Pointer
    // 068 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 070 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 078 SeasonViewModels                         000185CFB538 ModelClassListType List`1<ProduceAutoOneSeasonViewModel> List`1<ProduceAutoOneSeasonViewModel> List<ProduceAutoOneSeasonViewModel> Pointer
    // 080 IsUseAuto                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 084 LastNextOrder                            00018660CA90 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 088 LastProduceBaseInfo                      0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 090 OptionSaveData                           000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    // 098 IsExecLastWeekSchedule                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 099 IsShowReady                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09A IsExecEnd                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceAutoResultPopupPresenter
    {
        public IProduceAutoResultPopupView?             View                                    { get; set; }
        public ProduceAutoResultPopupViewModel?         ViewModel                               { get; set; }
        public ProduceAutoSettingModel?                 SettingModel                            { get; set; }
        public ProduceAutoExecModel?                    AutoExecModel                           { get; set; }
        public ProduceStrategySelectModel?              StrategySelectModel                     { get; set; }
        public ScheduleSelectionAIModel?                ScheduleSelectionAIModel                { get; set; }
        public CardSeceltModel?                         CardSelectModel                         { get; set; }
        public SelectSupportSkill?                      SelectSupportSkillModel                 { get; set; }
        public AutoIngameModel?                         AutoInGameModel                         { get; set; }
        public UnitCommunityModel?                      UnitCommunityModel                      { get; set; }
        public SubSeasonSelectModel?                    SubSeasonSelectModel                    { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public List<ProduceAutoOneSeasonViewModel>?     SeasonViewModels                        { get; set; }
        public bool                                     IsUseAuto                               { get; set; }
        public ProduceNextOrderType                     LastNextOrder                           { get; set; }
        public IProduceBaseInfoStatus?                  LastProduceBaseInfo                     { get; set; }
        public ProduceOptionSaveData?                   OptionSaveData                          { get; set; }
        public bool                                     IsExecLastWeekSchedule                  { get; set; }
        public bool                                     IsShowReady                             { get; set; }
        public bool                                     IsExecEnd                               { get; set; }

        public static ProduceAutoResultPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoResultPopupPresenter();

            value.View                                      = GetObject<IProduceAutoResultPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceAutoResultPopupView.FromPointer); // 0270D6458FA0 0x10 View                        ( 0001865E2390 ModelClassType IProduceAutoResultPopupView IProduceAutoResultPopupView IProduceAutoResultPopupView Pointer )
            value.ViewModel                                 = GetObject<ProduceAutoResultPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoResultPopupViewModel.FromPointer); // 0270D6458FC0 0x18 ViewModel                   ( 0001865302E0 ModelClassType ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel Pointer )
            value.SettingModel                              = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0270D6458FE0 0x20 SettingModel                ( 000186530F50 ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )
            value.AutoExecModel                             = GetObject<ProduceAutoExecModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceAutoExecModel.FromPointer); // 0270D6459000 0x28 AutoExecModel               ( 00018652A440 ModelClassType ProduceAutoExecModel ProduceAutoExecModel ProduceAutoExecModel Pointer )
            value.StrategySelectModel                       = GetObject<ProduceStrategySelectModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceStrategySelectModel.FromPointer); // 0270D6459020 0x30 StrategySelectModel         ( 000186584160 ModelClassType ProduceStrategySelectModel ProduceStrategySelectModel ProduceStrategySelectModel Pointer )
            value.ScheduleSelectionAIModel                  = GetObject<ScheduleSelectionAIModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionAIModel.FromPointer); // 0270D6459040 0x38 ScheduleSelectionAIModel    ( 0001866D82A0 ModelClassType ScheduleSelectionAIModel ScheduleSelectionAIModel ScheduleSelectionAIModel Pointer )
            value.CardSelectModel                           = GetObject<CardSeceltModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.CardSeceltModel.FromPointer); // 0270D6459060 0x40 CardSelectModel             ( 0001865471B0 ModelClassType CardSeceltModel CardSeceltModel CardSeceltModel Pointer )
            value.SelectSupportSkillModel                   = GetObject<SelectSupportSkill>(new IntPtr(p + 0x048), ReversePrism.DataModels.SelectSupportSkill.FromPointer); // 0270D6459080 0x48 SelectSupportSkillModel     ( 00018671E390 ModelClassType SelectSupportSkill SelectSupportSkill SelectSupportSkill Pointer )
            value.AutoInGameModel                           = GetObject<AutoIngameModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.AutoIngameModel.FromPointer); // 0270D64590A0 0x50 AutoInGameModel             ( 000186725CF0 ModelClassType AutoIngameModel AutoIngameModel AutoIngameModel Pointer )
            value.UnitCommunityModel                        = GetObject<UnitCommunityModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.UnitCommunityModel.FromPointer); // 0270D64590C0 0x58 UnitCommunityModel          ( 00018670B460 ModelClassType UnitCommunityModel UnitCommunityModel UnitCommunityModel Pointer )
            value.SubSeasonSelectModel                      = GetObject<SubSeasonSelectModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.SubSeasonSelectModel.FromPointer); // 0270D64590E0 0x60 SubSeasonSelectModel        ( 0001865D7B10 ModelClassType SubSeasonSelectModel SubSeasonSelectModel SubSeasonSelectModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6459100 0x68 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x070), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6459120 0x70 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.SeasonViewModels                          = GetObjectList<ProduceAutoOneSeasonViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ProduceAutoOneSeasonViewModel.FromPointer); // 0270D6459140 0x78 SeasonViewModels            ( 000185CFB538 ModelClassListType List`1<ProduceAutoOneSeasonViewModel> List`1<ProduceAutoOneSeasonViewModel> List<ProduceAutoOneSeasonViewModel> Pointer )
            value.IsUseAuto                                 = GetBool(new IntPtr(p + 0x080)); // 0270D6459160 0x80 IsUseAuto                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastNextOrder                             = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x084)); // 0270D6459180 0x84 LastNextOrder               ( 00018660CA90 ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.LastProduceBaseInfo                       = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0270D64591A0 0x88 LastProduceBaseInfo         ( 0001865E2F10 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.OptionSaveData                            = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0270D64591C0 0x90 OptionSaveData              ( 000186561420 ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )
            value.IsExecLastWeekSchedule                    = GetBool(new IntPtr(p + 0x098)); // 0270D64591E0 0x98 IsExecLastWeekSchedule      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsShowReady                               = GetBool(new IntPtr(p + 0x099)); // 0270D6459200 0x99 IsShowReady                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsExecEnd                                 = GetBool(new IntPtr(p + 0x09A)); // 0270D6459220 0x9A IsExecEnd                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
