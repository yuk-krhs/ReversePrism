using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_TrackingType                           00018662EBA0 ModelEnumType TrackingType TrackingType TrackingType Int32
    // 024 M_UpdateType                             00018662F2A0 ModelEnumType UpdateType UpdateType UpdateType Int32
    // 028 M_IgnoreTrackingState                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_PositionInput                          0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 048 M_RotationInput                          0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 060 M_TrackingStateInput                     0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 078 M_CurrentPosition                        0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 084 M_CurrentRotation                        000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 094 M_CurrentTrackingState                   00018662E430 ModelEnumType TrackingStates TrackingStates TrackingStates Int32
    // 098 M_RotationBound                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 099 M_PositionBound                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09A M_TrackingStateBound                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09B M_IsFirstUpdate                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 M_PositionAction                         0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    // 0A8 M_RotationAction                         0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer
    public partial class TrackedPoseDriver : DataModel
    {
        public TrackingType                             M_TrackingType                          { get; set; }
        public UpdateType                               M_UpdateType                            { get; set; }
        public bool                                     M_IgnoreTrackingState                   { get; set; }
        public InputActionProperty                      M_PositionInput                         { get; set; }
        public InputActionProperty                      M_RotationInput                         { get; set; }
        public InputActionProperty                      M_TrackingStateInput                    { get; set; }
        public Vector3                                  M_CurrentPosition                       { get; set; }
        public Quaternion                               M_CurrentRotation                       { get; set; }
        public TrackingStates                           M_CurrentTrackingState                  { get; set; }
        public bool                                     M_RotationBound                         { get; set; }
        public bool                                     M_PositionBound                         { get; set; }
        public bool                                     M_TrackingStateBound                    { get; set; }
        public bool                                     M_IsFirstUpdate                         { get; set; }
        public InputAction?                             M_PositionAction                        { get; set; }
        public InputAction?                             M_RotationAction                        { get; set; }

        public static TrackedPoseDriver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TrackedPoseDriver() { Pointer= p0 };

            value.M_TrackingType                            = (TrackingType)GetInt32(new IntPtr(p + 0x020)); // 0246677DE658 0x20 M_TrackingType              ( 00018662EBA0 ModelEnumType TrackingType TrackingType TrackingType Int32 )
            value.M_UpdateType                              = (UpdateType)GetInt32(new IntPtr(p + 0x024)); // 0246677DE678 0x24 M_UpdateType                ( 00018662F2A0 ModelEnumType UpdateType UpdateType UpdateType Int32 )
            value.M_IgnoreTrackingState                     = GetBool(new IntPtr(p + 0x028)); // 0246677DE698 0x28 M_IgnoreTrackingState       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PositionInput                           = (InputActionProperty)GetInt32(new IntPtr(p + 0x030)); // 0246677DE6B8 0x30 M_PositionInput             ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_RotationInput                           = (InputActionProperty)GetInt32(new IntPtr(p + 0x048)); // 0246677DE6D8 0x48 M_RotationInput             ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_TrackingStateInput                      = (InputActionProperty)GetInt32(new IntPtr(p + 0x060)); // 0246677DE6F8 0x60 M_TrackingStateInput        ( 0001865E90D0 ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_CurrentPosition                         = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 0246677DE718 0x78 M_CurrentPosition           ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_CurrentRotation                         = (Quaternion)GetInt32(new IntPtr(p + 0x084)); // 0246677DE738 0x84 M_CurrentRotation           ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_CurrentTrackingState                    = (TrackingStates)GetInt32(new IntPtr(p + 0x094)); // 0246677DE758 0x94 M_CurrentTrackingState      ( 00018662E430 ModelEnumType TrackingStates TrackingStates TrackingStates Int32 )
            value.M_RotationBound                           = GetBool(new IntPtr(p + 0x098)); // 0246677DE778 0x98 M_RotationBound             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PositionBound                           = GetBool(new IntPtr(p + 0x099)); // 0246677DE798 0x99 M_PositionBound             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TrackingStateBound                      = GetBool(new IntPtr(p + 0x09A)); // 0246677DE7B8 0x9A M_TrackingStateBound        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsFirstUpdate                           = GetBool(new IntPtr(p + 0x09B)); // 0246677DE7D8 0x9B M_IsFirstUpdate             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PositionAction                          = GetObject<InputAction>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.InputAction.FromPointer); // 0246677DE7F8 0xA0 M_PositionAction            ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )
            value.M_RotationAction                          = GetObject<InputAction>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.InputAction.FromPointer); // 0246677DE818 0xA8 M_RotationAction            ( 0001865E7E40 ModelClassType InputAction InputAction InputAction Pointer )

            return value;
        }
    }
}
