using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Lens                                     ModelEnumType LensSettings LensSettings LensSettings Int32
    // 044 ReferenceUp                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 050 ReferenceLookAt                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 000 kNoPoint                                 Vector3 IL2CPP_TYPE_VALUETYPE
    // 05C RawPosition                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 068 RawOrientation                           ModelEnumType Quaternion Quaternion Quaternion Int32
    // 078 PositionDampingBypass                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 084 ShotQuality                              ModelPrimitiveType float float float Single
    // 088 PositionCorrection                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 094 OrientationCorrection                    ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0A4 BlendHint                                ModelEnumType BlendHintValue BlendHintValue BlendHintValue Int32
    // 0A8 MCustom0                                 ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32
    // 0B8 MCustom1                                 ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32
    // 0C8 MCustom2                                 ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32
    // 0D8 MCustom3                                 ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32
    // 0E8 M_CustomOverflow                         ModelEnumListType List`1<CustomBlendable> List`1<CustomBlendable> List<CustomBlendable> Pointer
    // 0F0 NumCustomBlendables                      ModelPrimitiveType int int int Int32
    public partial class CameraState : DataModel
    {
        public LensSettings                             Lens                                    { get; set; }
        public Vector3                                  ReferenceUp                             { get; set; }
        public Vector3                                  ReferenceLookAt                         { get; set; }
        public Vector3                                  RawPosition                             { get; set; }
        public Quaternion                               RawOrientation                          { get; set; }
        public Vector3                                  PositionDampingBypass                   { get; set; }
        public float                                    ShotQuality                             { get; set; }
        public Vector3                                  PositionCorrection                      { get; set; }
        public Quaternion                               OrientationCorrection                   { get; set; }
        public BlendHintValue                           BlendHint                               { get; set; }
        public CustomBlendable                          MCustom0                                { get; set; }
        public CustomBlendable                          MCustom1                                { get; set; }
        public CustomBlendable                          MCustom2                                { get; set; }
        public CustomBlendable                          MCustom3                                { get; set; }
        public List<CustomBlendable>?                   M_CustomOverflow                        { get; set; }
        public int                                      NumCustomBlendables                     { get; set; }

        public static CameraState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraState() { Pointer= p0 };

            value.Lens                                      = (LensSettings)GetInt32(new IntPtr(p + 0x010)); // 0x10 Lens                        ( ModelEnumType LensSettings LensSettings LensSettings Int32 )
            value.ReferenceUp                               = (Vector3)GetInt32(new IntPtr(p + 0x044)); // 0x44 ReferenceUp                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ReferenceLookAt                           = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 0x50 ReferenceLookAt             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RawPosition                               = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 0x5C RawPosition                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RawOrientation                            = (Quaternion)GetInt32(new IntPtr(p + 0x068)); // 0x68 RawOrientation              ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.PositionDampingBypass                     = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 0x78 PositionDampingBypass       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ShotQuality                               = GetSingle(new IntPtr(p + 0x084)); // 0x84 ShotQuality                 ( ModelPrimitiveType float float float Single )
            value.PositionCorrection                        = (Vector3)GetInt32(new IntPtr(p + 0x088)); // 0x88 PositionCorrection          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OrientationCorrection                     = (Quaternion)GetInt32(new IntPtr(p + 0x094)); // 0x94 OrientationCorrection       ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.BlendHint                                 = (BlendHintValue)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 BlendHint                   ( ModelEnumType BlendHintValue BlendHintValue BlendHintValue Int32 )
            value.MCustom0                                  = (CustomBlendable)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 MCustom0                    ( ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32 )
            value.MCustom1                                  = (CustomBlendable)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 MCustom1                    ( ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32 )
            value.MCustom2                                  = (CustomBlendable)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 MCustom2                    ( ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32 )
            value.MCustom3                                  = (CustomBlendable)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 MCustom3                    ( ModelEnumType CustomBlendable CustomBlendable CustomBlendable Int32 )
            value.M_CustomOverflow                          = GetEnumList<CustomBlendable>(new IntPtr(p + 0x0E8)); // 0xE8 M_CustomOverflow            ( ModelEnumListType List`1<CustomBlendable> List`1<CustomBlendable> List<CustomBlendable> Pointer )
            value.NumCustomBlendables                       = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 NumCustomBlendables         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
