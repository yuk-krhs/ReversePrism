using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Type                                   000186583760 ModelEnumType XRNode XRNode XRNode Int32
    // 014 M_AvailableFields                        00018672A080 ModelEnumType AvailableTrackingData AvailableTrackingData AvailableTrackingData Int32
    // 018 M_Position                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 M_Rotation                               000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 034 M_Velocity                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 M_AngularVelocity                        0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C M_Acceleration                           0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 M_AngularAcceleration                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 064 M_Tracked                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 M_UniqueID                               00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class XRNodeState
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
            var value   = new XRNodeState();

            value.M_Type                                    = (XRNode)GetInt32(new IntPtr(p + 0x010)); // 0270021265D8 0x10 M_Type                      ( 000186583760 ModelEnumType XRNode XRNode XRNode Int32 )
            value.M_AvailableFields                         = (AvailableTrackingData)GetInt32(new IntPtr(p + 0x014)); // 0270021265F8 0x14 M_AvailableFields           ( 00018672A080 ModelEnumType AvailableTrackingData AvailableTrackingData AvailableTrackingData Int32 )
            value.M_Position                                = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 027002126618 0x18 M_Position                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Rotation                                = (Quaternion)GetInt32(new IntPtr(p + 0x024)); // 027002126638 0x24 M_Rotation                  ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_Velocity                                = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 027002126658 0x34 M_Velocity                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AngularVelocity                         = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 027002126678 0x40 M_AngularVelocity           ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Acceleration                            = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 027002126698 0x4C M_Acceleration              ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AngularAcceleration                     = (Vector3)GetInt32(new IntPtr(p + 0x058)); // 0270021266B8 0x58 M_AngularAcceleration       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Tracked                                 = GetInt32(new IntPtr(p + 0x064)); // 0270021266D8 0x64 M_Tracked                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_UniqueID                                = GetUInt64(new IntPtr(p + 0x068)); // 0270021266F8 0x68 M_UniqueID                  ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
