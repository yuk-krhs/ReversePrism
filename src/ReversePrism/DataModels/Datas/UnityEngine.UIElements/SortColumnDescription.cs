using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ColumnIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_ColumnName                             000186671910 ModelPrimitiveType string string string String
    // 020 M_SortDirection                          00018652F220 ModelEnumType SortDirection SortDirection SortDirection Int32
    // 028 Column                                   0001865D5780 ModelClassType Column Column Column Pointer
    // 030 changed                                  Action`1<SortColumnDescription> IL2CPP_TYPE_GENERICINST
    public partial class SortColumnDescription
    {
        public int                                      M_ColumnIndex                           { get; set; }
        public string                                   M_ColumnName                            { get; set; }
        public SortDirection                            M_SortDirection                         { get; set; }
        public Column?                                  Column                                  { get; set; }

        public static SortColumnDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortColumnDescription();

            value.M_ColumnIndex                             = GetInt32(new IntPtr(p + 0x010)); // 02700672C548 0x10 M_ColumnIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ColumnName                              = GetString(new IntPtr(p + 0x018)); // 02700672C568 0x18 M_ColumnName                ( 000186671910 ModelPrimitiveType string string string String )
            value.M_SortDirection                           = (SortDirection)GetInt32(new IntPtr(p + 0x020)); // 02700672C588 0x20 M_SortDirection             ( 00018652F220 ModelEnumType SortDirection SortDirection SortDirection Int32 )
            value.Column                                    = GetObject<Column>(new IntPtr(p + 0x028), ReversePrism.DataModels.Column.FromPointer); // 02700672C5A8 0x28 Column                      ( 0001865D5780 ModelClassType Column Column Column Pointer )

            return value;
        }
    }
}
