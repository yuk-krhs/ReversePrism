using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 M_AllPolys                               ModelClassListType List`1<PolyNode> List`1<PolyNode> List<PolyNode> Pointer
    public partial class PolyTree : DataModel
    {
        public List<PolyNode>?                          M_AllPolys                              { get; set; }

        public static PolyTree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PolyTree() { Pointer= p0 };

            value.M_AllPolys                                = GetObjectList<PolyNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.PolyNode.FromPointer); // 0x40 M_AllPolys                  ( ModelClassListType List`1<PolyNode> List`1<PolyNode> List<PolyNode> Pointer )

            return value;
        }
    }
}
