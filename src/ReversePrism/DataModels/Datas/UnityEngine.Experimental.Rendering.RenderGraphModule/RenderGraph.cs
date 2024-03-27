using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMaxMRTCount                             int IL2CPP_TYPE_I4
    // 010 M_Resources                              000186655FC0 ModelClassType RenderGraphResourceRegistry RenderGraphResourceRegistry RenderGraphResourceRegistry Pointer
    // 018 M_RenderGraphPool                        0001866544F0 ModelClassType RenderGraphObjectPool RenderGraphObjectPool RenderGraphObjectPool Pointer
    // 020 M_RenderPasses                           000185D01BA8 ModelClassListType List`1<RenderGraphPass> List`1<RenderGraphPass> List<RenderGraphPass> Pointer
    // 028 M_RendererLists                          000185D027F8 ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer
    // 030 M_DebugParameters                        000186652EE0 ModelClassType RenderGraphDebugParams RenderGraphDebugParams RenderGraphDebugParams Pointer
    // 038 M_FrameInformationLogger                 000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer
    // 040 M_DefaultResources                       0001866533E0 ModelClassType RenderGraphDefaultResources RenderGraphDefaultResources RenderGraphDefaultResources Pointer
    // 048 m_DefaultProfilingSamplers               Dictionary`2<int, ProfilingSampler> IL2CPP_TYPE_GENERICINST
    // 050 M_ExecutionExceptionWasRaised            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 M_RenderGraphContext                     000186652770 ModelClassType RenderGraphContext RenderGraphContext RenderGraphContext Pointer
    // 060 M_PreviousCommandBuffer                  0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 068 M_CurrentImmediatePassIndex              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 m_ImmediateModeResourceList              List`1<int>[] IL2CPP_TYPE_SZARRAY
    // 078 m_CompiledResourcesInfos                 DynamicArray`1<CompiledResourceInfo>[] IL2CPP_TYPE_SZARRAY
    // 080 m_CompiledPassInfos                      DynamicArray`1<CompiledPassInfo> IL2CPP_TYPE_GENERICINST
    // 088 m_CullingStack                           Stack`1<int> IL2CPP_TYPE_GENERICINST
    // 090 M_ExecutionCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 M_CurrentFrameIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 M_HasRenderGraphBegun                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 M_CurrentExecutionName                   000186671910 ModelPrimitiveType string string string String
    // 0A8 M_RendererListCulling                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B0 m_DebugData                              Dictionary`2<string, RenderGraphDebugData> IL2CPP_TYPE_GENERICINST
    // 008 s_RegisteredGraphs                       List`1<RenderGraph> IL2CPP_TYPE_GENERICINST
    // 0B8 Name                                     000186671910 ModelPrimitiveType string string string String
    // 010 RequireDebugData                         000186595C30 ModelPrimitiveType bool bool bool Bool
    // 018 OnGraphRegistered                        0001866CCE00 ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer
    // 020 OnGraphUnregistered                      0001866CCE00 ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer
    // 028 OnExecutionRegistered                    0001866CC950 ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer
    // 030 OnExecutionUnregistered                  0001866CC950 ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer
    public partial class RenderGraph
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
            var value   = new RenderGraph();

            value.M_Resources                               = GetObject<RenderGraphResourceRegistry>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderGraphResourceRegistry.FromPointer); // 0270D90795D0 0x10 M_Resources                 ( 000186655FC0 ModelClassType RenderGraphResourceRegistry RenderGraphResourceRegistry RenderGraphResourceRegistry Pointer )
            value.M_RenderGraphPool                         = GetObject<RenderGraphObjectPool>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderGraphObjectPool.FromPointer); // 0270D90795F0 0x18 M_RenderGraphPool           ( 0001866544F0 ModelClassType RenderGraphObjectPool RenderGraphObjectPool RenderGraphObjectPool Pointer )
            value.M_RenderPasses                            = GetObjectList<RenderGraphPass>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderGraphPass.FromPointer); // 0270D9079610 0x20 M_RenderPasses              ( 000185D01BA8 ModelClassListType List`1<RenderGraphPass> List`1<RenderGraphPass> List<RenderGraphPass> Pointer )
            value.M_RendererLists                           = GetEnumList<RendererListHandle>(new IntPtr(p + 0x028)); // 0270D9079630 0x28 M_RendererLists             ( 000185D027F8 ModelEnumListType List`1<RendererListHandle> List`1<RendererListHandle> List<RendererListHandle> Pointer )
            value.M_DebugParameters                         = GetObject<RenderGraphDebugParams>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderGraphDebugParams.FromPointer); // 0270D9079650 0x30 M_DebugParameters           ( 000186652EE0 ModelClassType RenderGraphDebugParams RenderGraphDebugParams RenderGraphDebugParams Pointer )
            value.M_FrameInformationLogger                  = GetObject<RenderGraphLogger>(new IntPtr(p + 0x038), ReversePrism.DataModels.RenderGraphLogger.FromPointer); // 0270D9079670 0x38 M_FrameInformationLogger    ( 000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer )
            value.M_DefaultResources                        = GetObject<RenderGraphDefaultResources>(new IntPtr(p + 0x040), ReversePrism.DataModels.RenderGraphDefaultResources.FromPointer); // 0270D9079690 0x40 M_DefaultResources          ( 0001866533E0 ModelClassType RenderGraphDefaultResources RenderGraphDefaultResources RenderGraphDefaultResources Pointer )
            value.M_ExecutionExceptionWasRaised             = GetBool(new IntPtr(p + 0x050)); // 0270D90796D0 0x50 M_ExecutionExceptionWasRaised ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_RenderGraphContext                      = GetObject<RenderGraphContext>(new IntPtr(p + 0x058), ReversePrism.DataModels.RenderGraphContext.FromPointer); // 0270D90796F0 0x58 M_RenderGraphContext        ( 000186652770 ModelClassType RenderGraphContext RenderGraphContext RenderGraphContext Pointer )
            value.M_PreviousCommandBuffer                   = GetObject<CommandBuffer>(new IntPtr(p + 0x060), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0270D9079710 0x60 M_PreviousCommandBuffer     ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_CurrentImmediatePassIndex               = GetInt32(new IntPtr(p + 0x068)); // 0270D9079730 0x68 M_CurrentImmediatePassIndex ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ExecutionCount                          = GetInt32(new IntPtr(p + 0x090)); // 0270D90797D0 0x90 M_ExecutionCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentFrameIndex                       = GetInt32(new IntPtr(p + 0x094)); // 0270D90797F0 0x94 M_CurrentFrameIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_HasRenderGraphBegun                     = GetBool(new IntPtr(p + 0x098)); // 0270D9079810 0x98 M_HasRenderGraphBegun       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentExecutionName                    = GetString(new IntPtr(p + 0x0A0)); // 0270D9079830 0xA0 M_CurrentExecutionName      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_RendererListCulling                     = GetBool(new IntPtr(p + 0x0A8)); // 0270D9079850 0xA8 M_RendererListCulling       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x0B8)); // 0270D90798B0 0xB8 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.RequireDebugData                          = GetBool(new IntPtr(p + 0x010)); // 0270D90798D0 0x10 RequireDebugData            ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.OnGraphRegistered                         = GetObject<OnGraphRegisteredDelegate>(new IntPtr(p + 0x018), ReversePrism.DataModels.OnGraphRegisteredDelegate.FromPointer); // 0270D90798F0 0x18 OnGraphRegistered           ( 0001866CCE00 ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer )
            value.OnGraphUnregistered                       = GetObject<OnGraphRegisteredDelegate>(new IntPtr(p + 0x020), ReversePrism.DataModels.OnGraphRegisteredDelegate.FromPointer); // 0270D9079910 0x20 OnGraphUnregistered         ( 0001866CCE00 ModelClassType OnGraphRegisteredDelegate OnGraphRegisteredDelegate OnGraphRegisteredDelegate Pointer )
            value.OnExecutionRegistered                     = GetObject<OnExecutionRegisteredDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.OnExecutionRegisteredDelegate.FromPointer); // 0270D9079930 0x28 OnExecutionRegistered       ( 0001866CC950 ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer )
            value.OnExecutionUnregistered                   = GetObject<OnExecutionRegisteredDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.OnExecutionRegisteredDelegate.FromPointer); // 0270D9079950 0x30 OnExecutionUnregistered     ( 0001866CC950 ModelClassType OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate OnExecutionRegisteredDelegate Pointer )

            return value;
        }
    }
}
