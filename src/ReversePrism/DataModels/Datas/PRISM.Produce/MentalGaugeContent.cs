using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GaugeParts                               000185CBEE18 ModelClassListType GaugeParts[] GaugeParts[] List<GaugeParts> Pointer
    // 028 PinchIcon                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 PinchEffectArea                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 PinchLine                                000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 PinchLineText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SafeLineArea                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 SafeIcon                                 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 SafeText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 GaugeAnimators                           000185B701C0 ModelClassListType Animator[] Animator[] List<Animator> Pointer
    // 068 CurState                                 0001866033D0 ModelEnumType MentalState MentalState MentalState Int32
    // 070 CurGaugeParts                            00018670F220 ModelClassType GaugeParts GaugeParts GaugeParts Pointer
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

        public static MentalGaugeContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MentalGaugeContent() { Pointer= p0 };

            value.GaugeParts                                = GetObjectList<GaugeParts>(new IntPtr(p + 0x020), ReversePrism.DataModels.GaugeParts.FromPointer); // 024665C39E18 0x20 GaugeParts                  ( 000185CBEE18 ModelClassListType GaugeParts[] GaugeParts[] List<GaugeParts> Pointer )
            value.PinchIcon                                 = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665C39E38 0x28 PinchIcon                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PinchEffectArea                           = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 024665C39E58 0x30 PinchEffectArea             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PinchLine                                 = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 024665C39E78 0x38 PinchLine                   ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.PinchLineText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C39E98 0x40 PinchLineText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SafeLineArea                              = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 024665C39EB8 0x48 SafeLineArea                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SafeIcon                                  = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 024665C39ED8 0x50 SafeIcon                    ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.SafeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665C39EF8 0x58 SafeText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GaugeAnimators                            = GetObjectList<Animator>(new IntPtr(p + 0x060), ReversePrism.DataModels.Animator.FromPointer); // 024665C39F18 0x60 GaugeAnimators              ( 000185B701C0 ModelClassListType Animator[] Animator[] List<Animator> Pointer )
            value.CurState                                  = (MentalState)GetInt32(new IntPtr(p + 0x068)); // 024665C39F38 0x68 CurState                    ( 0001866033D0 ModelEnumType MentalState MentalState MentalState Int32 )
            value.CurGaugeParts                             = GetObject<GaugeParts>(new IntPtr(p + 0x070), ReversePrism.DataModels.GaugeParts.FromPointer); // 024665C39F58 0x70 CurGaugeParts               ( 00018670F220 ModelClassType GaugeParts GaugeParts GaugeParts Pointer )

            return value;
        }
    }
}
