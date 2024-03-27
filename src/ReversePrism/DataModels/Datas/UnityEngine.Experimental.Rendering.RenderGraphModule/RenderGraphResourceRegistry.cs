using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kSharedResourceLifetime                  int IL2CPP_TYPE_I4
    // 000 m_CurrentRegistry                        RenderGraphResourceRegistry IL2CPP_TYPE_CLASS
    // 010 M_RenderGraphResources                   000185CC16E8 ModelClassListType RenderGraphResourcesData[] RenderGraphResourcesData[] List<RenderGraphResourcesData> Pointer
    // 018 m_RendererListResources                  DynamicArray`1<RendererListResource> IL2CPP_TYPE_GENERICINST
    // 020 M_RenderGraphDebug                       000186652EE0 ModelClassType RenderGraphDebugParams RenderGraphDebugParams RenderGraphDebugParams Pointer
    // 028 M_ResourceLogger                         000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer
    // 030 M_FrameInformationLogger                 000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer
    // 038 M_CurrentFrameIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C M_ExecutionCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 M_CurrentBackbuffer                      00018664B080 ModelClassType RTHandle RTHandle RTHandle Pointer
    // 000 kInitialRendererListCount                int IL2CPP_TYPE_I4
    // 048 M_ActiveRendererLists                    000185D02598 ModelEnumListType List`1<RendererList> List`1<RendererList> List<RendererList> Pointer
    public partial class RenderGraphResourceRegistry
    {
        public List<RenderGraphResourcesData>?          M_RenderGraphResources                  { get; set; }
        public RenderGraphDebugParams?                  M_RenderGraphDebug                      { get; set; }
        public RenderGraphLogger?                       M_ResourceLogger                        { get; set; }
        public RenderGraphLogger?                       M_FrameInformationLogger                { get; set; }
        public int                                      M_CurrentFrameIndex                     { get; set; }
        public int                                      M_ExecutionCount                        { get; set; }
        public RTHandle?                                M_CurrentBackbuffer                     { get; set; }
        public List<RendererList>?                      M_ActiveRendererLists                   { get; set; }

        public static RenderGraphResourceRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphResourceRegistry();

            value.M_RenderGraphResources                    = GetObjectList<RenderGraphResourcesData>(new IntPtr(p + 0x010), ReversePrism.DataModels.RenderGraphResourcesData.FromPointer); // 0270D9097690 0x10 M_RenderGraphResources      ( 000185CC16E8 ModelClassListType RenderGraphResourcesData[] RenderGraphResourcesData[] List<RenderGraphResourcesData> Pointer )
            value.M_RenderGraphDebug                        = GetObject<RenderGraphDebugParams>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderGraphDebugParams.FromPointer); // 0270D90976D0 0x20 M_RenderGraphDebug          ( 000186652EE0 ModelClassType RenderGraphDebugParams RenderGraphDebugParams RenderGraphDebugParams Pointer )
            value.M_ResourceLogger                          = GetObject<RenderGraphLogger>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderGraphLogger.FromPointer); // 0270D90976F0 0x28 M_ResourceLogger            ( 000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer )
            value.M_FrameInformationLogger                  = GetObject<RenderGraphLogger>(new IntPtr(p + 0x030), ReversePrism.DataModels.RenderGraphLogger.FromPointer); // 0270D9097710 0x30 M_FrameInformationLogger    ( 000186654050 ModelClassType RenderGraphLogger RenderGraphLogger RenderGraphLogger Pointer )
            value.M_CurrentFrameIndex                       = GetInt32(new IntPtr(p + 0x038)); // 0270D9097730 0x38 M_CurrentFrameIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ExecutionCount                          = GetInt32(new IntPtr(p + 0x03C)); // 0270D9097750 0x3C M_ExecutionCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentBackbuffer                       = GetObject<RTHandle>(new IntPtr(p + 0x040), ReversePrism.DataModels.RTHandle.FromPointer); // 0270D9097770 0x40 M_CurrentBackbuffer         ( 00018664B080 ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ActiveRendererLists                     = GetEnumList<RendererList>(new IntPtr(p + 0x048)); // 0270D90977B0 0x48 M_ActiveRendererLists       ( 000185D02598 ModelEnumListType List`1<RendererList> List`1<RendererList> List<RendererList> Pointer )

            return value;
        }
    }
}
