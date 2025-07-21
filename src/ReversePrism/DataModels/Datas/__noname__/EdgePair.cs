using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 E                                        ModelClassType Edge Edge Edge Pointer
    // 018 ESym                                     ModelClassType Edge Edge Edge Pointer
    public partial class EdgePair : DataModel
    {
        public Edge?                                    E                                       { get; set; }
        public Edge?                                    ESym                                    { get; set; }

        public static EdgePair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EdgePair() { Pointer= p0 };

            value.E                                         = GetObject<Edge>(new IntPtr(p + 0x010), ReversePrism.DataModels.Edge.FromPointer); // 0x10 E                           ( ModelClassType Edge Edge Edge Pointer )
            value.ESym                                      = GetObject<Edge>(new IntPtr(p + 0x018), ReversePrism.DataModels.Edge.FromPointer); // 0x18 ESym                        ( ModelClassType Edge Edge Edge Pointer )

            return value;
        }
    }
}
