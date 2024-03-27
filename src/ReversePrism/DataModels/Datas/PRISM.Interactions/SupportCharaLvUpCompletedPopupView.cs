using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SCharaIconRectView                       0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 TxtAlias                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtBeforeLv                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtAfterLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SupportEffectView                        0001865F25A0 ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer
    // 050 LvUpParticleRenderers                    000185CA0CE8 ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDetail                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 CueSheetName                             000186671910 ModelPrimitiveType string string string String
    // 070 CueName                                  000186671910 ModelPrimitiveType string string string String
    // 078 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SupportCharaLvUpCompletedPopupView
    {
        public SCharaIconRectView?                      SCharaIconRectView                      { get; set; }
        public UITextMeshProUGUI?                       TxtAlias                                { get; set; }
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeLv                             { get; set; }
        public UITextMeshProUGUI?                       TxtAfterLv                              { get; set; }
        public SupportEffectView?                       SupportEffectView                       { get; set; }
        public List<Renderer>?                          LvUpParticleRenderers                   { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SupportCharaLvUpCompletedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaLvUpCompletedPopupView();

            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0270DA3408A0 0x20 SCharaIconRectView          ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3408C0 0x28 TxtAlias                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA3408E0 0x30 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA340900 0x38 TxtBeforeLv                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA340920 0x40 TxtAfterLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportEffectView                         = GetObject<SupportEffectView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportEffectView.FromPointer); // 0270DA340940 0x48 SupportEffectView           ( 0001865F25A0 ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer )
            value.LvUpParticleRenderers                     = GetObjectList<Renderer>(new IntPtr(p + 0x050), ReversePrism.DataModels.Renderer.FromPointer); // 0270DA340960 0x50 LvUpParticleRenderers       ( 000185CA0CE8 ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x068)); // 0270DA3409C0 0x68 CueSheetName                ( 000186671910 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x070)); // 0270DA3409E0 0x70 CueName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA340A00 0x78 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
