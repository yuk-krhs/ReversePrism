using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 F                                        000186666050 ModelPrimitiveType float float float Single
    // 010 U                                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class Union : DataModel
    {
        public float                                    F                                       { get; set; }
        public uint                                     U                                       { get; set; }

        public static Union? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Union() { Pointer= p0 };

            value.F                                         = GetSingle(new IntPtr(p + 0x010)); // 02466A974EA0 0x10 F                           ( 000186666050 ModelPrimitiveType float float float Single )
            value.U                                         = GetUInt32(new IntPtr(p + 0x010)); // 02466A974EC0 0x10 U                           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
