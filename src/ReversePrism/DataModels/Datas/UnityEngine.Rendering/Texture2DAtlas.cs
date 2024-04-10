using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kGPUTexInvalid                           int IL2CPP_TYPE_I4
    // 000 kGPUTexValidMip0                         int IL2CPP_TYPE_I4
    // 000 kGPUTexValidMipAll                       int IL2CPP_TYPE_I4
    // 010 M_AtlasTexture                           00018664B2F0 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 018 M_Width                                  0001865F2D90 ModelPrimitiveType int int int Int32
    // 01C M_Height                                 0001865F2D90 ModelPrimitiveType int int int Int32
    // 020 M_Format                                 000186696410 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 024 M_UseMipMaps                             000186594FA0 ModelPrimitiveType bool bool bool Bool
    // 025 M_IsAtlasTextureOwner                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 M_AtlasAllocator                         00018670B570 ModelClassType AtlasAllocator AtlasAllocator AtlasAllocator Pointer
    // 030 m_AllocationCache                        Dictionary`2<int, ValueTuple`2<Vector4, Vector2Int>> IL2CPP_TYPE_GENERICINST
    // 038 m_IsGPUTextureUpToDate                   Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 040 m_TextureHashes                          Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 000 fullScaleOffset                          Vector4 IL2CPP_TYPE_VALUETYPE
    // 010 S_MaxMipLevelPadding                     0001865F4BC0 ModelPrimitiveType int int int Int32
    public partial class Texture2DAtlas : DataModel
    {
        public RTHandle?                                M_AtlasTexture                          { get; set; }
        public int                                      M_Width                                 { get; set; }
        public int                                      M_Height                                { get; set; }
        public GraphicsFormat                           M_Format                                { get; set; }
        public bool                                     M_UseMipMaps                            { get; set; }
        public bool                                     M_IsAtlasTextureOwner                   { get; set; }
        public AtlasAllocator?                          M_AtlasAllocator                        { get; set; }
        public int                                      S_MaxMipLevelPadding                    { get; set; }

        public static Texture2DAtlas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Texture2DAtlas() { Pointer= p0 };

            value.M_AtlasTexture                            = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0246692D3DA8 0x10 M_AtlasTexture              ( 00018664B2F0 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_Width                                   = GetInt32(new IntPtr(p + 0x018)); // 0246692D3DC8 0x18 M_Width                     ( 0001865F2D90 ModelPrimitiveType int int int Int32 )
            value.M_Height                                  = GetInt32(new IntPtr(p + 0x01C)); // 0246692D3DE8 0x1C M_Height                    ( 0001865F2D90 ModelPrimitiveType int int int Int32 )
            value.M_Format                                  = (GraphicsFormat)GetInt32(new IntPtr(p + 0x020)); // 0246692D3E08 0x20 M_Format                    ( 000186696410 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_UseMipMaps                              = GetBool(new IntPtr(p + 0x024)); // 0246692D3E28 0x24 M_UseMipMaps                ( 000186594FA0 ModelPrimitiveType bool bool bool Bool )
            value.M_IsAtlasTextureOwner                     = GetBool(new IntPtr(p + 0x025)); // 0246692D3E48 0x25 M_IsAtlasTextureOwner       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_AtlasAllocator                          = GetObject<AtlasAllocator>(new IntPtr(p + 0x028), ReversePrism.DataModels.AtlasAllocator.FromPointer); // 0246692D3E68 0x28 M_AtlasAllocator            ( 00018670B570 ModelClassType AtlasAllocator AtlasAllocator AtlasAllocator Pointer )
            value.S_MaxMipLevelPadding                      = GetInt32(new IntPtr(p + 0x010)); // 0246692D3F08 0x10 S_MaxMipLevelPadding        ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
