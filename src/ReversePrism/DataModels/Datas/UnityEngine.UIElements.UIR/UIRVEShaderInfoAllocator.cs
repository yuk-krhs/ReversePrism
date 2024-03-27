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
    public partial class UIRVEShaderInfoAllocator
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
            var value   = new UIRVEShaderInfoAllocator();

            value.M_Storage                                 = GetObject<BaseShaderInfoStorage>(new IntPtr(p + 0x010), ReversePrism.DataModels.BaseShaderInfoStorage.FromPointer); // 02700686A810 0x10 M_Storage                   ( 000186742CC0 ModelClassType BaseShaderInfoStorage BaseShaderInfoStorage BaseShaderInfoStorage Pointer )
            value.M_TransformAllocator                      = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x018)); // 02700686A830 0x18 M_TransformAllocator        ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_ClipRectAllocator                       = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x038)); // 02700686A850 0x38 M_ClipRectAllocator         ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_OpacityAllocator                        = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x058)); // 02700686A870 0x58 M_OpacityAllocator          ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_ColorAllocator                          = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x078)); // 02700686A890 0x78 M_ColorAllocator            ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_TextSettingsAllocator                   = (BitmapAllocator32)GetInt32(new IntPtr(p + 0x098)); // 02700686A8B0 0x98 M_TextSettingsAllocator     ( 000186594470 ModelEnumType BitmapAllocator32 BitmapAllocator32 BitmapAllocator32 Int32 )
            value.M_StorageReallyCreated                    = GetBool(new IntPtr(p + 0x0B8)); // 02700686A8D0 0xB8 M_StorageReallyCreated      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_VertexTexturingEnabled                  = GetBool(new IntPtr(p + 0x0B9)); // 02700686A8F0 0xB9 M_VertexTexturingEnabled    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FullOpacityTexel                          = (Vector2Int)GetInt32(new IntPtr(p + 0x010)); // 02700686A990 0x10 FullOpacityTexel            ( 0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.ClearColorTexel                           = (Vector2Int)GetInt32(new IntPtr(p + 0x018)); // 02700686A9B0 0x18 ClearColorTexel             ( 0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.DefaultTextCoreSettingsTexel              = (Vector2Int)GetInt32(new IntPtr(p + 0x020)); // 02700686A9D0 0x20 DefaultTextCoreSettingsTexel ( 0001866AAD80 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.IdentityTransformValue                    = (Matrix4x4)GetInt32(new IntPtr(p + 0x028)); // 02700686A9F0 0x28 IdentityTransformValue      ( 00018660E960 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.IdentityTransformRow0Value                = (Vector4)GetInt32(new IntPtr(p + 0x068)); // 02700686AA10 0x68 IdentityTransformRow0Value  ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.IdentityTransformRow1Value                = (Vector4)GetInt32(new IntPtr(p + 0x078)); // 02700686AA30 0x78 IdentityTransformRow1Value  ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.IdentityTransformRow2Value                = (Vector4)GetInt32(new IntPtr(p + 0x088)); // 02700686AA50 0x88 IdentityTransformRow2Value  ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.InfiniteClipRectValue                     = (Vector4)GetInt32(new IntPtr(p + 0x098)); // 02700686AA70 0x98 InfiniteClipRectValue       ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.FullOpacityValue                          = (Vector4)GetInt32(new IntPtr(p + 0x0A8)); // 02700686AA90 0xA8 FullOpacityValue            ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.ClearColorValue                           = (Vector4)GetInt32(new IntPtr(p + 0x0B8)); // 02700686AAB0 0xB8 ClearColorValue             ( 0001866AF780 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.DefaultTextCoreSettingsValue              = (TextCoreSettings)GetInt32(new IntPtr(p + 0x0C8)); // 02700686AAD0 0xC8 DefaultTextCoreSettingsValue ( 000186636720 ModelEnumType TextCoreSettings TextCoreSettings TextCoreSettings Int32 )
            value.IdentityTransform                         = (BMPAlloc)GetInt32(new IntPtr(p + 0x108)); // 02700686AAF0 0x108 IdentityTransform           ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.InfiniteClipRect                          = (BMPAlloc)GetInt32(new IntPtr(p + 0x110)); // 02700686AB10 0x110 InfiniteClipRect            ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.FullOpacity                               = (BMPAlloc)GetInt32(new IntPtr(p + 0x118)); // 02700686AB30 0x118 FullOpacity                 ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.ClearColor                                = (BMPAlloc)GetInt32(new IntPtr(p + 0x120)); // 02700686AB50 0x120 ClearColor                  ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )
            value.DefaultTextCoreSettings                   = (BMPAlloc)GetInt32(new IntPtr(p + 0x128)); // 02700686AB70 0x128 DefaultTextCoreSettings     ( 0001867329D0 ModelEnumType BMPAlloc BMPAlloc BMPAlloc Int32 )

            return value;
        }
    }
}
