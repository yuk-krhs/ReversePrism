using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NotRotate                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 BendStrength                             000186666050 ModelPrimitiveType float float float Single
    // 018 BaseGravity                              000186666050 ModelPrimitiveType float float float Single
    // 01C InertiaMoment                            000186666050 ModelPrimitiveType float float float Single
    // 020 AirResistance                            000186666050 ModelPrimitiveType float float float Single
    // 024 DeformResistance                         000186666050 ModelPrimitiveType float float float Single
    public partial class ForceParam
    {
        public bool                                     NotRotate                               { get; set; }
        public float                                    BendStrength                            { get; set; }
        public float                                    BaseGravity                             { get; set; }
        public float                                    InertiaMoment                           { get; set; }
        public float                                    AirResistance                           { get; set; }
        public float                                    DeformResistance                        { get; set; }

        public static ForceParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForceParam();

            value.NotRotate                                 = GetBool(new IntPtr(p + 0x010)); // 027006A08858 0x10 NotRotate                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BendStrength                              = GetSingle(new IntPtr(p + 0x014)); // 027006A08878 0x14 BendStrength                ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaseGravity                               = GetSingle(new IntPtr(p + 0x018)); // 027006A08898 0x18 BaseGravity                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.InertiaMoment                             = GetSingle(new IntPtr(p + 0x01C)); // 027006A088B8 0x1C InertiaMoment               ( 000186666050 ModelPrimitiveType float float float Single )
            value.AirResistance                             = GetSingle(new IntPtr(p + 0x020)); // 027006A088D8 0x20 AirResistance               ( 000186666050 ModelPrimitiveType float float float Single )
            value.DeformResistance                          = GetSingle(new IntPtr(p + 0x024)); // 027006A088F8 0x24 DeformResistance            ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
