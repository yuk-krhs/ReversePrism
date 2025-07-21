using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_TrackedObjectOffset                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 M_LookaheadTime                          ModelPrimitiveType float float float Single
    // 038 M_LookaheadSmoothing                     ModelPrimitiveType float float float Single
    // 03C M_LookaheadIgnoreY                       ModelPrimitiveType bool bool bool Bool
    // 040 M_XDamping                               ModelPrimitiveType float float float Single
    // 044 M_YDamping                               ModelPrimitiveType float float float Single
    // 048 M_ZDamping                               ModelPrimitiveType float float float Single
    // 04C M_TargetMovementOnly                     ModelPrimitiveType bool bool bool Bool
    // 050 M_ScreenX                                ModelPrimitiveType float float float Single
    // 054 M_ScreenY                                ModelPrimitiveType float float float Single
    // 058 M_CameraDistance                         ModelPrimitiveType float float float Single
    // 05C M_DeadZoneWidth                          ModelPrimitiveType float float float Single
    // 060 M_DeadZoneHeight                         ModelPrimitiveType float float float Single
    // 064 M_DeadZoneDepth                          ModelPrimitiveType float float float Single
    // 068 M_UnlimitedSoftZone                      ModelPrimitiveType bool bool bool Bool
    // 06C M_SoftZoneWidth                          ModelPrimitiveType float float float Single
    // 070 M_SoftZoneHeight                         ModelPrimitiveType float float float Single
    // 074 M_BiasX                                  ModelPrimitiveType float float float Single
    // 078 M_BiasY                                  ModelPrimitiveType float float float Single
    // 07C M_CenterOnActivate                       ModelPrimitiveType bool bool bool Bool
    // 080 M_GroupFramingMode                       ModelEnumType FramingMode FramingMode FramingMode Int32
    // 084 M_AdjustmentMode                         ModelEnumType AdjustmentMode AdjustmentMode AdjustmentMode Int32
    // 088 M_GroupFramingSize                       ModelPrimitiveType float float float Single
    // 08C M_MaxDollyIn                             ModelPrimitiveType float float float Single
    // 090 M_MaxDollyOut                            ModelPrimitiveType float float float Single
    // 094 M_MinimumDistance                        ModelPrimitiveType float float float Single
    // 098 M_MaximumDistance                        ModelPrimitiveType float float float Single
    // 09C M_MinimumFOV                             ModelPrimitiveType float float float Single
    // 0A0 M_MaximumFOV                             ModelPrimitiveType float float float Single
    // 0A4 M_MinimumOrthoSize                       ModelPrimitiveType float float float Single
    // 0A8 M_MaximumOrthoSize                       ModelPrimitiveType float float float Single
    // 000 kMinimumCameraDistance                   float IL2CPP_TYPE_R4
    // 000 kMinimumGroupSize                        float IL2CPP_TYPE_R4
    // 0AC M_PreviousCameraPosition                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B8 M_Predictor                              ModelClassType PositionPredictor PositionPredictor PositionPredictor Pointer
    // 0C0 TrackedPoint                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0CC M_InheritingPosition                     ModelPrimitiveType bool bool bool Bool
    // 0D0 M_prevFOV                                ModelPrimitiveType float float float Single
    // 0D4 M_prevRotation                           ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0E4 LastBounds                               ModelEnumType Bounds Bounds Bounds Int32
    // 0FC LastBoundsMatrix                         ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class CinemachineFramingTransposer : DataModel
    {
        public Vector3                                  M_TrackedObjectOffset                   { get; set; }
        public float                                    M_LookaheadTime                         { get; set; }
        public float                                    M_LookaheadSmoothing                    { get; set; }
        public bool                                     M_LookaheadIgnoreY                      { get; set; }
        public float                                    M_XDamping                              { get; set; }
        public float                                    M_YDamping                              { get; set; }
        public float                                    M_ZDamping                              { get; set; }
        public bool                                     M_TargetMovementOnly                    { get; set; }
        public float                                    M_ScreenX                               { get; set; }
        public float                                    M_ScreenY                               { get; set; }
        public float                                    M_CameraDistance                        { get; set; }
        public float                                    M_DeadZoneWidth                         { get; set; }
        public float                                    M_DeadZoneHeight                        { get; set; }
        public float                                    M_DeadZoneDepth                         { get; set; }
        public bool                                     M_UnlimitedSoftZone                     { get; set; }
        public float                                    M_SoftZoneWidth                         { get; set; }
        public float                                    M_SoftZoneHeight                        { get; set; }
        public float                                    M_BiasX                                 { get; set; }
        public float                                    M_BiasY                                 { get; set; }
        public bool                                     M_CenterOnActivate                      { get; set; }
        public FramingMode                              M_GroupFramingMode                      { get; set; }
        public AdjustmentMode                           M_AdjustmentMode                        { get; set; }
        public float                                    M_GroupFramingSize                      { get; set; }
        public float                                    M_MaxDollyIn                            { get; set; }
        public float                                    M_MaxDollyOut                           { get; set; }
        public float                                    M_MinimumDistance                       { get; set; }
        public float                                    M_MaximumDistance                       { get; set; }
        public float                                    M_MinimumFOV                            { get; set; }
        public float                                    M_MaximumFOV                            { get; set; }
        public float                                    M_MinimumOrthoSize                      { get; set; }
        public float                                    M_MaximumOrthoSize                      { get; set; }
        public Vector3                                  M_PreviousCameraPosition                { get; set; }
        public PositionPredictor?                       M_Predictor                             { get; set; }
        public Vector3                                  TrackedPoint                            { get; set; }
        public bool                                     M_InheritingPosition                    { get; set; }
        public float                                    M_prevFOV                               { get; set; }
        public Quaternion                               M_prevRotation                          { get; set; }
        public Bounds                                   LastBounds                              { get; set; }
        public Matrix4x4                                LastBoundsMatrix                        { get; set; }

        public static CinemachineFramingTransposer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineFramingTransposer() { Pointer= p0 };

            value.M_TrackedObjectOffset                     = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_TrackedObjectOffset       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_LookaheadTime                           = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_LookaheadTime             ( ModelPrimitiveType float float float Single )
            value.M_LookaheadSmoothing                      = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_LookaheadSmoothing        ( ModelPrimitiveType float float float Single )
            value.M_LookaheadIgnoreY                        = GetBool(new IntPtr(p + 0x03C)); // 0x3C M_LookaheadIgnoreY          ( ModelPrimitiveType bool bool bool Bool )
            value.M_XDamping                                = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_XDamping                  ( ModelPrimitiveType float float float Single )
            value.M_YDamping                                = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_YDamping                  ( ModelPrimitiveType float float float Single )
            value.M_ZDamping                                = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_ZDamping                  ( ModelPrimitiveType float float float Single )
            value.M_TargetMovementOnly                      = GetBool(new IntPtr(p + 0x04C)); // 0x4C M_TargetMovementOnly        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ScreenX                                 = GetSingle(new IntPtr(p + 0x050)); // 0x50 M_ScreenX                   ( ModelPrimitiveType float float float Single )
            value.M_ScreenY                                 = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_ScreenY                   ( ModelPrimitiveType float float float Single )
            value.M_CameraDistance                          = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_CameraDistance            ( ModelPrimitiveType float float float Single )
            value.M_DeadZoneWidth                           = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_DeadZoneWidth             ( ModelPrimitiveType float float float Single )
            value.M_DeadZoneHeight                          = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_DeadZoneHeight            ( ModelPrimitiveType float float float Single )
            value.M_DeadZoneDepth                           = GetSingle(new IntPtr(p + 0x064)); // 0x64 M_DeadZoneDepth             ( ModelPrimitiveType float float float Single )
            value.M_UnlimitedSoftZone                       = GetBool(new IntPtr(p + 0x068)); // 0x68 M_UnlimitedSoftZone         ( ModelPrimitiveType bool bool bool Bool )
            value.M_SoftZoneWidth                           = GetSingle(new IntPtr(p + 0x06C)); // 0x6C M_SoftZoneWidth             ( ModelPrimitiveType float float float Single )
            value.M_SoftZoneHeight                          = GetSingle(new IntPtr(p + 0x070)); // 0x70 M_SoftZoneHeight            ( ModelPrimitiveType float float float Single )
            value.M_BiasX                                   = GetSingle(new IntPtr(p + 0x074)); // 0x74 M_BiasX                     ( ModelPrimitiveType float float float Single )
            value.M_BiasY                                   = GetSingle(new IntPtr(p + 0x078)); // 0x78 M_BiasY                     ( ModelPrimitiveType float float float Single )
            value.M_CenterOnActivate                        = GetBool(new IntPtr(p + 0x07C)); // 0x7C M_CenterOnActivate          ( ModelPrimitiveType bool bool bool Bool )
            value.M_GroupFramingMode                        = (FramingMode)GetInt32(new IntPtr(p + 0x080)); // 0x80 M_GroupFramingMode          ( ModelEnumType FramingMode FramingMode FramingMode Int32 )
            value.M_AdjustmentMode                          = (AdjustmentMode)GetInt32(new IntPtr(p + 0x084)); // 0x84 M_AdjustmentMode            ( ModelEnumType AdjustmentMode AdjustmentMode AdjustmentMode Int32 )
            value.M_GroupFramingSize                        = GetSingle(new IntPtr(p + 0x088)); // 0x88 M_GroupFramingSize          ( ModelPrimitiveType float float float Single )
            value.M_MaxDollyIn                              = GetSingle(new IntPtr(p + 0x08C)); // 0x8C M_MaxDollyIn                ( ModelPrimitiveType float float float Single )
            value.M_MaxDollyOut                             = GetSingle(new IntPtr(p + 0x090)); // 0x90 M_MaxDollyOut               ( ModelPrimitiveType float float float Single )
            value.M_MinimumDistance                         = GetSingle(new IntPtr(p + 0x094)); // 0x94 M_MinimumDistance           ( ModelPrimitiveType float float float Single )
            value.M_MaximumDistance                         = GetSingle(new IntPtr(p + 0x098)); // 0x98 M_MaximumDistance           ( ModelPrimitiveType float float float Single )
            value.M_MinimumFOV                              = GetSingle(new IntPtr(p + 0x09C)); // 0x9C M_MinimumFOV                ( ModelPrimitiveType float float float Single )
            value.M_MaximumFOV                              = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 M_MaximumFOV                ( ModelPrimitiveType float float float Single )
            value.M_MinimumOrthoSize                        = GetSingle(new IntPtr(p + 0x0A4)); // 0xA4 M_MinimumOrthoSize          ( ModelPrimitiveType float float float Single )
            value.M_MaximumOrthoSize                        = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 M_MaximumOrthoSize          ( ModelPrimitiveType float float float Single )
            value.M_PreviousCameraPosition                  = (Vector3)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC M_PreviousCameraPosition    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Predictor                               = GetObject<PositionPredictor>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PositionPredictor.FromPointer); // 0xB8 M_Predictor                 ( ModelClassType PositionPredictor PositionPredictor PositionPredictor Pointer )
            value.TrackedPoint                              = (Vector3)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 TrackedPoint                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_InheritingPosition                      = GetBool(new IntPtr(p + 0x0CC)); // 0xCC M_InheritingPosition        ( ModelPrimitiveType bool bool bool Bool )
            value.M_prevFOV                                 = GetSingle(new IntPtr(p + 0x0D0)); // 0xD0 M_prevFOV                   ( ModelPrimitiveType float float float Single )
            value.M_prevRotation                            = (Quaternion)GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 M_prevRotation              ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.LastBounds                                = (Bounds)GetInt32(new IntPtr(p + 0x0E4)); // 0xE4 LastBounds                  ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.LastBoundsMatrix                          = (Matrix4x4)GetInt32(new IntPtr(p + 0x0FC)); // 0xFC LastBoundsMatrix            ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
