using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LittleIndexTypeData                      ModelEnumType LittleIndexType LittleIndexType LittleIndexType Int32
    // 014 Season                                   ModelPrimitiveType int int int Int32
    // 018 Week                                     ModelPrimitiveType int int int Int32
    // 01C SubSeasonId                              ModelPrimitiveType int int int Int32
    public partial class LogLittleIndexViewModel : DataModel
    {
        public LittleIndexType                          LittleIndexTypeData                     { get; set; }
        public int                                      Season                                  { get; set; }
        public int                                      Week                                    { get; set; }
        public int                                      SubSeasonId                             { get; set; }

        public static LogLittleIndexViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LogLittleIndexViewModel() { Pointer= p0 };

            value.LittleIndexTypeData                       = (LittleIndexType)GetInt32(new IntPtr(p + 0x010)); // 0x10 LittleIndexTypeData         ( ModelEnumType LittleIndexType LittleIndexType LittleIndexType Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Season                      ( ModelPrimitiveType int int int Int32 )
            value.Week                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Week                        ( ModelPrimitiveType int int int Int32 )
            value.SubSeasonId                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SubSeasonId                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
