using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DateTimeSqliteDefaultFormat              string IL2CPP_TYPE_STRING
    // 010 UniqueKey                                000186672F10 ModelPrimitiveType string string string String
    // 018 DatabasePath                             000186672F10 ModelPrimitiveType string string string String
    // 020 StoreDateTimeAsTicks                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 021 StoreTimeSpanAsTicks                     0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 028 DateTimeStringFormat                     000186672F10 ModelPrimitiveType string string string String
    // 030 DateTimeStyle                            0001865BE810 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32
    // 038 <Key>k__BackingField                     <object> IL2CPP_TYPE_OBJECT
    // 040 OpenFlags                                0001866B2B30 ModelEnumType SQLiteOpenFlags SQLiteOpenFlags SQLiteOpenFlags Int32
    // 048 <PreKeyAction>k__BackingField            Action`1<SQLiteConnection> IL2CPP_TYPE_GENERICINST
    // 050 <PostKeyAction>k__BackingField           Action`1<SQLiteConnection> IL2CPP_TYPE_GENERICINST
    // 058 VfsName                                  000186672F10 ModelPrimitiveType string string string String
    public partial class SQLiteConnectionString
    {
        public string                                   UniqueKey                               { get; set; }
        public string                                   DatabasePath                            { get; set; }
        public bool                                     StoreDateTimeAsTicks                    { get; set; }
        public bool                                     StoreTimeSpanAsTicks                    { get; set; }
        public string                                   DateTimeStringFormat                    { get; set; }
        public DateTimeStyles                           DateTimeStyle                           { get; set; }
        public SQLiteOpenFlags                          OpenFlags                               { get; set; }
        public string                                   VfsName                                 { get; set; }

        public static SQLiteConnectionString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteConnectionString();

            value.UniqueKey                                 = GetString(new IntPtr(p + 0x010)); // 027003D2B568 0x10 UniqueKey                   ( 000186672F10 ModelPrimitiveType string string string String )
            value.DatabasePath                              = GetString(new IntPtr(p + 0x018)); // 027003D2B588 0x18 DatabasePath                ( 000186672F10 ModelPrimitiveType string string string String )
            value.StoreDateTimeAsTicks                      = GetBool(new IntPtr(p + 0x020)); // 027003D2B5A8 0x20 StoreDateTimeAsTicks        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.StoreTimeSpanAsTicks                      = GetBool(new IntPtr(p + 0x021)); // 027003D2B5C8 0x21 StoreTimeSpanAsTicks        ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.DateTimeStringFormat                      = GetString(new IntPtr(p + 0x028)); // 027003D2B5E8 0x28 DateTimeStringFormat        ( 000186672F10 ModelPrimitiveType string string string String )
            value.DateTimeStyle                             = (DateTimeStyles)GetInt32(new IntPtr(p + 0x030)); // 027003D2B608 0x30 DateTimeStyle               ( 0001865BE810 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32 )
            value.OpenFlags                                 = (SQLiteOpenFlags)GetInt32(new IntPtr(p + 0x040)); // 027003D2B648 0x40 OpenFlags                   ( 0001866B2B30 ModelEnumType SQLiteOpenFlags SQLiteOpenFlags SQLiteOpenFlags Int32 )
            value.VfsName                                   = GetString(new IntPtr(p + 0x058)); // 027003D2B6A8 0x58 VfsName                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
