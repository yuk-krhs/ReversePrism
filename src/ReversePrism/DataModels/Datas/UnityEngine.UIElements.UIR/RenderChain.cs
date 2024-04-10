using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FirstCommand                           0001866544B0 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer
    // 018 M_DirtyTracker                           0001866CBD20 ModelEnumType DepthOrderedDirtyTracking DepthOrderedDirtyTracking DepthOrderedDirtyTracking Int32
    // 040 m_CommandPool                            LinkedPool`1<RenderChainCommand> IL2CPP_TYPE_GENERICINST
    // 048 m_TexturePool                            BasicNodePool`1<TextureEntry> IL2CPP_TYPE_GENERICINST
    // 050 M_RenderNodesData                        000185D29F98 ModelEnumListType List`1<RenderNodeData> List`1<RenderNodeData> List<RenderNodeData> Pointer
    // 058 M_DefaultShader                          00018674C760 ModelClassType Shader Shader Shader Pointer
    // 060 M_DefaultWorldSpaceShader                00018674C760 ModelClassType Shader Shader Shader Pointer
    // 068 M_DefaultMat                             00018660BDD0 ModelClassType Material Material Material Pointer
    // 070 M_DefaultWorldSpaceMat                   00018660BDD0 ModelClassType Material Material Material Pointer
    // 078 M_BlockDirtyRegistration                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 07C M_StaticIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 M_ActiveRenderNodes                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 M_CustomMaterialCommands                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 M_Stats                                  0001865A5F90 ModelEnumType ChainBuilderStats ChainBuilderStats ChainBuilderStats Int32
    // 0E8 M_StatsElementsAdded                     000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 0EC M_StatsElementsRemoved                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 0F0 M_TextureRegistry                        000186656720 ModelClassType TextureRegistry TextureRegistry TextureRegistry Pointer
    // 0F8 OpacityIdAccelerator                     0001866E0B20 ModelClassType OpacityIdAccelerator OpacityIdAccelerator OpacityIdAccelerator Pointer
    // 000 s_MarkerProcess                          ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 008 s_MarkerClipProcessing                   ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 010 S_MarkerOpacityProcessing                0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 018 S_MarkerColorsProcessing                 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 S_MarkerTransformProcessing              0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 S_MarkerVisualsProcessing                0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 030 S_MarkerTextRegen                        0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 100 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 OnPreRender                              000186679EC0 ModelClassType Action Action Action Pointer
    // 108 Panel                                    000186745F20 ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer
    // 110 Device                                   0001866F0570 ModelClassType UIRenderDevice UIRenderDevice UIRenderDevice Pointer
    // 118 Atlas                                    00018670BF90 ModelClassType AtlasBase AtlasBase AtlasBase Pointer
    // 120 VectorImageManager                       000186509820 ModelClassType VectorImageManager VectorImageManager VectorImageManager Pointer
    // 128 <vertsPool>k__BackingField               TempAllocator`1<Vertex> IL2CPP_TYPE_GENERICINST
    // 130 <indicesPool>k__BackingField             TempAllocator`1<ushort> IL2CPP_TYPE_GENERICINST
    // 138 JobManager                               00018674BD60 ModelClassType JobManager JobManager JobManager Pointer
    // 140 ShaderInfoAllocator                      0001866EF4B0 ModelEnumType UIRVEShaderInfoAllocator UIRVEShaderInfoAllocator UIRVEShaderInfoAllocator Int32
    // 210 Painter                                  0001866EEDE0 ModelClassType UIRStylePainter UIRStylePainter UIRStylePainter Pointer
    // 218 DrawStats                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 219 DrawInCameras                            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class RenderChain : DataModel
    {
        public RenderChainCommand?                      M_FirstCommand                          { get; set; }
        public DepthOrderedDirtyTracking                M_DirtyTracker                          { get; set; }
        public List<RenderNodeData>?                    M_RenderNodesData                       { get; set; }
        public Shader?                                  M_DefaultShader                         { get; set; }
        public Shader?                                  M_DefaultWorldSpaceShader               { get; set; }
        public Material?                                M_DefaultMat                            { get; set; }
        public Material?                                M_DefaultWorldSpaceMat                  { get; set; }
        public bool                                     M_BlockDirtyRegistration                { get; set; }
        public int                                      M_StaticIndex                           { get; set; }
        public int                                      M_ActiveRenderNodes                     { get; set; }
        public int                                      M_CustomMaterialCommands                { get; set; }
        public ChainBuilderStats                        M_Stats                                 { get; set; }
        public uint                                     M_StatsElementsAdded                    { get; set; }
        public uint                                     M_StatsElementsRemoved                  { get; set; }
        public TextureRegistry?                         M_TextureRegistry                       { get; set; }
        public OpacityIdAccelerator?                    OpacityIdAccelerator                    { get; set; }
        public ProfilerMarker                           S_MarkerOpacityProcessing               { get; set; }
        public ProfilerMarker                           S_MarkerColorsProcessing                { get; set; }
        public ProfilerMarker                           S_MarkerTransformProcessing             { get; set; }
        public ProfilerMarker                           S_MarkerVisualsProcessing               { get; set; }
        public ProfilerMarker                           S_MarkerTextRegen                       { get; set; }
        public bool                                     Disposed                                { get; set; }
        public Action?                                  OnPreRender                             { get; set; }
        public BaseVisualElementPanel?                  Panel                                   { get; set; }
        public UIRenderDevice?                          Device                                  { get; set; }
        public AtlasBase?                               Atlas                                   { get; set; }
        public VectorImageManager?                      VectorImageManager                      { get; set; }
        public JobManager?                              JobManager                              { get; set; }
        public UIRVEShaderInfoAllocator                 ShaderInfoAllocator                     { get; set; }
        public UIRStylePainter?                         Painter                                 { get; set; }
        public bool                                     DrawStats                               { get; set; }
        public bool                                     DrawInCameras                           { get; set; }

        public static RenderChain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderChain() { Pointer= p0 };

            value.M_FirstCommand                            = GetObject<RenderChainCommand>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderChainCommand.FromPointer); // 0245A682CAC8 0x10 M_FirstCommand              ( 0001866544B0 ModelClassType RenderChainCommand RenderChainCommand RenderChainCommand Pointer )
            value.M_DirtyTracker                            = (DepthOrderedDirtyTracking)GetInt32(new IntPtr(p + 0x018)); // 0245A682CAE8 0x18 M_DirtyTracker              ( 0001866CBD20 ModelEnumType DepthOrderedDirtyTracking DepthOrderedDirtyTracking DepthOrderedDirtyTracking Int32 )
            value.M_RenderNodesData                         = GetEnumList<RenderNodeData>(new IntPtr(p + 0x050)); // 0245A682CB48 0x50 M_RenderNodesData           ( 000185D29F98 ModelEnumListType List`1<RenderNodeData> List`1<RenderNodeData> List<RenderNodeData> Pointer )
            value.M_DefaultShader                           = GetObject<Shader>(new IntPtr(p + 0x058), ReversePrism.DataModels.Shader.FromPointer); // 0245A682CB68 0x58 M_DefaultShader             ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.M_DefaultWorldSpaceShader                 = GetObject<Shader>(new IntPtr(p + 0x060), ReversePrism.DataModels.Shader.FromPointer); // 0245A682CB88 0x60 M_DefaultWorldSpaceShader   ( 00018674C760 ModelClassType Shader Shader Shader Pointer )
            value.M_DefaultMat                              = GetObject<Material>(new IntPtr(p + 0x068), ReversePrism.DataModels.Material.FromPointer); // 0245A682CBA8 0x68 M_DefaultMat                ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_DefaultWorldSpaceMat                    = GetObject<Material>(new IntPtr(p + 0x070), ReversePrism.DataModels.Material.FromPointer); // 0245A682CBC8 0x70 M_DefaultWorldSpaceMat      ( 00018660BDD0 ModelClassType Material Material Material Pointer )
            value.M_BlockDirtyRegistration                  = GetBool(new IntPtr(p + 0x078)); // 0245A682CBE8 0x78 M_BlockDirtyRegistration    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_StaticIndex                             = GetInt32(new IntPtr(p + 0x07C)); // 0245A682CC08 0x7C M_StaticIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ActiveRenderNodes                       = GetInt32(new IntPtr(p + 0x080)); // 0245A682CC28 0x80 M_ActiveRenderNodes         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CustomMaterialCommands                  = GetInt32(new IntPtr(p + 0x084)); // 0245A682CC48 0x84 M_CustomMaterialCommands    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Stats                                   = (ChainBuilderStats)GetInt32(new IntPtr(p + 0x088)); // 0245A682CC68 0x88 M_Stats                     ( 0001865A5F90 ModelEnumType ChainBuilderStats ChainBuilderStats ChainBuilderStats Int32 )
            value.M_StatsElementsAdded                      = GetUInt32(new IntPtr(p + 0x0E8)); // 0245A682CC88 0xE8 M_StatsElementsAdded        ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_StatsElementsRemoved                    = GetUInt32(new IntPtr(p + 0x0EC)); // 0245A682CCA8 0xEC M_StatsElementsRemoved      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_TextureRegistry                         = GetObject<TextureRegistry>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.TextureRegistry.FromPointer); // 0245A682CCC8 0xF0 M_TextureRegistry           ( 000186656720 ModelClassType TextureRegistry TextureRegistry TextureRegistry Pointer )
            value.OpacityIdAccelerator                      = GetObject<OpacityIdAccelerator>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.OpacityIdAccelerator.FromPointer); // 0245A682CCE8 0xF8 OpacityIdAccelerator        ( 0001866E0B20 ModelClassType OpacityIdAccelerator OpacityIdAccelerator OpacityIdAccelerator Pointer )
            value.S_MarkerOpacityProcessing                 = (ProfilerMarker)GetInt32(new IntPtr(p + 0x010)); // 0245A682CD48 0x10 S_MarkerOpacityProcessing   ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MarkerColorsProcessing                  = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0245A682CD68 0x18 S_MarkerColorsProcessing    ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MarkerTransformProcessing               = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0245A682CD88 0x20 S_MarkerTransformProcessing ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MarkerVisualsProcessing                 = (ProfilerMarker)GetInt32(new IntPtr(p + 0x028)); // 0245A682CDA8 0x28 S_MarkerVisualsProcessing   ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_MarkerTextRegen                         = (ProfilerMarker)GetInt32(new IntPtr(p + 0x030)); // 0245A682CDC8 0x30 S_MarkerTextRegen           ( 0001865C9730 ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x100)); // 0245A682CDE8 0x100 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnPreRender                               = GetObject<Action>(new IntPtr(p + 0x038), ReversePrism.DataModels.Action.FromPointer); // 0245A682CE08 0x38 OnPreRender                 ( 000186679EC0 ModelClassType Action Action Action Pointer )
            value.Panel                                     = GetObject<BaseVisualElementPanel>(new IntPtr(p + 0x108), ReversePrism.DataModels.BaseVisualElementPanel.FromPointer); // 0245A682CE28 0x108 Panel                       ( 000186745F20 ModelClassType BaseVisualElementPanel BaseVisualElementPanel BaseVisualElementPanel Pointer )
            value.Device                                    = GetObject<UIRenderDevice>(new IntPtr(p + 0x110), ReversePrism.DataModels.UIRenderDevice.FromPointer); // 0245A682CE48 0x110 Device                      ( 0001866F0570 ModelClassType UIRenderDevice UIRenderDevice UIRenderDevice Pointer )
            value.Atlas                                     = GetObject<AtlasBase>(new IntPtr(p + 0x118), ReversePrism.DataModels.AtlasBase.FromPointer); // 0245A682CE68 0x118 Atlas                       ( 00018670BF90 ModelClassType AtlasBase AtlasBase AtlasBase Pointer )
            value.VectorImageManager                        = GetObject<VectorImageManager>(new IntPtr(p + 0x120), ReversePrism.DataModels.VectorImageManager.FromPointer); // 0245A682CE88 0x120 VectorImageManager          ( 000186509820 ModelClassType VectorImageManager VectorImageManager VectorImageManager Pointer )
            value.JobManager                                = GetObject<JobManager>(new IntPtr(p + 0x138), ReversePrism.DataModels.JobManager.FromPointer); // 0245A682CEE8 0x138 JobManager                  ( 00018674BD60 ModelClassType JobManager JobManager JobManager Pointer )
            value.ShaderInfoAllocator                       = (UIRVEShaderInfoAllocator)GetInt32(new IntPtr(p + 0x140)); // 0245A682CF08 0x140 ShaderInfoAllocator         ( 0001866EF4B0 ModelEnumType UIRVEShaderInfoAllocator UIRVEShaderInfoAllocator UIRVEShaderInfoAllocator Int32 )
            value.Painter                                   = GetObject<UIRStylePainter>(new IntPtr(p + 0x210), ReversePrism.DataModels.UIRStylePainter.FromPointer); // 0245A682CF28 0x210 Painter                     ( 0001866EEDE0 ModelClassType UIRStylePainter UIRStylePainter UIRStylePainter Pointer )
            value.DrawStats                                 = GetBool(new IntPtr(p + 0x218)); // 0245A682CF48 0x218 DrawStats                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DrawInCameras                             = GetBool(new IntPtr(p + 0x219)); // 0245A682CF68 0x219 DrawInCameras               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
