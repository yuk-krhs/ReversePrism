using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_dateWords                              000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 000 s_knownWords                             Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 018 YmdFlags                                 00018657C3C0 ModelEnumType FoundDatePattern FoundDatePattern FoundDatePattern Int32
    public partial class DateTimeFormatInfoScanner : DataModel
    {
        public List<string>?                            M_dateWords                             { get; set; }
        public FoundDatePattern                         YmdFlags                                { get; set; }

        public static DateTimeFormatInfoScanner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeFormatInfoScanner() { Pointer= p0 };

            value.M_dateWords                               = GetStringList(new IntPtr(p + 0x010)); // 024662FD4720 0x10 M_dateWords                 ( 000185D0D578 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.YmdFlags                                  = (FoundDatePattern)GetInt32(new IntPtr(p + 0x018)); // 024662FD4760 0x18 YmdFlags                    ( 00018657C3C0 ModelEnumType FoundDatePattern FoundDatePattern FoundDatePattern Int32 )

            return value;
        }
    }
}
