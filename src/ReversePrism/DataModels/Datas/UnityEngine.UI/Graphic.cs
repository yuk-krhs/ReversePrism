using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DefaultUI                              Material IL2CPP_TYPE_CLASS
    // 008 s_WhiteTexture                           Texture2D IL2CPP_TYPE_CLASS
    // 020 M_Material                               00018660C290 ModelClassType Material Material Material Pointer
    // 028 M_Color                                  0001865AA8E0 ModelEnumType Color Color Color Int32
    // 038 M_SkipLayoutUpdate                       000186597990 ModelPrimitiveType bool bool bool Bool
    // 039 M_SkipMaterialUpdate                     000186597990 ModelPrimitiveType bool bool bool Bool
    // 03A M_RaycastTarget                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03B M_RaycastTargetCache                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C M_RaycastPadding                         0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 050 M_RectTransform                          000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 058 M_CanvasRenderer                         0001865420F0 ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer
    // 060 M_Canvas                                 000186540820 ModelClassType Canvas Canvas Canvas Pointer
    // 068 M_VertsDirty                             0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 069 M_MaterialDirty                          0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 070 M_OnDirtyLayoutCallback                  0001867129A0 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 078 M_OnDirtyVertsCallback                   0001867129A0 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 080 M_OnDirtyMaterialCallback                0001867129A0 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 010 S_Mesh                                   000186611540 ModelClassType Mesh Mesh Mesh Pointer
    // 018 S_VertexHelper                           000186513FB0 ModelClassType VertexHelper VertexHelper VertexHelper Pointer
    // 088 M_CachedMesh                             0001866112E0 ModelClassType Mesh Mesh Mesh Pointer
    // 090 M_CachedUvs                              000185CB0A38 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 098 m_ColorTweenRunner                       TweenRunner`1<ColorTween> IL2CPP_TYPE_GENERICINST
    // 0A0 UseLegacyMeshGeneration                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Graphic : DataModel
    {
        public Material?                                M_Material                              { get; set; }
        public Color                                    M_Color                                 { get; set; }
        public bool                                     M_SkipLayoutUpdate                      { get; set; }
        public bool                                     M_SkipMaterialUpdate                    { get; set; }
        public bool                                     M_RaycastTarget                         { get; set; }
        public bool                                     M_RaycastTargetCache                    { get; set; }
        public Vector4                                  M_RaycastPadding                        { get; set; }
        public RectTransform?                           M_RectTransform                         { get; set; }
        public CanvasRenderer?                          M_CanvasRenderer                        { get; set; }
        public Canvas?                                  M_Canvas                                { get; set; }
        public bool                                     M_VertsDirty                            { get; set; }
        public bool                                     M_MaterialDirty                         { get; set; }
        public UnityAction?                             M_OnDirtyLayoutCallback                 { get; set; }
        public UnityAction?                             M_OnDirtyVertsCallback                  { get; set; }
        public UnityAction?                             M_OnDirtyMaterialCallback               { get; set; }
        public Mesh?                                    S_Mesh                                  { get; set; }
        public VertexHelper?                            S_VertexHelper                          { get; set; }
        public Mesh?                                    M_CachedMesh                            { get; set; }
        public List<Vector2>?                           M_CachedUvs                             { get; set; }
        public bool                                     UseLegacyMeshGeneration                 { get; set; }

        public static Graphic? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Graphic() { Pointer= p0 };

            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0245A35EABC8 0x20 M_Material                  ( 00018660C290 ModelClassType Material Material Material Pointer )
            value.M_Color                                   = (Color)GetInt32(new IntPtr(p + 0x028)); // 0245A35EABE8 0x28 M_Color                     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_SkipLayoutUpdate                        = GetBool(new IntPtr(p + 0x038)); // 0245A35EAC08 0x38 M_SkipLayoutUpdate          ( 000186597990 ModelPrimitiveType bool bool bool Bool )
            value.M_SkipMaterialUpdate                      = GetBool(new IntPtr(p + 0x039)); // 0245A35EAC28 0x39 M_SkipMaterialUpdate        ( 000186597990 ModelPrimitiveType bool bool bool Bool )
            value.M_RaycastTarget                           = GetBool(new IntPtr(p + 0x03A)); // 0245A35EAC48 0x3A M_RaycastTarget             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RaycastTargetCache                      = GetBool(new IntPtr(p + 0x03B)); // 0245A35EAC68 0x3B M_RaycastTargetCache        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RaycastPadding                          = (Vector4)GetInt32(new IntPtr(p + 0x03C)); // 0245A35EAC88 0x3C M_RaycastPadding            ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.M_RectTransform                           = GetObject<RectTransform>(new IntPtr(p + 0x050), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A35EACA8 0x50 M_RectTransform             ( 000186630DC0 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_CanvasRenderer                          = GetObject<CanvasRenderer>(new IntPtr(p + 0x058), ReversePrism.DataModels.CanvasRenderer.FromPointer); // 0245A35EACC8 0x58 M_CanvasRenderer            ( 0001865420F0 ModelClassType CanvasRenderer CanvasRenderer CanvasRenderer Pointer )
            value.M_Canvas                                  = GetObject<Canvas>(new IntPtr(p + 0x060), ReversePrism.DataModels.Canvas.FromPointer); // 0245A35EACE8 0x60 M_Canvas                    ( 000186540820 ModelClassType Canvas Canvas Canvas Pointer )
            value.M_VertsDirty                              = GetBool(new IntPtr(p + 0x068)); // 0245A35EAD08 0x68 M_VertsDirty                ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_MaterialDirty                           = GetBool(new IntPtr(p + 0x069)); // 0245A35EAD28 0x69 M_MaterialDirty             ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.M_OnDirtyLayoutCallback                   = GetObject<UnityAction>(new IntPtr(p + 0x070), ReversePrism.DataModels.UnityAction.FromPointer); // 0245A35EAD48 0x70 M_OnDirtyLayoutCallback     ( 0001867129A0 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.M_OnDirtyVertsCallback                    = GetObject<UnityAction>(new IntPtr(p + 0x078), ReversePrism.DataModels.UnityAction.FromPointer); // 0245A35EAD68 0x78 M_OnDirtyVertsCallback      ( 0001867129A0 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.M_OnDirtyMaterialCallback                 = GetObject<UnityAction>(new IntPtr(p + 0x080), ReversePrism.DataModels.UnityAction.FromPointer); // 0245A35EAD88 0x80 M_OnDirtyMaterialCallback   ( 0001867129A0 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.S_Mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x010), ReversePrism.DataModels.Mesh.FromPointer); // 0245A35EADA8 0x10 S_Mesh                      ( 000186611540 ModelClassType Mesh Mesh Mesh Pointer )
            value.S_VertexHelper                            = GetObject<VertexHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.VertexHelper.FromPointer); // 0245A35EADC8 0x18 S_VertexHelper              ( 000186513FB0 ModelClassType VertexHelper VertexHelper VertexHelper Pointer )
            value.M_CachedMesh                              = GetObject<Mesh>(new IntPtr(p + 0x088), ReversePrism.DataModels.Mesh.FromPointer); // 0245A35EADE8 0x88 M_CachedMesh                ( 0001866112E0 ModelClassType Mesh Mesh Mesh Pointer )
            value.M_CachedUvs                               = GetEnumList<Vector2>(new IntPtr(p + 0x090)); // 0245A35EAE08 0x90 M_CachedUvs                 ( 000185CB0A38 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.UseLegacyMeshGeneration                   = GetBool(new IntPtr(p + 0x0A0)); // 0245A35EAE48 0xA0 UseLegacyMeshGeneration     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
