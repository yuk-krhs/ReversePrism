using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ImpulseChannel                         ModelPrimitiveType int int int Int32
    // 014 M_ImpulseShape                           ModelEnumType ImpulseShapes ImpulseShapes ImpulseShapes Int32
    // 018 M_CustomImpulseShape                     ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 020 M_ImpulseDuration                        ModelPrimitiveType float float float Single
    // 024 M_ImpulseType                            ModelEnumType ImpulseTypes ImpulseTypes ImpulseTypes Int32
    // 028 M_DissipationRate                        ModelPrimitiveType float float float Single
    // 030 M_RawSignal                              ModelClassType SignalSourceAsset SignalSourceAsset SignalSourceAsset Pointer
    // 038 M_AmplitudeGain                          ModelPrimitiveType float float float Single
    // 03C M_FrequencyGain                          ModelPrimitiveType float float float Single
    // 040 M_RepeatMode                             ModelEnumType RepeatMode RepeatMode RepeatMode Int32
    // 044 M_Randomize                              ModelPrimitiveType bool bool bool Bool
    // 048 M_TimeEnvelope                           ModelEnumType EnvelopeDefinition EnvelopeDefinition EnvelopeDefinition Int32
    // 068 M_ImpactRadius                           ModelPrimitiveType float float float Single
    // 06C M_DirectionMode                          ModelEnumType DirectionMode DirectionMode DirectionMode Int32
    // 070 M_DissipationMode                        ModelEnumType DissipationMode DissipationMode DissipationMode Int32
    // 074 M_DissipationDistance                    ModelPrimitiveType float float float Single
    // 078 M_PropagationSpeed                       ModelPrimitiveType float float float Single
    // 000 sStandardShapes                          AnimationCurve[] IL2CPP_TYPE_SZARRAY
    public partial class CinemachineImpulseDefinition : DataModel
    {
        public int                                      M_ImpulseChannel                        { get; set; }
        public ImpulseShapes                            M_ImpulseShape                          { get; set; }
        public AnimationCurve?                          M_CustomImpulseShape                    { get; set; }
        public float                                    M_ImpulseDuration                       { get; set; }
        public ImpulseTypes                             M_ImpulseType                           { get; set; }
        public float                                    M_DissipationRate                       { get; set; }
        public SignalSourceAsset?                       M_RawSignal                             { get; set; }
        public float                                    M_AmplitudeGain                         { get; set; }
        public float                                    M_FrequencyGain                         { get; set; }
        public RepeatMode                               M_RepeatMode                            { get; set; }
        public bool                                     M_Randomize                             { get; set; }
        public EnvelopeDefinition                       M_TimeEnvelope                          { get; set; }
        public float                                    M_ImpactRadius                          { get; set; }
        public DirectionMode                            M_DirectionMode                         { get; set; }
        public DissipationMode                          M_DissipationMode                       { get; set; }
        public float                                    M_DissipationDistance                   { get; set; }
        public float                                    M_PropagationSpeed                      { get; set; }

        public static CinemachineImpulseDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineImpulseDefinition() { Pointer= p0 };

            value.M_ImpulseChannel                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_ImpulseChannel            ( ModelPrimitiveType int int int Int32 )
            value.M_ImpulseShape                            = (ImpulseShapes)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_ImpulseShape              ( ModelEnumType ImpulseShapes ImpulseShapes ImpulseShapes Int32 )
            value.M_CustomImpulseShape                      = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x18 M_CustomImpulseShape        ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.M_ImpulseDuration                         = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_ImpulseDuration           ( ModelPrimitiveType float float float Single )
            value.M_ImpulseType                             = (ImpulseTypes)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_ImpulseType               ( ModelEnumType ImpulseTypes ImpulseTypes ImpulseTypes Int32 )
            value.M_DissipationRate                         = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_DissipationRate           ( ModelPrimitiveType float float float Single )
            value.M_RawSignal                               = GetObject<SignalSourceAsset>(new IntPtr(p + 0x030), ReversePrism.DataModels.SignalSourceAsset.FromPointer); // 0x30 M_RawSignal                 ( ModelClassType SignalSourceAsset SignalSourceAsset SignalSourceAsset Pointer )
            value.M_AmplitudeGain                           = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_AmplitudeGain             ( ModelPrimitiveType float float float Single )
            value.M_FrequencyGain                           = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_FrequencyGain             ( ModelPrimitiveType float float float Single )
            value.M_RepeatMode                              = (RepeatMode)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_RepeatMode                ( ModelEnumType RepeatMode RepeatMode RepeatMode Int32 )
            value.M_Randomize                               = GetBool(new IntPtr(p + 0x044)); // 0x44 M_Randomize                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_TimeEnvelope                            = (EnvelopeDefinition)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_TimeEnvelope              ( ModelEnumType EnvelopeDefinition EnvelopeDefinition EnvelopeDefinition Int32 )
            value.M_ImpactRadius                            = GetSingle(new IntPtr(p + 0x068)); // 0x68 M_ImpactRadius              ( ModelPrimitiveType float float float Single )
            value.M_DirectionMode                           = (DirectionMode)GetInt32(new IntPtr(p + 0x06C)); // 0x6C M_DirectionMode             ( ModelEnumType DirectionMode DirectionMode DirectionMode Int32 )
            value.M_DissipationMode                         = (DissipationMode)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_DissipationMode           ( ModelEnumType DissipationMode DissipationMode DissipationMode Int32 )
            value.M_DissipationDistance                     = GetSingle(new IntPtr(p + 0x074)); // 0x74 M_DissipationDistance       ( ModelPrimitiveType float float float Single )
            value.M_PropagationSpeed                        = GetSingle(new IntPtr(p + 0x078)); // 0x78 M_PropagationSpeed          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
