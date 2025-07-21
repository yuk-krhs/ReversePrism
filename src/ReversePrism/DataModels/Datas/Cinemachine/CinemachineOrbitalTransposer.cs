using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A0 M_Heading                                ModelEnumType Heading Heading Heading Int32
    // 0AC M_RecenterToTargetHeading                ModelEnumType Recentering Recentering Recentering Int32
    // 0D0 M_XAxis                                  ModelEnumType AxisState AxisState AxisState Int32
    // 140 M_LegacyRadius                           ModelPrimitiveType float float float Single
    // 144 M_LegacyHeightOffset                     ModelPrimitiveType float float float Single
    // 148 M_LegacyHeadingBias                      ModelPrimitiveType float float float Single
    // 14C M_HeadingIsSlave                         ModelPrimitiveType bool bool bool Bool
    // 150 HeadingUpdater                           ModelClassType UpdateHeadingDelegate UpdateHeadingDelegate UpdateHeadingDelegate Pointer
    // 158 M_LastTargetPosition                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 168 MHeadingTracker                          ModelClassType HeadingTracker HeadingTracker HeadingTracker Pointer
    // 170 M_TargetRigidBody                        ModelClassType Rigidbody Rigidbody Rigidbody Pointer
    // 178 M_PreviousTarget                         ModelClassType Transform Transform Transform Pointer
    // 180 M_LastCameraPosition                     ModelEnumType Vector3 Vector3 Vector3 Int32
    // 18C M_LastHeading                            ModelPrimitiveType float float float Single
    public partial class CinemachineOrbitalTransposer : DataModel
    {
        public Heading                                  M_Heading                               { get; set; }
        public Recentering                              M_RecenterToTargetHeading               { get; set; }
        public AxisState                                M_XAxis                                 { get; set; }
        public float                                    M_LegacyRadius                          { get; set; }
        public float                                    M_LegacyHeightOffset                    { get; set; }
        public float                                    M_LegacyHeadingBias                     { get; set; }
        public bool                                     M_HeadingIsSlave                        { get; set; }
        public UpdateHeadingDelegate?                   HeadingUpdater                          { get; set; }
        public Vector3                                  M_LastTargetPosition                    { get; set; }
        public HeadingTracker?                          MHeadingTracker                         { get; set; }
        public Rigidbody?                               M_TargetRigidBody                       { get; set; }
        public Transform?                               M_PreviousTarget                        { get; set; }
        public Vector3                                  M_LastCameraPosition                    { get; set; }
        public float                                    M_LastHeading                           { get; set; }

        public static CinemachineOrbitalTransposer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineOrbitalTransposer() { Pointer= p0 };

            value.M_Heading                                 = (Heading)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_Heading                   ( ModelEnumType Heading Heading Heading Int32 )
            value.M_RecenterToTargetHeading                 = (Recentering)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC M_RecenterToTargetHeading   ( ModelEnumType Recentering Recentering Recentering Int32 )
            value.M_XAxis                                   = (AxisState)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 M_XAxis                     ( ModelEnumType AxisState AxisState AxisState Int32 )
            value.M_LegacyRadius                            = GetSingle(new IntPtr(p + 0x140)); // 0x140 M_LegacyRadius              ( ModelPrimitiveType float float float Single )
            value.M_LegacyHeightOffset                      = GetSingle(new IntPtr(p + 0x144)); // 0x144 M_LegacyHeightOffset        ( ModelPrimitiveType float float float Single )
            value.M_LegacyHeadingBias                       = GetSingle(new IntPtr(p + 0x148)); // 0x148 M_LegacyHeadingBias         ( ModelPrimitiveType float float float Single )
            value.M_HeadingIsSlave                          = GetBool(new IntPtr(p + 0x14C)); // 0x14C M_HeadingIsSlave            ( ModelPrimitiveType bool bool bool Bool )
            value.HeadingUpdater                            = GetObject<UpdateHeadingDelegate>(new IntPtr(p + 0x150), ReversePrism.DataModels.UpdateHeadingDelegate.FromPointer); // 0x150 HeadingUpdater              ( ModelClassType UpdateHeadingDelegate UpdateHeadingDelegate UpdateHeadingDelegate Pointer )
            value.M_LastTargetPosition                      = (Vector3)GetInt32(new IntPtr(p + 0x158)); // 0x158 M_LastTargetPosition        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MHeadingTracker                           = GetObject<HeadingTracker>(new IntPtr(p + 0x168), ReversePrism.DataModels.HeadingTracker.FromPointer); // 0x168 MHeadingTracker             ( ModelClassType HeadingTracker HeadingTracker HeadingTracker Pointer )
            value.M_TargetRigidBody                         = GetObject<Rigidbody>(new IntPtr(p + 0x170), ReversePrism.DataModels.Rigidbody.FromPointer); // 0x170 M_TargetRigidBody           ( ModelClassType Rigidbody Rigidbody Rigidbody Pointer )
            value.M_PreviousTarget                          = GetObject<Transform>(new IntPtr(p + 0x178), ReversePrism.DataModels.Transform.FromPointer); // 0x178 M_PreviousTarget            ( ModelClassType Transform Transform Transform Pointer )
            value.M_LastCameraPosition                      = (Vector3)GetInt32(new IntPtr(p + 0x180)); // 0x180 M_LastCameraPosition        ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_LastHeading                             = GetSingle(new IntPtr(p + 0x18C)); // 0x18C M_LastHeading               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
