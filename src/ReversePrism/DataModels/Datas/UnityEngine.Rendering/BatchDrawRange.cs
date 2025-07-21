using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DrawCommandsBegin                        ModelPrimitiveType uint uint uint UInt32
    // 014 DrawCommandsCount                        ModelPrimitiveType uint uint uint UInt32
    // 018 FilterSettings                           ModelEnumType BatchFilterSettings BatchFilterSettings BatchFilterSettings Int32
    public partial class BatchDrawRange : DataModel
    {
        public uint                                     DrawCommandsBegin                       { get; set; }
        public uint                                     DrawCommandsCount                       { get; set; }
        public BatchFilterSettings                      FilterSettings                          { get; set; }

        public static BatchDrawRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchDrawRange() { Pointer= p0 };

            value.DrawCommandsBegin                         = GetUInt32(new IntPtr(p + 0x010)); // 0x10 DrawCommandsBegin           ( ModelPrimitiveType uint uint uint UInt32 )
            value.DrawCommandsCount                         = GetUInt32(new IntPtr(p + 0x014)); // 0x14 DrawCommandsCount           ( ModelPrimitiveType uint uint uint UInt32 )
            value.FilterSettings                            = (BatchFilterSettings)GetInt32(new IntPtr(p + 0x018)); // 0x18 FilterSettings              ( ModelEnumType BatchFilterSettings BatchFilterSettings BatchFilterSettings Int32 )

            return value;
        }
    }
}
