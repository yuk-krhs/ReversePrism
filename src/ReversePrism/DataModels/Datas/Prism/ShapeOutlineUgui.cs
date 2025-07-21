using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 Texture                                  ModelClassType Texture Texture Texture Pointer
    // 0E8 ShapeUgui                                ModelClassType IShapeUgui IShapeUgui IShapeUgui Pointer
    // 0F0 IsIgnoreParentColor                      ModelPrimitiveType bool bool bool Bool
    public partial class ShapeOutlineUgui : DataModel
    {
        public Texture?                                 Texture                                 { get; set; }
        public IShapeUgui?                              ShapeUgui                               { get; set; }
        public bool                                     IsIgnoreParentColor                     { get; set; }

        public static ShapeOutlineUgui? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShapeOutlineUgui() { Pointer= p0 };

            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Texture.FromPointer); // 0xE0 Texture                     ( ModelClassType Texture Texture Texture Pointer )
            value.ShapeUgui                                 = GetObject<IShapeUgui>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.IShapeUgui.FromPointer); // 0xE8 ShapeUgui                   ( ModelClassType IShapeUgui IShapeUgui IShapeUgui Pointer )
            value.IsIgnoreParentColor                       = GetBool(new IntPtr(p + 0x0F0)); // 0xF0 IsIgnoreParentColor         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
