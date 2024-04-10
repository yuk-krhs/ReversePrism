using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               ShaderDebugPrintManager IL2CPP_TYPE_CLASS
    // 000 k_DebugUAVSlot                           int IL2CPP_TYPE_I4
    // 000 k_FramesInFlight                         int IL2CPP_TYPE_I4
    // 000 k_MaxBufferElements                      int IL2CPP_TYPE_I4
    // 010 M_OutputBuffers                          000185CDF738 ModelClassListType List`1<GraphicsBuffer> List`1<GraphicsBuffer> List<GraphicsBuffer> Pointer
    // 018 M_ReadbackRequests                       000185CCD788 ModelEnumListType List`1<AsyncGPUReadbackRequest> List`1<AsyncGPUReadbackRequest> List<AsyncGPUReadbackRequest> Pointer
    // 020 m_BufferReadCompleteAction               Action`1<AsyncGPUReadbackRequest> IL2CPP_TYPE_GENERICINST
    // 028 M_FrameCounter                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_FrameCleared                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_OutputLine                             000186671910 ModelPrimitiveType string string string String
    // 038 m_OutputAction                           Action`1<string> IL2CPP_TYPE_GENERICINST
    // 008 m_ShaderPropertyIDInputMouse             int IL2CPP_TYPE_I4
    // 00C m_ShaderPropertyIDInputFrame             int IL2CPP_TYPE_I4
    // 000 k_TypeHasTag                             uint IL2CPP_TYPE_U4
    public partial class ShaderDebugPrintManager : DataModel
    {
        public List<GraphicsBuffer>?                    M_OutputBuffers                         { get; set; }
        public List<AsyncGPUReadbackRequest>?           M_ReadbackRequests                      { get; set; }
        public int                                      M_FrameCounter                          { get; set; }
        public bool                                     M_FrameCleared                          { get; set; }
        public string                                   M_OutputLine                            { get; set; }

        public static ShaderDebugPrintManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderDebugPrintManager() { Pointer= p0 };

            value.M_OutputBuffers                           = GetObjectList<GraphicsBuffer>(new IntPtr(p + 0x010), ReversePrism.DataModels.GraphicsBuffer.FromPointer); // 0246691FBCF0 0x10 M_OutputBuffers             ( 000185CDF738 ModelClassListType List`1<GraphicsBuffer> List`1<GraphicsBuffer> List<GraphicsBuffer> Pointer )
            value.M_ReadbackRequests                        = GetEnumList<AsyncGPUReadbackRequest>(new IntPtr(p + 0x018)); // 0246691FBD10 0x18 M_ReadbackRequests          ( 000185CCD788 ModelEnumListType List`1<AsyncGPUReadbackRequest> List`1<AsyncGPUReadbackRequest> List<AsyncGPUReadbackRequest> Pointer )
            value.M_FrameCounter                            = GetInt32(new IntPtr(p + 0x028)); // 0246691FBD50 0x28 M_FrameCounter              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_FrameCleared                            = GetBool(new IntPtr(p + 0x02C)); // 0246691FBD70 0x2C M_FrameCleared              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_OutputLine                              = GetString(new IntPtr(p + 0x030)); // 0246691FBD90 0x30 M_OutputLine                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
