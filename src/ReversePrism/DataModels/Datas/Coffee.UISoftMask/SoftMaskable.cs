using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kVisibleInside                           int IL2CPP_TYPE_I4
    // 000 kVisibleOutside                          int IL2CPP_TYPE_I4
    // 000 k_InvalidHash                            Hash128 IL2CPP_TYPE_VALUETYPE
    // 010 S_SoftMaskTexId                          ModelPrimitiveType int int int Int32
    // 014 S_StencilCompId                          ModelPrimitiveType int int int Int32
    // 018 S_MaskInteractionId                      ModelPrimitiveType int int int Int32
    // 01C S_GameVPId                               ModelPrimitiveType int int int Int32
    // 020 S_GameTVPId                              ModelPrimitiveType int int int Int32
    // 028 S_ActiveSoftMaskables                    ModelClassListType List`1<SoftMaskable> List`1<SoftMaskable> List<SoftMaskable> Pointer
    // 030 S_Interactions                           ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 M_Inverse                                ModelPrimitiveType bool bool bool Bool
    // 024 M_MaskInteraction                        ModelPrimitiveType int int int Int32
    // 028 M_UseStencil                             ModelPrimitiveType bool bool bool Bool
    // 029 M_RaycastFilter                          ModelPrimitiveType bool bool bool Bool
    // 030 Graphic                                  ModelClassType Graphic Graphic Graphic Pointer
    // 038 SoftMask                                 ModelClassType SoftMask SoftMask SoftMask Pointer
    // 040 EffectMaterialHash                       ModelEnumType Hash128 Hash128 Hash128 Int32
    // 050 ModifiedMaterial                         ModelClassType Material Material Material Pointer
    public partial class SoftMaskable : DataModel
    {
        public int                                      S_SoftMaskTexId                         { get; set; }
        public int                                      S_StencilCompId                         { get; set; }
        public int                                      S_MaskInteractionId                     { get; set; }
        public int                                      S_GameVPId                              { get; set; }
        public int                                      S_GameTVPId                             { get; set; }
        public List<SoftMaskable>?                      S_ActiveSoftMaskables                   { get; set; }
        public List<int>?                               S_Interactions                          { get; set; }
        public bool                                     M_Inverse                               { get; set; }
        public int                                      M_MaskInteraction                       { get; set; }
        public bool                                     M_UseStencil                            { get; set; }
        public bool                                     M_RaycastFilter                         { get; set; }
        public Graphic?                                 Graphic                                 { get; set; }
        public SoftMask?                                SoftMask                                { get; set; }
        public Hash128                                  EffectMaterialHash                      { get; set; }
        public Material?                                ModifiedMaterial                        { get; set; }

        public static SoftMaskable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoftMaskable() { Pointer= p0 };

            value.S_SoftMaskTexId                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 S_SoftMaskTexId             ( ModelPrimitiveType int int int Int32 )
            value.S_StencilCompId                           = GetInt32(new IntPtr(p + 0x014)); // 0x14 S_StencilCompId             ( ModelPrimitiveType int int int Int32 )
            value.S_MaskInteractionId                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 S_MaskInteractionId         ( ModelPrimitiveType int int int Int32 )
            value.S_GameVPId                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C S_GameVPId                  ( ModelPrimitiveType int int int Int32 )
            value.S_GameTVPId                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 S_GameTVPId                 ( ModelPrimitiveType int int int Int32 )
            value.S_ActiveSoftMaskables                     = GetObjectList<SoftMaskable>(new IntPtr(p + 0x028), ReversePrism.DataModels.SoftMaskable.FromPointer); // 0x28 S_ActiveSoftMaskables       ( ModelClassListType List`1<SoftMaskable> List`1<SoftMaskable> List<SoftMaskable> Pointer )
            value.S_Interactions                            = GetInt32List(new IntPtr(p + 0x030)); // 0x30 S_Interactions              ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_Inverse                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 M_Inverse                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_MaskInteraction                         = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_MaskInteraction           ( ModelPrimitiveType int int int Int32 )
            value.M_UseStencil                              = GetBool(new IntPtr(p + 0x028)); // 0x28 M_UseStencil                ( ModelPrimitiveType bool bool bool Bool )
            value.M_RaycastFilter                           = GetBool(new IntPtr(p + 0x029)); // 0x29 M_RaycastFilter             ( ModelPrimitiveType bool bool bool Bool )
            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x030), ReversePrism.DataModels.Graphic.FromPointer); // 0x30 Graphic                     ( ModelClassType Graphic Graphic Graphic Pointer )
            value.SoftMask                                  = GetObject<SoftMask>(new IntPtr(p + 0x038), ReversePrism.DataModels.SoftMask.FromPointer); // 0x38 SoftMask                    ( ModelClassType SoftMask SoftMask SoftMask Pointer )
            value.EffectMaterialHash                        = (Hash128)GetInt32(new IntPtr(p + 0x040)); // 0x40 EffectMaterialHash          ( ModelEnumType Hash128 Hash128 Hash128 Int32 )
            value.ModifiedMaterial                          = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0x50 ModifiedMaterial            ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
