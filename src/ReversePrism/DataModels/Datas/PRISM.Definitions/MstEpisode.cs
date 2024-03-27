using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstUnitId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Chapter                                  0001865F4260 ModelPrimitiveType int int int Int32
    public partial class MstEpisode
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      Chapter                                 { get; set; }

        public static MstEpisode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstEpisode();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270045A7060 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x014)); // 0270045A7080 0x14 MstUnitId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Chapter                                   = GetInt32(new IntPtr(p + 0x018)); // 0270045A70A0 0x18 Chapter                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
