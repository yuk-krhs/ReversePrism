using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Mode                                     ModelEnumType PathMode PathMode PathMode Int32
    // 014 OrientType                               ModelEnumType OrientType OrientType OrientType Int32
    // 018 LockPositionAxis                         ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 01C LockRotationAxis                         ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 020 IsClosedPath                             ModelPrimitiveType bool bool bool Bool
    // 024 LookAtPosition                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 030 LookAtTransform                          ModelClassType Transform Transform Transform Pointer
    // 038 LookAhead                                ModelPrimitiveType float float float Single
    // 03C HasCustomForwardDirection                ModelPrimitiveType bool bool bool Bool
    // 040 Forward                                  ModelEnumType Quaternion Quaternion Quaternion Int32
    // 050 UseLocalPosition                         ModelPrimitiveType bool bool bool Bool
    // 058 Parent                                   ModelClassType Transform Transform Transform Pointer
    // 060 IsRigidbody                              ModelPrimitiveType bool bool bool Bool
    // 064 StartupRot                               ModelEnumType Quaternion Quaternion Quaternion Int32
    // 074 StartupZRot                              ModelPrimitiveType float float float Single
    // 078 AddedExtraStartWp                        ModelPrimitiveType bool bool bool Bool
    // 079 AddedExtraEndWp                          ModelPrimitiveType bool bool bool Bool
    public partial class PathOptions : DataModel
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
            var value   = new PathOptions() { Pointer= p0 };

            value.Mode                                      = (PathMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 Mode                        ( ModelEnumType PathMode PathMode PathMode Int32 )
            value.OrientType                                = (OrientType)GetInt32(new IntPtr(p + 0x014)); // 0x14 OrientType                  ( ModelEnumType OrientType OrientType OrientType Int32 )
            value.LockPositionAxis                          = (AxisConstraint)GetInt32(new IntPtr(p + 0x018)); // 0x18 LockPositionAxis            ( ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.LockRotationAxis                          = (AxisConstraint)GetInt32(new IntPtr(p + 0x01C)); // 0x1C LockRotationAxis            ( ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.IsClosedPath                              = GetBool(new IntPtr(p + 0x020)); // 0x20 IsClosedPath                ( ModelPrimitiveType bool bool bool Bool )
            value.LookAtPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0x24 LookAtPosition              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.LookAtTransform                           = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 LookAtTransform             ( ModelClassType Transform Transform Transform Pointer )
            value.LookAhead                                 = GetSingle(new IntPtr(p + 0x038)); // 0x38 LookAhead                   ( ModelPrimitiveType float float float Single )
            value.HasCustomForwardDirection                 = GetBool(new IntPtr(p + 0x03C)); // 0x3C HasCustomForwardDirection   ( ModelPrimitiveType bool bool bool Bool )
            value.Forward                                   = (Quaternion)GetInt32(new IntPtr(p + 0x040)); // 0x40 Forward                     ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.UseLocalPosition                          = GetBool(new IntPtr(p + 0x050)); // 0x50 UseLocalPosition            ( ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 Parent                      ( ModelClassType Transform Transform Transform Pointer )
            value.IsRigidbody                               = GetBool(new IntPtr(p + 0x060)); // 0x60 IsRigidbody                 ( ModelPrimitiveType bool bool bool Bool )
            value.StartupRot                                = (Quaternion)GetInt32(new IntPtr(p + 0x064)); // 0x64 StartupRot                  ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.StartupZRot                               = GetSingle(new IntPtr(p + 0x074)); // 0x74 StartupZRot                 ( ModelPrimitiveType float float float Single )
            value.AddedExtraStartWp                         = GetBool(new IntPtr(p + 0x078)); // 0x78 AddedExtraStartWp           ( ModelPrimitiveType bool bool bool Bool )
            value.AddedExtraEndWp                           = GetBool(new IntPtr(p + 0x079)); // 0x79 AddedExtraEndWp             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
