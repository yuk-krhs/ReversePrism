using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Power                                    ModelPrimitiveType float float float Single
    // 024 Degree                                   ModelPrimitiveType float float float Single
    // 028 PowerRange                               ModelPrimitiveType float float float Single
    // 02C DegreeRange                              ModelPrimitiveType float float float Single
    public partial class WindController : DataModel
    {
        public float                                    Power                                   { get; set; }
        public float                                    Degree                                  { get; set; }
        public float                                    PowerRange                              { get; set; }
        public float                                    DegreeRange                             { get; set; }

        public static WindController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WindController() { Pointer= p0 };

            value.Power                                     = GetSingle(new IntPtr(p + 0x020)); // 0x20 Power                       ( ModelPrimitiveType float float float Single )
            value.Degree                                    = GetSingle(new IntPtr(p + 0x024)); // 0x24 Degree                      ( ModelPrimitiveType float float float Single )
            value.PowerRange                                = GetSingle(new IntPtr(p + 0x028)); // 0x28 PowerRange                  ( ModelPrimitiveType float float float Single )
            value.DegreeRange                               = GetSingle(new IntPtr(p + 0x02C)); // 0x2C DegreeRange                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
