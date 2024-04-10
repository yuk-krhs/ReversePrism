using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FilterMode                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 CullingMask                              000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 018 InstanceID                               0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.FilterMode                                = GetInt32(new IntPtr(p + 0x010)); // 0245A24582F8 0x10 FilterMode                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CullingMask                               = GetUInt32(new IntPtr(p + 0x014)); // 0245A2458318 0x14 CullingMask                 ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.InstanceID                                = GetInt32(new IntPtr(p + 0x018)); // 0245A2458338 0x18 InstanceID                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
