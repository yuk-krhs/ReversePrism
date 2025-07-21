using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Edge1                                    ModelClassType TEdge TEdge TEdge Pointer
    // 018 Edge2                                    ModelClassType TEdge TEdge TEdge Pointer
    // 020 Pt                                       ModelEnumType IntPoint IntPoint IntPoint Int32
    public partial class IntersectNode : DataModel
    {
        public TEdge?                                   Edge1                                   { get; set; }
        public TEdge?                                   Edge2                                   { get; set; }
        public IntPoint                                 Pt                                      { get; set; }

        public static IntersectNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntersectNode() { Pointer= p0 };

            value.Edge1                                     = GetObject<TEdge>(new IntPtr(p + 0x010), ReversePrism.DataModels.TEdge.FromPointer); // 0x10 Edge1                       ( ModelClassType TEdge TEdge TEdge Pointer )
            value.Edge2                                     = GetObject<TEdge>(new IntPtr(p + 0x018), ReversePrism.DataModels.TEdge.FromPointer); // 0x18 Edge2                       ( ModelClassType TEdge TEdge TEdge Pointer )
            value.Pt                                        = (IntPoint)GetInt32(new IntPtr(p + 0x020)); // 0x20 Pt                          ( ModelEnumType IntPoint IntPoint IntPoint Int32 )

            return value;
        }
    }
}
