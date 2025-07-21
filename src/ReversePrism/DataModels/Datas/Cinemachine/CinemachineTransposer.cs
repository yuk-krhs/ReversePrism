using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 M_BindingMode                            ModelEnumType BindingMode BindingMode BindingMode Int32
    // 02C M_FollowOffset                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 038 M_XDamping                               ModelPrimitiveType float float float Single
    // 03C M_YDamping                               ModelPrimitiveType float float float Single
    // 040 M_ZDamping                               ModelPrimitiveType float float float Single
    // 044 M_AngularDampingMode                     ModelEnumType AngularDampingMode AngularDampingMode AngularDampingMode Int32
    // 048 M_PitchDamping                           ModelPrimitiveType float float float Single
    // 04C M_YawDamping                             ModelPrimitiveType float float float Single
    // 050 M_RollDamping                            ModelPrimitiveType float float float Single
    // 054 M_AngularDamping                         ModelPrimitiveType float float float Single
    // 058 HideOffsetInInspector                    ModelPrimitiveType bool bool bool Bool
    // 05C M_PreviousTargetPosition                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 068 M_PreviousReferenceOrientation           ModelEnumType Quaternion Quaternion Quaternion Int32
    // 078 M_targetOrientationOnAssign              ModelEnumType Quaternion Quaternion Quaternion Int32
    // 088 M_PreviousOffset                         ModelEnumType Vector3 Vector3 Vector3 Int32
    // 098 M_previousTarget                         ModelClassType Transform Transform Transform Pointer
    public partial class CinemachineTransposer : DataModel
    {
        public BindingMode                              M_BindingMode                           { get; set; }
        public Vector3                                  M_FollowOffset                          { get; set; }
        public float                                    M_XDamping                              { get; set; }
        public float                                    M_YDamping                              { get; set; }
        public float                                    M_ZDamping                              { get; set; }
        public AngularDampingMode                       M_AngularDampingMode                    { get; set; }
        public float                                    M_PitchDamping                          { get; set; }
        public float                                    M_YawDamping                            { get; set; }
        public float                                    M_RollDamping                           { get; set; }
        public float                                    M_AngularDamping                        { get; set; }
        public bool                                     HideOffsetInInspector                   { get; set; }
        public Vector3                                  M_PreviousTargetPosition                { get; set; }
        public Quaternion                               M_PreviousReferenceOrientation          { get; set; }
        public Quaternion                               M_targetOrientationOnAssign             { get; set; }
        public Vector3                                  M_PreviousOffset                        { get; set; }
        public Transform?                               M_previousTarget                        { get; set; }

        public static CinemachineTransposer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineTransposer() { Pointer= p0 };

            value.M_BindingMode                             = (BindingMode)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_BindingMode               ( ModelEnumType BindingMode BindingMode BindingMode Int32 )
            value.M_FollowOffset                            = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_FollowOffset              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_XDamping                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_XDamping                  ( ModelPrimitiveType float float float Single )
            value.M_YDamping                                = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_YDamping                  ( ModelPrimitiveType float float float Single )
            value.M_ZDamping                                = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_ZDamping                  ( ModelPrimitiveType float float float Single )
            value.M_AngularDampingMode                      = (AngularDampingMode)GetInt32(new IntPtr(p + 0x044)); // 0x44 M_AngularDampingMode        ( ModelEnumType AngularDampingMode AngularDampingMode AngularDampingMode Int32 )
            value.M_PitchDamping                            = GetSingle(new IntPtr(p + 0x048)); // 0x48 M_PitchDamping              ( ModelPrimitiveType float float float Single )
            value.M_YawDamping                              = GetSingle(new IntPtr(p + 0x04C)); // 0x4C M_YawDamping                ( ModelPrimitiveType float float float Single )
            value.M_RollDamping                             = GetSingle(new IntPtr(p + 0x050)); // 0x50 M_RollDamping               ( ModelPrimitiveType float float float Single )
            value.M_AngularDamping                          = GetSingle(new IntPtr(p + 0x054)); // 0x54 M_AngularDamping            ( ModelPrimitiveType float float float Single )
            value.HideOffsetInInspector                     = GetBool(new IntPtr(p + 0x058)); // 0x58 HideOffsetInInspector       ( ModelPrimitiveType bool bool bool Bool )
            value.M_PreviousTargetPosition                  = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_PreviousTargetPosition    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_PreviousReferenceOrientation            = (Quaternion)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_PreviousReferenceOrientation ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_targetOrientationOnAssign               = (Quaternion)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_targetOrientationOnAssign ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_PreviousOffset                          = (Vector3)GetInt32(new IntPtr(p + 0x088)); // 0x88 M_PreviousOffset            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_previousTarget                          = GetObject<Transform>(new IntPtr(p + 0x098), ReversePrism.DataModels.Transform.FromPointer); // 0x98 M_previousTarget            ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
