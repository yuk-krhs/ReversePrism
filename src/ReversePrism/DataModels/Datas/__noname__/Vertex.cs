using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prev                                     ModelClassType Vertex Vertex Vertex Pointer
    // 018 Next                                     ModelClassType Vertex Vertex Vertex Pointer
    // 020 AnEdge                                   ModelClassType Edge Edge Edge Pointer
    // 028 Coords                                   ModelEnumType Vec3 Vec3 Vec3 Int32
    // 034 S                                        ModelPrimitiveType float float float Single
    // 038 T                                        ModelPrimitiveType float float float Single
    // 03C PqHandle                                 ModelEnumType PQHandle PQHandle PQHandle Int32
    // 040 N                                        ModelPrimitiveType int int int Int32
    // 048 _data                                    <object> IL2CPP_TYPE_OBJECT
    public partial class Vertex : DataModel
    {
        public Vertex?                                  Prev                                    { get; set; }
        public Vertex?                                  Next                                    { get; set; }
        public Edge?                                    AnEdge                                  { get; set; }
        public Vec3                                     Coords                                  { get; set; }
        public float                                    S                                       { get; set; }
        public float                                    T                                       { get; set; }
        public PQHandle                                 PqHandle                                { get; set; }
        public int                                      N                                       { get; set; }

        public static Vertex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vertex() { Pointer= p0 };

            value.Prev                                      = GetObject<Vertex>(new IntPtr(p + 0x010), ReversePrism.DataModels.Vertex.FromPointer); // 0x10 Prev                        ( ModelClassType Vertex Vertex Vertex Pointer )
            value.Next                                      = GetObject<Vertex>(new IntPtr(p + 0x018), ReversePrism.DataModels.Vertex.FromPointer); // 0x18 Next                        ( ModelClassType Vertex Vertex Vertex Pointer )
            value.AnEdge                                    = GetObject<Edge>(new IntPtr(p + 0x020), ReversePrism.DataModels.Edge.FromPointer); // 0x20 AnEdge                      ( ModelClassType Edge Edge Edge Pointer )
            value.Coords                                    = (Vec3)GetInt32(new IntPtr(p + 0x028)); // 0x28 Coords                      ( ModelEnumType Vec3 Vec3 Vec3 Int32 )
            value.S                                         = GetSingle(new IntPtr(p + 0x034)); // 0x34 S                           ( ModelPrimitiveType float float float Single )
            value.T                                         = GetSingle(new IntPtr(p + 0x038)); // 0x38 T                           ( ModelPrimitiveType float float float Single )
            value.PqHandle                                  = (PQHandle)GetInt32(new IntPtr(p + 0x03C)); // 0x3C PqHandle                    ( ModelEnumType PQHandle PQHandle PQHandle Int32 )
            value.N                                         = GetInt32(new IntPtr(p + 0x040)); // 0x40 N                           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
