using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_fNotNull                               ModelPrimitiveType bool bool bool Bool
    // 014 M_day                                    ModelPrimitiveType int int int Int32
    // 018 M_time                                   ModelPrimitiveType int int int Int32
    // 000 s_SQLTicksPerMillisecond                 double IL2CPP_TYPE_R8
    // 008 SQLTicksPerSecond                        int IL2CPP_TYPE_I4
    // 00C SQLTicksPerMinute                        int IL2CPP_TYPE_I4
    // 010 SQLTicksPerHour                          ModelPrimitiveType int int int Int32
    // 014 S_SQLTicksPerDay                         ModelPrimitiveType int int int Int32
    // 018 S_ticksPerSecond                         ModelPrimitiveType long long long Int64
    // 020 S_SQLBaseDate                            ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 S_SQLBaseDateTicks                       ModelPrimitiveType long long long Int64
    // 030 S_minYear                                ModelPrimitiveType int int int Int32
    // 034 S_maxYear                                ModelPrimitiveType int int int Int32
    // 038 S_minDay                                 ModelPrimitiveType int int int Int32
    // 03C S_maxDay                                 ModelPrimitiveType int int int Int32
    // 040 S_minTime                                ModelPrimitiveType int int int Int32
    // 044 S_maxTime                                ModelPrimitiveType int int int Int32
    // 048 S_dayBase                                ModelPrimitiveType int int int Int32
    // 050 S_daysToMonth365                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 S_daysToMonth366                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 S_minDateTime                            ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 068 S_maxDateTime                            ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 070 S_minTimeSpan                            ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 078 S_maxTimeSpan                            ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 080 S_ISO8601_DateTimeFormat                 ModelPrimitiveType string string string String
    // 088 S_dateTimeFormats                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 090 MinValue                                 ModelEnumType SqlDateTime SqlDateTime SqlDateTime Int32
    // 09C MaxValue                                 ModelEnumType SqlDateTime SqlDateTime SqlDateTime Int32
    // 0A8 Null                                     ModelEnumType SqlDateTime SqlDateTime SqlDateTime Int32
    public partial class SqlDateTime : DataModel
    {
        public bool                                     M_fNotNull                              { get; set; }
        public int                                      M_day                                   { get; set; }
        public int                                      M_time                                  { get; set; }
        public int                                      SQLTicksPerHour                         { get; set; }
        public int                                      S_SQLTicksPerDay                        { get; set; }
        public long                                     S_ticksPerSecond                        { get; set; }
        public DateTime                                 S_SQLBaseDate                           { get; set; }
        public long                                     S_SQLBaseDateTicks                      { get; set; }
        public int                                      S_minYear                               { get; set; }
        public int                                      S_maxYear                               { get; set; }
        public int                                      S_minDay                                { get; set; }
        public int                                      S_maxDay                                { get; set; }
        public int                                      S_minTime                               { get; set; }
        public int                                      S_maxTime                               { get; set; }
        public int                                      S_dayBase                               { get; set; }
        public List<int>?                               S_daysToMonth365                        { get; set; }
        public List<int>?                               S_daysToMonth366                        { get; set; }
        public DateTime                                 S_minDateTime                           { get; set; }
        public DateTime                                 S_maxDateTime                           { get; set; }
        public TimeSpan                                 S_minTimeSpan                           { get; set; }
        public TimeSpan                                 S_maxTimeSpan                           { get; set; }
        public string                                   S_ISO8601_DateTimeFormat                { get; set; }
        public List<string>?                            S_dateTimeFormats                       { get; set; }
        public SqlDateTime                              MinValue                                { get; set; }
        public SqlDateTime                              MaxValue                                { get; set; }
        public SqlDateTime                              Null                                    { get; set; }

        public static SqlDateTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlDateTime() { Pointer= p0 };

            value.M_fNotNull                                = GetBool(new IntPtr(p + 0x010)); // 0x10 M_fNotNull                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_day                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_day                       ( ModelPrimitiveType int int int Int32 )
            value.M_time                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_time                      ( ModelPrimitiveType int int int Int32 )
            value.SQLTicksPerHour                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 SQLTicksPerHour             ( ModelPrimitiveType int int int Int32 )
            value.S_SQLTicksPerDay                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 S_SQLTicksPerDay            ( ModelPrimitiveType int int int Int32 )
            value.S_ticksPerSecond                          = GetInt64(new IntPtr(p + 0x018)); // 0x18 S_ticksPerSecond            ( ModelPrimitiveType long long long Int64 )
            value.S_SQLBaseDate                             = GetDateTime(new IntPtr(p + 0x020)); // 0x20 S_SQLBaseDate               ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.S_SQLBaseDateTicks                        = GetInt64(new IntPtr(p + 0x028)); // 0x28 S_SQLBaseDateTicks          ( ModelPrimitiveType long long long Int64 )
            value.S_minYear                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 S_minYear                   ( ModelPrimitiveType int int int Int32 )
            value.S_maxYear                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 S_maxYear                   ( ModelPrimitiveType int int int Int32 )
            value.S_minDay                                  = GetInt32(new IntPtr(p + 0x038)); // 0x38 S_minDay                    ( ModelPrimitiveType int int int Int32 )
            value.S_maxDay                                  = GetInt32(new IntPtr(p + 0x03C)); // 0x3C S_maxDay                    ( ModelPrimitiveType int int int Int32 )
            value.S_minTime                                 = GetInt32(new IntPtr(p + 0x040)); // 0x40 S_minTime                   ( ModelPrimitiveType int int int Int32 )
            value.S_maxTime                                 = GetInt32(new IntPtr(p + 0x044)); // 0x44 S_maxTime                   ( ModelPrimitiveType int int int Int32 )
            value.S_dayBase                                 = GetInt32(new IntPtr(p + 0x048)); // 0x48 S_dayBase                   ( ModelPrimitiveType int int int Int32 )
            value.S_daysToMonth365                          = GetInt32List(new IntPtr(p + 0x050)); // 0x50 S_daysToMonth365            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_daysToMonth366                          = GetInt32List(new IntPtr(p + 0x058)); // 0x58 S_daysToMonth366            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_minDateTime                             = GetDateTime(new IntPtr(p + 0x060)); // 0x60 S_minDateTime               ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.S_maxDateTime                             = GetDateTime(new IntPtr(p + 0x068)); // 0x68 S_maxDateTime               ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.S_minTimeSpan                             = (TimeSpan)GetInt32(new IntPtr(p + 0x070)); // 0x70 S_minTimeSpan               ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.S_maxTimeSpan                             = (TimeSpan)GetInt32(new IntPtr(p + 0x078)); // 0x78 S_maxTimeSpan               ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.S_ISO8601_DateTimeFormat                  = GetString(new IntPtr(p + 0x080)); // 0x80 S_ISO8601_DateTimeFormat    ( ModelPrimitiveType string string string String )
            value.S_dateTimeFormats                         = GetStringList(new IntPtr(p + 0x088)); // 0x88 S_dateTimeFormats           ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.MinValue                                  = (SqlDateTime)GetInt32(new IntPtr(p + 0x090)); // 0x90 MinValue                    ( ModelEnumType SqlDateTime SqlDateTime SqlDateTime Int32 )
            value.MaxValue                                  = (SqlDateTime)GetInt32(new IntPtr(p + 0x09C)); // 0x9C MaxValue                    ( ModelEnumType SqlDateTime SqlDateTime SqlDateTime Int32 )
            value.Null                                      = (SqlDateTime)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Null                        ( ModelEnumType SqlDateTime SqlDateTime SqlDateTime Int32 )

            return value;
        }
    }
}
