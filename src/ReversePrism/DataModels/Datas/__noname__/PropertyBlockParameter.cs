using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RimColor                                 ModelEnumType Color Color Color Int32
    // 020 AngelRingColor                           ModelEnumType Color Color Color Int32
    // 030 RingRotation                             ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 070 Radius                                   ModelPrimitiveType float float float Single
    // 074 CenterPos                                ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 OutlineColorAdd                          ModelEnumType Color Color Color Int32
    // 090 OutlineAdjust                            ModelPrimitiveType float float float Single
    // 094 OutlineInclusive                         ModelPrimitiveType float float float Single
    // 098 ReferencePoint                           ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0A8 PlanePoint                               ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0B8 PlaneNormal                              ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0C8 CameraDir                                ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0D8 ScaleZ                                   ModelPrimitiveType float float float Single
    // 0DC PersonalLight                            ModelEnumType Color Color Color Int32
    public partial class PropertyBlockParameter : DataModel
    {
        public Color                                    RimColor                                { get; set; }
        public Color                                    AngelRingColor                          { get; set; }
        public Matrix4x4                                RingRotation                            { get; set; }
        public float                                    Radius                                  { get; set; }
        public Vector3                                  CenterPos                               { get; set; }
        public Color                                    OutlineColorAdd                         { get; set; }
        public float                                    OutlineAdjust                           { get; set; }
        public float                                    OutlineInclusive                        { get; set; }
        public Vector4                                  ReferencePoint                          { get; set; }
        public Vector4                                  PlanePoint                              { get; set; }
        public Vector4                                  PlaneNormal                             { get; set; }
        public Vector4                                  CameraDir                               { get; set; }
        public float                                    ScaleZ                                  { get; set; }
        public Color                                    PersonalLight                           { get; set; }

        public static PropertyBlockParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyBlockParameter() { Pointer= p0 };

            value.RimColor                                  = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 RimColor                    ( ModelEnumType Color Color Color Int32 )
            value.AngelRingColor                            = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 AngelRingColor              ( ModelEnumType Color Color Color Int32 )
            value.RingRotation                              = (Matrix4x4)GetInt32(new IntPtr(p + 0x030)); // 0x30 RingRotation                ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x070)); // 0x70 Radius                      ( ModelPrimitiveType float float float Single )
            value.CenterPos                                 = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0x74 CenterPos                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OutlineColorAdd                           = (Color)GetInt32(new IntPtr(p + 0x080)); // 0x80 OutlineColorAdd             ( ModelEnumType Color Color Color Int32 )
            value.OutlineAdjust                             = GetSingle(new IntPtr(p + 0x090)); // 0x90 OutlineAdjust               ( ModelPrimitiveType float float float Single )
            value.OutlineInclusive                          = GetSingle(new IntPtr(p + 0x094)); // 0x94 OutlineInclusive            ( ModelPrimitiveType float float float Single )
            value.ReferencePoint                            = (Vector4)GetInt32(new IntPtr(p + 0x098)); // 0x98 ReferencePoint              ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.PlanePoint                                = (Vector4)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 PlanePoint                  ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.PlaneNormal                               = (Vector4)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 PlaneNormal                 ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.CameraDir                                 = (Vector4)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 CameraDir                   ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ScaleZ                                    = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 ScaleZ                      ( ModelPrimitiveType float float float Single )
            value.PersonalLight                             = (Color)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC PersonalLight               ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
