using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Storage                                000186742CC0 ModelClassType BaseShaderInfoStorage BaseShaderInfoStorage BaseShaderInfoStorage Pointer
    // 018 M_TransformAllocator                     000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32
    // 038 M_ClipRectAllocator                      000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32
    // 058 M_OpacityAllocator                       000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32
    // 078 M_ColorAllocator                         000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32
    // 098 M_TextSettingsAllocator                  000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32
    // 0B8 M_StorageReallyCreated                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B9 M_VertexTexturingEnabled                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C0 m_Transforms                             NativeArray`1<Transform3x4> IL2CPP_TYPE_GENERICINST
    // 0D0 m_ClipRects                              NativeArray`1<Vector4> IL2CPP_TYPE_GENERICINST
    // 000 identityTransformTexel                   Vector2Int IL2CPP_TYPE_VALUETYPE
    // 008 infiniteClipRectTexel                    Vector2Int IL2CPP_TYPE_VALUETYPE
    // 010 FullOpacityTexel                         0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 018 ClearColorTexel                          0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 020 DefaultTextCoreSettingsTexel             0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 028 IdentityTransformValue                   00018660E960 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 068 IdentityTransformRow0Value               0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 078 IdentityTransformRow1Value               0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 088 IdentityTransformRow2Value               0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 098 InfiniteClipRectValue                    0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0A8 FullOpacityValue                         0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0B8 ClearColorValue                          0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0C8 DefaultTextCoreSettingsValue             000186636720 ModelEnumType TextCoreSettings TextCoreSettings TextCoreSettings Int32
    // 108 IdentityTransform                        0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 110 InfiniteClipRect                         0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 118 FullOpacity                              0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 120 ClearColor                               0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    // 128 DefaultTextCoreSettings                  0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32
    public partial class UIRVEShaderInfoAllocator : DataModel
    {
        public BaseShaderInfoStorage?                   M_Storage                               { get; set; }
        public BitmapAllocator32                        M_TransformAllocator                    { get; set; }
        public BitmapAllocator32                        M_ClipRectAllocator                     { get; set; }
        public BitmapAllocator32                        M_OpacityAllocator                      { get; set; }
        public BitmapAllocator32                        M_ColorAllocator                        { get; set; }
        public BitmapAllocator32                        M_TextSettingsAllocator                 { get; set; }
        public bool                                     M_StorageReallyCreated                  { get; set; }
        public bool                                     M_VertexTexturingEnabled                { get; set; }
        public Vector2Int                               FullOpacityTexel                        { get; set; }
        public Vector2Int                               ClearColorTexel                         { get; set; }
        public Vector2Int                               DefaultTextCoreSettingsTexel            { get; set; }
        public Matrix4x4                                IdentityTransformValue                  { get; set; }
        public Vector4                                  IdentityTransformRow0Value              { get; set; }
        public Vector4                                  IdentityTransformRow1Value              { get; set; }
        public Vector4                                  IdentityTransformRow2Value              { get; set; }
        public Vector4                                  InfiniteClipRectValue                   { get; set; }
        public Vector4                                  FullOpacityValue                        { get; set; }
        public Vector4                                  ClearColorValue                         { get; set; }
        public TextCoreSettings                         DefaultTextCoreSettingsValue            { get; set; }
        public BMPAlloc                                 IdentityTransform                       { get; set; }
        public BMPAlloc                                 InfiniteClipRect                        { get; set; }
        public BMPAlloc                                 FullOpacity                             { get; set; }
        public BMPAlloc                                 ClearColor                              { get; set; }
        public BMPAlloc                                 DefaultTextCoreSettings                 { get; set; }

        public static UIRVEShaderInfoAllocator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRVEShaderInfoAllocator() { Pointer= p0 };

            value.M_Storage                                 = GetObject<BaseShaderInfoStorage>(new IntPtr(p + 0x010), ReversePrism.DataModels.BaseShaderInfoStorage.FromPointer); // 0245A682CF88 0x10 M_Storage                   ( 000186742CC0 ModelClassType BaseShaderInfoStorage BaseShaderInfoStorage BaseShaderInfoStorage Pointer )
            value.M_TransformAllocator                      = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x018)); // 0245A682CFA8 0x18 M_TransformAllocator        ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_ClipRectAllocator                       = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x038)); // 0245A682CFC8 0x38 M_ClipRectAllocator         ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_OpacityAllocator                        = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x058)); // 0245A682CFE8 0x58 M_OpacityAllocator          ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_ColorAllocator                          = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x078)); // 0245A682D008 0x78 M_ColorAllocator            ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_TextSettingsAllocator                   = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x098)); // 0245A682D028 0x98 M_TextSettingsAllocator     ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_StorageReallyCreated                    = GetBool(new IntPtr(p + 0x0B8)); // 0245A682D048 0xB8 M_StorageReallyCreated      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_VertexTexturingEnabled                  = GetBool(new IntPtr(p + 0x0B9)); // 0245A682D068 0xB9 M_VertexTexturingEnabled    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FullOpacityTexel                          = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 0245A682D108 0x10 FullOpacityTexel            ( 0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.ClearColorTexel                           = (Vector2Int)GetInt32(new IntPtr(p + 0x018)); // 0245A682D128 0x18 ClearColorTexel             ( 0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.DefaultTextCoreSettingsTexel              = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 0245A682D148 0x20 DefaultTextCoreSettingsTexel ( 0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.IdentityTransformValue                    = (Matrix4x4)GetInt32(new IntPtr(p + 0x028)); // 0245A682D168 0x28 IdentityTransformValue      ( 00018660E960 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.IdentityTransformRow0Value                = (Vector4)GetInt32(new IntPtr(p + 0x068)); // 0245A682D188 0x68 IdentityTransformRow0Value  ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.IdentityTransformRow1Value                = (Vector4)GetInt32(new IntPtr(p + 0x078)); // 0245A682D1A8 0x78 IdentityTransformRow1Value  ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.IdentityTransformRow2Value                = (Vector4)GetInt32(new IntPtr(p + 0x088)); // 0245A682D1C8 0x88 IdentityTransformRow2Value  ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.InfiniteClipRectValue                     = (Vector4)GetInt32(new IntPtr(p + 0x098)); // 0245A682D1E8 0x98 InfiniteClipRectValue       ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.FullOpacityValue                          = (Vector4)GetInt32(new IntPtr(p + 0x0A8)); // 0245A682D208 0xA8 FullOpacityValue            ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ClearColorValue                           = (Vector4)GetInt32(new IntPtr(p + 0x0B8)); // 0245A682D228 0xB8 ClearColorValue             ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.DefaultTextCoreSettingsValue              = (TextCoreSettings)GetInt32(new IntPtr(p + 0x0C8)); // 0245A682D248 0xC8 DefaultTextCoreSettingsValue ( 000186636720 ModelEnumType TextCoreSettings TextCoreSettings TextCoreSettings Int32 )
            value.IdentityTransform                         = (BMPAlloc)GetInt32(new IntPtr(p + 0x108)); // 0245A682D268 0x108 IdentityTransform           ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.InfiniteClipRect                          = (BMPAlloc)GetInt32(new IntPtr(p + 0x110)); // 0245A682D288 0x110 InfiniteClipRect            ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.FullOpacity                               = (BMPAlloc)GetInt32(new IntPtr(p + 0x118)); // 0245A682D2A8 0x118 FullOpacity                 ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.ClearColor                                = (BMPAlloc)GetInt32(new IntPtr(p + 0x120)); // 0245A682D2C8 0x120 ClearColor                  ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.DefaultTextCoreSettings                   = (BMPAlloc)GetInt32(new IntPtr(p + 0x128)); // 0245A682D2E8 0x128 DefaultTextCoreSettings     ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )

            return value;
        }
    }
}
