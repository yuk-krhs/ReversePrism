using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Destination                              ModelClassType RenderTexture RenderTexture RenderTexture Pointer
    // 018 MipLevel                                 ModelPrimitiveType int int int Int32
    // 01C Face                                     ModelEnumType CubemapFace CubemapFace CubemapFace Int32
    // 020 Slice                                    ModelPrimitiveType int int int Int32
    public partial class SingleCameraRequest : DataModel
    {
        public RenderTexture?                           Destination                             { get; set; }
        public int                                      MipLevel                                { get; set; }
        public CubemapFace                              Face                                    { get; set; }
        public int                                      Slice                                   { get; set; }

        public static SingleCameraRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SingleCameraRequest() { Pointer= p0 };

            value.Destination                               = GetObject<RenderTexture>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderTexture.FromPointer); // 0x10 Destination                 ( ModelClassType RenderTexture RenderTexture RenderTexture Pointer )
            value.MipLevel                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 MipLevel                    ( ModelPrimitiveType int int int Int32 )
            value.Face                                      = (CubemapFace)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Face                        ( ModelEnumType CubemapFace CubemapFace CubemapFace Int32 )
            value.Slice                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Slice                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
