using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SrcTex                                   000186656460 ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 018 SrcTexArraySlice                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SrcRect                                  00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 02C DestRect                                 00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 040 foveatedRenderingInfo                    <int> IL2CPP_TYPE_I
    public partial class XRBlitParams : DataModel
    {
        public RenderTexture?                           SrcTex                                  { get; set; }
        public int                                      SrcTexArraySlice                        { get; set; }
        public Rect                                     SrcRect                                 { get; set; }
        public Rect                                     DestRect                                { get; set; }

        public static XRBlitParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRBlitParams() { Pointer= p0 };

            value.SrcTex                                    = GetObject<RenderTexture>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderTexture.FromPointer); // 0245A6925420 0x10 SrcTex                      ( 000186656460 ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.SrcTexArraySlice                          = GetInt32(new IntPtr(p + 0x018)); // 0245A6925440 0x18 SrcTexArraySlice            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SrcRect                                   = (Rect)GetInt32(new IntPtr(p + 0x01C)); // 0245A6925460 0x1C SrcRect                     ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.DestRect                                  = (Rect)GetInt32(new IntPtr(p + 0x02C)); // 0245A6925480 0x2C DestRect                    ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )

            return value;
        }
    }
}
