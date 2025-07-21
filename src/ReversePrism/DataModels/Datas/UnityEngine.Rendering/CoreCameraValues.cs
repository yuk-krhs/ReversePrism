using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FilterMode                               ModelPrimitiveType int int int Int32
    // 014 CullingMask                              ModelPrimitiveType uint uint uint UInt32
    // 018 InstanceID                               ModelPrimitiveType int int int Int32
    public partial class CoreCameraValues : DataModel
    {
        public int                                      FilterMode                              { get; set; }
        public uint                                     CullingMask                             { get; set; }
        public int                                      InstanceID                              { get; set; }

        public static CoreCameraValues? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CoreCameraValues() { Pointer= p0 };

            value.FilterMode                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 FilterMode                  ( ModelPrimitiveType int int int Int32 )
            value.CullingMask                               = GetUInt32(new IntPtr(p + 0x014)); // 0x14 CullingMask                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.InstanceID                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 InstanceID                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
