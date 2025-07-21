using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseCount                                 ModelPrimitiveType uint uint uint UInt32
    // 014 Limit                                    ModelPrimitiveType uint uint uint UInt32
    public partial class ResourceUsage : DataModel
    {
        public uint                                     UseCount                                { get; set; }
        public uint                                     Limit                                   { get; set; }

        public static ResourceUsage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceUsage() { Pointer= p0 };

            value.UseCount                                  = GetUInt32(new IntPtr(p + 0x010)); // 0x10 UseCount                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.Limit                                     = GetUInt32(new IntPtr(p + 0x014)); // 0x14 Limit                       ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
