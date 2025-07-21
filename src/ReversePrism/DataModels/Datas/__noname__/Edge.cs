using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pair                                     ModelEnumType EdgePair EdgePair EdgePair Int32
    // 020 Next                                     ModelClassType Edge Edge Edge Pointer
    // 028 Sym                                      ModelClassType Edge Edge Edge Pointer
    // 030 Onext                                    ModelClassType Edge Edge Edge Pointer
    // 038 Lnext                                    ModelClassType Edge Edge Edge Pointer
    // 040 Org                                      ModelClassType Vertex Vertex Vertex Pointer
    // 048 Lface                                    ModelClassType Face Face Face Pointer
    // 050 ActiveRegion                             ModelClassType ActiveRegion ActiveRegion ActiveRegion Pointer
    // 058 Winding                                  ModelPrimitiveType int int int Int32
    public partial class Edge : DataModel
    {
        public EdgePair                                 Pair                                    { get; set; }
        public Edge?                                    Next                                    { get; set; }
        public Edge?                                    Sym                                     { get; set; }
        public Edge?                                    Onext                                   { get; set; }
        public Edge?                                    Lnext                                   { get; set; }
        public Vertex?                                  Org                                     { get; set; }
        public Face?                                    Lface                                   { get; set; }
        public ActiveRegion?                            ActiveRegion                            { get; set; }
        public int                                      Winding                                 { get; set; }

        public static Edge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Edge() { Pointer= p0 };

            value.Pair                                      = (EdgePair)GetInt32(new IntPtr(p + 0x010)); // 0x10 Pair                        ( ModelEnumType EdgePair EdgePair EdgePair Int32 )
            value.Next                                      = GetObject<Edge>(new IntPtr(p + 0x020), ReversePrism.DataModels.Edge.FromPointer); // 0x20 Next                        ( ModelClassType Edge Edge Edge Pointer )
            value.Sym                                       = GetObject<Edge>(new IntPtr(p + 0x028), ReversePrism.DataModels.Edge.FromPointer); // 0x28 Sym                         ( ModelClassType Edge Edge Edge Pointer )
            value.Onext                                     = GetObject<Edge>(new IntPtr(p + 0x030), ReversePrism.DataModels.Edge.FromPointer); // 0x30 Onext                       ( ModelClassType Edge Edge Edge Pointer )
            value.Lnext                                     = GetObject<Edge>(new IntPtr(p + 0x038), ReversePrism.DataModels.Edge.FromPointer); // 0x38 Lnext                       ( ModelClassType Edge Edge Edge Pointer )
            value.Org                                       = GetObject<Vertex>(new IntPtr(p + 0x040), ReversePrism.DataModels.Vertex.FromPointer); // 0x40 Org                         ( ModelClassType Vertex Vertex Vertex Pointer )
            value.Lface                                     = GetObject<Face>(new IntPtr(p + 0x048), ReversePrism.DataModels.Face.FromPointer); // 0x48 Lface                       ( ModelClassType Face Face Face Pointer )
            value.ActiveRegion                              = GetObject<ActiveRegion>(new IntPtr(p + 0x050), ReversePrism.DataModels.ActiveRegion.FromPointer); // 0x50 ActiveRegion                ( ModelClassType ActiveRegion ActiveRegion ActiveRegion Pointer )
            value.Winding                                   = GetInt32(new IntPtr(p + 0x058)); // 0x58 Winding                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
