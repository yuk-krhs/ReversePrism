using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_enabled                                ModelPrimitiveType bool bool bool Bool
    // 014 M_WaitTime                               ModelPrimitiveType float float float Single
    // 018 M_RecenteringTime                        ModelPrimitiveType float float float Single
    // 01C M_LastUpdateTime                         ModelPrimitiveType float float float Single
    // 020 MLastAxisInputTime                       ModelPrimitiveType float float float Single
    // 024 MRecenteringVelocity                     ModelPrimitiveType float float float Single
    // 028 M_LegacyHeadingDefinition                ModelPrimitiveType int int int Int32
    // 02C M_LegacyVelocityFilterStrength           ModelPrimitiveType int int int Int32
    public partial class Recentering : DataModel
    {
        public bool                                     M_enabled                               { get; set; }
        public float                                    M_WaitTime                              { get; set; }
        public float                                    M_RecenteringTime                       { get; set; }
        public float                                    M_LastUpdateTime                        { get; set; }
        public float                                    MLastAxisInputTime                      { get; set; }
        public float                                    MRecenteringVelocity                    { get; set; }
        public int                                      M_LegacyHeadingDefinition               { get; set; }
        public int                                      M_LegacyVelocityFilterStrength          { get; set; }

        public static Recentering? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Recentering() { Pointer= p0 };

            value.M_enabled                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 M_enabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_WaitTime                                = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_WaitTime                  ( ModelPrimitiveType float float float Single )
            value.M_RecenteringTime                         = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_RecenteringTime           ( ModelPrimitiveType float float float Single )
            value.M_LastUpdateTime                          = GetSingle(new IntPtr(p + 0x01C)); // 0x1C M_LastUpdateTime            ( ModelPrimitiveType float float float Single )
            value.MLastAxisInputTime                        = GetSingle(new IntPtr(p + 0x020)); // 0x20 MLastAxisInputTime          ( ModelPrimitiveType float float float Single )
            value.MRecenteringVelocity                      = GetSingle(new IntPtr(p + 0x024)); // 0x24 MRecenteringVelocity        ( ModelPrimitiveType float float float Single )
            value.M_LegacyHeadingDefinition                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_LegacyHeadingDefinition   ( ModelPrimitiveType int int int Int32 )
            value.M_LegacyVelocityFilterStrength            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_LegacyVelocityFilterStrength ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
