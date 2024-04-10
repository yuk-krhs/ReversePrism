using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Command                                  000186671BA0 ModelPrimitiveType string string string String
    // 018 Flags                                    00018650E240 ModelEnumType PipelineEntryFlags PipelineEntryFlags PipelineEntryFlags Int32
    public partial class PipelineEntry : DataModel
    {
        public string                                   Command                                 { get; set; }
        public PipelineEntryFlags                       Flags                                   { get; set; }

        public static PipelineEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PipelineEntry() { Pointer= p0 };

            value.Command                                   = GetString(new IntPtr(p + 0x010)); // 024667A66000 0x10 Command                     ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Flags                                     = (PipelineEntryFlags)GetInt32(new IntPtr(p + 0x018)); // 024667A66020 0x18 Flags                       ( 00018650E240 ModelEnumType PipelineEntryFlags PipelineEntryFlags PipelineEntryFlags Int32 )

            return value;
        }
    }
}
