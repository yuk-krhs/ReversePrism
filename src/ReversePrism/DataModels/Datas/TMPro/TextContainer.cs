using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_hasChanged                             ModelPrimitiveType bool bool bool Bool
    // 024 M_pivot                                  ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C M_anchorPosition                         ModelEnumType TextContainerAnchors TextContainerAnchors TextContainerAnchors Int32
    // 030 M_rect                                   ModelEnumType Rect Rect Rect Int32
    // 040 M_isDefaultWidth                         ModelPrimitiveType bool bool bool Bool
    // 041 M_isDefaultHeight                        ModelPrimitiveType bool bool bool Bool
    // 042 M_isAutoFitting                          ModelPrimitiveType bool bool bool Bool
    // 048 M_corners                                ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 050 M_worldCorners                           ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 058 M_margins                                ModelEnumType Vector4 Vector4 Vector4 Int32
    // 068 M_rectTransform                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 000 k_defaultSize                            Vector2 IL2CPP_TYPE_VALUETYPE
    // 070 M_textMeshPro                            ModelClassType TextMeshPro TextMeshPro TextMeshPro Pointer
    public partial class TextContainer : DataModel
    {
        public bool                                     M_hasChanged                            { get; set; }
        public Vector2                                  M_pivot                                 { get; set; }
        public TextContainerAnchors                     M_anchorPosition                        { get; set; }
        public Rect                                     M_rect                                  { get; set; }
        public bool                                     M_isDefaultWidth                        { get; set; }
        public bool                                     M_isDefaultHeight                       { get; set; }
        public bool                                     M_isAutoFitting                         { get; set; }
        public List<Vector3>?                           M_corners                               { get; set; }
        public List<Vector3>?                           M_worldCorners                          { get; set; }
        public Vector4                                  M_margins                               { get; set; }
        public RectTransform?                           M_rectTransform                         { get; set; }
        public TextMeshPro?                             M_textMeshPro                           { get; set; }

        public static TextContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextContainer() { Pointer= p0 };

            value.M_hasChanged                              = GetBool(new IntPtr(p + 0x020)); // 0x20 M_hasChanged                ( ModelPrimitiveType bool bool bool Bool )
            value.M_pivot                                   = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_pivot                     ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_anchorPosition                          = (TextContainerAnchors)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_anchorPosition            ( ModelEnumType TextContainerAnchors TextContainerAnchors TextContainerAnchors Int32 )
            value.M_rect                                    = (Rect)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_rect                      ( ModelEnumType Rect Rect Rect Int32 )
            value.M_isDefaultWidth                          = GetBool(new IntPtr(p + 0x040)); // 0x40 M_isDefaultWidth            ( ModelPrimitiveType bool bool bool Bool )
            value.M_isDefaultHeight                         = GetBool(new IntPtr(p + 0x041)); // 0x41 M_isDefaultHeight           ( ModelPrimitiveType bool bool bool Bool )
            value.M_isAutoFitting                           = GetBool(new IntPtr(p + 0x042)); // 0x42 M_isAutoFitting             ( ModelPrimitiveType bool bool bool Bool )
            value.M_corners                                 = GetEnumList<Vector3>(new IntPtr(p + 0x048)); // 0x48 M_corners                   ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_worldCorners                            = GetEnumList<Vector3>(new IntPtr(p + 0x050)); // 0x50 M_worldCorners              ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_margins                                 = (Vector4)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_margins                   ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_rectTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x068), ReversePrism.DataModels.RectTransform.FromPointer); // 0x68 M_rectTransform             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_textMeshPro                             = GetObject<TextMeshPro>(new IntPtr(p + 0x070), ReversePrism.DataModels.TextMeshPro.FromPointer); // 0x70 M_textMeshPro               ( ModelClassType TextMeshPro TextMeshPro TextMeshPro Pointer )

            return value;
        }
    }
}
