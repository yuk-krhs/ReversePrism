using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BackBufferColor                          ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 018 CameraColor                              ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 020 CameraDepth                              ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 028 MainShadowsTexture                       ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 030 AdditionalShadowsTexture                 ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 038 Gbuffer                                  ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer
    // 040 CameraOpaqueTexture                      ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 048 CameraDepthTexture                       ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 050 CameraNormalsTexture                     ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 058 MotionVectorColor                        ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 060 MotionVectorDepth                        ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 068 InternalColorLut                         ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    // 070 OverlayUITexture                         ModelEnumType TextureHandle TextureHandle TextureHandle Int32
    public partial class RenderGraphFrameResources : DataModel
    {
        public TextureHandle                            BackBufferColor                         { get; set; }
        public TextureHandle                            CameraColor                             { get; set; }
        public TextureHandle                            CameraDepth                             { get; set; }
        public TextureHandle                            MainShadowsTexture                      { get; set; }
        public TextureHandle                            AdditionalShadowsTexture                { get; set; }
        public List<TextureHandle>?                     Gbuffer                                 { get; set; }
        public TextureHandle                            CameraOpaqueTexture                     { get; set; }
        public TextureHandle                            CameraDepthTexture                      { get; set; }
        public TextureHandle                            CameraNormalsTexture                    { get; set; }
        public TextureHandle                            MotionVectorColor                       { get; set; }
        public TextureHandle                            MotionVectorDepth                       { get; set; }
        public TextureHandle                            InternalColorLut                        { get; set; }
        public TextureHandle                            OverlayUITexture                        { get; set; }

        public static RenderGraphFrameResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphFrameResources() { Pointer= p0 };

            value.BackBufferColor                           = (TextureHandle)GetInt32(new IntPtr(p + 0x010)); // 0x10 BackBufferColor             ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.CameraColor                               = (TextureHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 CameraColor                 ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.CameraDepth                               = (TextureHandle)GetInt32(new IntPtr(p + 0x020)); // 0x20 CameraDepth                 ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.MainShadowsTexture                        = (TextureHandle)GetInt32(new IntPtr(p + 0x028)); // 0x28 MainShadowsTexture          ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.AdditionalShadowsTexture                  = (TextureHandle)GetInt32(new IntPtr(p + 0x030)); // 0x30 AdditionalShadowsTexture    ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.Gbuffer                                   = GetEnumList<TextureHandle>(new IntPtr(p + 0x038)); // 0x38 Gbuffer                     ( ModelEnumListType TextureHandle[] TextureHandle[] List<TextureHandle> Pointer )
            value.CameraOpaqueTexture                       = (TextureHandle)GetInt32(new IntPtr(p + 0x040)); // 0x40 CameraOpaqueTexture         ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.CameraDepthTexture                        = (TextureHandle)GetInt32(new IntPtr(p + 0x048)); // 0x48 CameraDepthTexture          ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.CameraNormalsTexture                      = (TextureHandle)GetInt32(new IntPtr(p + 0x050)); // 0x50 CameraNormalsTexture        ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.MotionVectorColor                         = (TextureHandle)GetInt32(new IntPtr(p + 0x058)); // 0x58 MotionVectorColor           ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.MotionVectorDepth                         = (TextureHandle)GetInt32(new IntPtr(p + 0x060)); // 0x60 MotionVectorDepth           ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.InternalColorLut                          = (TextureHandle)GetInt32(new IntPtr(p + 0x068)); // 0x68 InternalColorLut            ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )
            value.OverlayUITexture                          = (TextureHandle)GetInt32(new IntPtr(p + 0x070)); // 0x70 OverlayUITexture            ( ModelEnumType TextureHandle TextureHandle TextureHandle Int32 )

            return value;
        }
    }
}
