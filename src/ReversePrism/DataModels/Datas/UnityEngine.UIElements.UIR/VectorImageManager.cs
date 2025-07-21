using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 instances                                List`1<VectorImageManager> IL2CPP_TYPE_GENERICINST
    // 008 s_MarkerRegister                         ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 S_MarkerUnregister                       ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 010 M_Atlas                                  ModelClassType AtlasBase AtlasBase AtlasBase Pointer
    // 018 m_Registered                             Dictionary`2<VectorImage, VectorImageRenderInfo> IL2CPP_TYPE_GENERICINST
    // 020 M_RenderInfoPool                         ModelClassType VectorImageRenderInfoPool VectorImageRenderInfoPool VectorImageRenderInfoPool Pointer
    // 028 M_GradientRemapPool                      ModelClassType GradientRemapPool GradientRemapPool GradientRemapPool Pointer
    // 030 M_GradientSettingsAtlas                  ModelClassType GradientSettingsAtlas GradientSettingsAtlas GradientSettingsAtlas Pointer
    // 038 M_LoggedExhaustedSettingsAtlas           ModelPrimitiveType bool bool bool Bool
    // 039 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class VectorImageManager : DataModel
    {
        public ProfilerMarker                           S_MarkerUnregister                      { get; set; }
        public AtlasBase?                               M_Atlas                                 { get; set; }
        public VectorImageRenderInfoPool?               M_RenderInfoPool                        { get; set; }
        public GradientRemapPool?                       M_GradientRemapPool                     { get; set; }
        public GradientSettingsAtlas?                   M_GradientSettingsAtlas                 { get; set; }
        public bool                                     M_LoggedExhaustedSettingsAtlas          { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static VectorImageManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VectorImageManager() { Pointer= p0 };

            value.S_MarkerUnregister                        = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_MarkerUnregister          ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.M_Atlas                                   = GetObject<AtlasBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.AtlasBase.FromPointer); // 0x10 M_Atlas                     ( ModelClassType AtlasBase AtlasBase AtlasBase Pointer )
            value.M_RenderInfoPool                          = GetObject<VectorImageRenderInfoPool>(new IntPtr(p + 0x020), ReversePrism.DataModels.VectorImageRenderInfoPool.FromPointer); // 0x20 M_RenderInfoPool            ( ModelClassType VectorImageRenderInfoPool VectorImageRenderInfoPool VectorImageRenderInfoPool Pointer )
            value.M_GradientRemapPool                       = GetObject<GradientRemapPool>(new IntPtr(p + 0x028), ReversePrism.DataModels.GradientRemapPool.FromPointer); // 0x28 M_GradientRemapPool         ( ModelClassType GradientRemapPool GradientRemapPool GradientRemapPool Pointer )
            value.M_GradientSettingsAtlas                   = GetObject<GradientSettingsAtlas>(new IntPtr(p + 0x030), ReversePrism.DataModels.GradientSettingsAtlas.FromPointer); // 0x30 M_GradientSettingsAtlas     ( ModelClassType GradientSettingsAtlas GradientSettingsAtlas GradientSettingsAtlas Pointer )
            value.M_LoggedExhaustedSettingsAtlas            = GetBool(new IntPtr(p + 0x038)); // 0x38 M_LoggedExhaustedSettingsAtlas ( ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x039)); // 0x39 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
