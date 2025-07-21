using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LightType                              ModelEnumType LightType LightType LightType Int32
    // 014 M_FinalColor                             ModelEnumType Color Color Color Int32
    // 024 M_ScreenRect                             ModelEnumType Rect Rect Rect Int32
    // 034 M_LocalToWorldMatrix                     ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 074 M_Range                                  ModelPrimitiveType float float float Single
    // 078 M_SpotAngle                              ModelPrimitiveType float float float Single
    // 07C M_InstanceId                             ModelPrimitiveType int int int Int32
    // 080 M_Flags                                  ModelEnumType VisibleLightFlags VisibleLightFlags VisibleLightFlags Int32
    public partial class VisibleLight : DataModel
    {
        public LightType                                M_LightType                             { get; set; }
        public Color                                    M_FinalColor                            { get; set; }
        public Rect                                     M_ScreenRect                            { get; set; }
        public Matrix4x4                                M_LocalToWorldMatrix                    { get; set; }
        public float                                    M_Range                                 { get; set; }
        public float                                    M_SpotAngle                             { get; set; }
        public int                                      M_InstanceId                            { get; set; }
        public VisibleLightFlags                        M_Flags                                 { get; set; }

        public static VisibleLight? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisibleLight() { Pointer= p0 };

            value.M_LightType                               = (LightType)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_LightType                 ( ModelEnumType LightType LightType LightType Int32 )
            value.M_FinalColor                              = (Color)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_FinalColor                ( ModelEnumType Color Color Color Int32 )
            value.M_ScreenRect                              = (Rect)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_ScreenRect                ( ModelEnumType Rect Rect Rect Int32 )
            value.M_LocalToWorldMatrix                      = (Matrix4x4)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_LocalToWorldMatrix        ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_Range                                   = GetSingle(new IntPtr(p + 0x074)); // 0x74 M_Range                     ( ModelPrimitiveType float float float Single )
            value.M_SpotAngle                               = GetSingle(new IntPtr(p + 0x078)); // 0x78 M_SpotAngle                 ( ModelPrimitiveType float float float Single )
            value.M_InstanceId                              = GetInt32(new IntPtr(p + 0x07C)); // 0x7C M_InstanceId                ( ModelPrimitiveType int int int Int32 )
            value.M_Flags                                   = (VisibleLightFlags)GetInt32(new IntPtr(p + 0x080)); // 0x80 M_Flags                     ( ModelEnumType VisibleLightFlags VisibleLightFlags VisibleLightFlags Int32 )

            return value;
        }
    }
}
