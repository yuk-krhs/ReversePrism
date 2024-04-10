using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    0001865357B0 ModelEnumType HS HS HS Int32
    // 014 Result                                   0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class HebrewNumberParsingContext : DataModel
    {
        public HS                                       State                                   { get; set; }
        public int                                      Result                                  { get; set; }

        public static HebrewNumberParsingContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HebrewNumberParsingContext() { Pointer= p0 };

            value.State                                     = (HS)GetInt32(new IntPtr(p + 0x010)); // 024666D89CF8 0x10 State                       ( 0001865357B0 ModelEnumType HS HS HS Int32 )
            value.Result                                    = GetInt32(new IntPtr(p + 0x014)); // 024666D89D18 0x14 Result                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
