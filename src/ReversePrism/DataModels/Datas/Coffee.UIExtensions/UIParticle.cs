using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_IsTrail                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 0E1 M_IgnoreCanvasScaler                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E4 M_Scale                                  0001866656B0 ModelPrimitiveType float float float Single
    // 0E8 M_Scale3D                                0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0F8 M_AnimatableProperties                   000185B6FC70 ModelClassListType AnimatableProperty[] AnimatableProperty[] List<AnimatableProperty> Pointer
    // 100 M_Particles                              000185CF81F8 ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer
    // 108 M_ShrinkByMaterial                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 109 ShouldBeRemoved                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 10A Tracker                                  000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    // 110 BakedMesh                                0001866104D0 ModelClassType Mesh Mesh Mesh Pointer
    // 118 ModifiedMaterials                        000185CF2148 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 120 MaskMaterials                            000185CF2148 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 128 ActiveMeshIndices                        000185CCF508 ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer
    // 130 CachedPosition                           0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 000 s_TempMaterials                          List`1<Material> IL2CPP_TYPE_GENERICINST
    // 008 s_Mpb                                    MaterialPropertyBlock IL2CPP_TYPE_CLASS
    // 010 S_PrevMaskMaterials                      000185CF2218 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 018 S_PrevModifiedMaterials                  000185CF2218 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 020 S_Components                             000185CD4028 ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer
    // 028 S_ParticleSystems                        000185CF82E8 ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer
    public partial class UIParticle
    {
        public bool                                     M_IsTrail                               { get; set; }
        public bool                                     M_IgnoreCanvasScaler                    { get; set; }
        public float                                    M_Scale                                 { get; set; }
        public Vector3                                  M_Scale3D                               { get; set; }
        public List<AnimatableProperty>?                M_AnimatableProperties                  { get; set; }
        public List<ParticleSystem>?                    M_Particles                             { get; set; }
        public bool                                     M_ShrinkByMaterial                      { get; set; }
        public bool                                     ShouldBeRemoved                         { get; set; }
        public DrivenRectTransformTracker               Tracker                                 { get; set; }
        public Mesh?                                    BakedMesh                               { get; set; }
        public List<Material>?                          ModifiedMaterials                       { get; set; }
        public List<Material>?                          MaskMaterials                           { get; set; }
        public List<bool>?                              ActiveMeshIndices                       { get; set; }
        public Vector3                                  CachedPosition                          { get; set; }
        public List<Material>?                          S_PrevMaskMaterials                     { get; set; }
        public List<Material>?                          S_PrevModifiedMaterials                 { get; set; }
        public List<Component>?                         S_Components                            { get; set; }
        public List<ParticleSystem>?                    S_ParticleSystems                       { get; set; }

        public static UIParticle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIParticle();

            value.M_IsTrail                                 = GetBool(new IntPtr(p + 0x0E0)); // 027003C4FA40 0xE0 M_IsTrail                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_IgnoreCanvasScaler                      = GetBool(new IntPtr(p + 0x0E1)); // 027003C4FA60 0xE1 M_IgnoreCanvasScaler        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x0E4)); // 027003C4FA80 0xE4 M_Scale                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Scale3D                                 = (Vector3)GetInt32(new IntPtr(p + 0x0E8)); // 027003C4FAA0 0xE8 M_Scale3D                   ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AnimatableProperties                    = GetObjectList<AnimatableProperty>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.AnimatableProperty.FromPointer); // 027003C4FAC0 0xF8 M_AnimatableProperties      ( 000185B6FC70 ModelClassListType AnimatableProperty[] AnimatableProperty[] List<AnimatableProperty> Pointer )
            value.M_Particles                               = GetObjectList<ParticleSystem>(new IntPtr(p + 0x100), ReversePrism.DataModels.ParticleSystem.FromPointer); // 027003C4FAE0 0x100 M_Particles                 ( 000185CF81F8 ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer )
            value.M_ShrinkByMaterial                        = GetBool(new IntPtr(p + 0x108)); // 027003C4FB00 0x108 M_ShrinkByMaterial          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ShouldBeRemoved                           = GetBool(new IntPtr(p + 0x109)); // 027003C4FB20 0x109 ShouldBeRemoved             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Tracker                                   = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x10A)); // 027003C4FB40 0x10A Tracker                     ( 000186705B80 ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )
            value.BakedMesh                                 = GetObject<Mesh>(new IntPtr(p + 0x110), ReversePrism.DataModels.Mesh.FromPointer); // 027003C4FB60 0x110 BakedMesh                   ( 0001866104D0 ModelClassType Mesh Mesh Mesh Pointer )
            value.ModifiedMaterials                         = GetObjectList<Material>(new IntPtr(p + 0x118), ReversePrism.DataModels.Material.FromPointer); // 027003C4FB80 0x118 ModifiedMaterials           ( 000185CF2148 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.MaskMaterials                             = GetObjectList<Material>(new IntPtr(p + 0x120), ReversePrism.DataModels.Material.FromPointer); // 027003C4FBA0 0x120 MaskMaterials               ( 000185CF2148 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.ActiveMeshIndices                         = GetBoolList(new IntPtr(p + 0x128)); // 027003C4FBC0 0x128 ActiveMeshIndices           ( 000185CCF508 ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer )
            value.CachedPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x130)); // 027003C4FBE0 0x130 CachedPosition              ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.S_PrevMaskMaterials                       = GetObjectList<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 027003C4FC40 0x10 S_PrevMaskMaterials         ( 000185CF2218 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.S_PrevModifiedMaterials                   = GetObjectList<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 027003C4FC60 0x18 S_PrevModifiedMaterials     ( 000185CF2218 ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.S_Components                              = GetObjectList<Component>(new IntPtr(p + 0x020), ReversePrism.DataModels.Component.FromPointer); // 027003C4FC80 0x20 S_Components                ( 000185CD4028 ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer )
            value.S_ParticleSystems                         = GetObjectList<ParticleSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParticleSystem.FromPointer); // 027003C4FCA0 0x28 S_ParticleSystems           ( 000185CF82E8 ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer )

            return value;
        }
    }
}
