using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RimColor                                 0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 AngelRingColor                           0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 RingRotation                             00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 070 Radius                                   000186666050 ModelPrimitiveType float float float Single
    // 074 CenterPos                                0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 OutlineColorAdd                          0001865AB0A0 ModelEnumType Color Color Color Int32
    // 090 OutlineAdjust                            000186666050 ModelPrimitiveType float float float Single
    // 094 OutlineInclusive                         000186666050 ModelPrimitiveType float float float Single
    // 098 ReferencePoint                           0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0A8 PlanePoint                               0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0B8 PlaneNormal                              0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0C8 CameraDir                                0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0D8 ScaleZ                                   000186666050 ModelPrimitiveType float float float Single
    // 0DC PersonalLight                            0001865AB0A0 ModelEnumType Color Color Color Int32
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

            value.RimColor                                  = (Color)GetInt32(new IntPtr(p + 0x010)); // 0245A4FA8EE0 0x10 RimColor                    ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.AngelRingColor                            = (Color)GetInt32(new IntPtr(p + 0x020)); // 0245A4FA8F00 0x20 AngelRingColor              ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RingRotation                              = (Matrix4x4)GetInt32(new IntPtr(p + 0x030)); // 0245A4FA8F20 0x30 RingRotation                ( 00018660DFD0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x070)); // 0245A4FA8F40 0x70 Radius                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.CenterPos                                 = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0245A4FA8F60 0x74 CenterPos                   ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OutlineColorAdd                           = (Color)GetInt32(new IntPtr(p + 0x080)); // 0245A4FA8F80 0x80 OutlineColorAdd             ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.OutlineAdjust                             = GetSingle(new IntPtr(p + 0x090)); // 0245A4FA8FA0 0x90 OutlineAdjust               ( 000186666050 ModelPrimitiveType float float float Single )
            value.OutlineInclusive                          = GetSingle(new IntPtr(p + 0x094)); // 0245A4FA8FC0 0x94 OutlineInclusive            ( 000186666050 ModelPrimitiveType float float float Single )
            value.ReferencePoint                            = (Vector4)GetInt32(new IntPtr(p + 0x098)); // 0245A4FA8FE0 0x98 ReferencePoint              ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.PlanePoint                                = (Vector4)GetInt32(new IntPtr(p + 0x0A8)); // 0245A4FA9000 0xA8 PlanePoint                  ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.PlaneNormal                               = (Vector4)GetInt32(new IntPtr(p + 0x0B8)); // 0245A4FA9020 0xB8 PlaneNormal                 ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.CameraDir                                 = (Vector4)GetInt32(new IntPtr(p + 0x0C8)); // 0245A4FA9040 0xC8 CameraDir                   ( 0001866AF040 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ScaleZ                                    = GetSingle(new IntPtr(p + 0x0D8)); // 0245A4FA9060 0xD8 ScaleZ                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.PersonalLight                             = (Color)GetInt32(new IntPtr(p + 0x0DC)); // 0245A4FA9080 0xDC PersonalLight               ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
