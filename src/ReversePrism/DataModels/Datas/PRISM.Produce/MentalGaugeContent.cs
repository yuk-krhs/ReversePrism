using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GaugeParts                               ModelClassListType GaugeParts[] GaugeParts[] List<GaugeParts> Pointer
    // 028 PinchIcon                                ModelClassType GameObject GameObject GameObject Pointer
    // 030 PinchEffectArea                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 PinchLine                                ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 PinchLineText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SafeLineArea                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 SafeIcon                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 SafeText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GaugeAnimators                           ModelClassListType Animator[] Animator[] List<Animator> Pointer
    // 068 CurState                                 ModelEnumType MentalState MentalState MentalState Int32
    // 070 CurGaugeParts                            ModelClassType GaugeParts GaugeParts GaugeParts Pointer
    // 078 IsAnimationMental                        ModelPrimitiveType bool bool bool Bool
    // 080 MentalAnimDataList                       ModelClassListType List`1<MentalAnimationData> List`1<MentalAnimationData> List<MentalAnimationData> Pointer
    public partial class MentalGaugeContent : DataModel
    {
        public List<GaugeParts>?                        GaugeParts                              { get; set; }
        public GameObject?                              PinchIcon                               { get; set; }
        public RectTransform?                           PinchEffectArea                         { get; set; }
        public RectTransform?                           PinchLine                               { get; set; }
        public UITextMeshProUGUI?                       PinchLineText                           { get; set; }
        public RectTransform?                           SafeLineArea                            { get; set; }
        public RectTransform?                           SafeIcon                                { get; set; }
        public UITextMeshProUGUI?                       SafeText                                { get; set; }
        public List<Animator>?                          GaugeAnimators                          { get; set; }
        public MentalState                              CurState                                { get; set; }
        public GaugeParts?                              CurGaugeParts                           { get; set; }
        public bool                                     IsAnimationMental                       { get; set; }
        public List<MentalAnimationData>?               MentalAnimDataList                      { get; set; }

        public static MentalGaugeContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MentalGaugeContent() { Pointer= p0 };

            value.GaugeParts                                = GetObjectList<GaugeParts>(new IntPtr(p + 0x020), ReversePrism.DataModels.GaugeParts.FromPointer); // 0x20 GaugeParts                  ( ModelClassListType GaugeParts[] GaugeParts[] List<GaugeParts> Pointer )
            value.PinchIcon                                 = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 PinchIcon                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PinchEffectArea                           = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 PinchEffectArea             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PinchLine                                 = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 PinchLine                   ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PinchLineText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 PinchLineText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SafeLineArea                              = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 SafeLineArea                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SafeIcon                                  = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0x50 SafeIcon                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SafeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 SafeText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GaugeAnimators                            = GetObjectList<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 0x60 GaugeAnimators              ( ModelClassListType Animator[] Animator[] List<Animator> Pointer )
            value.CurState                                  = (MentalState)GetInt32(new IntPtr(p + 0x068)); // 0x68 CurState                    ( ModelEnumType MentalState MentalState MentalState Int32 )
            value.CurGaugeParts                             = GetObject<GaugeParts>(new IntPtr(p + 0x070), ReversePrism.DataModels.GaugeParts.FromPointer); // 0x70 CurGaugeParts               ( ModelClassType GaugeParts GaugeParts GaugeParts Pointer )
            value.IsAnimationMental                         = GetBool(new IntPtr(p + 0x078)); // 0x78 IsAnimationMental           ( ModelPrimitiveType bool bool bool Bool )
            value.MentalAnimDataList                        = GetObjectList<MentalAnimationData>(new IntPtr(p + 0x080), ReversePrism.DataModels.MentalAnimationData.FromPointer); // 0x80 MentalAnimDataList          ( ModelClassListType List`1<MentalAnimationData> List`1<MentalAnimationData> List<MentalAnimationData> Pointer )

            return value;
        }
    }
}
