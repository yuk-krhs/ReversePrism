using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderContext                            ModelEnumType ScriptableRenderContext ScriptableRenderContext ScriptableRenderContext Int32
    // 018 Cmd                                      ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 020 RenderGraphPool                          ModelClassType RenderGraphObjectPool RenderGraphObjectPool RenderGraphObjectPool Pointer
    // 028 DefaultResources                         ModelClassType RenderGraphDefaultResources RenderGraphDefaultResources RenderGraphDefaultResources Pointer
    public partial class RenderGraphContext : DataModel
    {
        public ScriptableRenderContext                  RenderContext                           { get; set; }
        public CommandBuffer?                           Cmd                                     { get; set; }
        public RenderGraphObjectPool?                   RenderGraphPool                         { get; set; }
        public RenderGraphDefaultResources?             DefaultResources                        { get; set; }

        public static RenderGraphContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphContext() { Pointer= p0 };

            value.RenderContext                             = (ScriptableRenderContext)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderContext               ( ModelEnumType ScriptableRenderContext ScriptableRenderContext ScriptableRenderContext Int32 )
            value.Cmd                                       = GetObject<CommandBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x18 Cmd                         ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.RenderGraphPool                           = GetObject<RenderGraphObjectPool>(new IntPtr(p + 0x020), ReversePrism.DataModels.RenderGraphObjectPool.FromPointer); // 0x20 RenderGraphPool             ( ModelClassType RenderGraphObjectPool RenderGraphObjectPool RenderGraphObjectPool Pointer )
            value.DefaultResources                          = GetObject<RenderGraphDefaultResources>(new IntPtr(p + 0x028), ReversePrism.DataModels.RenderGraphDefaultResources.FromPointer); // 0x28 DefaultResources            ( ModelClassType RenderGraphDefaultResources RenderGraphDefaultResources RenderGraphDefaultResources Pointer )

            return value;
        }
    }
}
