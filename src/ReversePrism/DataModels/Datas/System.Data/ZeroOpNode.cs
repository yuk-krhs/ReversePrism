using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Op                                       ModelPrimitiveType int int int Int32
    public partial class ZeroOpNode : DataModel
    {
        public int                                      Op                                      { get; set; }

        public static ZeroOpNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ZeroOpNode() { Pointer= p0 };

            value.Op                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Op                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
