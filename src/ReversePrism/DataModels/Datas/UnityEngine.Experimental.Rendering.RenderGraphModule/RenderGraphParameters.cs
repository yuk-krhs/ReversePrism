using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExecutionName                            ModelPrimitiveType string string string String
    // 018 CurrentFrameIndex                        ModelPrimitiveType int int int Int32
    // 01C RendererListCulling                      ModelPrimitiveType bool bool bool Bool
    // 020 ScriptableRenderContext                  ModelEnumType ScriptableRenderContext ScriptableRenderContext ScriptableRenderContext Int32
    // 028 CommandBuffer                            ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    public partial class RenderGraphParameters : DataModel
    {
        public string                                   ExecutionName                           { get; set; }
        public int                                      CurrentFrameIndex                       { get; set; }
        public bool                                     RendererListCulling                     { get; set; }
        public ScriptableRenderContext                  ScriptableRenderContext                 { get; set; }
        public CommandBuffer?                           CommandBuffer                           { get; set; }

        public static RenderGraphParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderGraphParameters() { Pointer= p0 };

            value.ExecutionName                             = GetString(new IntPtr(p + 0x010)); // 0x10 ExecutionName               ( ModelPrimitiveType string string string String )
            value.CurrentFrameIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentFrameIndex           ( ModelPrimitiveType int int int Int32 )
            value.RendererListCulling                       = GetBool(new IntPtr(p + 0x01C)); // 0x1C RendererListCulling         ( ModelPrimitiveType bool bool bool Bool )
            value.ScriptableRenderContext                   = (ScriptableRenderContext)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScriptableRenderContext     ( ModelEnumType ScriptableRenderContext ScriptableRenderContext ScriptableRenderContext Int32 )
            value.CommandBuffer                             = GetObject<CommandBuffer>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x28 CommandBuffer               ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )

            return value;
        }
    }
}
