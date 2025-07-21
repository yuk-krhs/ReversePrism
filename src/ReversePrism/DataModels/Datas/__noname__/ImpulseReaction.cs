using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_SecondaryNoise                         ModelClassType NoiseSettings NoiseSettings NoiseSettings Pointer
    // 018 M_AmplitudeGain                          ModelPrimitiveType float float float Single
    // 01C M_FrequencyGain                          ModelPrimitiveType float float float Single
    // 020 M_Duration                               ModelPrimitiveType float float float Single
    // 024 M_CurrentAmount                          ModelPrimitiveType float float float Single
    // 028 M_CurrentTime                            ModelPrimitiveType float float float Single
    // 02C M_CurrentDamping                         ModelPrimitiveType float float float Single
    // 030 M_Initialized                            ModelPrimitiveType bool bool bool Bool
    // 034 M_NoiseOffsets                           ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class ImpulseReaction : DataModel
    {
        public NoiseSettings?                           M_SecondaryNoise                        { get; set; }
        public float                                    M_AmplitudeGain                         { get; set; }
        public float                                    M_FrequencyGain                         { get; set; }
        public float                                    M_Duration                              { get; set; }
        public float                                    M_CurrentAmount                         { get; set; }
        public float                                    M_CurrentTime                           { get; set; }
        public float                                    M_CurrentDamping                        { get; set; }
        public bool                                     M_Initialized                           { get; set; }
        public Vector3                                  M_NoiseOffsets                          { get; set; }

        public static ImpulseReaction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImpulseReaction() { Pointer= p0 };

            value.M_SecondaryNoise                          = GetObject<NoiseSettings>(new IntPtr(p + 0x010), ReversePrism.DataModels.NoiseSettings.FromPointer); // 0x10 M_SecondaryNoise            ( ModelClassType NoiseSettings NoiseSettings NoiseSettings Pointer )
            value.M_AmplitudeGain                           = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_AmplitudeGain             ( ModelPrimitiveType float float float Single )
            value.M_FrequencyGain                           = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_FrequencyGain             ( ModelPrimitiveType float float float Single )
            value.M_Duration                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_Duration                  ( ModelPrimitiveType float float float Single )
            value.M_CurrentAmount                           = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_CurrentAmount             ( ModelPrimitiveType float float float Single )
            value.M_CurrentTime                             = GetSingle(new IntPtr(p + 0x028)); // 0x28 M_CurrentTime               ( ModelPrimitiveType float float float Single )
            value.M_CurrentDamping                          = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_CurrentDamping            ( ModelPrimitiveType float float float Single )
            value.M_Initialized                             = GetBool(new IntPtr(p + 0x030)); // 0x30 M_Initialized               ( ModelPrimitiveType bool bool bool Bool )
            value.M_NoiseOffsets                            = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_NoiseOffsets              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
