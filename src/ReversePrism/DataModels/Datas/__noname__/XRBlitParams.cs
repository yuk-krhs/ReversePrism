using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SrcTex                                   ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 018 SrcTexArraySlice                         ModelPrimitiveType int int int Int32
    // 01C SrcRect                                  ModelEnumType Rect Rect Rect Int32
    // 02C DestRect                                 ModelEnumType Rect Rect Rect Int32
    // 040 foveatedRenderingInfo                    <int> IL2CPP_TYPE_I
    // 048 SrcHdrEncoded                            ModelPrimitiveType bool bool bool Bool
    // 04C SrcHdrColorGamut                         ModelEnumType ColorGamut ColorGamut ColorGamut Int32
    // 050 SrcHdrMaxLuminance                       ModelPrimitiveType int int int Int32
    public partial class XRBlitParams : DataModel
    {
        public RenderTexture?                           SrcTex                                  { get; set; }
        public int                                      SrcTexArraySlice                        { get; set; }
        public Rect                                     SrcRect                                 { get; set; }
        public Rect                                     DestRect                                { get; set; }
        public bool                                     SrcHdrEncoded                           { get; set; }
        public ColorGamut                               SrcHdrColorGamut                        { get; set; }
        public int                                      SrcHdrMaxLuminance                      { get; set; }

        public static XRBlitParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRBlitParams() { Pointer= p0 };

            value.SrcTex                                    = GetObject<RenderTexture>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x10 SrcTex                      ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.SrcTexArraySlice                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 SrcTexArraySlice            ( ModelPrimitiveType int int int Int32 )
            value.SrcRect                                   = (Rect)GetInt32(new IntPtr(p + 0x01C)); // 0x1C SrcRect                     ( ModelEnumType Rect Rect Rect Int32 )
            value.DestRect                                  = (Rect)GetInt32(new IntPtr(p + 0x02C)); // 0x2C DestRect                    ( ModelEnumType Rect Rect Rect Int32 )
            value.SrcHdrEncoded                             = GetBool(new IntPtr(p + 0x048)); // 0x48 SrcHdrEncoded               ( ModelPrimitiveType bool bool bool Bool )
            value.SrcHdrColorGamut                          = (ColorGamut)GetInt32(new IntPtr(p + 0x04C)); // 0x4C SrcHdrColorGamut            ( ModelEnumType ColorGamut ColorGamut ColorGamut Int32 )
            value.SrcHdrMaxLuminance                        = GetInt32(new IntPtr(p + 0x050)); // 0x50 SrcHdrMaxLuminance          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
