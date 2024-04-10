using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 FlareRenderer                            00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 028 BeamRenderer                             00018665F150 ModelClassType Renderer Renderer Renderer Pointer
    // 030 MyTransform                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 MyLensFlare                              00018651A300 ModelClassType LensFlare LensFlare LensFlare Pointer
    // 040 TargetCamera                             0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 048 FlareMaterialPropertyBlock               0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 050 BeamMaterialPropertyBlock                0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 058 Color                                    0001865AA8E0 ModelEnumType Color Color Color Int32
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

            value.FlareRenderer                             = GetObject<Renderer>(new IntPtr(p + 0x020), ReversePrism.DataModels.Renderer.FromPointer); // 024664E3E1D8 0x20 FlareRenderer               ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.BeamRenderer                              = GetObject<Renderer>(new IntPtr(p + 0x028), ReversePrism.DataModels.Renderer.FromPointer); // 024664E3E1F8 0x28 BeamRenderer                ( 00018665F150 ModelClassType Renderer Renderer Renderer Pointer )
            value.MyTransform                               = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 024664E3E218 0x30 MyTransform                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.MyLensFlare                               = GetObject<LensFlare>(new IntPtr(p + 0x038), ReversePrism.DataModels.LensFlare.FromPointer); // 024664E3E238 0x38 MyLensFlare                 ( 00018651A300 ModelClassType LensFlare LensFlare LensFlare Pointer )
            value.TargetCamera                              = GetObject<Camera>(new IntPtr(p + 0x040), ReversePrism.DataModels.Camera.FromPointer); // 024664E3E258 0x40 TargetCamera                ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.FlareMaterialPropertyBlock                = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x048), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 024664E3E278 0x48 FlareMaterialPropertyBlock  ( 0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.BeamMaterialPropertyBlock                 = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x050), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 024664E3E298 0x50 BeamMaterialPropertyBlock   ( 0001865E0FC0 ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x058)); // 024664E3E2B8 0x58 Color                       ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
