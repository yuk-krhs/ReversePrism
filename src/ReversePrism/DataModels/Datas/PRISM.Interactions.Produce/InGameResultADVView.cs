using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SafeAreaRoot                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 AdvUI                                    ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer
    // 030 InAdvDeactivatedObjectList               ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 038 VitalityGauge                            ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer
    // 040 ParameterVariationContent                ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer
    // 048 SupportEffectDemonstrateUIContent        ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer
    public partial class InGameResultADVView : DataModel
    {
        public RectTransform?                           SafeAreaRoot                            { get; set; }
        public AdvScreenView?                           AdvUI                                   { get; set; }
        public List<GameObject>?                        InAdvDeactivatedObjectList              { get; set; }
        public ScheduleVitalityGauge?                   VitalityGauge                           { get; set; }
        public ParameterVariationContent?               ParameterVariationContent               { get; set; }
        public SupportEffectDemonstrateUIContent?       SupportEffectDemonstrateUIContent       { get; set; }

        public static InGameResultADVView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameResultADVView() { Pointer= p0 };

            value.SafeAreaRoot                              = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 SafeAreaRoot                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AdvUI                                     = GetObject<AdvScreenView>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvScreenView.FromPointer); // 0x28 AdvUI                       ( ModelClassType AdvScreenView AdvScreenView AdvScreenView Pointer )
            value.InAdvDeactivatedObjectList                = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 InAdvDeactivatedObjectList  ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.VitalityGauge                             = GetObject<ScheduleVitalityGauge>(new IntPtr(p + 0x038), ReversePrism.DataModels.ScheduleVitalityGauge.FromPointer); // 0x38 VitalityGauge               ( ModelClassType ScheduleVitalityGauge ScheduleVitalityGauge ScheduleVitalityGauge Pointer )
            value.ParameterVariationContent                 = GetObject<ParameterVariationContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ParameterVariationContent.FromPointer); // 0x40 ParameterVariationContent   ( ModelClassType ParameterVariationContent ParameterVariationContent ParameterVariationContent Pointer )
            value.SupportEffectDemonstrateUIContent         = GetObject<SupportEffectDemonstrateUIContent>(new IntPtr(p + 0x048), ReversePrism.DataModels.SupportEffectDemonstrateUIContent.FromPointer); // 0x48 SupportEffectDemonstrateUIContent ( ModelClassType SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent SupportEffectDemonstrateUIContent Pointer )

            return value;
        }
    }
}
