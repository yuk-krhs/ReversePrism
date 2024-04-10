using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LittleIndexTypeData                      0001866E8980 ModelEnumType LittleIndexType LittleIndexType LittleIndexType Int32
    // 014 Season                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Week                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C SubSeasonId                              0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.LittleIndexTypeData                       = (LittleIndexType)GetInt32(new IntPtr(p + 0x010)); // 024666589778 0x10 LittleIndexTypeData         ( 0001866E8980 ModelEnumType LittleIndexType LittleIndexType LittleIndexType Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x014)); // 024666589798 0x14 Season                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Week                                      = GetInt32(new IntPtr(p + 0x018)); // 0246665897B8 0x18 Week                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SubSeasonId                               = GetInt32(new IntPtr(p + 0x01C)); // 0246665897D8 0x1C SubSeasonId                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
