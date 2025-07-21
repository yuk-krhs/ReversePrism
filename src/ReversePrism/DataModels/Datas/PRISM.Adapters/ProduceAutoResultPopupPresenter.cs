using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceAutoResultPopupView IProduceAutoResultPopupView IProduceAutoResultPopupView Pointer
    // 018 ViewModel                                ModelClassType ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel Pointer
    // 020 SettingModel                             ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer
    // 028 AutoExecModel                            ModelClassType ProduceAutoExecModel ProduceAutoExecModel ProduceAutoExecModel Pointer
    // 030 StrategySelectModel                      ModelClassType ProduceStrategySelectModel ProduceStrategySelectModel ProduceStrategySelectModel Pointer
    // 038 ScheduleSelectionAIModel                 ModelClassType ScheduleSelectionAIModel ScheduleSelectionAIModel ScheduleSelectionAIModel Pointer
    // 040 CardSelectModel                          ModelClassType CardSeceltModel CardSeceltModel CardSeceltModel Pointer
    // 048 SelectSupportSkillModel                  ModelClassType SelectSupportSkill SelectSupportSkill SelectSupportSkill Pointer
    // 050 AutoInGameModel                          ModelClassType AutoIngameModel AutoIngameModel AutoIngameModel Pointer
    // 058 UnitCommunityModel                       ModelClassType UnitCommunityModel UnitCommunityModel UnitCommunityModel Pointer
    // 060 SubSeasonSelectModel                     ModelClassType SubSeasonSelectModel SubSeasonSelectModel SubSeasonSelectModel Pointer
    // 068 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 070 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 078 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 080 SeasonViewModels                         ModelClassListType List`1<ProduceAutoOneSeasonViewModel> List`1<ProduceAutoOneSeasonViewModel> List<ProduceAutoOneSeasonViewModel> Pointer
    // 088 IsUseAuto                                ModelPrimitiveType bool bool bool Bool
    // 08C LastNextOrder                            ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32
    // 090 LastProduceBaseInfo                      ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 098 OptionSaveData                           ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    // 0A0 IsExecLastWeekSchedule                   ModelPrimitiveType bool bool bool Bool
    // 0A1 IsShowReady                              ModelPrimitiveType bool bool bool Bool
    // 0A2 IsExecEnd                                ModelPrimitiveType bool bool bool Bool
    public partial class ProduceAutoResultPopupPresenter : DataModel
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
        public IResourceLoader?                         ResourceLoader                          { get; set; }
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
            var value   = new ProduceAutoResultPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceAutoResultPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceAutoResultPopupView.FromPointer); // 0x10 View                        ( ModelClassType IProduceAutoResultPopupView IProduceAutoResultPopupView IProduceAutoResultPopupView Pointer )
            value.ViewModel                                 = GetObject<ProduceAutoResultPopupViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoResultPopupViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel ProduceAutoResultPopupViewModel Pointer )
            value.SettingModel                              = GetObject<ProduceAutoSettingModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceAutoSettingModel.FromPointer); // 0x20 SettingModel                ( ModelClassType ProduceAutoSettingModel ProduceAutoSettingModel ProduceAutoSettingModel Pointer )
            value.AutoExecModel                             = GetObject<ProduceAutoExecModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceAutoExecModel.FromPointer); // 0x28 AutoExecModel               ( ModelClassType ProduceAutoExecModel ProduceAutoExecModel ProduceAutoExecModel Pointer )
            value.StrategySelectModel                       = GetObject<ProduceStrategySelectModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceStrategySelectModel.FromPointer); // 0x30 StrategySelectModel         ( ModelClassType ProduceStrategySelectModel ProduceStrategySelectModel ProduceStrategySelectModel Pointer )
            value.ScheduleSelectionAIModel                  = GetObject<ScheduleSelectionAIModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionAIModel.FromPointer); // 0x38 ScheduleSelectionAIModel    ( ModelClassType ScheduleSelectionAIModel ScheduleSelectionAIModel ScheduleSelectionAIModel Pointer )
            value.CardSelectModel                           = GetObject<CardSeceltModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.CardSeceltModel.FromPointer); // 0x40 CardSelectModel             ( ModelClassType CardSeceltModel CardSeceltModel CardSeceltModel Pointer )
            value.SelectSupportSkillModel                   = GetObject<SelectSupportSkill>(new IntPtr(p + 0x048), ReversePrism.DataModels.SelectSupportSkill.FromPointer); // 0x48 SelectSupportSkillModel     ( ModelClassType SelectSupportSkill SelectSupportSkill SelectSupportSkill Pointer )
            value.AutoInGameModel                           = GetObject<AutoIngameModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.AutoIngameModel.FromPointer); // 0x50 AutoInGameModel             ( ModelClassType AutoIngameModel AutoIngameModel AutoIngameModel Pointer )
            value.UnitCommunityModel                        = GetObject<UnitCommunityModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.UnitCommunityModel.FromPointer); // 0x58 UnitCommunityModel          ( ModelClassType UnitCommunityModel UnitCommunityModel UnitCommunityModel Pointer )
            value.SubSeasonSelectModel                      = GetObject<SubSeasonSelectModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.SubSeasonSelectModel.FromPointer); // 0x60 SubSeasonSelectModel        ( ModelClassType SubSeasonSelectModel SubSeasonSelectModel SubSeasonSelectModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x68 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x70 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x78 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.SeasonViewModels                          = GetObjectList<ProduceAutoOneSeasonViewModel>(new IntPtr(p + 0x080), ReversePrism.DataModels.ProduceAutoOneSeasonViewModel.FromPointer); // 0x80 SeasonViewModels            ( ModelClassListType List`1<ProduceAutoOneSeasonViewModel> List`1<ProduceAutoOneSeasonViewModel> List<ProduceAutoOneSeasonViewModel> Pointer )
            value.IsUseAuto                                 = GetBool(new IntPtr(p + 0x088)); // 0x88 IsUseAuto                   ( ModelPrimitiveType bool bool bool Bool )
            value.LastNextOrder                             = (ProduceNextOrderType)GetInt32(new IntPtr(p + 0x08C)); // 0x8C LastNextOrder               ( ModelEnumType ProduceNextOrderType ProduceNextOrderType ProduceNextOrderType Int32 )
            value.LastProduceBaseInfo                       = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0x90 LastProduceBaseInfo         ( ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.OptionSaveData                            = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0x98 OptionSaveData              ( ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )
            value.IsExecLastWeekSchedule                    = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 IsExecLastWeekSchedule      ( ModelPrimitiveType bool bool bool Bool )
            value.IsShowReady                               = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 IsShowReady                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsExecEnd                                 = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 IsExecEnd                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
