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
    // 010 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 ScheduleViewModel                        0001866E2A30 ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer
    // 020 ScheduleModel                            0001866DC3D0 ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer
    // 028 ScheduleView                             000186627780 ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer
    // 030 UnitIdolPresenter                        0001866E0CE0 ModelClassType ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter Pointer
    // 038 LeftBottomAreaPresenter                  0001866D95D0 ModelClassType ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter Pointer
    // 040 LeftWeekPresenter                        0001866DABE0 ModelClassType ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter Pointer
    // 048 ScheduleDetailPresenter                  0001866DEAB0 ModelClassType ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter Pointer
    // 050 ScheduleSelectionDisposables             0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 058 IsNonRingVoice                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C BeforeIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 SelectorFolder                           000186671910 ModelPrimitiveType string string string String
    // 068 CalcInterval                             0001866656B0 ModelPrimitiveType float float float Single
    // 06C VoicePlayCounter                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 RandomVoicePlayIntervalMilliSecond       0001866656B0 ModelPrimitiveType float float float Single
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

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 024666694920 0x10 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ScheduleViewModel                         = GetObject<ScheduleSelectionViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ScheduleSelectionViewModel.FromPointer); // 024666694940 0x18 ScheduleViewModel           ( 0001866E2A30 ModelClassType ScheduleSelectionViewModel ScheduleSelectionViewModel ScheduleSelectionViewModel Pointer )
            value.ScheduleModel                             = GetObject<ScheduleSelectionModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleSelectionModel.FromPointer); // 024666694960 0x20 ScheduleModel               ( 0001866DC3D0 ModelClassType ScheduleSelectionModel ScheduleSelectionModel ScheduleSelectionModel Pointer )
            value.ScheduleView                              = GetObject<IScheduleSelectionView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IScheduleSelectionView.FromPointer); // 024666694980 0x28 ScheduleView                ( 000186627780 ModelClassType IScheduleSelectionView IScheduleSelectionView IScheduleSelectionView Pointer )
            value.UnitIdolPresenter                         = GetObject<ScheduleSelectionUnitIdolPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleSelectionUnitIdolPresenter.FromPointer); // 0246666949A0 0x30 UnitIdolPresenter           ( 0001866E0CE0 ModelClassType ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter ScheduleSelectionUnitIdolPresenter Pointer )
            value.LeftBottomAreaPresenter                   = GetObject<ScheduleSelectionLeftBottomAreaPresenter>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionLeftBottomAreaPresenter.FromPointer); // 0246666949C0 0x38 LeftBottomAreaPresenter     ( 0001866D95D0 ModelClassType ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter ScheduleSelectionLeftBottomAreaPresenter Pointer )
            value.LeftWeekPresenter                         = GetObject<ScheduleSelectionLeftWeekPresenter>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScheduleSelectionLeftWeekPresenter.FromPointer); // 0246666949E0 0x40 LeftWeekPresenter           ( 0001866DABE0 ModelClassType ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter ScheduleSelectionLeftWeekPresenter Pointer )
            value.ScheduleDetailPresenter                   = GetObject<ScheduleSelectionScheduleDetailPresenter>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScheduleSelectionScheduleDetailPresenter.FromPointer); // 024666694A00 0x48 ScheduleDetailPresenter     ( 0001866DEAB0 ModelClassType ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter ScheduleSelectionScheduleDetailPresenter Pointer )
            value.ScheduleSelectionDisposables              = GetObject<CompositeDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024666694A20 0x50 ScheduleSelectionDisposables ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsNonRingVoice                            = GetBool(new IntPtr(p + 0x058)); // 024666694A40 0x58 IsNonRingVoice              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BeforeIndex                               = GetInt32(new IntPtr(p + 0x05C)); // 024666694A60 0x5C BeforeIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SelectorFolder                            = GetString(new IntPtr(p + 0x060)); // 024666694A80 0x60 SelectorFolder              ( 000186671910 ModelPrimitiveType string string string String )
            value.CalcInterval                              = GetSingle(new IntPtr(p + 0x068)); // 024666694AA0 0x68 CalcInterval                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.VoicePlayCounter                          = GetInt32(new IntPtr(p + 0x06C)); // 024666694AC0 0x6C VoicePlayCounter            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RandomVoicePlayIntervalMilliSecond        = GetSingle(new IntPtr(p + 0x070)); // 024666694AE0 0x70 RandomVoicePlayIntervalMilliSecond ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
