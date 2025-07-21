using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Height                                 ModelPrimitiveType float float float Single
    // 014 M_Radius                                 ModelPrimitiveType float float float Single
    public partial class Orbit : DataModel
    {
        public float                                    M_Height                                { get; set; }
        public float                                    M_Radius                                { get; set; }

        public static Orbit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Orbit() { Pointer= p0 };

            value.M_Height                                  = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_Height                    ( ModelPrimitiveType float float float Single )
            value.M_Radius                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 M_Radius                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
