using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BlurPassCount                            ModelPrimitiveType int int int Int32
    // 024 Downsample                               ModelPrimitiveType int int int Int32
    // 028 TintColor                                ModelEnumType Color Color Color Int32
    // 038 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 040 BlurPass                                 ModelClassType KawaseBlurPass KawaseBlurPass KawaseBlurPass Pointer
    // 048 BlitMaterial                             ModelClassType Material Material Material Pointer
    // 050 BlurMaterial                             ModelClassType Material Material Material Pointer
    public partial class BackgroundBlur : DataModel
    {
        public int                                      BlurPassCount                           { get; set; }
        public int                                      Downsample                              { get; set; }
        public Color                                    TintColor                               { get; set; }
        public Camera?                                  Camera                                  { get; set; }
        public KawaseBlurPass?                          BlurPass                                { get; set; }
        public Material?                                BlitMaterial                            { get; set; }
        public Material?                                BlurMaterial                            { get; set; }

        public static BackgroundBlur? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BackgroundBlur() { Pointer= p0 };

            value.BlurPassCount                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 BlurPassCount               ( ModelPrimitiveType int int int Int32 )
            value.Downsample                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 Downsample                  ( ModelPrimitiveType int int int Int32 )
            value.TintColor                                 = (Color)GetInt32(new IntPtr(p + 0x028)); // 0x28 TintColor                   ( ModelEnumType Color Color Color Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x038), ReversePrism.DataModels.Camera.FromPointer); // 0x38 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.BlurPass                                  = GetObject<KawaseBlurPass>(new IntPtr(p + 0x040), ReversePrism.DataModels.KawaseBlurPass.FromPointer); // 0x40 BlurPass                    ( ModelClassType KawaseBlurPass KawaseBlurPass KawaseBlurPass Pointer )
            value.BlitMaterial                              = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0x48 BlitMaterial                ( ModelClassType Material Material Material Pointer )
            value.BlurMaterial                              = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0x50 BlurMaterial                ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
