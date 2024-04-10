using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 c_InvalidFaceIndex                       uint IL2CPP_TYPE_U4
    // 010 M_ColliderID                             0001865F44E0 ModelPrimitiveType int int int Int32
    // 014 M_OtherColliderID                        0001865F44E0 ModelPrimitiveType int int int Int32
    // 018 m_StartPtr                               <int> IL2CPP_TYPE_I
    // 020 M_NbPoints                               000186699C60 ModelPrimitiveType uint uint uint UInt32
    // 024 M_Flags                                  0001865CA900 ModelEnumType CollisionPairFlags CollisionPairFlags CollisionPairFlags Int32
    // 026 M_Events                                 0001865CA220 ModelEnumType CollisionPairEventFlags CollisionPairEventFlags CollisionPairEventFlags Int32
    // 028 M_ImpulseSum                             0001866AC6C0 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class ContactPair : DataModel
    {
        public int                                      M_ColliderID                            { get; set; }
        public int                                      M_OtherColliderID                       { get; set; }
        public uint                                     M_NbPoints                              { get; set; }
        public CollisionPairFlags                       M_Flags                                 { get; set; }
        public CollisionPairEventFlags                  M_Events                                { get; set; }
        public Vector3                                  M_ImpulseSum                            { get; set; }

        public static ContactPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContactPair() { Pointer= p0 };

            value.M_ColliderID                              = GetInt32(new IntPtr(p + 0x010)); // 0245A2143038 0x10 M_ColliderID                ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.M_OtherColliderID                         = GetInt32(new IntPtr(p + 0x014)); // 0245A2143058 0x14 M_OtherColliderID           ( 0001865F44E0 ModelPrimitiveType int int int Int32 )
            value.M_NbPoints                                = GetUInt32(new IntPtr(p + 0x020)); // 0245A2143098 0x20 M_NbPoints                  ( 000186699C60 ModelPrimitiveType uint uint uint UInt32 )
            value.M_Flags                                   = (CollisionPairFlags)GetInt32(new IntPtr(p + 0x024)); // 0245A21430B8 0x24 M_Flags                     ( 0001865CA900 ModelEnumType CollisionPairFlags CollisionPairFlags CollisionPairFlags Int32 )
            value.M_Events                                  = (CollisionPairEventFlags)GetInt32(new IntPtr(p + 0x026)); // 0245A21430D8 0x26 M_Events                    ( 0001865CA220 ModelEnumType CollisionPairEventFlags CollisionPairEventFlags CollisionPairEventFlags Int32 )
            value.M_ImpulseSum                              = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0245A21430F8 0x28 M_ImpulseSum                ( 0001866AC6C0 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
