using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 State                                    ModelEnumType HS HS HS Int32
    // 014 Result                                   ModelPrimitiveType int int int Int32
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

            value.State                                     = (HS)GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelEnumType HS HS HS Int32 )
            value.Result                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Result                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
