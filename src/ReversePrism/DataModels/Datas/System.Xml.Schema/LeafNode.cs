using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pos                                      ModelPrimitiveType int int int Int32
    public partial class LeafNode : DataModel
    {
        public int                                      Pos                                     { get; set; }

        public static LeafNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LeafNode() { Pointer= p0 };

            value.Pos                                       = GetInt32(new IntPtr(p + 0x010)); // 0x10 Pos                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
