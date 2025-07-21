using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StartTime                              ModelPrimitiveType float float float Single
    // 018 M_Envelope                               ModelEnumType EnvelopeDefinition EnvelopeDefinition EnvelopeDefinition Int32
    // 038 M_SignalSource                           ModelClassType ISignalSource6D ISignalSource6D ISignalSource6D Pointer
    // 040 M_Position                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C M_Radius                                 ModelPrimitiveType float float float Single
    // 050 M_DirectionMode                          ModelEnumType DirectionMode DirectionMode DirectionMode Int32
    // 054 M_Channel                                ModelPrimitiveType int int int Int32
    // 058 M_DissipationMode                        ModelEnumType DissipationMode DissipationMode DissipationMode Int32
    // 05C M_DissipationDistance                    ModelPrimitiveType float float float Single
    // 060 M_CustomDissipation                      ModelPrimitiveType float float float Single
    // 064 M_PropagationSpeed                       ModelPrimitiveType float float float Single
    public partial class ImpulseEvent : DataModel
    {
        public float                                    M_StartTime                             { get; set; }
        public EnvelopeDefinition                       M_Envelope                              { get; set; }
        public ISignalSource6D?                         M_SignalSource                          { get; set; }
        public Vector3                                  M_Position                              { get; set; }
        public float                                    M_Radius                                { get; set; }
        public DirectionMode                            M_DirectionMode                         { get; set; }
        public int                                      M_Channel                               { get; set; }
        public DissipationMode                          M_DissipationMode                       { get; set; }
        public float                                    M_DissipationDistance                   { get; set; }
        public float                                    M_CustomDissipation                     { get; set; }
        public float                                    M_PropagationSpeed                      { get; set; }

        public static ImpulseEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImpulseEvent() { Pointer= p0 };

            value.M_StartTime                               = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_StartTime                 ( ModelPrimitiveType float float float Single )
            value.M_Envelope                                = (EnvelopeDefinition)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Envelope                  ( ModelEnumType EnvelopeDefinition EnvelopeDefinition EnvelopeDefinition Int32 )
            value.M_SignalSource                            = GetObject<ISignalSource6D>(new IntPtr(p + 0x038), ReversePrism.DataModels.ISignalSource6D.FromPointer); // 0x38 M_SignalSource              ( ModelClassType ISignalSource6D ISignalSource6D ISignalSource6D Pointer )
            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_Position                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Radius                                  = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_Radius                    ( ModelPrimitiveType float float float Single )
            value.M_DirectionMode                           = (DirectionMode)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_DirectionMode             ( ModelEnumType DirectionMode DirectionMode DirectionMode Int32 )
            value.M_Channel                                 = GetInt32(new IntPtr(p + 0x054)); // 0x54 M_Channel                   ( ModelPrimitiveType int int int Int32 )
            value.M_DissipationMode                         = (DissipationMode)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_DissipationMode           ( ModelEnumType DissipationMode DissipationMode DissipationMode Int32 )
            value.M_DissipationDistance                     = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_DissipationDistance       ( ModelPrimitiveType float float float Single )
            value.M_CustomDissipation                       = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_CustomDissipation         ( ModelPrimitiveType float float float Single )
            value.M_PropagationSpeed                        = GetSingle(new IntPtr(p + 0x064)); // 0x64 M_PropagationSpeed          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
