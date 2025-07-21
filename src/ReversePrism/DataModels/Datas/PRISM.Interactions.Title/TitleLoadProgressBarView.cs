using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProgressBar                              ModelClassType Slider Slider Slider Pointer
    // 028 StartingGameText                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 PercentageText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 FadeGroup                                ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 IsFinished                               ModelPrimitiveType bool bool bool Bool
    // 041 IsLoading                                ModelPrimitiveType bool bool bool Bool
    // 044 LastProgress                             ModelPrimitiveType float float float Single
    public partial class TitleLoadProgressBarView : DataModel
    {
        public Slider?                                  ProgressBar                             { get; set; }
        public UITextMeshProUGUI?                       StartingGameText                        { get; set; }
        public UITextMeshProUGUI?                       PercentageText                          { get; set; }
        public CanvasGroup?                             FadeGroup                               { get; set; }
        public bool                                     IsFinished                              { get; set; }
        public bool                                     IsLoading                               { get; set; }
        public float                                    LastProgress                            { get; set; }

        public static TitleLoadProgressBarView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TitleLoadProgressBarView() { Pointer= p0 };

            value.ProgressBar                               = GetObject<Slider>(new IntPtr(p + 0x020), ReversePrism.DataModels.Slider.FromPointer); // 0x20 ProgressBar                 ( ModelClassType Slider Slider Slider Pointer )
            value.StartingGameText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 StartingGameText            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PercentageText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 PercentageText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FadeGroup                                 = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 FadeGroup                   ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.IsFinished                                = GetBool(new IntPtr(p + 0x040)); // 0x40 IsFinished                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsLoading                                 = GetBool(new IntPtr(p + 0x041)); // 0x41 IsLoading                   ( ModelPrimitiveType bool bool bool Bool )
            value.LastProgress                              = GetSingle(new IntPtr(p + 0x044)); // 0x44 LastProgress                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
