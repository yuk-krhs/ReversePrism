using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewTotal                                ModelPrimitiveType uint uint uint UInt32
    // 014 ViewCount                                ModelPrimitiveType uint uint uint UInt32
    // 018 ViewOffset                               ModelPrimitiveType uint uint uint UInt32
    public partial class VFXCameraXRSettings : DataModel
    {
        public uint                                     ViewTotal                               { get; set; }
        public uint                                     ViewCount                               { get; set; }
        public uint                                     ViewOffset                              { get; set; }

        public static VFXCameraXRSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXCameraXRSettings() { Pointer= p0 };

            value.ViewTotal                                 = GetUInt32(new IntPtr(p + 0x010)); // 0x10 ViewTotal                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.ViewCount                                 = GetUInt32(new IntPtr(p + 0x014)); // 0x14 ViewCount                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.ViewOffset                                = GetUInt32(new IntPtr(p + 0x018)); // 0x18 ViewOffset                  ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
