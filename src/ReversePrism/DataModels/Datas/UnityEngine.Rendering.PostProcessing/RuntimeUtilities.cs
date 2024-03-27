using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_WhiteTexture                           Texture2D IL2CPP_TYPE_CLASS
    // 008 m_WhiteTexture3D                         Texture3D IL2CPP_TYPE_CLASS
    // 010 M_BlackTexture                           000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 018 M_BlackTexture3D                         00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer
    // 020 M_TransparentTexture                     000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 028 M_TransparentTexture3D                   00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer
    // 030 m_LutStrips                              Dictionary`2<int, Texture2D> IL2CPP_TYPE_GENERICINST
    // 038 S_Resources                              00018676DE80 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 040 S_FullscreenTriangle                     000186610B40 ModelClassType Mesh Mesh Mesh Pointer
    // 048 S_FullscreenQuad                         000186610B40 ModelClassType Mesh Mesh Mesh Pointer
    // 050 S_CopyStdMaterial                        00018660C770 ModelClassType Material Material Material Pointer
    // 058 S_CopyStdFromDoubleWideMaterial          00018660C770 ModelClassType Material Material Material Pointer
    // 060 S_CopyMaterial                           00018660C770 ModelClassType Material Material Material Pointer
    // 068 S_CopyFromTexArrayMaterial               00018660C770 ModelClassType Material Material Material Pointer
    // 070 S_CopySheet                              0001865D5B40 ModelClassType PropertySheet PropertySheet PropertySheet Pointer
    // 078 S_CopyFromTexArraySheet                  0001865D5B40 ModelClassType PropertySheet PropertySheet PropertySheet Pointer
    // 080 m_AssemblyTypes                          IEnumerable`1<Type> IL2CPP_TYPE_GENERICINST
    public partial class RuntimeUtilities
    {
        public Texture2D?                               M_BlackTexture                          { get; set; }
        public Texture3D?                               M_BlackTexture3D                        { get; set; }
        public Texture2D?                               M_TransparentTexture                    { get; set; }
        public Texture3D?                               M_TransparentTexture3D                  { get; set; }
        public PostProcessResources?                    S_Resources                             { get; set; }
        public Mesh?                                    S_FullscreenTriangle                    { get; set; }
        public Mesh?                                    S_FullscreenQuad                        { get; set; }
        public Material?                                S_CopyStdMaterial                       { get; set; }
        public Material?                                S_CopyStdFromDoubleWideMaterial         { get; set; }
        public Material?                                S_CopyMaterial                          { get; set; }
        public Material?                                S_CopyFromTexArrayMaterial              { get; set; }
        public PropertySheet?                           S_CopySheet                             { get; set; }
        public PropertySheet?                           S_CopyFromTexArraySheet                 { get; set; }

        public static RuntimeUtilities? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeUtilities();

            value.M_BlackTexture                            = GetObject<Texture2D>(new IntPtr(p + 0x010), ReversePrism.DataModels.Texture2D.FromPointer); // 027006142D80 0x10 M_BlackTexture              ( 000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_BlackTexture3D                          = GetObject<Texture3D>(new IntPtr(p + 0x018), ReversePrism.DataModels.Texture3D.FromPointer); // 027006142DA0 0x18 M_BlackTexture3D            ( 00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer )
            value.M_TransparentTexture                      = GetObject<Texture2D>(new IntPtr(p + 0x020), ReversePrism.DataModels.Texture2D.FromPointer); // 027006142DC0 0x20 M_TransparentTexture        ( 000186686190 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.M_TransparentTexture3D                    = GetObject<Texture3D>(new IntPtr(p + 0x028), ReversePrism.DataModels.Texture3D.FromPointer); // 027006142DE0 0x28 M_TransparentTexture3D      ( 00018664F180 ModelClassType Texture3D Texture3D Texture3D Pointer )
            value.S_Resources                               = GetObject<PostProcessResources>(new IntPtr(p + 0x038), ReversePrism.DataModels.PostProcessResources.FromPointer); // 027006142E20 0x38 S_Resources                 ( 00018676DE80 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.S_FullscreenTriangle                      = GetObject<Mesh>(new IntPtr(p + 0x040), ReversePrism.DataModels.Mesh.FromPointer); // 027006142E40 0x40 S_FullscreenTriangle        ( 000186610B40 ModelClassType Mesh Mesh Mesh Pointer )
            value.S_FullscreenQuad                          = GetObject<Mesh>(new IntPtr(p + 0x048), ReversePrism.DataModels.Mesh.FromPointer); // 027006142E60 0x48 S_FullscreenQuad            ( 000186610B40 ModelClassType Mesh Mesh Mesh Pointer )
            value.S_CopyStdMaterial                         = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 027006142E80 0x50 S_CopyStdMaterial           ( 00018660C770 ModelClassType Material Material Material Pointer )
            value.S_CopyStdFromDoubleWideMaterial           = GetObject<Material>(new IntPtr(p + 0x058), ReversePrism.DataModels.Material.FromPointer); // 027006142EA0 0x58 S_CopyStdFromDoubleWideMaterial ( 00018660C770 ModelClassType Material Material Material Pointer )
            value.S_CopyMaterial                            = GetObject<Material>(new IntPtr(p + 0x060), ReversePrism.DataModels.Material.FromPointer); // 027006142EC0 0x60 S_CopyMaterial              ( 00018660C770 ModelClassType Material Material Material Pointer )
            value.S_CopyFromTexArrayMaterial                = GetObject<Material>(new IntPtr(p + 0x068), ReversePrism.DataModels.Material.FromPointer); // 027006142EE0 0x68 S_CopyFromTexArrayMaterial  ( 00018660C770 ModelClassType Material Material Material Pointer )
            value.S_CopySheet                               = GetObject<PropertySheet>(new IntPtr(p + 0x070), ReversePrism.DataModels.PropertySheet.FromPointer); // 027006142F00 0x70 S_CopySheet                 ( 0001865D5B40 ModelClassType PropertySheet PropertySheet PropertySheet Pointer )
            value.S_CopyFromTexArraySheet                   = GetObject<PropertySheet>(new IntPtr(p + 0x078), ReversePrism.DataModels.PropertySheet.FromPointer); // 027006142F20 0x78 S_CopyFromTexArraySheet     ( 0001865D5B40 ModelClassType PropertySheet PropertySheet PropertySheet Pointer )

            return value;
        }
    }
}
