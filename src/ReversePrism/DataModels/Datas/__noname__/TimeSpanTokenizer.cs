using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _value                                   ReadOnlySpan`1<char> IL2CPP_TYPE_GENERICINST
    // 020 Pos                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TimeSpanTokenizer : DataModel
    {
        public int                                      Pos                                     { get; set; }

        public static TimeSpanTokenizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpanTokenizer() { Pointer= p0 };

            value.Pos                                       = GetInt32(new IntPtr(p + 0x020)); // 024666D8BDC0 0x20 Pos                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
