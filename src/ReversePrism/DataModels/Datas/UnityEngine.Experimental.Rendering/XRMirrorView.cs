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
    // 010 K_SourceTex                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 014 K_SourceTexArraySlice                    0001865F4BC0 ModelPrimitiveType int int int Int32
    // 018 K_ScaleBias                              0001865F4BC0 ModelPrimitiveType int int int Int32
    // 01C K_ScaleBiasRt                            0001865F4BC0 ModelPrimitiveType int int int Int32
    // 020 K_SRGBRead                               0001865F4BC0 ModelPrimitiveType int int int Int32
    // 024 K_SRGBWrite                              0001865F4BC0 ModelPrimitiveType int int int Int32
    public partial class XRMirrorView
    {
        public int                                      K_SourceTex                             { get; set; }
        public int                                      K_SourceTexArraySlice                   { get; set; }
        public int                                      K_ScaleBias                             { get; set; }
        public int                                      K_ScaleBiasRt                           { get; set; }
        public int                                      K_SRGBRead                              { get; set; }
        public int                                      K_SRGBWrite                             { get; set; }

        public static XRMirrorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRMirrorView();

            value.K_SourceTex                               = GetInt32(new IntPtr(p + 0x010)); // 0270D90775E0 0x10 K_SourceTex                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.K_SourceTexArraySlice                     = GetInt32(new IntPtr(p + 0x014)); // 0270D9077600 0x14 K_SourceTexArraySlice       ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.K_ScaleBias                               = GetInt32(new IntPtr(p + 0x018)); // 0270D9077620 0x18 K_ScaleBias                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.K_ScaleBiasRt                             = GetInt32(new IntPtr(p + 0x01C)); // 0270D9077640 0x1C K_ScaleBiasRt               ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.K_SRGBRead                                = GetInt32(new IntPtr(p + 0x020)); // 0270D9077660 0x20 K_SRGBRead                  ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.K_SRGBWrite                               = GetInt32(new IntPtr(p + 0x024)); // 0270D9077680 0x24 K_SRGBWrite                 ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
