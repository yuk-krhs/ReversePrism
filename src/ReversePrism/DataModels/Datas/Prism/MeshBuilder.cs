using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vert                                     000185D26998 ModelEnumListType List`1<VertexData> List`1<VertexData> List<VertexData> Pointer
    // 018 Tris                                     000185D18F78 ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer
    public partial class MeshBuilder
    {
        public List<VertexData>?                        Vert                                    { get; set; }
        public List<ushort>?                            Tris                                    { get; set; }

        public static MeshBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshBuilder();

            value.Vert                                      = GetEnumList<VertexData>(new IntPtr(p + 0x010)); // 0270D4E831D0 0x10 Vert                        ( 000185D26998 ModelEnumListType List`1<VertexData> List`1<VertexData> List<VertexData> Pointer )
            value.Tris                                      = GetUInt16List(new IntPtr(p + 0x018)); // 0270D4E831F0 0x18 Tris                        ( 000185D18F78 ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer )

            return value;
        }
    }
}
