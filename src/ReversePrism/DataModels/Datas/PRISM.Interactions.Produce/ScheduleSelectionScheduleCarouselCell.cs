using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 CellRectTransform                        ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 BackgroundImage                          ModelClassType UIImage UIImage UIImage Pointer
    // 050 BackgroundGradation                      ModelClassType GameObject GameObject GameObject Pointer
    // 058 TimeValueText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TimeUnitText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 PanelGroup                               ModelClassType ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup Pointer
    // 070 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    // 078 CellData                                 ModelClassType ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData Pointer
    public partial class ScheduleSelectionScheduleCarouselCell : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public RectTransform?                           CellRectTransform                       { get; set; }
        public UIImage?                                 BackgroundImage                         { get; set; }
        public GameObject?                              BackgroundGradation                     { get; set; }
        public UITextMeshProUGUI?                       TimeValueText                           { get; set; }
        public UITextMeshProUGUI?                       TimeUnitText                            { get; set; }
        public ScheduleSelectionPanelGroup?             PanelGroup                              { get; set; }
        public IDisposable?                             Disposable                              { get; set; }
        public ScheduleSelectionScheduleCarouselCellData? CellData                                { get; set; }

        public static ScheduleSelectionScheduleCarouselCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionScheduleCarouselCell() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CellRectTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 CellRectTransform           ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BackgroundImage                           = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 0x48 BackgroundImage             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.BackgroundGradation                       = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 BackgroundGradation         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TimeValueText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 TimeValueText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TimeUnitText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 TimeUnitText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PanelGroup                                = GetObject<ScheduleSelectionPanelGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScheduleSelectionPanelGroup.FromPointer); // 0x68 PanelGroup                  ( ModelClassType ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 0x70 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CellData                                  = GetObject<ScheduleSelectionScheduleCarouselCellData>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScheduleSelectionScheduleCarouselCellData.FromPointer); // 0x78 CellData                    ( ModelClassType ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData Pointer )

            return value;
        }
    }
}
