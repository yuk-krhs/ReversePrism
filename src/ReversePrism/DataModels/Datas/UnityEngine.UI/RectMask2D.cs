using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_VertexClipper                          ModelClassType RectangularVertexClipper RectangularVertexClipper RectangularVertexClipper Pointer
    // 028 M_RectTransform                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 030 m_MaskableTargets                        HashSet`1<MaskableGraphic> IL2CPP_TYPE_GENERICINST
    // 038 m_ClipTargets                            HashSet`1<IClippable> IL2CPP_TYPE_GENERICINST
    // 040 M_ShouldRecalculateClipRects             ModelPrimitiveType bool bool bool Bool
    // 048 M_Clippers                               ModelClassListType List`1<RectMask2D> List`1<RectMask2D> List<RectMask2D> Pointer
    // 050 M_LastClipRectCanvasSpace                ModelEnumType Rect Rect Rect Int32
    // 060 M_ForceClip                              ModelPrimitiveType bool bool bool Bool
    // 064 M_Padding                                ModelEnumType Vector4 Vector4 Vector4 Int32
    // 074 M_Softness                               ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 080 M_Canvas                                 ModelClassType Canvas Canvas Canvas Pointer
    // 088 M_Corners                                ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    public partial class RectMask2D : DataModel
    {
        public RectangularVertexClipper?                M_VertexClipper                         { get; set; }
        public RectTransform?                           M_RectTransform                         { get; set; }
        public bool                                     M_ShouldRecalculateClipRects            { get; set; }
        public List<RectMask2D>?                        M_Clippers                              { get; set; }
        public Rect                                     M_LastClipRectCanvasSpace               { get; set; }
        public bool                                     M_ForceClip                             { get; set; }
        public Vector4                                  M_Padding                               { get; set; }
        public Vector2Int                               M_Softness                              { get; set; }
        public Canvas?                                  M_Canvas                                { get; set; }
        public List<Vector3>?                           M_Corners                               { get; set; }

        public static RectMask2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RectMask2D() { Pointer= p0 };

            value.M_VertexClipper                           = GetObject<RectangularVertexClipper>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectangularVertexClipper.FromPointer); // 0x20 M_VertexClipper             ( ModelClassType RectangularVertexClipper RectangularVertexClipper RectangularVertexClipper Pointer )
            value.M_RectTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x028), ReversePrism.DataModels.RectTransform.FromPointer); // 0x28 M_RectTransform             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_ShouldRecalculateClipRects              = GetBool(new IntPtr(p + 0x040)); // 0x40 M_ShouldRecalculateClipRects ( ModelPrimitiveType bool bool bool Bool )
            value.M_Clippers                                = GetObjectList<RectMask2D>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectMask2D.FromPointer); // 0x48 M_Clippers                  ( ModelClassListType List`1<RectMask2D> List`1<RectMask2D> List<RectMask2D> Pointer )
            value.M_LastClipRectCanvasSpace                 = (Rect)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_LastClipRectCanvasSpace   ( ModelEnumType Rect Rect Rect Int32 )
            value.M_ForceClip                               = GetBool(new IntPtr(p + 0x060)); // 0x60 M_ForceClip                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_Padding                                 = (Vector4)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_Padding                   ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_Softness                                = (Vector2Int)GetInt32(new IntPtr(p + 0x074)); // 0x74 M_Softness                  ( ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.M_Canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x080), ReversePrism.DataModels.Canvas.FromPointer); // 0x80 M_Canvas                    ( ModelClassType Canvas Canvas Canvas Pointer )
            value.M_Corners                                 = GetEnumList<Vector3>(new IntPtr(p + 0x088)); // 0x88 M_Corners                   ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
