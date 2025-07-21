using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_ArcRadius                              float IL2CPP_TYPE_R4
    // 000 k_AxisLength                             float IL2CPP_TYPE_R4
    // 000 k_MaxDistance                            float IL2CPP_TYPE_R4
    // 020 M_Distance                               ModelPrimitiveType float float float Single
    // 024 M_FrameSpace                             ModelEnumType UpDirection UpDirection UpDirection Int32
    // 028 M_AnchorPositionOverride                 ModelClassType Transform Transform Transform Pointer
    // 030 M_AnchorPositionOffset                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C M_Yaw                                    ModelPrimitiveType float float float Single
    // 040 M_Pitch                                  ModelPrimitiveType float float float Single
    // 044 M_Roll                                   ModelPrimitiveType float float float Single
    public partial class LightAnchor : DataModel
    {
        public float                                    M_Distance                              { get; set; }
        public UpDirection                              M_FrameSpace                            { get; set; }
        public Transform?                               M_AnchorPositionOverride                { get; set; }
        public Vector3                                  M_AnchorPositionOffset                  { get; set; }
        public float                                    M_Yaw                                   { get; set; }
        public float                                    M_Pitch                                 { get; set; }
        public float                                    M_Roll                                  { get; set; }

        public static LightAnchor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightAnchor() { Pointer= p0 };

            value.M_Distance                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_Distance                  ( ModelPrimitiveType float float float Single )
            value.M_FrameSpace                              = (UpDirection)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_FrameSpace                ( ModelEnumType UpDirection UpDirection UpDirection Int32 )
            value.M_AnchorPositionOverride                  = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 M_AnchorPositionOverride    ( ModelClassType Transform Transform Transform Pointer )
            value.M_AnchorPositionOffset                    = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_AnchorPositionOffset      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Yaw                                     = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_Yaw                       ( ModelPrimitiveType float float float Single )
            value.M_Pitch                                   = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_Pitch                     ( ModelPrimitiveType float float float Single )
            value.M_Roll                                    = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_Roll                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
