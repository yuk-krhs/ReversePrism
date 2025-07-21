using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Type                                   ModelEnumType XRNode XRNode XRNode Int32
    // 014 M_AvailableFields                        ModelEnumType AvailableTrackingData AvailableTrackingData AvailableTrackingData Int32
    // 018 M_Position                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 M_Rotation                               ModelEnumType Quaternion Quaternion Quaternion Int32
    // 034 M_Velocity                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 M_AngularVelocity                        ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C M_Acceleration                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 M_AngularAcceleration                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 064 M_Tracked                                ModelPrimitiveType int int int Int32
    // 068 M_UniqueID                               ModelPrimitiveType ulong ulong ulong UInt64
    public partial class XRNodeState : DataModel
    {
        public XRNode                                   M_Type                                  { get; set; }
        public AvailableTrackingData                    M_AvailableFields                       { get; set; }
        public Vector3                                  M_Position                              { get; set; }
        public Quaternion                               M_Rotation                              { get; set; }
        public Vector3                                  M_Velocity                              { get; set; }
        public Vector3                                  M_AngularVelocity                       { get; set; }
        public Vector3                                  M_Acceleration                          { get; set; }
        public Vector3                                  M_AngularAcceleration                   { get; set; }
        public int                                      M_Tracked                               { get; set; }
        public ulong                                    M_UniqueID                              { get; set; }

        public static XRNodeState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRNodeState() { Pointer= p0 };

            value.M_Type                                    = (XRNode)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Type                      ( ModelEnumType XRNode XRNode XRNode Int32 )
            value.M_AvailableFields                         = (AvailableTrackingData)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_AvailableFields           ( ModelEnumType AvailableTrackingData AvailableTrackingData AvailableTrackingData Int32 )
            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Position                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Rotation                                = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_Rotation                  ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_Velocity                                = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_Velocity                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AngularVelocity                         = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_AngularVelocity           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Acceleration                            = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_Acceleration              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AngularAcceleration                     = (Vector3)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_AngularAcceleration       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Tracked                                 = GetInt32(new IntPtr(p + 0x064)); // 0x64 M_Tracked                   ( ModelPrimitiveType int int int Int32 )
            value.M_UniqueID                                = GetUInt64(new IntPtr(p + 0x068)); // 0x68 M_UniqueID                  ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
