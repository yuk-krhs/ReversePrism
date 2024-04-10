using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NullOffset                               TimeSpan IL2CPP_TYPE_VALUETYPE
    // 008 allStandardFormats                       char[] IL2CPP_TYPE_SZARRAY
    // 010 InvariantFormatInfo                      0001865BBAA0 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
    // 018 InvariantAbbreviatedMonthNames           000185B821B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 InvariantAbbreviatedDayNames             000185B821B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 FixedNumberFormats                       000185B81B90 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class DateTimeFormat : DataModel
    {
        public DateTimeFormatInfo?                      InvariantFormatInfo                     { get; set; }
        public List<string>?                            InvariantAbbreviatedMonthNames          { get; set; }
        public List<string>?                            InvariantAbbreviatedDayNames            { get; set; }
        public List<string>?                            FixedNumberFormats                      { get; set; }

        public static DateTimeFormat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DateTimeFormat() { Pointer= p0 };

            value.InvariantFormatInfo                       = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0245A3CAFEB0 0x10 InvariantFormatInfo         ( 0001865BBAA0 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )
            value.InvariantAbbreviatedMonthNames            = GetStringList(new IntPtr(p + 0x018)); // 0245A3CAFED0 0x18 InvariantAbbreviatedMonthNames ( 000185B821B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.InvariantAbbreviatedDayNames              = GetStringList(new IntPtr(p + 0x020)); // 0245A3CAFEF0 0x20 InvariantAbbreviatedDayNames ( 000185B821B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FixedNumberFormats                        = GetStringList(new IntPtr(p + 0x028)); // 0245A3CAFF10 0x28 FixedNumberFormats          ( 000185B81B90 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
