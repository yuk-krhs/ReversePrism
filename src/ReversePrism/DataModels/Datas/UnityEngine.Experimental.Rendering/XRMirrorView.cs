using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_MirrorViewMaterialProperty             MaterialPropertyBlock IL2CPP_TYPE_CLASS
    // 008 k_MirrorViewProfilingSampler             ProfilingSampler IL2CPP_TYPE_CLASS
    // 010 K_SourceTex                              ModelPrimitiveType int int int Int32
    // 014 K_SourceTexArraySlice                    ModelPrimitiveType int int int Int32
    // 018 K_ScaleBias                              ModelPrimitiveType int int int Int32
    // 01C K_ScaleBiasRt                            ModelPrimitiveType int int int Int32
    // 020 K_SRGBRead                               ModelPrimitiveType int int int Int32
    // 024 K_SRGBWrite                              ModelPrimitiveType int int int Int32
    // 028 K_MaxNits                                ModelPrimitiveType int int int Int32
    // 02C K_SourceMaxNits                          ModelPrimitiveType int int int Int32
    // 030 K_SourceHDREncoding                      ModelPrimitiveType int int int Int32
    // 034 K_ColorTransform                         ModelPrimitiveType int int int Int32
    public partial class XRMirrorView : DataModel
    {
        public int                                      K_SourceTex                             { get; set; }
        public int                                      K_SourceTexArraySlice                   { get; set; }
        public int                                      K_ScaleBias                             { get; set; }
        public int                                      K_ScaleBiasRt                           { get; set; }
        public int                                      K_SRGBRead                              { get; set; }
        public int                                      K_SRGBWrite                             { get; set; }
        public int                                      K_MaxNits                               { get; set; }
        public int                                      K_SourceMaxNits                         { get; set; }
        public int                                      K_SourceHDREncoding                     { get; set; }
        public int                                      K_ColorTransform                        { get; set; }

        public static XRMirrorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRMirrorView() { Pointer= p0 };

            value.K_SourceTex                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 K_SourceTex                 ( ModelPrimitiveType int int int Int32 )
            value.K_SourceTexArraySlice                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 K_SourceTexArraySlice       ( ModelPrimitiveType int int int Int32 )
            value.K_ScaleBias                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 K_ScaleBias                 ( ModelPrimitiveType int int int Int32 )
            value.K_ScaleBiasRt                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C K_ScaleBiasRt               ( ModelPrimitiveType int int int Int32 )
            value.K_SRGBRead                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 K_SRGBRead                  ( ModelPrimitiveType int int int Int32 )
            value.K_SRGBWrite                               = GetInt32(new IntPtr(p + 0x024)); // 0x24 K_SRGBWrite                 ( ModelPrimitiveType int int int Int32 )
            value.K_MaxNits                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 K_MaxNits                   ( ModelPrimitiveType int int int Int32 )
            value.K_SourceMaxNits                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C K_SourceMaxNits             ( ModelPrimitiveType int int int Int32 )
            value.K_SourceHDREncoding                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 K_SourceHDREncoding         ( ModelPrimitiveType int int int Int32 )
            value.K_ColorTransform                          = GetInt32(new IntPtr(p + 0x034)); // 0x34 K_ColorTransform            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
