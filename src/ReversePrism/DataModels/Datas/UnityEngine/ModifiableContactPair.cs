using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 actor                                    <int> IL2CPP_TYPE_I
    // 018 otherActor                               <int> IL2CPP_TYPE_I
    // 020 shape                                    <int> IL2CPP_TYPE_I
    // 028 otherShape                               <int> IL2CPP_TYPE_I
    // 030 Rotation                                 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 040 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 04C OtherRotation                            00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 05C OtherPosition                            0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 068 NumContacts                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 contacts                                 <int> IL2CPP_TYPE_I
    public partial class ModifiableContactPair
    {
        public Quaternion                               Rotation                                { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Quaternion                               OtherRotation                           { get; set; }
        public Vector3                                  OtherPosition                           { get; set; }
        public int                                      NumContacts                             { get; set; }

        public static ModifiableContactPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ModifiableContactPair();

            value.Rotation                                  = (Quaternion)GetInt32(new IntPtr(p + 0x030)); // 02700696B3A0 0x30 Rotation                    ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x040)); // 02700696B3C0 0x40 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.OtherRotation                             = (Quaternion)GetInt32(new IntPtr(p + 0x04C)); // 02700696B3E0 0x4C OtherRotation               ( 00018664A340 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.OtherPosition                             = (Vector3)GetInt32(new IntPtr(p + 0x05C)); // 02700696B400 0x5C OtherPosition               ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.NumContacts                               = GetInt32(new IntPtr(p + 0x068)); // 02700696B420 0x68 NumContacts                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
