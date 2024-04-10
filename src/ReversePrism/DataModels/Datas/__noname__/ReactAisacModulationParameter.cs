using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EnableDecrementAisacModulationKey        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 DecrementAisacModulationKey              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 EnableIncrementAisacModulationKey        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IncrementAisacModulationKey              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class ReactAisacModulationParameter : DataModel
    {
        public int                                      EnableDecrementAisacModulationKey       { get; set; }
        public uint                                     DecrementAisacModulationKey             { get; set; }
        public int                                      EnableIncrementAisacModulationKey       { get; set; }
        public uint                                     IncrementAisacModulationKey             { get; set; }

        public static ReactAisacModulationParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReactAisacModulationParameter() { Pointer= p0 };

            value.EnableDecrementAisacModulationKey         = GetInt32(new IntPtr(p + 0x010)); // 02466ACD6690 0x10 EnableDecrementAisacModulationKey ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DecrementAisacModulationKey               = GetUInt32(new IntPtr(p + 0x014)); // 02466ACD66B0 0x14 DecrementAisacModulationKey ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.EnableIncrementAisacModulationKey         = GetInt32(new IntPtr(p + 0x018)); // 02466ACD66D0 0x18 EnableIncrementAisacModulationKey ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IncrementAisacModulationKey               = GetUInt32(new IntPtr(p + 0x01C)); // 02466ACD66F0 0x1C IncrementAisacModulationKey ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
