using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ColumnIndex                            ModelPrimitiveType int int int Int32
    // 018 M_ColumnName                             ModelPrimitiveType string string string String
    // 020 M_SortDirection                          ModelEnumType SortDirection SortDirection SortDirection Int32
    // 028 Column                                   ModelClassType Column Column Column Pointer
    // 030 changed                                  Action`1<SortColumnDescription> IL2CPP_TYPE_GENERICINST
    public partial class SortColumnDescription : DataModel
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
            var value   = new SortColumnDescription() { Pointer= p0 };

            value.M_ColumnIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_ColumnIndex               ( ModelPrimitiveType int int int Int32 )
            value.M_ColumnName                              = GetString(new IntPtr(p + 0x018)); // 0x18 M_ColumnName                ( ModelPrimitiveType string string string String )
            value.M_SortDirection                           = (SortDirection)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_SortDirection             ( ModelEnumType SortDirection SortDirection SortDirection Int32 )
            value.Column                                    = GetObject<Column>(new IntPtr(p + 0x028), ReversePrism.DataModels.Column.FromPointer); // 0x28 Column                      ( ModelClassType Column Column Column Pointer )

            return value;
        }
    }
}
