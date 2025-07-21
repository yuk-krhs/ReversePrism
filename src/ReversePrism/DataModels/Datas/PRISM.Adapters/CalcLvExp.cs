using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 expTable                                 ValueTuple`2<long, int>[] IL2CPP_TYPE_SZARRAY
    // 018 MaxExp                                   ModelPrimitiveType long long long Int64
    // 020 MaxLv                                    ModelPrimitiveType int int int Int32
    public partial class CalcLvExp : DataModel
    {
        public long                                     MaxExp                                  { get; set; }
        public int                                      MaxLv                                   { get; set; }

        public static CalcLvExp? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CalcLvExp() { Pointer= p0 };

            value.MaxExp                                    = GetInt64(new IntPtr(p + 0x018)); // 0x18 MaxExp                      ( ModelPrimitiveType long long long Int64 )
            value.MaxLv                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 MaxLv                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
