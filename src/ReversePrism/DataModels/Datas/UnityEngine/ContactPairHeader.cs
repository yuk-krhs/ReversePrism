using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_BodyID                                 ModelPrimitiveType int int int Int32
    // 014 M_OtherBodyID                            ModelPrimitiveType int int int Int32
    // 018 m_StartPtr                               <int> IL2CPP_TYPE_I
    // 020 M_NbPairs                                ModelPrimitiveType uint uint uint UInt32
    // 024 M_Flags                                  ModelEnumType CollisionPairHeaderFlags CollisionPairHeaderFlags CollisionPairHeaderFlags Int32
    // 028 M_RelativeVelocity                       ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class ContactPairHeader : DataModel
    {
        public int                                      M_BodyID                                { get; set; }
        public int                                      M_OtherBodyID                           { get; set; }
        public uint                                     M_NbPairs                               { get; set; }
        public CollisionPairHeaderFlags                 M_Flags                                 { get; set; }
        public Vector3                                  M_RelativeVelocity                      { get; set; }

        public static ContactPairHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContactPairHeader() { Pointer= p0 };

            value.M_BodyID                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_BodyID                    ( ModelPrimitiveType int int int Int32 )
            value.M_OtherBodyID                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_OtherBodyID               ( ModelPrimitiveType int int int Int32 )
            value.M_NbPairs                                 = GetUInt32(new IntPtr(p + 0x020)); // 0x20 M_NbPairs                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_Flags                                   = (CollisionPairHeaderFlags)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_Flags                     ( ModelEnumType CollisionPairHeaderFlags CollisionPairHeaderFlags CollisionPairHeaderFlags Int32 )
            value.M_RelativeVelocity                        = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_RelativeVelocity          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
