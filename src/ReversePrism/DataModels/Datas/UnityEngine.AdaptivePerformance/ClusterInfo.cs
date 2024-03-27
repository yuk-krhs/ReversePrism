using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BigCore                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 MediumCore                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 LittleCore                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ClusterInfo
    {
        public int                                      BigCore                                 { get; set; }
        public int                                      MediumCore                              { get; set; }
        public int                                      LittleCore                              { get; set; }

        public static ClusterInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClusterInfo();

            value.BigCore                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D090A428 0x10 BigCore                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MediumCore                                = GetInt32(new IntPtr(p + 0x014)); // 0270D090A448 0x14 MediumCore                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LittleCore                                = GetInt32(new IntPtr(p + 0x018)); // 0270D090A468 0x18 LittleCore                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
