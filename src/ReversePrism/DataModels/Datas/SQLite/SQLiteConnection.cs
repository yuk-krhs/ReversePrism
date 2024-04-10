using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Open                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 BusyTimeout                              00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 000 _mappings                                Dictionary`2<string, TableMapping> IL2CPP_TYPE_GENERICINST
    // 020 TransactionDepth                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 Rand                                     0001866093D0 ModelClassType Random Random Random Pointer
    // 030 <Handle>k__BackingField                  <int> IL2CPP_TYPE_I
    // 008 NullHandle                               <int> IL2CPP_TYPE_I
    // 010 NullBackupHandle                         <int> IL2CPP_TYPE_I
    // 038 DatabasePath                             000186671910 ModelPrimitiveType string string string String
    // 040 LibVersionNumber                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 StoreDateTimeAsTicks                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 045 StoreTimeSpanAsTicks                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 DateTimeStringFormat                     000186671910 ModelPrimitiveType string string string String
    // 050 DateTimeStyle                            0001865BE5C0 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32
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

            value.Open                                      = GetBool(new IntPtr(p + 0x010)); // 0245A3D2B8A8 0x10 Open                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BusyTimeout                               = (TimeSpan)GetInt32(new IntPtr(p + 0x018)); // 0245A3D2B8C8 0x18 BusyTimeout                 ( 00018668A8A0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.TransactionDepth                          = GetInt32(new IntPtr(p + 0x020)); // 0245A3D2B908 0x20 TransactionDepth            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rand                                      = GetObject<Random>(new IntPtr(p + 0x028), ReversePrism.DataModels.Random.FromPointer); // 0245A3D2B928 0x28 Rand                        ( 0001866093D0 ModelClassType Random Random Random Pointer )
            value.DatabasePath                              = GetString(new IntPtr(p + 0x038)); // 0245A3D2B9A8 0x38 DatabasePath                ( 000186671910 ModelPrimitiveType string string string String )
            value.LibVersionNumber                          = GetInt32(new IntPtr(p + 0x040)); // 0245A3D2B9C8 0x40 LibVersionNumber            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StoreDateTimeAsTicks                      = GetBool(new IntPtr(p + 0x044)); // 0245A3D2B9E8 0x44 StoreDateTimeAsTicks        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StoreTimeSpanAsTicks                      = GetBool(new IntPtr(p + 0x045)); // 0245A3D2BA08 0x45 StoreTimeSpanAsTicks        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DateTimeStringFormat                      = GetString(new IntPtr(p + 0x048)); // 0245A3D2BA28 0x48 DateTimeStringFormat        ( 000186671910 ModelPrimitiveType string string string String )
            value.DateTimeStyle                             = (DateTimeStyles)GetInt32(new IntPtr(p + 0x050)); // 0245A3D2BA48 0x50 DateTimeStyle               ( 0001865BE5C0 ModelEnumType DateTimeStyles DateTimeStyles DateTimeStyles Int32 )

            return value;
        }
    }
}
