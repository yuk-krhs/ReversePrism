using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DwLowDateTime                            000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 014 DwHighDateTime                           000186698DF0 ModelPrimitiveType uint uint uint UInt32
    public partial class FILE_TIME : DataModel
    {
        public uint                                     DwLowDateTime                           { get; set; }
        public uint                                     DwHighDateTime                          { get; set; }

        public static FILE_TIME? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FILE_TIME() { Pointer= p0 };

            value.DwLowDateTime                             = GetUInt32(new IntPtr(p + 0x010)); // 0245A3D02D28 0x10 DwLowDateTime               ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.DwHighDateTime                            = GetUInt32(new IntPtr(p + 0x014)); // 0245A3D02D48 0x14 DwHighDateTime              ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
