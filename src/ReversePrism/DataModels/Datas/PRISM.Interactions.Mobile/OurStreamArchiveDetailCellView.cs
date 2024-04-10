using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 088 FavoriteToggle                           000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 090 ArchiveButton                            0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 098 ArchivePModeButton                       0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 ArchiveButtonText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 ArchivePModeButtonText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 DateTextCanvasGroup                      000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0B8 LimitTextCanvasGroup                     000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0C0 LimitDateLabelText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 LimitDateText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 TimeText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D8 DisplayTime                              0001866656B0 ModelPrimitiveType float float float Single
    // 0DC Duration                                 0001866656B0 ModelPrimitiveType float float float Single
    // 0E0 Interval                                 0001866656B0 ModelPrimitiveType float float float Single
    // 0E8 onClickFavoriteToggleSubject             Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 0F0 IsTerminate                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamArchiveDetailCellView : DataModel
    {
        public ToggleButton?                            FavoriteToggle                          { get; set; }
        public UIButton?                                ArchiveButton                           { get; set; }
        public UIButton?                                ArchivePModeButton                      { get; set; }
        public UITextMeshProUGUI?                       ArchiveButtonText                       { get; set; }
        public UITextMeshProUGUI?                       ArchivePModeButtonText                  { get; set; }
        public CanvasGroup?                             DateTextCanvasGroup                     { get; set; }
        public CanvasGroup?                             LimitTextCanvasGroup                    { get; set; }
        public UITextMeshProUGUI?                       LimitDateLabelText                      { get; set; }
        public UITextMeshProUGUI?                       LimitDateText                           { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }
        public float                                    DisplayTime                             { get; set; }
        public float                                    Duration                                { get; set; }
        public float                                    Interval                                { get; set; }
        public bool                                     IsTerminate                             { get; set; }

        public static OurStreamArchiveDetailCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveDetailCellView() { Pointer= p0 };

            value.FavoriteToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466B196D00 0x88 FavoriteToggle              ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ArchiveButton                             = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 02466B196D20 0x90 ArchiveButton               ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ArchivePModeButton                        = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 02466B196D40 0x98 ArchivePModeButton          ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ArchiveButtonText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196D60 0xA0 ArchiveButtonText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ArchivePModeButtonText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196D80 0xA8 ArchivePModeButtonText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateTextCanvasGroup                       = GetObject<CanvasGroup>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B196DA0 0xB0 DateTextCanvasGroup         ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LimitTextCanvasGroup                      = GetObject<CanvasGroup>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B196DC0 0xB8 LimitTextCanvasGroup        ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LimitDateLabelText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196DE0 0xC0 LimitDateLabelText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitDateText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196E00 0xC8 LimitDateText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196E20 0xD0 TimeText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x0D8)); // 02466B196E40 0xD8 DisplayTime                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x0DC)); // 02466B196E60 0xDC Duration                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Interval                                  = GetSingle(new IntPtr(p + 0x0E0)); // 02466B196E80 0xE0 Interval                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsTerminate                               = GetBool(new IntPtr(p + 0x0F0)); // 02466B196EC0 0xF0 IsTerminate                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
