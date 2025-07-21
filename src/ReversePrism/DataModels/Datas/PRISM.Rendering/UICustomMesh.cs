using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 MeshColor                                ModelEnumType Color Color Color Int32
    // 0B8 ShapeType                                ModelEnumType ShapeType ShapeType ShapeType Int32
    // 0C0 VertexPosList                            ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer
    public partial class UICustomMesh : DataModel
    {
        public Color                                    MeshColor                               { get; set; }
        public ShapeType                                ShapeType                               { get; set; }
        public List<Vector2>?                           VertexPosList                           { get; set; }

        public static UICustomMesh? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UICustomMesh() { Pointer= p0 };

            value.MeshColor                                 = (Color)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 MeshColor                   ( ModelEnumType Color Color Color Int32 )
            value.ShapeType                                 = (ShapeType)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 ShapeType                   ( ModelEnumType ShapeType ShapeType ShapeType Int32 )
            value.VertexPosList                             = GetEnumList<Vector2>(new IntPtr(p + 0x0C0)); // 0xC0 VertexPosList               ( ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer )

            return value;
        }
    }
}
