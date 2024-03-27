using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IntensityScale                           000186666050 ModelPrimitiveType float float float Single
    // 024 InvalidateProbes                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 025 OverrideDilationThreshold                000186595960 ModelPrimitiveType bool bool bool Bool
    // 028 OverriddenDilationThreshold              000186666050 ModelPrimitiveType float float float Single
    // 02C Size                                     0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class ProbeTouchupVolume
    {
        public float                                    IntensityScale                          { get; set; }
        public bool                                     InvalidateProbes                        { get; set; }
        public bool                                     OverrideDilationThreshold               { get; set; }
        public float                                    OverriddenDilationThreshold             { get; set; }
        public Vector3                                  Size                                    { get; set; }

        public static ProbeTouchupVolume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProbeTouchupVolume();

            value.IntensityScale                            = GetSingle(new IntPtr(p + 0x020)); // 0270D9220348 0x20 IntensityScale              ( 000186666050 ModelPrimitiveType float float float Single )
            value.InvalidateProbes                          = GetBool(new IntPtr(p + 0x024)); // 0270D9220368 0x24 InvalidateProbes            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OverrideDilationThreshold                 = GetBool(new IntPtr(p + 0x025)); // 0270D9220388 0x25 OverrideDilationThreshold   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OverriddenDilationThreshold               = GetSingle(new IntPtr(p + 0x028)); // 0270D92203A8 0x28 OverriddenDilationThreshold ( 000186666050 ModelPrimitiveType float float float Single )
            value.Size                                      = (Vector3)GetInt32(new IntPtr(p + 0x02C)); // 0270D92203C8 0x2C Size                        ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
