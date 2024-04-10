using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ValueIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 MatchedVariableCount                     0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MatchContext : DataModel
    {
        public int                                      ValueIndex                              { get; set; }
        public int                                      MatchedVariableCount                    { get; set; }

        public static MatchContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MatchContext() { Pointer= p0 };

            value.ValueIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0245A6848FD8 0x10 ValueIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MatchedVariableCount                      = GetInt32(new IntPtr(p + 0x014)); // 0245A6848FF8 0x14 MatchedVariableCount        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
