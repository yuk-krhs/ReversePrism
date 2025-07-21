using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ValueGauge                               ModelClassType Image Image Image Pointer
    // 028 ValueText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ValueUpGauge                             ModelClassType Image Image Image Pointer
    // 038 ValueDownGauge                           ModelClassType Image Image Image Pointer
    // 040 ValueUpDownTextArea                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 ValueUpText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ValueDownText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 060 GaugeEffect                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 GaugeEffectOffset                        ModelPrimitiveType float float float Single
    // 06C AnimationSpeed                           ModelPrimitiveType float float float Single
    // 070 Tweener                                  ModelClassType Tweener Tweener Tweener Pointer
    public partial class InGameGaugeBase : DataModel
    {
        public Image?                                   ValueGauge                              { get; set; }
        public UITextMeshProUGUI?                       ValueText                               { get; set; }
        public Image?                                   ValueUpGauge                            { get; set; }
        public Image?                                   ValueDownGauge                          { get; set; }
        public RectTransform?                           ValueUpDownTextArea                     { get; set; }
        public UITextMeshProUGUI?                       ValueUpText                             { get; set; }
        public UITextMeshProUGUI?                       ValueDownText                           { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public RectTransform?                           GaugeEffect                             { get; set; }
        public float                                    GaugeEffectOffset                       { get; set; }
        public float                                    AnimationSpeed                          { get; set; }
        public Tweener?                                 Tweener                                 { get; set; }

        public static InGameGaugeBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameGaugeBase() { Pointer= p0 };

            value.ValueGauge                                = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0x20 ValueGauge                  ( ModelClassType Image Image Image Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ValueText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueUpGauge                              = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0x30 ValueUpGauge                ( ModelClassType Image Image Image Pointer )
            value.ValueDownGauge                            = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 ValueDownGauge              ( ModelClassType Image Image Image Pointer )
            value.ValueUpDownTextArea                       = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 ValueUpDownTextArea         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ValueUpText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 ValueUpText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueDownText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 ValueDownText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x058), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x58 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.GaugeEffect                               = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0x60 GaugeEffect                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GaugeEffectOffset                         = GetSingle(new IntPtr(p + 0x068)); // 0x68 GaugeEffectOffset           ( ModelPrimitiveType float float float Single )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x06C)); // 0x6C AnimationSpeed              ( ModelPrimitiveType float float float Single )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x070), ReversePrism.DataModels.Tweener.FromPointer); // 0x70 Tweener                     ( ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
