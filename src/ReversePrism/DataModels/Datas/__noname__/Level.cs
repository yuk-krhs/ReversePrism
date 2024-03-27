using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Down                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Up                                       0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class Level
    {
        public int                                      Down                                    { get; set; }
        public int                                      Up                                      { get; set; }

        public static Level? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Level();

            value.Down                                      = GetInt32(new IntPtr(p + 0x010)); // 0270DBA7D1F0 0x10 Down                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Up                                        = GetInt32(new IntPtr(p + 0x014)); // 0270DBA7D210 0x14 Up                          ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
