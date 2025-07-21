using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prev                                     ModelClassType Face Face Face Pointer
    // 018 Next                                     ModelClassType Face Face Face Pointer
    // 020 AnEdge                                   ModelClassType Edge Edge Edge Pointer
    // 028 Trail                                    ModelClassType Face Face Face Pointer
    // 030 N                                        ModelPrimitiveType int int int Int32
    // 034 Marked                                   ModelPrimitiveType bool bool bool Bool
    // 035 Inside                                   ModelPrimitiveType bool bool bool Bool
    public partial class Face : DataModel
    {
        public Face?                                    Prev                                    { get; set; }
        public Face?                                    Next                                    { get; set; }
        public Edge?                                    AnEdge                                  { get; set; }
        public Face?                                    Trail                                   { get; set; }
        public int                                      N                                       { get; set; }
        public bool                                     Marked                                  { get; set; }
        public bool                                     Inside                                  { get; set; }

        public static Face? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Face() { Pointer= p0 };

            value.Prev                                      = GetObject<Face>(new IntPtr(p + 0x010), ReversePrism.DataModels.Face.FromPointer); // 0x10 Prev                        ( ModelClassType Face Face Face Pointer )
            value.Next                                      = GetObject<Face>(new IntPtr(p + 0x018), ReversePrism.DataModels.Face.FromPointer); // 0x18 Next                        ( ModelClassType Face Face Face Pointer )
            value.AnEdge                                    = GetObject<Edge>(new IntPtr(p + 0x020), ReversePrism.DataModels.Edge.FromPointer); // 0x20 AnEdge                      ( ModelClassType Edge Edge Edge Pointer )
            value.Trail                                     = GetObject<Face>(new IntPtr(p + 0x028), ReversePrism.DataModels.Face.FromPointer); // 0x28 Trail                       ( ModelClassType Face Face Face Pointer )
            value.N                                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 N                           ( ModelPrimitiveType int int int Int32 )
            value.Marked                                    = GetBool(new IntPtr(p + 0x034)); // 0x34 Marked                      ( ModelPrimitiveType bool bool bool Bool )
            value.Inside                                    = GetBool(new IntPtr(p + 0x035)); // 0x35 Inside                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
