using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ValueGauge                               0001866CD000 ModelClassType Image Image Image Pointer
    // 028 ValueText                                0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ValueUpGauge                             0001866CD000 ModelClassType Image Image Image Pointer
    // 038 ValueDownGauge                           0001866CD000 ModelClassType Image Image Image Pointer
    // 040 ValueUpDownTextArea                      000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 ValueUpText                              0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ValueDownText                            0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 060 GaugeEffect                              000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 GaugeEffectOffset                        000186665B50 ModelPrimitiveType float float float Single
    // 06C AnimationSpeed                           0001866656B0 ModelPrimitiveType float float float Single
    // 070 Tweener                                  0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer
    public partial class InGameGaugeBase
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
            var value   = new InGameGaugeBase();

            value.ValueGauge                                = GetObject<Image>(new IntPtr(p + 0x020), ReversePrism.DataModels.Image.FromPointer); // 0270D5AC5700 0x20 ValueGauge                  ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.ValueText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5AC5720 0x28 ValueText                   ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueUpGauge                              = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270D5AC5740 0x30 ValueUpGauge                ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.ValueDownGauge                            = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0270D5AC5760 0x38 ValueDownGauge              ( 0001866CD000 ModelClassType Image Image Image Pointer )
            value.ValueUpDownTextArea                       = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5AC5780 0x40 ValueUpDownTextArea         ( 000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.ValueUpText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5AC57A0 0x48 ValueUpText                 ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValueDownText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5AC57C0 0x50 ValueDownText               ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x058), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5AC57E0 0x58 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.GaugeEffect                               = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5AC5800 0x60 GaugeEffect                 ( 000186630680 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.GaugeEffectOffset                         = GetSingle(new IntPtr(p + 0x068)); // 0270D5AC5820 0x68 GaugeEffectOffset           ( 000186665B50 ModelPrimitiveType float float float Single )
            value.AnimationSpeed                            = GetSingle(new IntPtr(p + 0x06C)); // 0270D5AC5840 0x6C AnimationSpeed              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Tweener                                   = GetObject<Tweener>(new IntPtr(p + 0x070), ReversePrism.DataModels.Tweener.FromPointer); // 0270D5AC5860 0x70 Tweener                     ( 0001866C3DE0 ModelClassType Tweener Tweener Tweener Pointer )

            return value;
        }
    }
}
