using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VertexPair                               ModelEnumType int2 int2 int2 Int32
    // 018 Cost                                     ModelPrimitiveType float float float Single
    public partial class JoinEdge : DataModel
    {
        public int2                                     VertexPair                              { get; set; }
        public float                                    Cost                                    { get; set; }

        public static JoinEdge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JoinEdge() { Pointer= p0 };

            value.VertexPair                                = (int2)GetInt32(new IntPtr(p + 0x010)); // 0x10 VertexPair                  ( ModelEnumType int2 int2 int2 Int32 )
            value.Cost                                      = GetSingle(new IntPtr(p + 0x018)); // 0x18 Cost                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
