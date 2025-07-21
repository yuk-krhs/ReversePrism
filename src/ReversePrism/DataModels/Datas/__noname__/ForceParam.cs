using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NotRotate                                ModelPrimitiveType bool bool bool Bool
    // 014 BendStrength                             ModelPrimitiveType float float float Single
    // 018 BaseGravity                              ModelPrimitiveType float float float Single
    // 01C InertiaMoment                            ModelPrimitiveType float float float Single
    // 020 AirResistance                            ModelPrimitiveType float float float Single
    // 024 DeformResistance                         ModelPrimitiveType float float float Single
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

            value.NotRotate                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 NotRotate                   ( ModelPrimitiveType bool bool bool Bool )
            value.BendStrength                              = GetSingle(new IntPtr(p + 0x014)); // 0x14 BendStrength                ( ModelPrimitiveType float float float Single )
            value.BaseGravity                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 BaseGravity                 ( ModelPrimitiveType float float float Single )
            value.InertiaMoment                             = GetSingle(new IntPtr(p + 0x01C)); // 0x1C InertiaMoment               ( ModelPrimitiveType float float float Single )
            value.AirResistance                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 AirResistance               ( ModelPrimitiveType float float float Single )
            value.DeformResistance                          = GetSingle(new IntPtr(p + 0x024)); // 0x24 DeformResistance            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
