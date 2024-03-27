using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseCount                                 0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Limit                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class ResourceUsage
    {
        public uint                                     UseCount                                { get; set; }
        public uint                                     Limit                                   { get; set; }

        public static ResourceUsage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceUsage();

            value.UseCount                                  = GetUInt32(new IntPtr(p + 0x010)); // 0270DAC6CA80 0x10 UseCount                    ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Limit                                     = GetUInt32(new IntPtr(p + 0x014)); // 0270DAC6CAA0 0x14 Limit                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
