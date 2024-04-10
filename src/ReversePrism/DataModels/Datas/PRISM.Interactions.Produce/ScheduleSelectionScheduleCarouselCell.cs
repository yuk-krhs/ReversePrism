using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 CellRectTransform                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 BackgroundImage                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 050 BackgroundGradation                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 TimeValueText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 TimeUnitText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 PanelGroup                               0001866DC8D0 ModelClassType ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup Pointer
    // 070 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 078 CellData                                 0001866DD9B0 ModelClassType ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData Pointer
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

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A27F758 0x38 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CellRectTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A27F778 0x40 CellRectTransform           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BackgroundImage                           = GetObject<UIImage>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIImage.FromPointer); // 02466A27F798 0x48 BackgroundImage             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.BackgroundGradation                       = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 02466A27F7B8 0x50 BackgroundGradation         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TimeValueText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A27F7D8 0x58 TimeValueText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TimeUnitText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A27F7F8 0x60 TimeUnitText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PanelGroup                                = GetObject<ScheduleSelectionPanelGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.ScheduleSelectionPanelGroup.FromPointer); // 02466A27F818 0x68 PanelGroup                  ( 0001866DC8D0 ModelClassType ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup ScheduleSelectionPanelGroup Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x070), ReversePrism.DataModels.IDisposable.FromPointer); // 02466A27F838 0x70 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.CellData                                  = GetObject<ScheduleSelectionScheduleCarouselCellData>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScheduleSelectionScheduleCarouselCellData.FromPointer); // 02466A27F858 0x78 CellData                    ( 0001866DD9B0 ModelClassType ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData ScheduleSelectionScheduleCarouselCellData Pointer )

            return value;
        }
    }
}
