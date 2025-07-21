using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pass                                     ModelClassType MainLightShadowCasterPass MainLightShadowCasterPass MainLightShadowCasterPass Pointer
    // 018 Graph                                    ModelClassType RenderGraph RenderGraph RenderGraph Pointer
    // 020 ShadowmapTexture                         ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 028 RenderingData                            ModelEnumType RenderingData RenderingData RenderingData Int32
    // 2E0 ShadowmapID                              ModelPrimitiveType int int int Int32
    // 2E4 EmptyShadowmap                           ModelPrimitiveType bool bool bool Bool
    public partial class PassData : DataModel
    {
        public MainLightShadowCasterPass?               Pass                                    { get; set; }
        public RenderGraph?                             Graph                                   { get; set; }
        public TextureHandle                            ShadowmapTexture                        { get; set; }
        public RenderingData                            RenderingData                           { get; set; }
        public int                                      ShadowmapID                             { get; set; }
        public bool                                     EmptyShadowmap                          { get; set; }

        public static PassData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PassData() { Pointer= p0 };

            value.Pass                                      = GetObject<MainLightShadowCasterPass>(new IntPtr(p + 0x010), ReversePrism.DataModels.MainLightShadowCasterPass.FromPointer); // 0x10 Pass                        ( ModelClassType MainLightShadowCasterPass MainLightShadowCasterPass MainLightShadowCasterPass Pointer )
            value.Graph                                     = GetObject<RenderGraph>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderGraph.FromPointer); // 0x18 Graph                       ( ModelClassType RenderGraph RenderGraph RenderGraph Pointer )
            value.ShadowmapTexture                          = (TextureHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 ShadowmapTexture            ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.RenderingData                             = (RenderingData)GetInt32(new IntPtr(p + 0x028)); // 0x28 RenderingData               ( ModelEnumType RenderingData RenderingData RenderingData Int32 )
            value.ShadowmapID                               = GetInt32(new IntPtr(p + 0x2E0)); // 0x2E0 ShadowmapID                 ( ModelPrimitiveType int int int Int32 )
            value.EmptyShadowmap                            = GetBool(new IntPtr(p + 0x2E4)); // 0x2E4 EmptyShadowmap              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
