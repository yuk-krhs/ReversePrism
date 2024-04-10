using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BlurPassCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Downsample                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 TintColor                                0001865AA8E0 ModelEnumType Color Color Color Int32
    // 038 Camera                                   0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 040 BlurPass                                 00018676AA90 ModelClassType KawaseBlurPass KawaseBlurPass KawaseBlurPass Pointer
    // 048 BlitMaterial                             00018660BDD0 ModelClassType Material Material Material Pointer
    // 050 BlurMaterial                             00018660BDD0 ModelClassType Material Material Material Pointer
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

            value.BlurPassCount                             = GetInt32(new IntPtr(p + 0x020)); // 0245A1E985F8 0x20 BlurPassCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Downsample                                = GetInt32(new IntPtr(p + 0x024)); // 0245A1E98618 0x24 Downsample                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TintColor                                 = (Color)GetInt32(new IntPtr(p + 0x028)); // 0245A1E98638 0x28 TintColor                   ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x038), ReversePrism.DataModels.Camera.FromPointer); // 0245A1E98658 0x38 Camera                      ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.BlurPass                                  = GetObject<KawaseBlurPass>(new IntPtr(p + 0x040), ReversePrism.DataModels.KawaseBlurPass.FromPointer); // 0245A1E98678 0x40 BlurPass                    ( 00018676AA90 ModelClassType KawaseBlurPass KawaseBlurPass KawaseBlurPass Pointer )
            value.BlitMaterial                              = GetObject<Material>(new IntPtr(p + 0x048), ReversePrism.DataModels.Material.FromPointer); // 0245A1E98698 0x48 BlitMaterial                ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.BlurMaterial                              = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0245A1E986B8 0x50 BlurMaterial                ( 00018660BDD0 ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
