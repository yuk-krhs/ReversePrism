using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LineNo                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 LinePos                                  0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class LineInfo : DataModel
    {
        public int                                      LineNo                                  { get; set; }
        public int                                      LinePos                                 { get; set; }

        public static LineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LineInfo() { Pointer= p0 };

            value.LineNo                                    = GetInt32(new IntPtr(p + 0x010)); // 0246673BF448 0x10 LineNo                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x014)); // 0246673BF468 0x14 LinePos                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
