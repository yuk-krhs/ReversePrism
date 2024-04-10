using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CellButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 FavoriteToggle                           000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 030 ThumbnailImage                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 038 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TimeText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 DateCanvasGroup                          000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 050 DateLabelText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 DateText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 LimitDateCanvasGroup                     000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 068 LimitDateLabelText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 LimitDateText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 DisplayTime                              0001866656B0 ModelPrimitiveType float float float Single
    // 07C Duration                                 0001866656B0 ModelPrimitiveType float float float Single
    // 080 Interval                                 0001866656B0 ModelPrimitiveType float float float Single
    // 088 ResourceLoader                           00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer
    // 090 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 098 IsTerminate                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 CtsFade                                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
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
        public ResourceLoader?                          ResourceLoader                          { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public bool                                     IsTerminate                             { get; set; }
        public CancellationTokenSource?                 CtsFade                                 { get; set; }

        public static OurStreamArchiveCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveCellView() { Pointer= p0 };

            value.CellButton                                = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466B196618 0x20 CellButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.FavoriteToggle                            = GetObject<ToggleButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.ToggleButton.FromPointer); // 02466B196638 0x28 FavoriteToggle              ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.ThumbnailImage                            = GetObject<UIImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIImage.FromPointer); // 02466B196658 0x30 ThumbnailImage              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196678 0x38 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196698 0x40 TimeText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateCanvasGroup                           = GetObject<CanvasGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B1966B8 0x48 DateCanvasGroup             ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.DateLabelText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1966D8 0x50 DateLabelText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B1966F8 0x58 DateText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitDateCanvasGroup                      = GetObject<CanvasGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B196718 0x60 LimitDateCanvasGroup        ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.LimitDateLabelText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196738 0x68 LimitDateLabelText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LimitDateText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B196758 0x70 LimitDateText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DisplayTime                               = GetSingle(new IntPtr(p + 0x078)); // 02466B196778 0x78 DisplayTime                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Duration                                  = GetSingle(new IntPtr(p + 0x07C)); // 02466B196798 0x7C Duration                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Interval                                  = GetSingle(new IntPtr(p + 0x080)); // 02466B1967B8 0x80 Interval                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ResourceLoader                            = GetObject<ResourceLoader>(new IntPtr(p + 0x088), ReversePrism.DataModels.ResourceLoader.FromPointer); // 02466B1967D8 0x88 ResourceLoader              ( 00018666F230 ModelClassType ResourceLoader ResourceLoader ResourceLoader Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x090), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466B1967F8 0x90 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.IsTerminate                               = GetBool(new IntPtr(p + 0x098)); // 02466B196818 0x98 IsTerminate                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CtsFade                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466B196838 0xA0 CtsFade                     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
