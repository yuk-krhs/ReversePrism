using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_NoiseProfile                           ModelClassType NoiseSettings NoiseSettings NoiseSettings Pointer
    // 030 M_PivotOffset                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C M_AmplitudeGain                          ModelPrimitiveType float float float Single
    // 040 M_FrequencyGain                          ModelPrimitiveType float float float Single
    // 044 MInitialized                             ModelPrimitiveType bool bool bool Bool
    // 048 MNoiseTime                               ModelPrimitiveType float float float Single
    // 04C MNoiseOffsets                            ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CinemachineBasicMultiChannelPerlin : DataModel
    {
        public NoiseSettings?                           M_NoiseProfile                          { get; set; }
        public Vector3                                  M_PivotOffset                           { get; set; }
        public float                                    M_AmplitudeGain                         { get; set; }
        public float                                    M_FrequencyGain                         { get; set; }
        public bool                                     MInitialized                            { get; set; }
        public float                                    MNoiseTime                              { get; set; }
        public Vector3                                  MNoiseOffsets                           { get; set; }

        public static CinemachineBasicMultiChannelPerlin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineBasicMultiChannelPerlin() { Pointer= p0 };

            value.M_NoiseProfile                            = GetObject<NoiseSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.NoiseSettings.FromPointer); // 0x28 M_NoiseProfile              ( ModelClassType NoiseSettings NoiseSettings NoiseSettings Pointer )
            value.M_PivotOffset                             = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_PivotOffset               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AmplitudeGain                           = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_AmplitudeGain             ( ModelPrimitiveType float float float Single )
            value.M_FrequencyGain                           = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_FrequencyGain             ( ModelPrimitiveType float float float Single )
            value.MInitialized                              = GetBool(new IntPtr(p + 0x044)); // 0x44 MInitialized                ( ModelPrimitiveType bool bool bool Bool )
            value.MNoiseTime                                = GetSingle(new IntPtr(p + 0x048)); // 0x48 MNoiseTime                  ( ModelPrimitiveType float float float Single )
            value.MNoiseOffsets                             = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 0x4C MNoiseOffsets               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
