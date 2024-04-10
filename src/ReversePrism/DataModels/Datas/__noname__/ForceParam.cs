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
    public partial class ForceParam : DataModel
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
            var value   = new ForceParam() { Pointer= p0 };

            value.NotRotate                                 = GetBool(new IntPtr(p + 0x010)); // 0245A69BE6E0 0x10 NotRotate                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BendStrength                              = GetSingle(new IntPtr(p + 0x014)); // 0245A69BE700 0x14 BendStrength                ( 000186666050 ModelPrimitiveType float float float Single )
            value.BaseGravity                               = GetSingle(new IntPtr(p + 0x018)); // 0245A69BE720 0x18 BaseGravity                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.InertiaMoment                             = GetSingle(new IntPtr(p + 0x01C)); // 0245A69BE740 0x1C InertiaMoment               ( 000186666050 ModelPrimitiveType float float float Single )
            value.AirResistance                             = GetSingle(new IntPtr(p + 0x020)); // 0245A69BE760 0x20 AirResistance               ( 000186666050 ModelPrimitiveType float float float Single )
            value.DeformResistance                          = GetSingle(new IntPtr(p + 0x024)); // 0245A69BE780 0x24 DeformResistance            ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
