using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 Texture                                  ModelClassType Texture Texture Texture Pointer
    // 0E8 Vertices                                 ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer
    // 0F0 OutlineSize                              ModelPrimitiveType float float float Single
    // 0F4 ScaleOffset                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 100 IsMonospacedOutline                      ModelPrimitiveType bool bool bool Bool
    // 104 OutlineColor                             ModelEnumType Color Color Color Int32
    // 118 Outline                                  ModelClassType ShapeOutlineUgui ShapeOutlineUgui ShapeOutlineUgui Pointer
    // 120 IsIgnoreParentColor                      ModelPrimitiveType bool bool bool Bool
    // 121 IsDirtyOutline                           ModelPrimitiveType bool bool bool Bool
    // 124 Bounds                                   ModelEnumType Bounds Bounds Bounds Int32
    public partial class ShapeUgui : DataModel
    {
        public Texture?                                 Texture                                 { get; set; }
        public List<Vector2>?                           Vertices                                { get; set; }
        public float                                    OutlineSize                             { get; set; }
        public Vector3                                  ScaleOffset                             { get; set; }
        public bool                                     IsMonospacedOutline                     { get; set; }
        public Color                                    OutlineColor                            { get; set; }
        public ShapeOutlineUgui?                        Outline                                 { get; set; }
        public bool                                     IsIgnoreParentColor                     { get; set; }
        public bool                                     IsDirtyOutline                          { get; set; }
        public Bounds                                   Bounds                                  { get; set; }

        public static ShapeUgui? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShapeUgui() { Pointer= p0 };

            value.Texture                                   = GetObject<Texture>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Texture.FromPointer); // 0xE0 Texture                     ( ModelClassType Texture Texture Texture Pointer )
            value.Vertices                                  = GetEnumList<Vector2>(new IntPtr(p + 0x0E8)); // 0xE8 Vertices                    ( ModelEnumListType List`1<Vector2> List`1<Vector2> List<Vector2> Pointer )
            value.OutlineSize                               = GetSingle(new IntPtr(p + 0x0F0)); // 0xF0 OutlineSize                 ( ModelPrimitiveType float float float Single )
            value.ScaleOffset                               = (Vector3)GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 ScaleOffset                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.IsMonospacedOutline                       = GetBool(new IntPtr(p + 0x100)); // 0x100 IsMonospacedOutline         ( ModelPrimitiveType bool bool bool Bool )
            value.OutlineColor                              = (Color)GetInt32(new IntPtr(p + 0x104)); // 0x104 OutlineColor                ( ModelEnumType Color Color Color Int32 )
            value.Outline                                   = GetObject<ShapeOutlineUgui>(new IntPtr(p + 0x118), ReversePrism.DataModels.ShapeOutlineUgui.FromPointer); // 0x118 Outline                     ( ModelClassType ShapeOutlineUgui ShapeOutlineUgui ShapeOutlineUgui Pointer )
            value.IsIgnoreParentColor                       = GetBool(new IntPtr(p + 0x120)); // 0x120 IsIgnoreParentColor         ( ModelPrimitiveType bool bool bool Bool )
            value.IsDirtyOutline                            = GetBool(new IntPtr(p + 0x121)); // 0x121 IsDirtyOutline              ( ModelPrimitiveType bool bool bool Bool )
            value.Bounds                                    = (Bounds)GetInt32(new IntPtr(p + 0x124)); // 0x124 Bounds                      ( ModelEnumType Bounds Bounds Bounds Int32 )

            return value;
        }
    }
}
