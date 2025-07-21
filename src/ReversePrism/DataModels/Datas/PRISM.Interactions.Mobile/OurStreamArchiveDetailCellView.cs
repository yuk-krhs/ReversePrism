using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 FavoriteToggle                           ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 098 ArchiveButton                            ModelClassType UIButton UIButton UIButton Pointer
    // 0A0 ArchiveButtonText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A8 DateTextCanvasGroup                      ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0B0 LimitTextCanvasGroup                     ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 0B8 LimitDateLabelText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 LimitDateText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 TimeText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 ChangeStreamerCostumeText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D8 DisplayTime                              ModelPrimitiveType float float float Single
    // 0DC Duration                                 ModelPrimitiveType float float float Single
    // 0E0 Interval                                 ModelPrimitiveType float float float Single
    // 0E8 onClickFavoriteToggleSubject             Subject`1<ValueTuple`2<int, bool>> IL2CPP_TYPE_GENERICINST
    // 0F0 IsTerminate                              ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamArchiveDetailCellView : DataModel
    {
        public ToggleButton?                            FavoriteToggle                          { get; set; }
        public UIButton?                                ArchiveButton                           { get; set; }
        public UITextMeshProUGUI?                       ArchiveButtonText                       { get; set; }
        public CanvasGroup?                             DateTextCanvasGroup                     { get; set; }
        public CanvasGroup?                             LimitTextCanvasGroup                    { get; set; }
        public UITextMeshProUGUI?                       LimitDateLabelText                      { get; set; }
        public UITextMeshProUGUI?                       LimitDateText                           { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }
        public UITextMeshProUGUI?                       ChangeStreamerCostumeText               { get; set; }
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

            value.FavoriteToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x90 FavoriteToggle              ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ArchiveButton                             = GetObject<UIButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.UIButton.FromPointer); // 0x98 ArchiveButton               ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ArchiveButtonText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA0 ArchiveButtonText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateTextCanvasGroup                       = GetObject<CanvasGroup>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xA8 DateTextCanvasGroup         ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LimitTextCanvasGroup                      = GetObject<CanvasGroup>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0xB0 LimitTextCanvasGroup        ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LimitDateLabelText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 LimitDateLabelText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitDateText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 LimitDateText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC8 TimeText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ChangeStreamerCostumeText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xD0 ChangeStreamerCostumeText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 DisplayTime                 ( ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x0DC)); // 0xDC Duration                    ( ModelPrimitiveType float float float Single )
            value.Interval                                  = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 Interval                    ( ModelPrimitiveType float float float Single )
            value.IsTerminate                               = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 IsTerminate                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
