using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 M_ApplyAfter                             ModelEnumType Stage Stage Stage Int32
    // 034 M_ChannelMask                            ModelPrimitiveType int int int Int32
    // 038 M_Gain                                   ModelPrimitiveType float float float Single
    // 03C M_Use2DDistance                          ModelPrimitiveType bool bool bool Bool
    // 03D M_UseCameraSpace                         ModelPrimitiveType bool bool bool Bool
    // 040 M_ReactionSettings                       ModelEnumType ImpulseReaction ImpulseReaction ImpulseReaction Int32
    public partial class CinemachineImpulseListener : DataModel
    {
        public Stage                                    M_ApplyAfter                            { get; set; }
        public int                                      M_ChannelMask                           { get; set; }
        public float                                    M_Gain                                  { get; set; }
        public bool                                     M_Use2DDistance                         { get; set; }
        public bool                                     M_UseCameraSpace                        { get; set; }
        public ImpulseReaction                          M_ReactionSettings                      { get; set; }

        public static CinemachineImpulseListener? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineImpulseListener() { Pointer= p0 };

            value.M_ApplyAfter                              = (Stage)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_ApplyAfter                ( ModelEnumType Stage Stage Stage Int32 )
            value.M_ChannelMask                             = GetInt32(new IntPtr(p + 0x034)); // 0x34 M_ChannelMask               ( ModelPrimitiveType int int int Int32 )
            value.M_Gain                                    = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_Gain                      ( ModelPrimitiveType float float float Single )
            value.M_Use2DDistance                           = GetBool(new IntPtr(p + 0x03C)); // 0x3C M_Use2DDistance             ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseCameraSpace                          = GetBool(new IntPtr(p + 0x03D)); // 0x3D M_UseCameraSpace            ( ModelPrimitiveType bool bool bool Bool )
            value.M_ReactionSettings                        = (ImpulseReaction)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_ReactionSettings          ( ModelEnumType ImpulseReaction ImpulseReaction ImpulseReaction Int32 )

            return value;
        }
    }
}
