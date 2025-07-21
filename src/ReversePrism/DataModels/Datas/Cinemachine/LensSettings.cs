using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  LensSettings IL2CPP_TYPE_VALUETYPE
    // 010 FieldOfView                              ModelPrimitiveType float float float Single
    // 014 OrthographicSize                         ModelPrimitiveType float float float Single
    // 018 NearClipPlane                            ModelPrimitiveType float float float Single
    // 01C FarClipPlane                             ModelPrimitiveType float float float Single
    // 020 Dutch                                    ModelPrimitiveType float float float Single
    // 024 ModeOverride                             ModelEnumType OverrideModes OverrideModes OverrideModes Int32
    // 028 LensShift                                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 GateFit                                  ModelEnumType GateFitMode GateFitMode GateFitMode Int32
    // 034 FocusDistance                            ModelPrimitiveType float float float Single
    // 038 M_SensorSize                             ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 M_OrthoFromCamera                        ModelPrimitiveType bool bool bool Bool
    // 041 M_PhysicalFromCamera                     ModelPrimitiveType bool bool bool Bool
    public partial class LensSettings : DataModel
    {
        public float                                    FieldOfView                             { get; set; }
        public float                                    OrthographicSize                        { get; set; }
        public float                                    NearClipPlane                           { get; set; }
        public float                                    FarClipPlane                            { get; set; }
        public float                                    Dutch                                   { get; set; }
        public OverrideModes                            ModeOverride                            { get; set; }
        public Vector2                                  LensShift                               { get; set; }
        public GateFitMode                              GateFit                                 { get; set; }
        public float                                    FocusDistance                           { get; set; }
        public Vector2                                  M_SensorSize                            { get; set; }
        public bool                                     M_OrthoFromCamera                       { get; set; }
        public bool                                     M_PhysicalFromCamera                    { get; set; }

        public static LensSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensSettings() { Pointer= p0 };

            value.FieldOfView                               = GetSingle(new IntPtr(p + 0x010)); // 0x10 FieldOfView                 ( ModelPrimitiveType float float float Single )
            value.OrthographicSize                          = GetSingle(new IntPtr(p + 0x014)); // 0x14 OrthographicSize            ( ModelPrimitiveType float float float Single )
            value.NearClipPlane                             = GetSingle(new IntPtr(p + 0x018)); // 0x18 NearClipPlane               ( ModelPrimitiveType float float float Single )
            value.FarClipPlane                              = GetSingle(new IntPtr(p + 0x01C)); // 0x1C FarClipPlane                ( ModelPrimitiveType float float float Single )
            value.Dutch                                     = GetSingle(new IntPtr(p + 0x020)); // 0x20 Dutch                       ( ModelPrimitiveType float float float Single )
            value.ModeOverride                              = (OverrideModes)GetInt32(new IntPtr(p + 0x024)); // 0x24 ModeOverride                ( ModelEnumType OverrideModes OverrideModes OverrideModes Int32 )
            value.LensShift                                 = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 LensShift                   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.GateFit                                   = (GateFitMode)GetInt32(new IntPtr(p + 0x030)); // 0x30 GateFit                     ( ModelEnumType GateFitMode GateFitMode GateFitMode Int32 )
            value.FocusDistance                             = GetSingle(new IntPtr(p + 0x034)); // 0x34 FocusDistance               ( ModelPrimitiveType float float float Single )
            value.M_SensorSize                              = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_SensorSize                ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_OrthoFromCamera                         = GetBool(new IntPtr(p + 0x040)); // 0x40 M_OrthoFromCamera           ( ModelPrimitiveType bool bool bool Bool )
            value.M_PhysicalFromCamera                      = GetBool(new IntPtr(p + 0x041)); // 0x41 M_PhysicalFromCamera        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
