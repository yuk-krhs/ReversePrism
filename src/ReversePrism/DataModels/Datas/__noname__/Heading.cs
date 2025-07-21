using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Definition                             ModelEnumType HeadingDefinition HeadingDefinition HeadingDefinition Int32
    // 014 M_VelocityFilterStrength                 ModelPrimitiveType int int int Int32
    // 018 M_Bias                                   ModelPrimitiveType float float float Single
    public partial class Heading : DataModel
    {
        public HeadingDefinition                        M_Definition                            { get; set; }
        public int                                      M_VelocityFilterStrength                { get; set; }
        public float                                    M_Bias                                  { get; set; }

        public static Heading? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Heading() { Pointer= p0 };

            value.M_Definition                              = (HeadingDefinition)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Definition                ( ModelEnumType HeadingDefinition HeadingDefinition HeadingDefinition Int32 )
            value.M_VelocityFilterStrength                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_VelocityFilterStrength    ( ModelPrimitiveType int int int Int32 )
            value.M_Bias                                    = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_Bias                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
