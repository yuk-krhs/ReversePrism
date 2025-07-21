using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImpulsePosLastFrame                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C ImpulseRotLastFrame                      ModelEnumType Quaternion Quaternion Quaternion Int32
    // 03C M_ChannelMask                            ModelPrimitiveType int int int Int32
    // 040 M_Gain                                   ModelPrimitiveType float float float Single
    // 044 M_Use2DDistance                          ModelPrimitiveType bool bool bool Bool
    // 045 M_UseLocalSpace                          ModelPrimitiveType bool bool bool Bool
    // 048 M_ReactionSettings                       ModelEnumType ImpulseReaction ImpulseReaction ImpulseReaction Int32
    public partial class CinemachineIndependentImpulseListener : DataModel
    {
        public Vector3                                  ImpulsePosLastFrame                     { get; set; }
        public Quaternion                               ImpulseRotLastFrame                     { get; set; }
        public int                                      M_ChannelMask                           { get; set; }
        public float                                    M_Gain                                  { get; set; }
        public bool                                     M_Use2DDistance                         { get; set; }
        public bool                                     M_UseLocalSpace                         { get; set; }
        public ImpulseReaction                          M_ReactionSettings                      { get; set; }

        public static CinemachineIndependentImpulseListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineIndependentImpulseListener() { Pointer= p0 };

            value.ImpulsePosLastFrame                       = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 ImpulsePosLastFrame         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ImpulseRotLastFrame                       = (Quaternion)GetInt32(new IntPtr(p + 0x02C)); // 0x2C ImpulseRotLastFrame         ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_ChannelMask                             = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_ChannelMask               ( ModelPrimitiveType int int int Int32 )
            value.M_Gain                                    = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_Gain                      ( ModelPrimitiveType float float float Single )
            value.M_Use2DDistance                           = GetBool(new IntPtr(p + 0x044)); // 0x44 M_Use2DDistance             ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseLocalSpace                           = GetBool(new IntPtr(p + 0x045)); // 0x45 M_UseLocalSpace             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ReactionSettings                        = (ImpulseReaction)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_ReactionSettings          ( ModelEnumType ImpulseReaction ImpulseReaction ImpulseReaction Int32 )

            return value;
        }
    }
}
