using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_IsTrail                                ModelPrimitiveType bool bool bool Bool
    // 0E1 M_IgnoreCanvasScaler                     ModelPrimitiveType bool bool bool Bool
    // 0E4 M_Scale                                  ModelPrimitiveType float float float Single
    // 0E8 M_Scale3D                                ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0F8 M_AnimatableProperties                   ModelClassListType AnimatableProperty[] AnimatableProperty[] List<AnimatableProperty> Pointer
    // 100 M_Particles                              ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer
    // 108 M_ShrinkByMaterial                       ModelPrimitiveType bool bool bool Bool
    // 109 ShouldBeRemoved                          ModelPrimitiveType bool bool bool Bool
    // 10A Tracker                                  ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32
    // 110 BakedMesh                                ModelClassType Mesh Mesh Mesh Pointer
    // 118 ModifiedMaterials                        ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 120 MaskMaterials                            ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 128 ActiveMeshIndices                        ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer
    // 130 CachedPosition                           ModelEnumType Vector3 Vector3 Vector3 Int32
    // 000 s_TempMaterials                          List`1<Material> IL2CPP_TYPE_GENERICINST
    // 008 s_Mpb                                    MaterialPropertyBlock IL2CPP_TYPE_CLASS
    // 010 S_PrevMaskMaterials                      ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 018 S_PrevModifiedMaterials                  ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer
    // 020 S_Components                             ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer
    // 028 S_ParticleSystems                        ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer
    public partial class UIParticle : DataModel
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
            var value   = new UIParticle() { Pointer= p0 };

            value.M_IsTrail                                 = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 M_IsTrail                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_IgnoreCanvasScaler                      = GetBool(new IntPtr(p + 0x0E1)); // 0xE1 M_IgnoreCanvasScaler        ( ModelPrimitiveType bool bool bool Bool )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x0E4)); // 0xE4 M_Scale                     ( ModelPrimitiveType float float float Single )
            value.M_Scale3D                                 = (Vector3)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_Scale3D                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_AnimatableProperties                    = GetObjectList<AnimatableProperty>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.AnimatableProperty.FromPointer); // 0xF8 M_AnimatableProperties      ( ModelClassListType AnimatableProperty[] AnimatableProperty[] List<AnimatableProperty> Pointer )
            value.M_Particles                               = GetObjectList<ParticleSystem>(new IntPtr(p + 0x100), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x100 M_Particles                 ( ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer )
            value.M_ShrinkByMaterial                        = GetBool(new IntPtr(p + 0x108)); // 0x108 M_ShrinkByMaterial          ( ModelPrimitiveType bool bool bool Bool )
            value.ShouldBeRemoved                           = GetBool(new IntPtr(p + 0x109)); // 0x109 ShouldBeRemoved             ( ModelPrimitiveType bool bool bool Bool )
            value.Tracker                                   = (DrivenRectTransformTracker)GetInt32(new IntPtr(p + 0x10A)); // 0x10A Tracker                     ( ModelEnumType DrivenRectTransformTracker DrivenRectTransformTracker DrivenRectTransformTracker Int32 )
            value.BakedMesh                                 = GetObject<Mesh>(new IntPtr(p + 0x110), ReversePrism.DataModels.Mesh.FromPointer); // 0x110 BakedMesh                   ( ModelClassType Mesh Mesh Mesh Pointer )
            value.ModifiedMaterials                         = GetObjectList<Material>(new IntPtr(p + 0x118), ReversePrism.DataModels.Material.FromPointer); // 0x118 ModifiedMaterials           ( ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.MaskMaterials                             = GetObjectList<Material>(new IntPtr(p + 0x120), ReversePrism.DataModels.Material.FromPointer); // 0x120 MaskMaterials               ( ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.ActiveMeshIndices                         = GetBoolList(new IntPtr(p + 0x128)); // 0x128 ActiveMeshIndices           ( ModelPrimitiveListType List`1<bool> List`1<bool> List<bool> Pointer )
            value.CachedPosition                            = (Vector3)GetInt32(new IntPtr(p + 0x130)); // 0x130 CachedPosition              ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.S_PrevMaskMaterials                       = GetObjectList<Material>(new IntPtr(p + 0x010), ReversePrism.DataModels.Material.FromPointer); // 0x10 S_PrevMaskMaterials         ( ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.S_PrevModifiedMaterials                   = GetObjectList<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 S_PrevModifiedMaterials     ( ModelClassListType List`1<Material> List`1<Material> List<Material> Pointer )
            value.S_Components                              = GetObjectList<Component>(new IntPtr(p + 0x020), ReversePrism.DataModels.Component.FromPointer); // 0x20 S_Components                ( ModelClassListType List`1<Component> List`1<Component> List<Component> Pointer )
            value.S_ParticleSystems                         = GetObjectList<ParticleSystem>(new IntPtr(p + 0x028), ReversePrism.DataModels.ParticleSystem.FromPointer); // 0x28 S_ParticleSystems           ( ModelClassListType List`1<ParticleSystem> List`1<ParticleSystem> List<ParticleSystem> Pointer )

            return value;
        }
    }
}
