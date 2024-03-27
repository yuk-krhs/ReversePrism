using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 MeshColor                                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0B8 ShapeType                                000186659B70 ModelEnumType ShapeType ShapeType ShapeType Int32
    // 0C0 VertexPosList                            000185D1AB78 ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer
    public partial class UICustomMesh
    {
        public Color                                    MeshColor                               { get; set; }
        public ShapeType                                ShapeType                               { get; set; }
        public List<Vector2>?                           VertexPosList                           { get; set; }

        public static UICustomMesh? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICustomMesh();

            value.MeshColor                                 = (Color)GetInt32(new IntPtr(p + 0x0A8)); // 0270DBA9B8A0 0xA8 MeshColor                   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.ShapeType                                 = (ShapeType)GetInt32(new IntPtr(p + 0x0B8)); // 0270DBA9B8C0 0xB8 ShapeType                   ( 000186659B70 ModelEnumType ShapeType ShapeType ShapeType Int32 )
            value.VertexPosList                             = GetEnumList<Vector2>(new IntPtr(p + 0x0C0)); // 0270DBA9B8E0 0xC0 VertexPosList               ( 000185D1AB78 ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer )

            return value;
        }
    }
}
