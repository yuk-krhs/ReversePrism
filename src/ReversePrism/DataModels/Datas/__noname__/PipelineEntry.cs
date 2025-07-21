using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Command                                  ModelPrimitiveType string string string String
    // 018 Flags                                    ModelEnumType PipelineEntryFlags PipelineEntryFlags PipelineEntryFlags Int32
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

            value.Command                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Command                     ( ModelPrimitiveType string string string String )
            value.Flags                                     = (PipelineEntryFlags)GetInt32(new IntPtr(p + 0x018)); // 0x18 Flags                       ( ModelEnumType PipelineEntryFlags PipelineEntryFlags PipelineEntryFlags Int32 )

            return value;
        }
    }
}
