using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_WriteEnabled                           ModelPrimitiveType sbyte sbyte sbyte SByte
    // 011 M_CompareFunction                        ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DepthState : DataModel
    {
        public sbyte                                    M_WriteEnabled                          { get; set; }
        public sbyte                                    M_CompareFunction                       { get; set; }

        public static DepthState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DepthState() { Pointer= p0 };

            value.M_WriteEnabled                            = GetSByte(new IntPtr(p + 0x010)); // 0x10 M_WriteEnabled              ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_CompareFunction                         = GetSByte(new IntPtr(p + 0x011)); // 0x11 M_CompareFunction           ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
