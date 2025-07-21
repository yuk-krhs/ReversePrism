using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VHead                                    ModelClassType Vertex Vertex Vertex Pointer
    // 018 FHead                                    ModelClassType Face Face Face Pointer
    // 020 EHead                                    ModelClassType Edge Edge Edge Pointer
    // 028 EHeadSym                                 ModelClassType Edge Edge Edge Pointer
    public partial class Mesh : DataModel
    {
        public Vertex?                                  VHead                                   { get; set; }
        public Face?                                    FHead                                   { get; set; }
        public Edge?                                    EHead                                   { get; set; }
        public Edge?                                    EHeadSym                                { get; set; }

        public static Mesh? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Mesh() { Pointer= p0 };

            value.VHead                                     = GetObject<Vertex>(new IntPtr(p + 0x010), ReversePrism.DataModels.Vertex.FromPointer); // 0x10 VHead                       ( ModelClassType Vertex Vertex Vertex Pointer )
            value.FHead                                     = GetObject<Face>(new IntPtr(p + 0x018), ReversePrism.DataModels.Face.FromPointer); // 0x18 FHead                       ( ModelClassType Face Face Face Pointer )
            value.EHead                                     = GetObject<Edge>(new IntPtr(p + 0x020), ReversePrism.DataModels.Edge.FromPointer); // 0x20 EHead                       ( ModelClassType Edge Edge Edge Pointer )
            value.EHeadSym                                  = GetObject<Edge>(new IntPtr(p + 0x028), ReversePrism.DataModels.Edge.FromPointer); // 0x28 EHeadSym                    ( ModelClassType Edge Edge Edge Pointer )

            return value;
        }
    }
}
