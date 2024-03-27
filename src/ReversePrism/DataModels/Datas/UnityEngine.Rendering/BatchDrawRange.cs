using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DrawCommandsBegin                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 DrawCommandsCount                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 FilterSettings                           00018674B4D0 ModelEnumType BatchFilterSettings BatchFilterSettings BatchFilterSettings Int32
    public partial class BatchDrawRange
    {
        public uint                                     DrawCommandsBegin                       { get; set; }
        public uint                                     DrawCommandsCount                       { get; set; }
        public BatchFilterSettings                      FilterSettings                          { get; set; }

        public static BatchDrawRange? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchDrawRange();

            value.DrawCommandsBegin                         = GetUInt32(new IntPtr(p + 0x010)); // 0270068CAC28 0x10 DrawCommandsBegin           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DrawCommandsCount                         = GetUInt32(new IntPtr(p + 0x014)); // 0270068CAC48 0x14 DrawCommandsCount           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.FilterSettings                            = (BatchFilterSettings)GetInt32(new IntPtr(p + 0x018)); // 0270068CAC68 0x18 FilterSettings              ( 00018674B4D0 ModelEnumType BatchFilterSettings BatchFilterSettings BatchFilterSettings Int32 )

            return value;
        }
    }
}
