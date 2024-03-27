using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     000186729350 ModelEnumType PathMode PathMode PathMode Int32
    // 014 OrientType                               0001866EB7E0 ModelEnumType OrientType OrientType OrientType Int32
    // 018 LockPositionAxis                         0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 01C LockRotationAxis                         0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 020 IsClosedPath                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 024 LookAtPosition                           0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 LookAtTransform                          0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 038 LookAhead                                000186666050 ModelPrimitiveType float float float Single
    // 03C HasCustomForwardDirection                000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 Forward                                  00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 050 UseLocalPosition                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 058 Parent                                   0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 060 IsRigidbody                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 064 StartupRot                               00018664A090 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 074 StartupZRot                              000186665900 ModelPrimitiveType float float float Single
    // 078 AddedExtraStartWp                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 079 AddedExtraEndWp                          000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class PathOptions
    {
        public PathMode                                 Mode                                    { get; set; }
        public OrientType                               OrientType                              { get; set; }
        public AxisConstraint                           LockPositionAxis                        { get; set; }
        public AxisConstraint                           LockRotationAxis                        { get; set; }
        public bool                                     IsClosedPath                            { get; set; }
        public Vector3                                  LookAtPosition                          { get; set; }
        public Transform?                               LookAtTransform                         { get; set; }
        public float                                    LookAhead                               { get; set; }
        public bool                                     HasCustomForwardDirection               { get; set; }
        public Quaternion                               Forward                                 { get; set; }
        public bool                                     UseLocalPosition                        { get; set; }
        public Transform?                               Parent                                  { get; set; }
        public bool                                     IsRigidbody                             { get; set; }
        public Quaternion                               StartupRot                              { get; set; }
        public float                                    StartupZRot                             { get; set; }
        public bool                                     AddedExtraStartWp                       { get; set; }
        public bool                                     AddedExtraEndWp                         { get; set; }

        public static PathOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PathOptions();

            value.Mode                                      = (PathMode)GetInt32(new IntPtr(p + 0x010)); // 0270DB09C808 0x10 Mode                        ( 000186729350 ModelEnumType PathMode PathMode PathMode Int32 )
            value.OrientType                                = (OrientType)GetInt32(new IntPtr(p + 0x014)); // 0270DB09C828 0x14 OrientType                  ( 0001866EB7E0 ModelEnumType OrientType OrientType OrientType Int32 )
            value.LockPositionAxis                          = (AxisConstraint)GetInt32(new IntPtr(p + 0x018)); // 0270DB09C848 0x18 LockPositionAxis            ( 0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.LockRotationAxis                          = (AxisConstraint)GetInt32(new IntPtr(p + 0x01C)); // 0270DB09C868 0x1C LockRotationAxis            ( 0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.IsClosedPath                              = GetBool(new IntPtr(p + 0x020)); // 0270DB09C888 0x20 IsClosedPath                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LookAtPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0270DB09C8A8 0x24 LookAtPosition              ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LookAtTransform                           = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DB09C8C8 0x30 LookAtTransform             ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.LookAhead                                 = GetSingle(new IntPtr(p + 0x038)); // 0270DB09C8E8 0x38 LookAhead                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.HasCustomForwardDirection                 = GetBool(new IntPtr(p + 0x03C)); // 0270DB09C908 0x3C HasCustomForwardDirection   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Forward                                   = (Quaternion)GetInt32(new IntPtr(p + 0x040)); // 0270DB09C928 0x40 Forward                     ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.UseLocalPosition                          = GetBool(new IntPtr(p + 0x050)); // 0270DB09C948 0x50 UseLocalPosition            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0270DB09C968 0x58 Parent                      ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.IsRigidbody                               = GetBool(new IntPtr(p + 0x060)); // 0270DB09C988 0x60 IsRigidbody                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.StartupRot                                = (Quaternion)GetInt32(new IntPtr(p + 0x064)); // 0270DB09C9A8 0x64 StartupRot                  ( 00018664A090 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.StartupZRot                               = GetSingle(new IntPtr(p + 0x074)); // 0270DB09C9C8 0x74 StartupZRot                 ( 000186665900 ModelPrimitiveType float float float Single )
            value.AddedExtraStartWp                         = GetBool(new IntPtr(p + 0x078)); // 0270DB09C9E8 0x78 AddedExtraStartWp           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.AddedExtraEndWp                           = GetBool(new IntPtr(p + 0x079)); // 0270DB09CA08 0x79 AddedExtraEndWp             ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
