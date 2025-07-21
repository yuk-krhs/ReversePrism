using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 MaskTextureChannel                       ModelEnumType TextureChannel TextureChannel TextureChannel Int32
    // 01C BlendMode                                ModelEnumType BlendMode BlendMode BlendMode Int32
    // 020 IsDirty                                  ModelPrimitiveType bool bool bool Bool
    // 021 HasRenderTarget                          ModelPrimitiveType bool bool bool Bool
    // 024 RenderTargetHandleId                     ModelPrimitiveType int int int Int32
    // 028 RenderTargetHandle                       ModelClassType RTHandle RTHandle RTHandle Pointer
    public partial class Light2DBlendStyle : DataModel
    {
        public string                                   Name                                    { get; set; }
        public TextureChannel                           MaskTextureChannel                      { get; set; }
        public BlendMode                                BlendMode                               { get; set; }
        public bool                                     IsDirty                                 { get; set; }
        public bool                                     HasRenderTarget                         { get; set; }
        public int                                      RenderTargetHandleId                    { get; set; }
        public RTHandle?                                RenderTargetHandle                      { get; set; }

        public static Light2DBlendStyle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Light2DBlendStyle() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.MaskTextureChannel                        = (TextureChannel)GetInt32(new IntPtr(p + 0x018)); // 0x18 MaskTextureChannel          ( ModelEnumType TextureChannel TextureChannel TextureChannel Int32 )
            value.BlendMode                                 = (BlendMode)GetInt32(new IntPtr(p + 0x01C)); // 0x1C BlendMode                   ( ModelEnumType BlendMode BlendMode BlendMode Int32 )
            value.IsDirty                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsDirty                     ( ModelPrimitiveType bool bool bool Bool )
            value.HasRenderTarget                           = GetBool(new IntPtr(p + 0x021)); // 0x21 HasRenderTarget             ( ModelPrimitiveType bool bool bool Bool )
            value.RenderTargetHandleId                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 RenderTargetHandleId        ( ModelPrimitiveType int int int Int32 )
            value.RenderTargetHandle                        = GetObject<RTHandle>(new IntPtr(p + 0x028), ReversePrism.DataModels.RTHandle.FromPointer); // 0x28 RenderTargetHandle          ( ModelClassType RTHandle RTHandle RTHandle Pointer )

            return value;
        }
    }
}
