using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FlareRenderer                            ModelClassType Renderer Renderer Renderer Pointer
    // 028 BeamRenderer                             ModelClassType Renderer Renderer Renderer Pointer
    // 030 MyTransform                              ModelClassType Transform Transform Transform Pointer
    // 038 MyLensFlare                              ModelClassType LensFlare LensFlare LensFlare Pointer
    // 040 TargetCamera                             ModelClassType Camera Camera Camera Pointer
    // 048 FlareMaterialPropertyBlock               ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 050 BeamMaterialPropertyBlock                ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 058 Color                                    ModelEnumType Color Color Color Int32
    public partial class LightBeam : DataModel
    {
        public Renderer?                                FlareRenderer                           { get; set; }
        public Renderer?                                BeamRenderer                            { get; set; }
        public Transform?                               MyTransform                             { get; set; }
        public LensFlare?                               MyLensFlare                             { get; set; }
        public Camera?                                  TargetCamera                            { get; set; }
        public MaterialPropertyBlock?                   FlareMaterialPropertyBlock              { get; set; }
        public MaterialPropertyBlock?                   BeamMaterialPropertyBlock               { get; set; }
        public Color                                    Color                                   { get; set; }

        public static LightBeam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightBeam() { Pointer= p0 };

            value.FlareRenderer                             = GetObject<Renderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.Renderer.FromPointer); // 0x20 FlareRenderer               ( ModelClassType Renderer Renderer Renderer Pointer )
            value.BeamRenderer                              = GetObject<Renderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.Renderer.FromPointer); // 0x28 BeamRenderer                ( ModelClassType Renderer Renderer Renderer Pointer )
            value.MyTransform                               = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 MyTransform                 ( ModelClassType Transform Transform Transform Pointer )
            value.MyLensFlare                               = GetObject<LensFlare>(new IntPtr(p + 0x038), ReversePrism.DataModels.LensFlare.FromPointer); // 0x38 MyLensFlare                 ( ModelClassType LensFlare LensFlare LensFlare Pointer )
            value.TargetCamera                              = GetObject<Camera>(new IntPtr(p + 0x040), ReversePrism.DataModels.Camera.FromPointer); // 0x40 TargetCamera                ( ModelClassType Camera Camera Camera Pointer )
            value.FlareMaterialPropertyBlock                = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x048), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0x48 FlareMaterialPropertyBlock  ( ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.BeamMaterialPropertyBlock                 = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x050), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0x50 BeamMaterialPropertyBlock   ( ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x058)); // 0x58 Color                       ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
