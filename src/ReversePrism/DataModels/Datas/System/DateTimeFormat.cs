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
    // 010 InvariantFormatInfo                      ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
    // 018 InvariantAbbreviatedMonthNames           ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 InvariantAbbreviatedDayNames             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 FixedNumberFormats                       ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.InvariantFormatInfo                       = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0x10 InvariantFormatInfo         ( ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )
            value.InvariantAbbreviatedMonthNames            = GetStringList(new IntPtr(p + 0x018)); // 0x18 InvariantAbbreviatedMonthNames ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.InvariantAbbreviatedDayNames              = GetStringList(new IntPtr(p + 0x020)); // 0x20 InvariantAbbreviatedDayNames ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.FixedNumberFormats                        = GetStringList(new IntPtr(p + 0x028)); // 0x28 FixedNumberFormats          ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
