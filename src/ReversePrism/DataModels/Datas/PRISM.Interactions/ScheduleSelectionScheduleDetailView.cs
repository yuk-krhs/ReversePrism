using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TouchBleckObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 028 TouchBleckCanvas                         ModelClassType Canvas Canvas Canvas Pointer
    // 030 Scroller                                 ModelClassType Scroller Scroller Scroller Pointer
    // 038 Carousel                                 ModelClassType ScheduleSelectionListCarousel ScheduleSelectionListCarousel ScheduleSelectionListCarousel Pointer
    // 040 IndicatorObjectList                      ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 048 IndicatorOnObjectList                    ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 050 IndicatorOffObjectList                   ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 058 DetailDisplayCanvasGroup                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 060 FinishWorkTutorialSequence               ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    // 068 SafeAreaRoot                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 070 ScheduleDetailViewModel                  ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer
    // 078 WeekScheduleDetailList                   ModelClassListType IReadOnlyList`1<IScheduleStatus> IReadOnlyList`1<IScheduleStatus> List<IScheduleStatus> Pointer
    // 080 onClickScheduleExecute                   Subject`1<IScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 088 onClickScheduleCancel                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 090 onCallBlackActive                        Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 098 onClickDetailScheduleCancel              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0A0 onClickDetailScheduleExecute             Subject`1<IScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 0A8 onActivateCanvasGroup                    Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0B0 onClickRightButton                       Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0B8 onClickLeftButton                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0C0 onScheduleDetailContent                  Subject`1<ScheduleDetailContent> IL2CPP_TYPE_GENERICINST
    // 0C8 OnEndLoad                                ModelClassType Action Action Action Pointer
    // 0D0 onNotifyAudition                         Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0D8 CacheScheduleDetailContent               ModelClassType ScheduleDetailContent ScheduleDetailContent ScheduleDetailContent Pointer
    // 0E0 IsAudition                               ModelPrimitiveType bool bool bool Bool
    // 0E4 LoadCount                                ModelPrimitiveType int int int Int32
    // 0E8 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    // 0F0 Model3dLoader                            ModelClassType IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail Pointer
    public partial class ScheduleSelectionScheduleDetailView : DataModel
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
        public List<IScheduleStatus>?                   WeekScheduleDetailList                  { get; set; }
        public Action?                                  OnEndLoad                               { get; set; }
        public ScheduleDetailContent?                   CacheScheduleDetailContent              { get; set; }
        public bool                                     IsAudition                              { get; set; }
        public int                                      LoadCount                               { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IModel3dLoaderForScheduleDetail?         Model3dLoader                           { get; set; }

        public static ScheduleSelectionScheduleDetailView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleDetailView() { Pointer= p0 };

            value.TouchBleckObject                          = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 TouchBleckObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TouchBleckCanvas                          = GetObject<Canvas>(new IntPtr(p + 0x028), ReversePrism.DataModels.Canvas.FromPointer); // 0x28 TouchBleckCanvas            ( ModelClassType Canvas Canvas Canvas Pointer )
            value.Scroller                                  = GetObject<Scroller>(new IntPtr(p + 0x030), ReversePrism.DataModels.Scroller.FromPointer); // 0x30 Scroller                    ( ModelClassType Scroller Scroller Scroller Pointer )
            value.Carousel                                  = GetObject<ScheduleSelectionListCarousel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleSelectionListCarousel.FromPointer); // 0x38 Carousel                    ( ModelClassType ScheduleSelectionListCarousel ScheduleSelectionListCarousel ScheduleSelectionListCarousel Pointer )
            value.IndicatorObjectList                       = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 IndicatorObjectList         ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.IndicatorOnObjectList                     = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 IndicatorOnObjectList       ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.IndicatorOffObjectList                    = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 IndicatorOffObjectList      ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.DetailDisplayCanvasGroup                  = GetObject<CanvasGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x58 DetailDisplayCanvasGroup    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FinishWorkTutorialSequence                = GetObject<ITutorialSequence>(new IntPtr(p + 0x060), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x60 FinishWorkTutorialSequence  ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )
            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0x68 SafeAreaRoot                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ScheduleDetailViewModel                   = GetObject<ScheduleSelectionScheduleDetailViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ScheduleSelectionScheduleDetailViewModel.FromPointer); // 0x70 ScheduleDetailViewModel     ( ModelClassType ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel ScheduleSelectionScheduleDetailViewModel Pointer )
            value.WeekScheduleDetailList                    = GetObjectList<IScheduleStatus>(new IntPtr(p + 0x078), ReversePrism.DataModels.IScheduleStatus.FromPointer); // 0x78 WeekScheduleDetailList      ( ModelClassListType IReadOnlyList`1<IScheduleStatus> IReadOnlyList`1<IScheduleStatus> List<IScheduleStatus> Pointer )
            value.OnEndLoad                                 = GetObject<Action>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Action.FromPointer); // 0xC8 OnEndLoad                   ( ModelClassType Action Action Action Pointer )
            value.CacheScheduleDetailContent                = GetObject<ScheduleDetailContent>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ScheduleDetailContent.FromPointer); // 0xD8 CacheScheduleDetailContent  ( ModelClassType ScheduleDetailContent ScheduleDetailContent ScheduleDetailContent Pointer )
            value.IsAudition                                = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 IsAudition                  ( ModelPrimitiveType bool bool bool Bool )
            value.LoadCount                                 = GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 LoadCount                   ( ModelPrimitiveType int int int Int32 )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xE8 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Model3dLoader                             = GetObject<IModel3dLoaderForScheduleDetail>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IModel3dLoaderForScheduleDetail.FromPointer); // 0xF0 Model3dLoader               ( ModelClassType IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail IModel3dLoaderForScheduleDetail Pointer )

            return value;
        }
    }
}
