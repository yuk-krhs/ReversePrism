using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Layout                                 XRLayout IL2CPP_TYPE_CLASS
    // 008 s_PassAllocator                          Func`2<XRPassCreateInfo, XRPass> IL2CPP_TYPE_GENERICINST
    // 010 S_MSAASamples                            ModelEnumType MSAASamples MSAASamples MSAASamples Int32
    // 018 S_OcclusionMeshMaterial                  ModelClassType Material Material Material Pointer
    // 020 S_MirrorViewMaterial                     ModelClassType Material Material Material Pointer
    // 028 s_LayoutOverride                         Action`2<XRLayout, Camera> IL2CPP_TYPE_GENERICINST
    // 030 EmptyPass                                ModelClassType XRPass XRPass XRPass Pointer
    // 038 SinglePassAllowed                        ModelPrimitiveType bool bool bool Bool
    // 03C FoveatedRenderingCaps                    ModelEnumType FoveatedRenderingCaps FoveatedRenderingCaps FoveatedRenderingCaps Int32
    // 040 DumpDebugInfo                            ModelPrimitiveType bool bool bool Bool
    public partial class XRSystem : DataModel
    {
        public MSAASamples                              S_MSAASamples                           { get; set; }
        public Material?                                S_OcclusionMeshMaterial                 { get; set; }
        public Material?                                S_MirrorViewMaterial                    { get; set; }
        public XRPass?                                  EmptyPass                               { get; set; }
        public bool                                     SinglePassAllowed                       { get; set; }
        public FoveatedRenderingCaps                    FoveatedRenderingCaps                   { get; set; }
        public bool                                     DumpDebugInfo                           { get; set; }

        public static XRSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRSystem() { Pointer= p0 };

            value.S_MSAASamples                             = (MSAASamples)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_MSAASamples               ( ModelEnumType MSAASamples MSAASamples MSAASamples Int32 )
            value.S_OcclusionMeshMaterial                   = GetObject<Material>(new IntPtr(p + 0x018), ReversePrism.DataModels.Material.FromPointer); // 0x18 S_OcclusionMeshMaterial     ( ModelClassType Material Material Material Pointer )
            value.S_MirrorViewMaterial                      = GetObject<Material>(new IntPtr(p + 0x020), ReversePrism.DataModels.Material.FromPointer); // 0x20 S_MirrorViewMaterial        ( ModelClassType Material Material Material Pointer )
            value.EmptyPass                                 = GetObject<XRPass>(new IntPtr(p + 0x030), ReversePrism.DataModels.XRPass.FromPointer); // 0x30 EmptyPass                   ( ModelClassType XRPass XRPass XRPass Pointer )
            value.SinglePassAllowed                         = GetBool(new IntPtr(p + 0x038)); // 0x38 SinglePassAllowed           ( ModelPrimitiveType bool bool bool Bool )
            value.FoveatedRenderingCaps                     = (FoveatedRenderingCaps)GetInt32(new IntPtr(p + 0x03C)); // 0x3C FoveatedRenderingCaps       ( ModelEnumType FoveatedRenderingCaps FoveatedRenderingCaps FoveatedRenderingCaps Int32 )
            value.DumpDebugInfo                             = GetBool(new IntPtr(p + 0x040)); // 0x40 DumpDebugInfo               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
