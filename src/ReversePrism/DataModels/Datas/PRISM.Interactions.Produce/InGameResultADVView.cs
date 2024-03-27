using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SafeAreaRoot                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 AdvUI                                    000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer
    // 030 InAdvDeactivatedObjectList               000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 VitalityGauge                            00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer
    // 040 ParameterVariationContent                00018671D4D0 ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer
    // 048 SupportEffectDemonstrateUIContent        0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    // 050 GetProduceCardPopupPrefab                000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    // 058 GetSupportSkillPopupPrefab               000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer
    public partial class InGameResultADVView
    {
        public RectTransform?                           SafeAreaRoot                            { get; set; }
        public ADVUI?                                   AdvUI                                   { get; set; }
        public List<GameObject>?                        InAdvDeactivatedObjectList              { get; set; }
        public VitalityGauge?                           VitalityGauge                           { get; set; }
        public ParameterVariationContent?               ParameterVariationContent               { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }
        public PopupContentBase?                        GetProduceCardPopupPrefab               { get; set; }
        public PopupContentBase?                        GetSupportSkillPopupPrefab              { get; set; }

        public static InGameResultADVView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameResultADVView();

            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DA1D35A0 0x20 SafeAreaRoot                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AdvUI                                     = GetObject<ADVUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.ADVUI.FromPointer); // 0270DA1D35C0 0x28 AdvUI                       ( 000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer )
            value.InAdvDeactivatedObjectList                = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1D35E0 0x30 InAdvDeactivatedObjectList  ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.VitalityGauge                             = GetObject<VitalityGauge>(new IntPtr(p + 0x038), ReversePrism.DataModels.VitalityGauge.FromPointer); // 0270DA1D3600 0x38 VitalityGauge               ( 00018652E260 ModelClassType VitalityGauge VitalityGauge VitalityGauge Pointer )
            value.ParameterVariationContent                 = GetObject<ParameterVariationContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParameterVariationContent.FromPointer); // 0270DA1D3620 0x40 ParameterVariationContent   ( 00018671D4D0 ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0270DA1D3640 0x48 SupportEffectDemonstrateUIContent ( 0001865F0A00 ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )
            value.GetProduceCardPopupPrefab                 = GetObject<PopupContentBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA1D3660 0x50 GetProduceCardPopupPrefab   ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )
            value.GetSupportSkillPopupPrefab                = GetObject<PopupContentBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.PopupContentBase.FromPointer); // 0270DA1D3680 0x58 GetSupportSkillPopupPrefab  ( 000186761A40 ModelClassType PopupContentBase PopupContentBase PopupContentBase Pointer )

            return value;
        }
    }
}
