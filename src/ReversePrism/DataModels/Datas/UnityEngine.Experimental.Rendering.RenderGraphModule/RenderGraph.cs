using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxMRTCount                             int IL2CPP_TYPE_I4
    // 010 M_Resources                              ModelClassType RenderGraphResourceRegistry RenderGraphResourceRegistry RenderGraphResourceRegistry Pointer
    // 018 M_RenderGraphPool                        ModelClassType RenderGraphObjectPool RenderGraphObjectPool RenderGraphObjectPool Pointer
    // 020 M_RenderPasses                           ModelClassListType List`1<RenderGraphPass> List`1<RenderGraphPass> List<RenderGraphPass> Pointer
    // 028 M_RendererLists                          ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer
    // 030 M_DebugParameters                        ModelClassType RenderGraphDebugParams RenderGraphDebugParams RenderGraphDebugParams Pointer
    // 038 M_FrameInformationLogger                 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer
    // 040 M_DefaultResources                       ModelClassType RenderGraphDefaultResources RenderGraphDefaultResources RenderGraphDefaultResources Pointer
    // 048 m_DefaultProfilingSamplers               Dictionary`2<int, ProfilingSampler> IL2CPP_TYPE_GENERICINST
    // 050 M_ExecutionExceptionWasRaised            ModelPrimitiveType bool bool bool Bool
    // 058 M_RenderGraphContext                     ModelClassType RenderGraphContext RenderGraphContext RenderGraphContext Pointer
    // 060 M_PreviousCommandBuffer                  ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 068 M_CurrentImmediatePassIndex              ModelPrimitiveType int int int Int32
    // 070 m_ImmediateModeResourceList              List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 078 m_CompiledResourcesInfos                 DynamicArray`1<CompiledResourceInfo>[] IL2CPP_TYPE_SZARRAY
    // 080 m_CompiledPassInfos                      DynamicArray`1<CompiledPassInfo> IL2CPP_TYPE_GENERICINST
    // 088 m_CullingStack                           Stack`1<int> IL2CPP_TYPE_GENERICINST
    // 090 M_ExecutionCount                         ModelPrimitiveType int int int Int32
    // 094 M_CurrentFrameIndex                      ModelPrimitiveType int int int Int32
    // 098 M_HasRenderGraphBegun                    ModelPrimitiveType bool bool bool Bool
    // 0A0 M_CurrentExecutionName                   ModelPrimitiveType string string string String
    // 0A8 M_RendererListCulling                    ModelPrimitiveType bool bool bool Bool
    // 0B0 m_DebugData                              Dictionary`2<string, RenderGraphDebugData> IL2CPP_TYPE_GENERICINST
    // 008 s_RegisteredGraphs                       List`1<RenderGraph> IL2CPP_TYPE_GENERICINST
    // 0B8 Name                                     ModelPrimitiveType string string string String
    // 010 RequireDebugData                         ModelPrimitiveType bool bool bool Bool
    // 018 OnGraphRegistered                        ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer
    // 020 OnGraphUnregistered                      ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer
    // 028 OnExecutionRegistered                    ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer
    // 030 OnExecutionUnregistered                  ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer
    public partial class RenderGraph : DataModel
    {
        public RenderGraphResourceRegistry?             M_Resources                             { get; set; }
        public RenderGraphObjectPool?                   M_RenderGraphPool                       { get; set; }
        public List<RenderGraphPass>?                   M_RenderPasses                          { get; set; }
        public List<RendererListHandle>?                M_RendererLists                         { get; set; }
        public RenderGraphDebugParams?                  M_DebugParameters                       { get; set; }
        public RenderGraphLogger?                       M_FrameInformationLogger                { get; set; }
        public RenderGraphDefaultResources?             M_DefaultResources                      { get; set; }
        public bool                                     M_ExecutionExceptionWasRaised           { get; set; }
        public RenderGraphContext?                      M_RenderGraphContext                    { get; set; }
        public CommandBuffer?                           M_PreviousCommandBuffer                 { get; set; }
        public int                                      M_CurrentImmediatePassIndex             { get; set; }
        public int                                      M_ExecutionCount                        { get; set; }
        public int                                      M_CurrentFrameIndex                     { get; set; }
        public bool                                     M_HasRenderGraphBegun                   { get; set; }
        public string                                   M_CurrentExecutionName                  { get; set; }
        public bool                                     M_RendererListCulling                   { get; set; }
        public string                                   Name                                    { get; set; }
        public bool                                     RequireDebugData                        { get; set; }
        public OnGraphRegisteredDelegate?               OnGraphRegistered                       { get; set; }
        public OnGraphRegisteredDelegate?               OnGraphUnregistered                     { get; set; }
        public OnExecutionRegisteredDelegate?           OnExecutionRegistered                   { get; set; }
        public OnExecutionRegisteredDelegate?           OnExecutionUnregistered                 { get; set; }

        public static RenderGraph? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraph() { Pointer= p0 };

            value.M_Resources                               = GetObject<RenderGraphResourceRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderGraphResourceRegistry.FromPointer); // 0x10 M_Resources                 ( ModelClassType RenderGraphResourceRegistry RenderGraphResourceRegistry RenderGraphResourceRegistry Pointer )
            value.M_RenderGraphPool                         = GetObject<RenderGraphObjectPool>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderGraphObjectPool.FromPointer); // 0x18 M_RenderGraphPool           ( ModelClassType RenderGraphObjectPool RenderGraphObjectPool RenderGraphObjectPool Pointer )
            value.M_RenderPasses                            = GetObjectList<RenderGraphPass>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderGraphPass.FromPointer); // 0x20 M_RenderPasses              ( ModelClassListType List`1<RenderGraphPass> List`1<RenderGraphPass> List<RenderGraphPass> Pointer )
            value.M_RendererLists                           = GetEnumList<RendererListHandle>(new IntPtr(p + 0x028)); // 0x28 M_RendererLists             ( ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer )
            value.M_DebugParameters                         = GetObject<RenderGraphDebugParams>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderGraphDebugParams.FromPointer); // 0x30 M_DebugParameters           ( ModelClassType RenderGraphDebugParams RenderGraphDebugParams RenderGraphDebugParams Pointer )
            value.M_FrameInformationLogger                  = GetObject<RenderGraphLogger>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderGraphLogger.FromPointer); // 0x38 M_FrameInformationLogger    ( ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer )
            value.M_DefaultResources                        = GetObject<RenderGraphDefaultResources>(new IntPtr(p + 0x040), ReversePrism.DataModels.RenderGraphDefaultResources.FromPointer); // 0x40 M_DefaultResources          ( ModelClassType RenderGraphDefaultResources RenderGraphDefaultResources RenderGraphDefaultResources Pointer )
            value.M_ExecutionExceptionWasRaised             = GetBool(new IntPtr(p + 0x050)); // 0x50 M_ExecutionExceptionWasRaised ( ModelPrimitiveType bool bool bool Bool )
            value.M_RenderGraphContext                      = GetObject<RenderGraphContext>(new IntPtr(p + 0x058), ReversePrism.DataModels.RenderGraphContext.FromPointer); // 0x58 M_RenderGraphContext        ( ModelClassType RenderGraphContext RenderGraphContext RenderGraphContext Pointer )
            value.M_PreviousCommandBuffer                   = GetObject<CommandBuffer>(new IntPtr(p + 0x060), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x60 M_PreviousCommandBuffer     ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_CurrentImmediatePassIndex               = GetInt32(new IntPtr(p + 0x068)); // 0x68 M_CurrentImmediatePassIndex ( ModelPrimitiveType int int int Int32 )
            value.M_ExecutionCount                          = GetInt32(new IntPtr(p + 0x090)); // 0x90 M_ExecutionCount            ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentFrameIndex                       = GetInt32(new IntPtr(p + 0x094)); // 0x94 M_CurrentFrameIndex         ( ModelPrimitiveType int int int Int32 )
            value.M_HasRenderGraphBegun                     = GetBool(new IntPtr(p + 0x098)); // 0x98 M_HasRenderGraphBegun       ( ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentExecutionName                    = GetString(new IntPtr(p + 0x0A0)); // 0xA0 M_CurrentExecutionName      ( ModelPrimitiveType string string string String )
            value.M_RendererListCulling                     = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 M_RendererListCulling       ( ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x0B8)); // 0xB8 Name                        ( ModelPrimitiveType string string string String )
            value.RequireDebugData                          = GetBool(new IntPtr(p + 0x010)); // 0x10 RequireDebugData            ( ModelPrimitiveType bool bool bool Bool )
            value.OnGraphRegistered                         = GetObject<OnGraphRegisteredDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.OnGraphRegisteredDelegate.FromPointer); // 0x18 OnGraphRegistered           ( ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer )
            value.OnGraphUnregistered                       = GetObject<OnGraphRegisteredDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.OnGraphRegisteredDelegate.FromPointer); // 0x20 OnGraphUnregistered         ( ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer )
            value.OnExecutionRegistered                     = GetObject<OnExecutionRegisteredDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.OnExecutionRegisteredDelegate.FromPointer); // 0x28 OnExecutionRegistered       ( ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer )
            value.OnExecutionUnregistered                   = GetObject<OnExecutionRegisteredDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.OnExecutionRegisteredDelegate.FromPointer); // 0x30 OnExecutionUnregistered     ( ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer )

            return value;
        }
    }
}
