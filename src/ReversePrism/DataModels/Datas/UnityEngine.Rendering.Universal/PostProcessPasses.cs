using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ColorGradingLutPass                    ModelClassType ColorGradingLutPass ColorGradingLutPass ColorGradingLutPass Pointer
    // 018 M_PostProcessPass                        ModelClassType PostProcessPass PostProcessPass PostProcessPass Pointer
    // 020 M_FinalPostProcessPass                   ModelClassType PostProcessPass PostProcessPass PostProcessPass Pointer
    // 028 M_AfterPostProcessColor                  ModelClassType RTHandle RTHandle RTHandle Pointer
    // 030 M_ColorGradingLut                        ModelClassType RTHandle RTHandle RTHandle Pointer
    // 038 M_RendererPostProcessData                ModelClassType PostProcessData PostProcessData PostProcessData Pointer
    // 040 M_CurrentPostProcessData                 ModelClassType PostProcessData PostProcessData PostProcessData Pointer
    // 048 M_BlitMaterial                           ModelClassType Material Material Material Pointer
    public partial class PostProcessPasses : DataModel
    {
        public ColorGradingLutPass?                     M_ColorGradingLutPass                   { get; set; }
        public PostProcessPass?                         M_PostProcessPass                       { get; set; }
        public PostProcessPass?                         M_FinalPostProcessPass                  { get; set; }
        public RTHandle?                                M_AfterPostProcessColor                 { get; set; }
        public RTHandle?                                M_ColorGradingLut                       { get; set; }
        public PostProcessData?                         M_RendererPostProcessData               { get; set; }
        public PostProcessData?                         M_CurrentPostProcessData                { get; set; }
        public Material?                                M_BlitMaterial                          { get; set; }

        public static PostProcessPasses? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessPasses() { Pointer= p0 };

            value.M_ColorGradingLutPass                     = GetObject<ColorGradingLutPass>(new IntPtr(p + 0x010), ReversePrism.DataModels.ColorGradingLutPass.FromPointer); // 0x10 M_ColorGradingLutPass       ( ModelClassType ColorGradingLutPass ColorGradingLutPass ColorGradingLutPass Pointer )
            value.M_PostProcessPass                         = GetObject<PostProcessPass>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessPass.FromPointer); // 0x18 M_PostProcessPass           ( ModelClassType PostProcessPass PostProcessPass PostProcessPass Pointer )
            value.M_FinalPostProcessPass                    = GetObject<PostProcessPass>(new IntPtr(p + 0x020), ReversePrism.DataModels.PostProcessPass.FromPointer); // 0x20 M_FinalPostProcessPass      ( ModelClassType PostProcessPass PostProcessPass PostProcessPass Pointer )
            value.M_AfterPostProcessColor                   = GetObject<RTHandle>(new IntPtr(p + 0x028), ReversePrism.DataModels.RTHandle.FromPointer); // 0x28 M_AfterPostProcessColor     ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ColorGradingLut                         = GetObject<RTHandle>(new IntPtr(p + 0x030), ReversePrism.DataModels.RTHandle.FromPointer); // 0x30 M_ColorGradingLut           ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_RendererPostProcessData                 = GetObject<PostProcessData>(new IntPtr(p + 0x038), ReversePrism.DataModels.PostProcessData.FromPointer); // 0x38 M_RendererPostProcessData   ( ModelClassType PostProcessData PostProcessData PostProcessData Pointer )
            value.M_CurrentPostProcessData                  = GetObject<PostProcessData>(new IntPtr(p + 0x040), ReversePrism.DataModels.PostProcessData.FromPointer); // 0x40 M_CurrentPostProcessData    ( ModelClassType PostProcessData PostProcessData PostProcessData Pointer )
            value.M_BlitMaterial                            = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0x48 M_BlitMaterial              ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
