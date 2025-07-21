using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Y                                        ModelPrimitiveType long long long Int64
    // 018 LeftBound                                ModelClassType TEdge TEdge TEdge Pointer
    // 020 RightBound                               ModelClassType TEdge TEdge TEdge Pointer
    // 028 Next                                     ModelClassType LocalMinima LocalMinima LocalMinima Pointer
    public partial class LocalMinima : DataModel
    {
        public long                                     Y                                       { get; set; }
        public TEdge?                                   LeftBound                               { get; set; }
        public TEdge?                                   RightBound                              { get; set; }
        public LocalMinima?                             Next                                    { get; set; }

        public static LocalMinima? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalMinima() { Pointer= p0 };

            value.Y                                         = GetInt64(new IntPtr(p + 0x010)); // 0x10 Y                           ( ModelPrimitiveType long long long Int64 )
            value.LeftBound                                 = GetObject<TEdge>(new IntPtr(p + 0x018), ReversePrism.DataModels.TEdge.FromPointer); // 0x18 LeftBound                   ( ModelClassType TEdge TEdge TEdge Pointer )
            value.RightBound                                = GetObject<TEdge>(new IntPtr(p + 0x020), ReversePrism.DataModels.TEdge.FromPointer); // 0x20 RightBound                  ( ModelClassType TEdge TEdge TEdge Pointer )
            value.Next                                      = GetObject<LocalMinima>(new IntPtr(p + 0x028), ReversePrism.DataModels.LocalMinima.FromPointer); // 0x28 Next                        ( ModelClassType LocalMinima LocalMinima LocalMinima Pointer )

            return value;
        }
    }
}
