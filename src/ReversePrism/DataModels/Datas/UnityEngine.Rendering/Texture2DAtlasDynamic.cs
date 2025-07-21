using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AtlasTexture                           ModelClassType RTHandle RTHandle RTHandle Pointer
    // 018 IsAtlasTextureOwner                      ModelPrimitiveType bool bool bool Bool
    // 01C M_Width                                  ModelPrimitiveType int int int Int32
    // 020 M_Height                                 ModelPrimitiveType int int int Int32
    // 024 M_Format                                 ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32
    // 028 M_AtlasAllocator                         ModelClassType AtlasAllocatorDynamic AtlasAllocatorDynamic AtlasAllocatorDynamic Pointer
    // 030 m_AllocationCache                        Dictionary`2<int, Vector4> IL2CPP_TYPE_GENERICINST
    public partial class Texture2DAtlasDynamic : DataModel
    {
        public RTHandle?                                M_AtlasTexture                          { get; set; }
        public bool                                     IsAtlasTextureOwner                     { get; set; }
        public int                                      M_Width                                 { get; set; }
        public int                                      M_Height                                { get; set; }
        public GraphicsFormat                           M_Format                                { get; set; }
        public AtlasAllocatorDynamic?                   M_AtlasAllocator                        { get; set; }

        public static Texture2DAtlasDynamic? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Texture2DAtlasDynamic() { Pointer= p0 };

            value.M_AtlasTexture                            = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0x10 M_AtlasTexture              ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.IsAtlasTextureOwner                       = GetBool(new IntPtr(p + 0x018)); // 0x18 IsAtlasTextureOwner         ( ModelPrimitiveType bool bool bool Bool )
            value.M_Width                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Width                     ( ModelPrimitiveType int int int Int32 )
            value.M_Height                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Height                    ( ModelPrimitiveType int int int Int32 )
            value.M_Format                                  = (GraphicsFormat)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_Format                    ( ModelEnumType GraphicsFormat GraphicsFormat GraphicsFormat Int32 )
            value.M_AtlasAllocator                          = GetObject<AtlasAllocatorDynamic>(new IntPtr(p + 0x028), ReversePrism.DataModels.AtlasAllocatorDynamic.FromPointer); // 0x28 M_AtlasAllocator            ( ModelClassType AtlasAllocatorDynamic AtlasAllocatorDynamic AtlasAllocatorDynamic Pointer )

            return value;
        }
    }
}
