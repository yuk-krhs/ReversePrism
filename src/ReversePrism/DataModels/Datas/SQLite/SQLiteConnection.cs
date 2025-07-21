using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Open                                     ModelPrimitiveType bool bool bool Bool
    // 018 BusyTimeout                              ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 000 _mappings                                Dictionary`2<string, TableMapping> IL2CPP_TYPE_GENERICINST
    // 020 TransactionDepth                         ModelPrimitiveType int int int Int32
    // 028 Rand                                     ModelClassType Random Random Random Pointer
    // 030 <Handle>k__BackingField                  <int> IL2CPP_TYPE_I
    // 008 NullHandle                               <int> IL2CPP_TYPE_I
    // 010 NullBackupHandle                         <int> IL2CPP_TYPE_I
    // 038 DatabasePath                             ModelPrimitiveType string string string String
    // 040 LibVersionNumber                         ModelPrimitiveType int int int Int32
    // 044 StoreDateTimeAsTicks                     ModelPrimitiveType bool bool bool Bool
    // 045 StoreTimeSpanAsTicks                     ModelPrimitiveType bool bool bool Bool
    // 048 DateTimeStringFormat                     ModelPrimitiveType string string string String
    // 050 DateTimeStyle                            ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32
    // 058 _insertCommandMap                        Dictionary`2<Tuple`2<string, string>, PreparedSqliteInsertCommand> IL2CPP_TYPE_GENERICINST
    // 060 TableChanged                             EventHandler`1<NotifyTableChangedEventArgs> IL2CPP_TYPE_GENERICINST
    public partial class SQLiteConnection : DataModel
    {
        public bool                                     Open                                    { get; set; }
        public TimeSpan                                 BusyTimeout                             { get; set; }
        public int                                      TransactionDepth                        { get; set; }
        public Random?                                  Rand                                    { get; set; }
        public string                                   DatabasePath                            { get; set; }
        public int                                      LibVersionNumber                        { get; set; }
        public bool                                     StoreDateTimeAsTicks                    { get; set; }
        public bool                                     StoreTimeSpanAsTicks                    { get; set; }
        public string                                   DateTimeStringFormat                    { get; set; }
        public DateTimeStyles                           DateTimeStyle                           { get; set; }

        public static SQLiteConnection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SQLiteConnection() { Pointer= p0 };

            value.Open                                      = GetBool(new IntPtr(p + 0x010)); // 0x10 Open                        ( ModelPrimitiveType bool bool bool Bool )
            value.BusyTimeout                               = (TimeSpan)GetInt32(new IntPtr(p + 0x018)); // 0x18 BusyTimeout                 ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.TransactionDepth                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 TransactionDepth            ( ModelPrimitiveType int int int Int32 )
            value.Rand                                      = GetObject<Random>(new IntPtr(p + 0x028), ReversePrism.DataModels.Random.FromPointer); // 0x28 Rand                        ( ModelClassType Random Random Random Pointer )
            value.DatabasePath                              = GetString(new IntPtr(p + 0x038)); // 0x38 DatabasePath                ( ModelPrimitiveType string string string String )
            value.LibVersionNumber                          = GetInt32(new IntPtr(p + 0x040)); // 0x40 LibVersionNumber            ( ModelPrimitiveType int int int Int32 )
            value.StoreDateTimeAsTicks                      = GetBool(new IntPtr(p + 0x044)); // 0x44 StoreDateTimeAsTicks        ( ModelPrimitiveType bool bool bool Bool )
            value.StoreTimeSpanAsTicks                      = GetBool(new IntPtr(p + 0x045)); // 0x45 StoreTimeSpanAsTicks        ( ModelPrimitiveType bool bool bool Bool )
            value.DateTimeStringFormat                      = GetString(new IntPtr(p + 0x048)); // 0x48 DateTimeStringFormat        ( ModelPrimitiveType string string string String )
            value.DateTimeStyle                             = (DateTimeStyles)GetInt32(new IntPtr(p + 0x050)); // 0x50 DateTimeStyle               ( ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32 )

            return value;
        }
    }
}
