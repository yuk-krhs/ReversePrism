using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 VoicePlayIntervalMilliSecond             float IL2CPP_TYPE_R4
    // 000 BeforeIntervalAdjustMilliSecond          float IL2CPP_TYPE_R4
    // 010 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 ScheduleViewModel                        ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer
    // 020 ScheduleModel                            ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer
    // 028 ScheduleView                             ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer
    // 030 UnitIdolPresenter                        ModelClassType ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter Pointer
    // 038 LeftBottomAreaPresenter                  ModelClassType ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter Pointer
    // 040 LeftWeekPresenter                        ModelClassType ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter Pointer
    // 048 ScheduleDetailPresenter                  ModelClassType ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter Pointer
    // 050 ScheduleSelectionDisposables             ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 058 IsResumeSequence                         ModelPrimitiveType bool bool bool Bool
    // 059 IsNonRingVoice                           ModelPrimitiveType bool bool bool Bool
    // 05C BeforeIndex                              ModelPrimitiveType int int int Int32
    // 060 SelectorFolder                           ModelPrimitiveType string string string String
    // 068 CalcInterval                             ModelPrimitiveType float float float Single
    // 06C VoicePlayCounter                         ModelPrimitiveType int int int Int32
    // 070 RandomVoicePlayIntervalMilliSecond       ModelPrimitiveType float float float Single
    public partial class ScheduleSelectionPresenter : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public ScheduleSelectionViewModel?              ScheduleViewModel                       { get; set; }
        public ScheduleSelectionModel?                  ScheduleModel                           { get; set; }
        public IScheduleSelectionView?                  ScheduleView                            { get; set; }
        public ScheduleSelectionUnitIdolPresenter?      UnitIdolPresenter                       { get; set; }
        public ScheduleSelectionLeftBottomAreaPresenter? LeftBottomAreaPresenter                 { get; set; }
        public ScheduleSelectionLeftWeekPresenter?      LeftWeekPresenter                       { get; set; }
        public ScheduleSelectionScheduleDetailPresenter? ScheduleDetailPresenter                 { get; set; }
        public CompositeDisposable?                     ScheduleSelectionDisposables            { get; set; }
        public bool                                     IsResumeSequence                        { get; set; }
        public bool                                     IsNonRingVoice                          { get; set; }
        public int                                      BeforeIndex                             { get; set; }
        public string                                   SelectorFolder                          { get; set; }
        public float                                    CalcInterval                            { get; set; }
        public int                                      VoicePlayCounter                        { get; set; }
        public float                                    RandomVoicePlayIntervalMilliSecond      { get; set; }

        public static ScheduleSelectionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionPresenter() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ScheduleViewModel                         = GetObject<ScheduleSelectionViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScheduleSelectionViewModel.FromPointer); // 0x18 ScheduleViewModel           ( ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer )
            value.ScheduleModel                             = GetObject<ScheduleSelectionModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleSelectionModel.FromPointer); // 0x20 ScheduleModel               ( ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer )
            value.ScheduleView                              = GetObject<IScheduleSelectionView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IScheduleSelectionView.FromPointer); // 0x28 ScheduleView                ( ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer )
            value.UnitIdolPresenter                         = GetObject<ScheduleSelectionUnitIdolPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleSelectionUnitIdolPresenter.FromPointer); // 0x30 UnitIdolPresenter           ( ModelClassType ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter Pointer )
            value.LeftBottomAreaPresenter                   = GetObject<ScheduleSelectionLeftBottomAreaPresenter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionLeftBottomAreaPresenter.FromPointer); // 0x38 LeftBottomAreaPresenter     ( ModelClassType ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter Pointer )
            value.LeftWeekPresenter                         = GetObject<ScheduleSelectionLeftWeekPresenter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleSelectionLeftWeekPresenter.FromPointer); // 0x40 LeftWeekPresenter           ( ModelClassType ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter Pointer )
            value.ScheduleDetailPresenter                   = GetObject<ScheduleSelectionScheduleDetailPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScheduleSelectionScheduleDetailPresenter.FromPointer); // 0x48 ScheduleDetailPresenter     ( ModelClassType ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter Pointer )
            value.ScheduleSelectionDisposables              = GetObject<CompositeDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x50 ScheduleSelectionDisposables ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsResumeSequence                          = GetBool(new IntPtr(p + 0x058)); // 0x58 IsResumeSequence            ( ModelPrimitiveType bool bool bool Bool )
            value.IsNonRingVoice                            = GetBool(new IntPtr(p + 0x059)); // 0x59 IsNonRingVoice              ( ModelPrimitiveType bool bool bool Bool )
            value.BeforeIndex                               = GetInt32(new IntPtr(p + 0x05C)); // 0x5C BeforeIndex                 ( ModelPrimitiveType int int int Int32 )
            value.SelectorFolder                            = GetString(new IntPtr(p + 0x060)); // 0x60 SelectorFolder              ( ModelPrimitiveType string string string String )
            value.CalcInterval                              = GetSingle(new IntPtr(p + 0x068)); // 0x68 CalcInterval                ( ModelPrimitiveType float float float Single )
            value.VoicePlayCounter                          = GetInt32(new IntPtr(p + 0x06C)); // 0x6C VoicePlayCounter            ( ModelPrimitiveType int int int Int32 )
            value.RandomVoicePlayIntervalMilliSecond        = GetSingle(new IntPtr(p + 0x070)); // 0x70 RandomVoicePlayIntervalMilliSecond ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
