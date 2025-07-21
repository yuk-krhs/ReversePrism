using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Vert                                     ModelEnumListType List`1<VertexData> List`1<VertexData> List<VertexData> Pointer
    // 018 Tris                                     ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer
    public partial class MeshBuilder : DataModel
    {
        public List<VertexData>?                        Vert                                    { get; set; }
        public List<ushort>?                            Tris                                    { get; set; }

        public static MeshBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshBuilder() { Pointer= p0 };

            value.Vert                                      = GetEnumList<VertexData>(new IntPtr(p + 0x010)); // 0x10 Vert                        ( ModelEnumListType List`1<VertexData> List`1<VertexData> List<VertexData> Pointer )
            value.Tris                                      = GetUInt16List(new IntPtr(p + 0x018)); // 0x18 Tris                        ( ModelPrimitiveListType List`1<ushort> List`1<ushort> List<ushort> Pointer )

            return value;
        }
    }
}
