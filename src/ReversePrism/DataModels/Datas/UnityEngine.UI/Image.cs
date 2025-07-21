using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ETC1DefaultUI                          Material IL2CPP_TYPE_CLASS
    // 0E0 M_Sprite                                 ModelClassType Sprite Sprite Sprite Pointer
    // 0E8 M_OverrideSprite                         ModelClassType Sprite Sprite Sprite Pointer
    // 0F0 M_Type                                   ModelEnumType Type Type Type Int32
    // 0F4 M_PreserveAspect                         ModelPrimitiveType bool bool bool Bool
    // 0F5 M_FillCenter                             ModelPrimitiveType bool bool bool Bool
    // 0F8 M_FillMethod                             ModelEnumType FillMethod FillMethod FillMethod Int32
    // 0FC M_FillAmount                             ModelPrimitiveType float float float Single
    // 100 M_FillClockwise                          ModelPrimitiveType bool bool bool Bool
    // 104 M_FillOrigin                             ModelPrimitiveType int int int Int32
    // 108 M_AlphaHitTestMinimumThreshold           ModelPrimitiveType float float float Single
    // 10C M_Tracked                                ModelPrimitiveType bool bool bool Bool
    // 10D M_UseSpriteMesh                          ModelPrimitiveType bool bool bool Bool
    // 110 M_PixelsPerUnitMultiplier                ModelPrimitiveType float float float Single
    // 114 M_CachedReferencePixelsPerUnit           ModelPrimitiveType float float float Single
    // 008 s_VertScratch                            Vector2[] IL2CPP_TYPE_SZARRAY
    // 010 S_UVScratch                              ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 018 S_Xy                                     ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 020 S_Uv                                     ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 028 M_TrackedTexturelessImages               ModelClassListType List`1<Image> List`1<Image> List<Image> Pointer
    // 030 S_Initialized                            ModelPrimitiveType bool bool bool Bool
    public partial class Image : DataModel
    {
        public Sprite?                                  M_Sprite                                { get; set; }
        public Sprite?                                  M_OverrideSprite                        { get; set; }
        public Type                                     M_Type                                  { get; set; }
        public bool                                     M_PreserveAspect                        { get; set; }
        public bool                                     M_FillCenter                            { get; set; }
        public FillMethod                               M_FillMethod                            { get; set; }
        public float                                    M_FillAmount                            { get; set; }
        public bool                                     M_FillClockwise                         { get; set; }
        public int                                      M_FillOrigin                            { get; set; }
        public float                                    M_AlphaHitTestMinimumThreshold          { get; set; }
        public bool                                     M_Tracked                               { get; set; }
        public bool                                     M_UseSpriteMesh                         { get; set; }
        public float                                    M_PixelsPerUnitMultiplier               { get; set; }
        public float                                    M_CachedReferencePixelsPerUnit          { get; set; }
        public List<Vector2>?                           S_UVScratch                             { get; set; }
        public List<Vector3>?                           S_Xy                                    { get; set; }
        public List<Vector3>?                           S_Uv                                    { get; set; }
        public List<Image>?                             M_TrackedTexturelessImages              { get; set; }
        public bool                                     S_Initialized                           { get; set; }

        public static Image? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Image() { Pointer= p0 };

            value.M_Sprite                                  = GetObject<Sprite>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Sprite.FromPointer); // 0xE0 M_Sprite                    ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_OverrideSprite                          = GetObject<Sprite>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Sprite.FromPointer); // 0xE8 M_OverrideSprite            ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_Type                                    = (Type)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 M_Type                      ( ModelEnumType Type Type Type Int32 )
            value.M_PreserveAspect                          = GetBool(new IntPtr(p + 0x0F4)); // 0xF4 M_PreserveAspect            ( ModelPrimitiveType bool bool bool Bool )
            value.M_FillCenter                              = GetBool(new IntPtr(p + 0x0F5)); // 0xF5 M_FillCenter                ( ModelPrimitiveType bool bool bool Bool )
            value.M_FillMethod                              = (FillMethod)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_FillMethod                ( ModelEnumType FillMethod FillMethod FillMethod Int32 )
            value.M_FillAmount                              = GetSingle(new IntPtr(p + 0x0FC)); // 0xFC M_FillAmount                ( ModelPrimitiveType float float float Single )
            value.M_FillClockwise                           = GetBool(new IntPtr(p + 0x100)); // 0x100 M_FillClockwise             ( ModelPrimitiveType bool bool bool Bool )
            value.M_FillOrigin                              = GetInt32(new IntPtr(p + 0x104)); // 0x104 M_FillOrigin                ( ModelPrimitiveType int int int Int32 )
            value.M_AlphaHitTestMinimumThreshold            = GetSingle(new IntPtr(p + 0x108)); // 0x108 M_AlphaHitTestMinimumThreshold ( ModelPrimitiveType float float float Single )
            value.M_Tracked                                 = GetBool(new IntPtr(p + 0x10C)); // 0x10C M_Tracked                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseSpriteMesh                           = GetBool(new IntPtr(p + 0x10D)); // 0x10D M_UseSpriteMesh             ( ModelPrimitiveType bool bool bool Bool )
            value.M_PixelsPerUnitMultiplier                 = GetSingle(new IntPtr(p + 0x110)); // 0x110 M_PixelsPerUnitMultiplier   ( ModelPrimitiveType float float float Single )
            value.M_CachedReferencePixelsPerUnit            = GetSingle(new IntPtr(p + 0x114)); // 0x114 M_CachedReferencePixelsPerUnit ( ModelPrimitiveType float float float Single )
            value.S_UVScratch                               = GetEnumList<Vector2>(new IntPtr(p + 0x010)); // 0x10 S_UVScratch                 ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.S_Xy                                      = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0x18 S_Xy                        ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.S_Uv                                      = GetEnumList<Vector3>(new IntPtr(p + 0x020)); // 0x20 S_Uv                        ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_TrackedTexturelessImages                = GetObjectList<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 M_TrackedTexturelessImages  ( ModelClassListType List`1<Image> List`1<Image> List<Image> Pointer )
            value.S_Initialized                             = GetBool(new IntPtr(p + 0x030)); // 0x30 S_Initialized               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
