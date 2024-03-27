using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DayAbbreviations                         uint[] IL2CPP_TYPE_SZARRAY
    // 008 DayAbbreviationsLowercase                uint[] IL2CPP_TYPE_SZARRAY
    // 010 MonthAbbreviations                       000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 MonthAbbreviationsLowercase              000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class Utf8Formatter
    {
        public List<uint>?                              MonthAbbreviations                      { get; set; }
        public List<uint>?                              MonthAbbreviationsLowercase             { get; set; }

        public static Utf8Formatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Utf8Formatter();

            value.MonthAbbreviations                        = GetUInt32List(new IntPtr(p + 0x010)); // 0270D6E18D78 0x10 MonthAbbreviations          ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.MonthAbbreviationsLowercase               = GetUInt32List(new IntPtr(p + 0x018)); // 0270D6E18D98 0x18 MonthAbbreviationsLowercase ( 000185B83E90 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
