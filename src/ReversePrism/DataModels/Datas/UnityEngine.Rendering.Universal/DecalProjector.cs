using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onDecalAdd                               DecalProjectorAction IL2CPP_TYPE_CLASS
    // 008 onDecalRemove                            DecalProjectorAction IL2CPP_TYPE_CLASS
    // 010 OnDecalPropertyChange                    ModelClassType DecalProjectorAction DecalProjectorAction DecalProjectorAction Pointer
    // 018 OnAllDecalPropertyChange                 ModelClassType Action Action Action Pointer
    // 020 OnDecalMaterialChange                    ModelClassType DecalProjectorAction DecalProjectorAction DecalProjectorAction Pointer
    // 028 DefaultMaterial                          ModelClassType Material Material Material Pointer
    // 020 DecalEntity                              ModelEnumType DecalEntity DecalEntity DecalEntity Int32
    // 028 M_Material                               ModelClassType Material Material Material Pointer
    // 030 M_DrawDistance                           ModelPrimitiveType float float float Single
    // 034 M_FadeScale                              ModelPrimitiveType float float float Single
    // 038 M_StartAngleFade                         ModelPrimitiveType float float float Single
    // 03C M_EndAngleFade                           ModelPrimitiveType float float float Single
    // 040 M_UVScale                                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 048 M_UVBias                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 050 M_DecalLayerMask                         ModelPrimitiveType uint uint uint UInt32
    // 054 M_ScaleMode                              ModelEnumType DecalScaleMode DecalScaleMode DecalScaleMode Int32
    // 058 M_Offset                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 064 M_Size                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 070 M_FadeFactor                             ModelPrimitiveType float float float Single
    // 078 M_OldMaterial                            ModelClassType Material Material Material Pointer
    public partial class DecalProjector : DataModel
    {
        public DecalProjectorAction?                    OnDecalPropertyChange                   { get; set; }
        public Action?                                  OnAllDecalPropertyChange                { get; set; }
        public DecalProjectorAction?                    OnDecalMaterialChange                   { get; set; }
        public Material?                                DefaultMaterial                         { get; set; }
        public DecalEntity                              DecalEntity                             { get; set; }
        public Material?                                M_Material                              { get; set; }
        public float                                    M_DrawDistance                          { get; set; }
        public float                                    M_FadeScale                             { get; set; }
        public float                                    M_StartAngleFade                        { get; set; }
        public float                                    M_EndAngleFade                          { get; set; }
        public Vector2                                  M_UVScale                               { get; set; }
        public Vector2                                  M_UVBias                                { get; set; }
        public uint                                     M_DecalLayerMask                        { get; set; }
        public DecalScaleMode                           M_ScaleMode                             { get; set; }
        public Vector3                                  M_Offset                                { get; set; }
        public Vector3                                  M_Size                                  { get; set; }
        public float                                    M_FadeFactor                            { get; set; }
        public Material?                                M_OldMaterial                           { get; set; }

        public static DecalProjector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DecalProjector() { Pointer= p0 };

            value.OnDecalPropertyChange                     = GetObject<DecalProjectorAction>(new IntPtr(p + 0x010), ReversePrism.DataModels.DecalProjectorAction.FromPointer); // 0x10 OnDecalPropertyChange       ( ModelClassType DecalProjectorAction DecalProjectorAction DecalProjectorAction Pointer )
            value.OnAllDecalPropertyChange                  = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0x18 OnAllDecalPropertyChange    ( ModelClassType Action Action Action Pointer )
            value.OnDecalMaterialChange                     = GetObject<DecalProjectorAction>(new IntPtr(p + 0x020), ReversePrism.DataModels.DecalProjectorAction.FromPointer); // 0x20 OnDecalMaterialChange       ( ModelClassType DecalProjectorAction DecalProjectorAction DecalProjectorAction Pointer )
            value.DefaultMaterial                           = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 DefaultMaterial             ( ModelClassType Material Material Material Pointer )
            value.DecalEntity                               = (DecalEntity)GetInt32(new IntPtr(p + 0x020)); // 0x20 DecalEntity                 ( ModelEnumType DecalEntity DecalEntity DecalEntity Int32 )
            value.M_Material                                = GetObject<Material>(new IntPtr(p + 0x028), ReversePrism.DataModels.Material.FromPointer); // 0x28 M_Material                  ( ModelClassType Material Material Material Pointer )
            value.M_DrawDistance                            = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_DrawDistance              ( ModelPrimitiveType float float float Single )
            value.M_FadeScale                               = GetSingle(new IntPtr(p + 0x034)); // 0x34 M_FadeScale                 ( ModelPrimitiveType float float float Single )
            value.M_StartAngleFade                          = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_StartAngleFade            ( ModelPrimitiveType float float float Single )
            value.M_EndAngleFade                            = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_EndAngleFade              ( ModelPrimitiveType float float float Single )
            value.M_UVScale                                 = (Vector2)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_UVScale                   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_UVBias                                  = (Vector2)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_UVBias                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_DecalLayerMask                          = GetUInt32(new IntPtr(p + 0x050)); // 0x50 M_DecalLayerMask            ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_ScaleMode                               = (DecalScaleMode)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_ScaleMode                 ( ModelEnumType DecalScaleMode DecalScaleMode DecalScaleMode Int32 )
            value.M_Offset                                  = (Vector3)GetInt32(new IntPtr(p + 0x058)); // 0x58 M_Offset                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Size                                    = (Vector3)GetInt32(new IntPtr(p + 0x064)); // 0x64 M_Size                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_FadeFactor                              = GetSingle(new IntPtr(p + 0x070)); // 0x70 M_FadeFactor                ( ModelPrimitiveType float float float Single )
            value.M_OldMaterial                             = GetObject<Material>(new IntPtr(p + 0x078), ReversePrism.DataModels.Material.FromPointer); // 0x78 M_OldMaterial               ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
