using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SAM1159                                  000186671910 ModelPrimitiveType string string string String
    // 018 SPM2359                                  000186671910 ModelPrimitiveType string string string String
    // 020 STimeSeparator                           000186671910 ModelPrimitiveType string string string String
    // 028 SaLongTimes                              000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 SaShortTimes                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 IFirstDayOfWeek                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C IFirstWeekOfYear                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 WaCalendars                              000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 Calendars                                000185B72580 ModelClassListType CalendarData[] CalendarData[] List<CalendarData> Pointer
    // 050 SISO639Language                          000186671910 ModelPrimitiveType string string string String
    // 058 SRealName                                000186672F10 ModelPrimitiveType string string string String
    // 060 BUseOverrides                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 064 CalendarId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 NumberIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 06C IDefaultAnsiCodePage                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 IDefaultOemCodePage                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 IDefaultMacCodePage                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 IDefaultEbcdicCodePage                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C IsRightToLeft                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 SListSeparator                           000186671910 ModelPrimitiveType string string string String
    // 000 s_Invariant                              CultureData IL2CPP_TYPE_CLASS
    public partial class CultureData : DataModel
    {
        public string                                   SAM1159                                 { get; set; }
        public string                                   SPM2359                                 { get; set; }
        public string                                   STimeSeparator                          { get; set; }
        public List<string>?                            SaLongTimes                             { get; set; }
        public List<string>?                            SaShortTimes                            { get; set; }
        public int                                      IFirstDayOfWeek                         { get; set; }
        public int                                      IFirstWeekOfYear                        { get; set; }
        public List<int>?                               WaCalendars                             { get; set; }
        public List<CalendarData>?                      Calendars                               { get; set; }
        public string                                   SISO639Language                         { get; set; }
        public string                                   SRealName                               { get; set; }
        public bool                                     BUseOverrides                           { get; set; }
        public int                                      CalendarId                              { get; set; }
        public int                                      NumberIndex                             { get; set; }
        public int                                      IDefaultAnsiCodePage                    { get; set; }
        public int                                      IDefaultOemCodePage                     { get; set; }
        public int                                      IDefaultMacCodePage                     { get; set; }
        public int                                      IDefaultEbcdicCodePage                  { get; set; }
        public bool                                     IsRightToLeft                           { get; set; }
        public string                                   SListSeparator                          { get; set; }

        public static CultureData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureData() { Pointer= p0 };

            value.SAM1159                                   = GetString(new IntPtr(p + 0x010)); // 0245A3368C88 0x10 SAM1159                     ( 000186671910 ModelPrimitiveType string string string String )
            value.SPM2359                                   = GetString(new IntPtr(p + 0x018)); // 0245A3368CA8 0x18 SPM2359                     ( 000186671910 ModelPrimitiveType string string string String )
            value.STimeSeparator                            = GetString(new IntPtr(p + 0x020)); // 0245A3368CC8 0x20 STimeSeparator              ( 000186671910 ModelPrimitiveType string string string String )
            value.SaLongTimes                               = GetStringList(new IntPtr(p + 0x028)); // 0245A3368CE8 0x28 SaLongTimes                 ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaShortTimes                              = GetStringList(new IntPtr(p + 0x030)); // 0245A3368D08 0x30 SaShortTimes                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.IFirstDayOfWeek                           = GetInt32(new IntPtr(p + 0x038)); // 0245A3368D28 0x38 IFirstDayOfWeek             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IFirstWeekOfYear                          = GetInt32(new IntPtr(p + 0x03C)); // 0245A3368D48 0x3C IFirstWeekOfYear            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.WaCalendars                               = GetInt32List(new IntPtr(p + 0x040)); // 0245A3368D68 0x40 WaCalendars                 ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Calendars                                 = GetObjectList<CalendarData>(new IntPtr(p + 0x048), ReversePrism.DataModels.CalendarData.FromPointer); // 0245A3368D88 0x48 Calendars                   ( 000185B72580 ModelClassListType CalendarData[] CalendarData[] List<CalendarData> Pointer )
            value.SISO639Language                           = GetString(new IntPtr(p + 0x050)); // 0245A3368DA8 0x50 SISO639Language             ( 000186671910 ModelPrimitiveType string string string String )
            value.SRealName                                 = GetString(new IntPtr(p + 0x058)); // 0245A3368DC8 0x58 SRealName                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.BUseOverrides                             = GetBool(new IntPtr(p + 0x060)); // 0245A3368DE8 0x60 BUseOverrides               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CalendarId                                = GetInt32(new IntPtr(p + 0x064)); // 0245A3368E08 0x64 CalendarId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumberIndex                               = GetInt32(new IntPtr(p + 0x068)); // 0245A3368E28 0x68 NumberIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IDefaultAnsiCodePage                      = GetInt32(new IntPtr(p + 0x06C)); // 0245A3368E48 0x6C IDefaultAnsiCodePage        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IDefaultOemCodePage                       = GetInt32(new IntPtr(p + 0x070)); // 0245A3368E68 0x70 IDefaultOemCodePage         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IDefaultMacCodePage                       = GetInt32(new IntPtr(p + 0x074)); // 0245A3368E88 0x74 IDefaultMacCodePage         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IDefaultEbcdicCodePage                    = GetInt32(new IntPtr(p + 0x078)); // 0245A3368EA8 0x78 IDefaultEbcdicCodePage      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsRightToLeft                             = GetBool(new IntPtr(p + 0x07C)); // 0245A3368EC8 0x7C IsRightToLeft               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SListSeparator                            = GetString(new IntPtr(p + 0x080)); // 0245A3368EE8 0x80 SListSeparator              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
