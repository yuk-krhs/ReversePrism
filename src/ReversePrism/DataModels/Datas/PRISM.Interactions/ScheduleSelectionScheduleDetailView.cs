using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TouchBleckObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 TouchBleckCanvas                         00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer
    // 030 Scroller                                 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer
    // 038 Carousel                                 0001866DBA90 ModelClassType ScheduleSelectionListCarousel ScheduleSelectionListCarousel ScheduleSelectionListCarousel Pointer
    // 040 IndicatorObjectList                      000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 048 IndicatorOnObjectList                    000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 050 IndicatorOffObjectList                   000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 058 DetailDisplayCanvasGroup                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 060 FinishWorkTutorialSequence               0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 068 SafeAreaRoot                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 ScheduleDetailViewModel                  0001866DF950 ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer
    // 078 WeekSscheduleDetailList                  000185CE86C8 ModelClassListType List`1<IScheduleStatus> List`1<IScheduleStatus> List<IScheduleStatus> Pointer
    // 080 onClickScheduleExecute                   Subject`1<IScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 088 onClickScheduleCancel                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onCallBlackActive                        Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 098 onClickDetailScheduleCancel              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onClickDetailScheduleExecute             Subject`1<IScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 0A8 onActivateCanvasGroup                    Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0B0 onClickRightButton                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B8 onClickLeftButton                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0C0 onScheduleDetailContent                  Subject`1<ScheduleDetailContent> IL2CPP_TYPE_GENERICINST
    // 0C8 OnEndLoad                                0001866792B0 ModelClassType Action Action Action Pointer
    // 0D0 onNotifyAudition                         Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0D8 CacheScheduleDetailContent               0001866D1FB0 ModelClassType ScheduleDetailContent ScheduleDetailContent ScheduleDetailContent Pointer
    // 0E0 IsAudition                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E4 LoadCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0E8 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ScheduleSelectionScheduleDetailView
    {
        public GameObject?                              TouchBleckObject                        { get; set; }
        public Canvas?                                  TouchBleckCanvas                        { get; set; }
        public Scroller?                                Scroller                                { get; set; }
        public ScheduleSelectionListCarousel?           Carousel                                { get; set; }
        public List<GameObject>?                        IndicatorObjectList                     { get; set; }
        public List<GameObject>?                        IndicatorOnObjectList                   { get; set; }
        public List<GameObject>?                        IndicatorOffObjectList                  { get; set; }
        public CanvasGroup?                             DetailDisplayCanvasGroup                { get; set; }
        public ITutorialSequence?                       FinishWorkTutorialSequence              { get; set; }
        public RectTransform?                           SafeAreaRoot                            { get; set; }
        public ScheduleSelectionScheduleDetailViewModel? ScheduleDetailViewModel                 { get; set; }
        public List<IScheduleStatus>?                   WeekSscheduleDetailList                 { get; set; }
        public Action?                                  OnEndLoad                               { get; set; }
        public ScheduleDetailContent?                   CacheScheduleDetailContent              { get; set; }
        public bool                                     IsAudition                              { get; set; }
        public int                                      LoadCount                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static ScheduleSelectionScheduleDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleDetailView();

            value.TouchBleckObject                          = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA190060 0x20 TouchBleckObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TouchBleckCanvas                          = GetObject<Canvas>(new IntPtr(p + 0x028), ReversePrism.DataModels.Canvas.FromPointer); // 0270DA190080 0x28 TouchBleckCanvas            ( 00018653FDA0 ModelClassType Canvas Canvas Canvas Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.Scroller.FromPointer); // 0270DA1900A0 0x30 Scroller                    ( 0001866FAE60 ModelClassType Scroller Scroller Scroller Pointer )
            value.Carousel                                  = GetObject<ScheduleSelectionListCarousel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionListCarousel.FromPointer); // 0270DA1900C0 0x38 Carousel                    ( 0001866DBA90 ModelClassType ScheduleSelectionListCarousel ScheduleSelectionListCarousel ScheduleSelectionListCarousel Pointer )
            value.IndicatorObjectList                       = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1900E0 0x40 IndicatorObjectList         ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.IndicatorOnObjectList                     = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA190100 0x48 IndicatorOnObjectList       ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.IndicatorOffObjectList                    = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA190120 0x50 IndicatorOffObjectList      ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.DetailDisplayCanvasGroup                  = GetObject<CanvasGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA190140 0x58 DetailDisplayCanvasGroup    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FinishWorkTutorialSequence                = GetObject<ITutorialSequence>(new IntPtr(p + 0x060), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0270DA190160 0x60 FinishWorkTutorialSequence  ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA190180 0x68 SafeAreaRoot                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScheduleDetailViewModel                   = GetObject<ScheduleSelectionScheduleDetailViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScheduleSelectionScheduleDetailViewModel.FromPointer); // 0270DA1901A0 0x70 ScheduleDetailViewModel     ( 0001866DF950 ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer )
            value.WeekSscheduleDetailList                   = GetObjectList<IScheduleStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 0270DA1901C0 0x78 WeekSscheduleDetailList     ( 000185CE86C8 ModelClassListType List`1<IScheduleStatus> List`1<IScheduleStatus> List<IScheduleStatus> Pointer )
            value.OnEndLoad                                 = GetObject<Action>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Action.FromPointer); // 0270DA190300 0xC8 OnEndLoad                   ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.CacheScheduleDetailContent                = GetObject<ScheduleDetailContent>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ScheduleDetailContent.FromPointer); // 0270DA190340 0xD8 CacheScheduleDetailContent  ( 0001866D1FB0 ModelClassType ScheduleDetailContent ScheduleDetailContent ScheduleDetailContent Pointer )
            value.IsAudition                                = GetBool(new IntPtr(p + 0x0E0)); // 0270DA190360 0xE0 IsAudition                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LoadCount                                 = GetInt32(new IntPtr(p + 0x0E4)); // 0270DA190380 0xE4 LoadCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA1903A0 0xE8 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
