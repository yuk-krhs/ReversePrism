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
    // 010 S_SoftMaskTexId                          0001865F38E0 ModelPrimitiveType int int int Int32
    // 014 S_StencilCompId                          0001865F38E0 ModelPrimitiveType int int int Int32
    // 018 S_MaskInteractionId                      0001865F38E0 ModelPrimitiveType int int int Int32
    // 01C S_GameVPId                               0001865F38E0 ModelPrimitiveType int int int Int32
    // 020 S_GameTVPId                              0001865F38E0 ModelPrimitiveType int int int Int32
    // 028 S_ActiveSoftMaskables                    000185D0A628 ModelClassListType List`1<SoftMaskable> List`1<SoftMaskable> List<SoftMaskable> Pointer
    // 030 S_Interactions                           000185B7D6C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 M_Inverse                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 M_MaskInteraction                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_UseStencil                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 M_RaycastFilter                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 Graphic                                  0001866920B0 ModelClassType Graphic Graphic Graphic Pointer
    // 038 SoftMask                                 000186526680 ModelClassType SoftMask SoftMask SoftMask Pointer
    // 040 EffectMaterialHash                       0001865DD790 ModelEnumType Hash128 Hash128 Hash128 Int32
    // 050 ModifiedMaterial                         00018660BDD0 ModelClassType Material Material Material Pointer
    public partial class SoftMaskable
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
            var value   = new SoftMaskable();

            value.S_SoftMaskTexId                           = GetInt32(new IntPtr(p + 0x010)); // 0270DBE0B3E0 0x10 S_SoftMaskTexId             ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_StencilCompId                           = GetInt32(new IntPtr(p + 0x014)); // 0270DBE0B400 0x14 S_StencilCompId             ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_MaskInteractionId                       = GetInt32(new IntPtr(p + 0x018)); // 0270DBE0B420 0x18 S_MaskInteractionId         ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_GameVPId                                = GetInt32(new IntPtr(p + 0x01C)); // 0270DBE0B440 0x1C S_GameVPId                  ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_GameTVPId                               = GetInt32(new IntPtr(p + 0x020)); // 0270DBE0B460 0x20 S_GameTVPId                 ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_ActiveSoftMaskables                     = GetObjectList<SoftMaskable>(new IntPtr(p + 0x028), ReversePrism.DataModels.SoftMaskable.FromPointer); // 0270DBE0B480 0x28 S_ActiveSoftMaskables       ( 000185D0A628 ModelClassListType List`1<SoftMaskable> List`1<SoftMaskable> List<SoftMaskable> Pointer )
            value.S_Interactions                            = GetInt32List(new IntPtr(p + 0x030)); // 0270DBE0B4A0 0x30 S_Interactions              ( 000185B7D6C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_Inverse                                 = GetBool(new IntPtr(p + 0x020)); // 0270DBE0B4C0 0x20 M_Inverse                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MaskInteraction                         = GetInt32(new IntPtr(p + 0x024)); // 0270DBE0B4E0 0x24 M_MaskInteraction           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_UseStencil                              = GetBool(new IntPtr(p + 0x028)); // 0270DBE0B500 0x28 M_UseStencil                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RaycastFilter                           = GetBool(new IntPtr(p + 0x029)); // 0270DBE0B520 0x29 M_RaycastFilter             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x030), ReversePrism.DataModels.Graphic.FromPointer); // 0270DBE0B540 0x30 Graphic                     ( 0001866920B0 ModelClassType Graphic Graphic Graphic Pointer )
            value.SoftMask                                  = GetObject<SoftMask>(new IntPtr(p + 0x038), ReversePrism.DataModels.SoftMask.FromPointer); // 0270DBE0B560 0x38 SoftMask                    ( 000186526680 ModelClassType SoftMask SoftMask SoftMask Pointer )
            value.EffectMaterialHash                        = (Hash128)GetInt32(new IntPtr(p + 0x040)); // 0270DBE0B580 0x40 EffectMaterialHash          ( 0001865DD790 ModelEnumType Hash128 Hash128 Hash128 Int32 )
            value.ModifiedMaterial                          = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0270DBE0B5A0 0x50 ModifiedMaterial            ( 00018660BDD0 ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
