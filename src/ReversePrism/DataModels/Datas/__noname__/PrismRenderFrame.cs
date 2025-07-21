using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderTarget                             ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 018 CurrentWidth                             ModelPrimitiveType int int int Int32
    // 01C CurrentHeight                            ModelPrimitiveType int int int Int32
    // 020 CurrentEffectBufferID                    ModelPrimitiveType int int int Int32
    // 000 BufferInfoIDsDictionary                  Dictionary`2<int, BufferIDs> IL2CPP_TYPE_GENERICINST
    public partial class PrismRenderFrame : DataModel
    {
        public RenderTexture?                           RenderTarget                            { get; set; }
        public int                                      CurrentWidth                            { get; set; }
        public int                                      CurrentHeight                           { get; set; }
        public int                                      CurrentEffectBufferID                   { get; set; }

        public static PrismRenderFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrismRenderFrame() { Pointer= p0 };

            value.RenderTarget                              = GetObject<RenderTexture>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x10 RenderTarget                ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.CurrentWidth                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentWidth                ( ModelPrimitiveType int int int Int32 )
            value.CurrentHeight                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C CurrentHeight               ( ModelPrimitiveType int int int Int32 )
            value.CurrentEffectBufferID                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentEffectBufferID       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
