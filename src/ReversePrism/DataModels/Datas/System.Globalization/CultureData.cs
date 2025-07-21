using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SAM1159                                  ModelPrimitiveType string string string String
    // 018 SPM2359                                  ModelPrimitiveType string string string String
    // 020 STimeSeparator                           ModelPrimitiveType string string string String
    // 028 SaLongTimes                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 SaShortTimes                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 IFirstDayOfWeek                          ModelPrimitiveType int int int Int32
    // 03C IFirstWeekOfYear                         ModelPrimitiveType int int int Int32
    // 040 WaCalendars                              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 Calendars                                ModelClassListType CalendarData[] CalendarData[] List<CalendarData> Pointer
    // 050 SISO639Language                          ModelPrimitiveType string string string String
    // 058 SRealName                                ModelPrimitiveType string string string String
    // 060 BUseOverrides                            ModelPrimitiveType bool bool bool Bool
    // 064 CalendarId                               ModelPrimitiveType int int int Int32
    // 068 NumberIndex                              ModelPrimitiveType int int int Int32
    // 06C IDefaultAnsiCodePage                     ModelPrimitiveType int int int Int32
    // 070 IDefaultOemCodePage                      ModelPrimitiveType int int int Int32
    // 074 IDefaultMacCodePage                      ModelPrimitiveType int int int Int32
    // 078 IDefaultEbcdicCodePage                   ModelPrimitiveType int int int Int32
    // 07C IsRightToLeft                            ModelPrimitiveType bool bool bool Bool
    // 080 SListSeparator                           ModelPrimitiveType string string string String
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

            value.SAM1159                                   = GetString(new IntPtr(p + 0x010)); // 0x10 SAM1159                     ( ModelPrimitiveType string string string String )
            value.SPM2359                                   = GetString(new IntPtr(p + 0x018)); // 0x18 SPM2359                     ( ModelPrimitiveType string string string String )
            value.STimeSeparator                            = GetString(new IntPtr(p + 0x020)); // 0x20 STimeSeparator              ( ModelPrimitiveType string string string String )
            value.SaLongTimes                               = GetStringList(new IntPtr(p + 0x028)); // 0x28 SaLongTimes                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.SaShortTimes                              = GetStringList(new IntPtr(p + 0x030)); // 0x30 SaShortTimes                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.IFirstDayOfWeek                           = GetInt32(new IntPtr(p + 0x038)); // 0x38 IFirstDayOfWeek             ( ModelPrimitiveType int int int Int32 )
            value.IFirstWeekOfYear                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C IFirstWeekOfYear            ( ModelPrimitiveType int int int Int32 )
            value.WaCalendars                               = GetInt32List(new IntPtr(p + 0x040)); // 0x40 WaCalendars                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Calendars                                 = GetObjectList<CalendarData>(new IntPtr(p + 0x048), ReversePrism.DataModels.CalendarData.FromPointer); // 0x48 Calendars                   ( ModelClassListType CalendarData[] CalendarData[] List<CalendarData> Pointer )
            value.SISO639Language                           = GetString(new IntPtr(p + 0x050)); // 0x50 SISO639Language             ( ModelPrimitiveType string string string String )
            value.SRealName                                 = GetString(new IntPtr(p + 0x058)); // 0x58 SRealName                   ( ModelPrimitiveType string string string String )
            value.BUseOverrides                             = GetBool(new IntPtr(p + 0x060)); // 0x60 BUseOverrides               ( ModelPrimitiveType bool bool bool Bool )
            value.CalendarId                                = GetInt32(new IntPtr(p + 0x064)); // 0x64 CalendarId                  ( ModelPrimitiveType int int int Int32 )
            value.NumberIndex                               = GetInt32(new IntPtr(p + 0x068)); // 0x68 NumberIndex                 ( ModelPrimitiveType int int int Int32 )
            value.IDefaultAnsiCodePage                      = GetInt32(new IntPtr(p + 0x06C)); // 0x6C IDefaultAnsiCodePage        ( ModelPrimitiveType int int int Int32 )
            value.IDefaultOemCodePage                       = GetInt32(new IntPtr(p + 0x070)); // 0x70 IDefaultOemCodePage         ( ModelPrimitiveType int int int Int32 )
            value.IDefaultMacCodePage                       = GetInt32(new IntPtr(p + 0x074)); // 0x74 IDefaultMacCodePage         ( ModelPrimitiveType int int int Int32 )
            value.IDefaultEbcdicCodePage                    = GetInt32(new IntPtr(p + 0x078)); // 0x78 IDefaultEbcdicCodePage      ( ModelPrimitiveType int int int Int32 )
            value.IsRightToLeft                             = GetBool(new IntPtr(p + 0x07C)); // 0x7C IsRightToLeft               ( ModelPrimitiveType bool bool bool Bool )
            value.SListSeparator                            = GetString(new IntPtr(p + 0x080)); // 0x80 SListSeparator              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
