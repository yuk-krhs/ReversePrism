using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 028 FavoriteToggle                           ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 ThumbnailImage                           ModelClassType UIImage UIImage UIImage Pointer
    // 038 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TimeText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 DateCanvasGroup                          ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 DateLabelText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 DateText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 LimitDateCanvasGroup                     ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 LimitDateLabelText                       ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 LimitDateText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 DisplayTime                              ModelPrimitiveType float float float Single
    // 07C Duration                                 ModelPrimitiveType float float float Single
    // 080 Interval                                 ModelPrimitiveType float float float Single
    // 088 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 090 IsTerminate                              ModelPrimitiveType bool bool bool Bool
    // 098 CtsFade                                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class OurStreamArchiveCellView : DataModel
    {
        public UIButton?                                CellButton                              { get; set; }
        public ToggleButton?                            FavoriteToggle                          { get; set; }
        public UIImage?                                 ThumbnailImage                          { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }
        public CanvasGroup?                             DateCanvasGroup                         { get; set; }
        public UITextMeshProUGUI?                       DateLabelText                           { get; set; }
        public UITextMeshProUGUI?                       DateText                                { get; set; }
        public CanvasGroup?                             LimitDateCanvasGroup                    { get; set; }
        public UITextMeshProUGUI?                       LimitDateLabelText                      { get; set; }
        public UITextMeshProUGUI?                       LimitDateText                           { get; set; }
        public float                                    DisplayTime                             { get; set; }
        public float                                    Duration                                { get; set; }
        public float                                    Interval                                { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public bool                                     IsTerminate                             { get; set; }
        public CancellationTokenSource?                 CtsFade                                 { get; set; }

        public static OurStreamArchiveCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveCellView() { Pointer= p0 };

            value.CellButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 CellButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.FavoriteToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x28 FavoriteToggle              ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 0x30 ThumbnailImage              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TimeText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x48 DateCanvasGroup             ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.DateLabelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 DateLabelText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 DateText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitDateCanvasGroup                      = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x60 LimitDateCanvasGroup        ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LimitDateLabelText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 LimitDateLabelText          ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitDateText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 LimitDateText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x078)); // 0x78 DisplayTime                 ( ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x07C)); // 0x7C Duration                    ( ModelPrimitiveType float float float Single )
            value.Interval                                  = GetSingle(new IntPtr(p + 0x080)); // 0x80 Interval                    ( ModelPrimitiveType float float float Single )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x088), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x88 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.IsTerminate                               = GetBool(new IntPtr(p + 0x090)); // 0x90 IsTerminate                 ( ModelPrimitiveType bool bool bool Bool )
            value.CtsFade                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x098), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x98 CtsFade                     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
