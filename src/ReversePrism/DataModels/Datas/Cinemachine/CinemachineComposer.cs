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
    // 040 M_HorizontalDamping                      ModelPrimitiveType float float float Single
    // 044 M_VerticalDamping                        ModelPrimitiveType float float float Single
    // 048 M_ScreenX                                ModelPrimitiveType float float float Single
    // 04C M_ScreenY                                ModelPrimitiveType float float float Single
    // 050 M_DeadZoneWidth                          ModelPrimitiveType float float float Single
    // 054 M_DeadZoneHeight                         ModelPrimitiveType float float float Single
    // 058 M_SoftZoneWidth                          ModelPrimitiveType float float float Single
    // 05C M_SoftZoneHeight                         ModelPrimitiveType float float float Single
    // 060 M_BiasX                                  ModelPrimitiveType float float float Single
    // 064 M_BiasY                                  ModelPrimitiveType float float float Single
    // 068 M_CenterOnActivate                       ModelPrimitiveType bool bool bool Bool
    // 06C TrackedPoint                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 078 M_CameraPosPrevFrame                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 084 M_LookAtPrevFrame                        ModelEnumType Vector3 Vector3 Vector3 Int32
    // 090 M_ScreenOffsetPrevFrame                  ModelEnumType Vector2 Vector2 Vector2 Int32
    // 098 M_CameraOrientationPrevFrame             ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0A8 M_Predictor                              ModelClassType PositionPredictor PositionPredictor PositionPredictor Pointer
    // 0B0 MCache                                   ModelEnumType FovCache FovCache FovCache Int32
    public partial class CinemachineComposer : DataModel
    {
        public Vector3                                  M_TrackedObjectOffset                   { get; set; }
        public float                                    M_LookaheadTime                         { get; set; }
        public float                                    M_LookaheadSmoothing                    { get; set; }
        public bool                                     M_LookaheadIgnoreY                      { get; set; }
        public float                                    M_HorizontalDamping                     { get; set; }
        public float                                    M_VerticalDamping                       { get; set; }
        public float                                    M_ScreenX                               { get; set; }
        public float                                    M_ScreenY                               { get; set; }
        public float                                    M_DeadZoneWidth                         { get; set; }
        public float                                    M_DeadZoneHeight                        { get; set; }
        public float                                    M_SoftZoneWidth                         { get; set; }
        public float                                    M_SoftZoneHeight                        { get; set; }
        public float                                    M_BiasX                                 { get; set; }
        public float                                    M_BiasY                                 { get; set; }
        public bool                                     M_CenterOnActivate                      { get; set; }
        public Vector3                                  TrackedPoint                            { get; set; }
        public Vector3                                  M_CameraPosPrevFrame                    { get; set; }
        public Vector3                                  M_LookAtPrevFrame                       { get; set; }
        public Vector2                                  M_ScreenOffsetPrevFrame                 { get; set; }
        public Quaternion                               M_CameraOrientationPrevFrame            { get; set; }
        public PositionPredictor?                       M_Predictor                             { get; set; }
        public FovCache                                 MCache                                  { get; set; }

        public static CinemachineComposer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineComposer() { Pointer= p0 };

            value.M_TrackedObjectOffset                     = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_TrackedObjectOffset       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_LookaheadTime                           = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_LookaheadTime             ( ModelPrimitiveType float float float Single )
            value.M_LookaheadSmoothing                      = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_LookaheadSmoothing        ( ModelPrimitiveType float float float Single )
            value.M_LookaheadIgnoreY                        = GetBool(new IntPtr(p + 0x03C)); // 0x3C M_LookaheadIgnoreY          ( ModelPrimitiveType bool bool bool Bool )
            value.M_HorizontalDamping                       = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_HorizontalDamping         ( ModelPrimitiveType float float float Single )
            value.M_VerticalDamping                         = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_VerticalDamping           ( ModelPrimitiveType float float float Single )
            value.M_ScreenX                                 = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_ScreenX                   ( ModelPrimitiveType float float float Single )
            value.M_ScreenY                                 = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_ScreenY                   ( ModelPrimitiveType float float float Single )
            value.M_DeadZoneWidth                           = GetSingle(new IntPtr(p + 0x050)); // 0x50 M_DeadZoneWidth             ( ModelPrimitiveType float float float Single )
            value.M_DeadZoneHeight                          = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_DeadZoneHeight            ( ModelPrimitiveType float float float Single )
            value.M_SoftZoneWidth                           = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_SoftZoneWidth             ( ModelPrimitiveType float float float Single )
            value.M_SoftZoneHeight                          = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_SoftZoneHeight            ( ModelPrimitiveType float float float Single )
            value.M_BiasX                                   = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_BiasX                     ( ModelPrimitiveType float float float Single )
            value.M_BiasY                                   = GetSingle(new IntPtr(p + 0x064)); // 0x64 M_BiasY                     ( ModelPrimitiveType float float float Single )
            value.M_CenterOnActivate                        = GetBool(new IntPtr(p + 0x068)); // 0x68 M_CenterOnActivate          ( ModelPrimitiveType bool bool bool Bool )
            value.TrackedPoint                              = (Vector3)GetInt32(new IntPtr(p + 0x06C)); // 0x6C TrackedPoint                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_CameraPosPrevFrame                      = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_CameraPosPrevFrame        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_LookAtPrevFrame                         = (Vector3)GetInt32(new IntPtr(p + 0x084)); // 0x84 M_LookAtPrevFrame           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_ScreenOffsetPrevFrame                   = (Vector2)GetInt32(new IntPtr(p + 0x090)); // 0x90 M_ScreenOffsetPrevFrame     ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_CameraOrientationPrevFrame              = (Quaternion)GetInt32(new IntPtr(p + 0x098)); // 0x98 M_CameraOrientationPrevFrame ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_Predictor                               = GetObject<PositionPredictor>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.PositionPredictor.FromPointer); // 0xA8 M_Predictor                 ( ModelClassType PositionPredictor PositionPredictor PositionPredictor Pointer )
            value.MCache                                    = (FovCache)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 MCache                      ( ModelEnumType FovCache FovCache FovCache Int32 )

            return value;
        }
    }
}
