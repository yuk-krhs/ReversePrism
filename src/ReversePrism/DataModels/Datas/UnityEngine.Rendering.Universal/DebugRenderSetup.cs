using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DebugHandler                           ModelClassType DebugHandler DebugHandler DebugHandler Pointer
    // 018 M_Context                                ModelEnumType ScriptableRenderContext ScriptableRenderContext ScriptableRenderContext Int32
    // 020 M_CommandBuffer                          ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 028 M_Index                                  ModelPrimitiveType int int int Int32
    // 02C M_FilteringSettings                      ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32
    public partial class DebugRenderSetup : DataModel
    {
        public DebugHandler?                            M_DebugHandler                          { get; set; }
        public ScriptableRenderContext                  M_Context                               { get; set; }
        public CommandBuffer?                           M_CommandBuffer                         { get; set; }
        public int                                      M_Index                                 { get; set; }
        public FilteringSettings                        M_FilteringSettings                     { get; set; }

        public static DebugRenderSetup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugRenderSetup() { Pointer= p0 };

            value.M_DebugHandler                            = GetObject<DebugHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.DebugHandler.FromPointer); // 0x10 M_DebugHandler              ( ModelClassType DebugHandler DebugHandler DebugHandler Pointer )
            value.M_Context                                 = (ScriptableRenderContext)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Context                   ( ModelEnumType ScriptableRenderContext ScriptableRenderContext ScriptableRenderContext Int32 )
            value.M_CommandBuffer                           = GetObject<CommandBuffer>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x20 M_CommandBuffer             ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_Index                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Index                     ( ModelPrimitiveType int int int Int32 )
            value.M_FilteringSettings                       = (FilteringSettings)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_FilteringSettings         ( ModelEnumType FilteringSettings FilteringSettings FilteringSettings Int32 )

            return value;
        }
    }
}
