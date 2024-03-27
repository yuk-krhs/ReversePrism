using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 expTable                                 ValueTuple`2<long, int>[] IL2CPP_TYPE_SZARRAY
    // 018 MaxExp                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 020 MaxLv                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CalcLvExp
    {
        public long                                     MaxExp                                  { get; set; }
        public int                                      MaxLv                                   { get; set; }

        public static CalcLvExp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcLvExp();

            value.MaxExp                                    = GetInt64(new IntPtr(p + 0x018)); // 0270D5E62750 0x18 MaxExp                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.MaxLv                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D5E62770 0x20 MaxLv                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
