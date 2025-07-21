using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StopNaN                                  ModelClassType Material Material Material Pointer
    // 018 SubpixelMorphologicalAntialiasing        ModelClassType Material Material Material Pointer
    // 020 GaussianDepthOfField                     ModelClassType Material Material Material Pointer
    // 028 BokehDepthOfField                        ModelClassType Material Material Material Pointer
    // 030 CameraMotionBlur                         ModelClassType Material Material Material Pointer
    // 038 PaniniProjection                         ModelClassType Material Material Material Pointer
    // 040 Bloom                                    ModelClassType Material Material Material Pointer
    // 048 TemporalAntialiasing                     ModelClassType Material Material Material Pointer
    // 050 ScalingSetup                             ModelClassType Material Material Material Pointer
    // 058 Easu                                     ModelClassType Material Material Material Pointer
    // 060 Uber                                     ModelClassType Material Material Material Pointer
    // 068 FinalPass                                ModelClassType Material Material Material Pointer
    // 070 LensFlareDataDriven                      ModelClassType Material Material Material Pointer
    public partial class MaterialLibrary : DataModel
    {
        public Material?                                StopNaN                                 { get; set; }
        public Material?                                SubpixelMorphologicalAntialiasing       { get; set; }
        public Material?                                GaussianDepthOfField                    { get; set; }
        public Material?                                BokehDepthOfField                       { get; set; }
        public Material?                                CameraMotionBlur                        { get; set; }
        public Material?                                PaniniProjection                        { get; set; }
        public Material?                                Bloom                                   { get; set; }
        public Material?                                TemporalAntialiasing                    { get; set; }
        public Material?                                ScalingSetup                            { get; set; }
        public Material?                                Easu                                    { get; set; }
        public Material?                                Uber                                    { get; set; }
        public Material?                                FinalPass                               { get; set; }
        public Material?                                LensFlareDataDriven                     { get; set; }

        public static MaterialLibrary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MaterialLibrary() { Pointer= p0 };

            value.StopNaN                                   = GetObject<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 StopNaN                     ( ModelClassType Material Material Material Pointer )
            value.SubpixelMorphologicalAntialiasing         = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 SubpixelMorphologicalAntialiasing ( ModelClassType Material Material Material Pointer )
            value.GaussianDepthOfField                      = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0x20 GaussianDepthOfField        ( ModelClassType Material Material Material Pointer )
            value.BokehDepthOfField                         = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 BokehDepthOfField           ( ModelClassType Material Material Material Pointer )
            value.CameraMotionBlur                          = GetObject<Material>(new IntPtr(p + 0x030), ReversePrism.DataModels.Material.FromPointer); // 0x30 CameraMotionBlur            ( ModelClassType Material Material Material Pointer )
            value.PaniniProjection                          = GetObject<Material>(new IntPtr(p + 0x038), ReversePrism.DataModels.Material.FromPointer); // 0x38 PaniniProjection            ( ModelClassType Material Material Material Pointer )
            value.Bloom                                     = GetObject<Material>(new IntPtr(p + 0x040), ReversePrism.DataModels.Material.FromPointer); // 0x40 Bloom                       ( ModelClassType Material Material Material Pointer )
            value.TemporalAntialiasing                      = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0x48 TemporalAntialiasing        ( ModelClassType Material Material Material Pointer )
            value.ScalingSetup                              = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0x50 ScalingSetup                ( ModelClassType Material Material Material Pointer )
            value.Easu                                      = GetObject<Material>(new IntPtr(p + 0x058), ReversePrism.DataModels.Material.FromPointer); // 0x58 Easu                        ( ModelClassType Material Material Material Pointer )
            value.Uber                                      = GetObject<Material>(new IntPtr(p + 0x060), ReversePrism.DataModels.Material.FromPointer); // 0x60 Uber                        ( ModelClassType Material Material Material Pointer )
            value.FinalPass                                 = GetObject<Material>(new IntPtr(p + 0x068), ReversePrism.DataModels.Material.FromPointer); // 0x68 FinalPass                   ( ModelClassType Material Material Material Pointer )
            value.LensFlareDataDriven                       = GetObject<Material>(new IntPtr(p + 0x070), ReversePrism.DataModels.Material.FromPointer); // 0x70 LensFlareDataDriven         ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
