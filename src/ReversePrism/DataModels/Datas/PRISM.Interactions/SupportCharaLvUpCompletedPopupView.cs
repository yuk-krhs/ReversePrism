using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SCharaIconRectView                       ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 028 TxtAlias                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtBeforeLv                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtAfterLv                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SupportEffectView                        ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer
    // 050 LvUpParticleRenderers                    ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDetail                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 CueSheetName                             ModelPrimitiveType string string string String
    // 070 CueName                                  ModelPrimitiveType string string string String
    // 078 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SupportCharaLvUpCompletedPopupView : DataModel
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
            var value   = new SupportCharaLvUpCompletedPopupView() { Pointer= p0 };

            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x20 SCharaIconRectView          ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.TxtAlias                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtAlias                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtBeforeLv                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtAfterLv                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SupportEffectView                         = GetObject<SupportEffectView>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportEffectView.FromPointer); // 0x48 SupportEffectView           ( ModelClassType SupportEffectView SupportEffectView SupportEffectView Pointer )
            value.LvUpParticleRenderers                     = GetObjectList<Renderer>(new IntPtr(p + 0x050), ReversePrism.DataModels.Renderer.FromPointer); // 0x50 LvUpParticleRenderers       ( ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x068)); // 0x68 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x070)); // 0x70 CueName                     ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x78 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
