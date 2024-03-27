using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    // 018 Columns                                  000186677020 ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer
    // 020 OldRecord                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 024 NewRecord                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 028 TempRecord                               0001865F2F90 ModelPrimitiveType int int int Int32
    // 030 RowID                                    0001865F79C0 ModelPrimitiveType long long long Int64
    // 038 Action                                   00018667D870 ModelEnumType DataRowAction DataRowAction DataRowAction Int32
    // 03C InChangingEvent                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 03D InDeletingEvent                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 03E InCascade                                000186595210 ModelPrimitiveType bool bool bool Bool
    // 040 LastChangedColumn                        0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 048 CountColumnChange                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 Error                                    000186679B80 ModelClassType DataError DataError DataError Pointer
    // 058 RbTreeNodeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 05C ObjectID                                 0001865F44E0 ModelPrimitiveType int int int Int32
    public partial class DataRow
    {
        public DataTable?                               Table                                   { get; set; }
        public DataColumnCollection?                    Columns                                 { get; set; }
        public int                                      OldRecord                               { get; set; }
        public int                                      NewRecord                               { get; set; }
        public int                                      TempRecord                              { get; set; }
        public long                                     RowID                                   { get; set; }
        public DataRowAction                            Action                                  { get; set; }
        public bool                                     InChangingEvent                         { get; set; }
        public bool                                     InDeletingEvent                         { get; set; }
        public bool                                     InCascade                               { get; set; }
        public DataColumn?                              LastChangedColumn                       { get; set; }
        public int                                      CountColumnChange                       { get; set; }
        public DataError?                               Error                                   { get; set; }
        public int                                      RbTreeNodeId                            { get; set; }
        public int                                      ObjectID                                { get; set; }

        public static DataRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRow();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88A2B68 0x10 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )
            value.Columns                                   = GetObject<DataColumnCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataColumnCollection.FromPointer); // 0270D88A2B88 0x18 Columns                     ( 000186677020 ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer )
            value.OldRecord                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D88A2BA8 0x20 OldRecord                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.NewRecord                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D88A2BC8 0x24 NewRecord                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.TempRecord                                = GetInt32(new IntPtr(p + 0x028)); // 0270D88A2BE8 0x28 TempRecord                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.RowID                                     = GetInt64(new IntPtr(p + 0x030)); // 0270D88A2C08 0x30 RowID                       ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.Action                                    = (DataRowAction)GetInt32(new IntPtr(p + 0x038)); // 0270D88A2C28 0x38 Action                      ( 00018667D870 ModelEnumType DataRowAction DataRowAction DataRowAction Int32 )
            value.InChangingEvent                           = GetBool(new IntPtr(p + 0x03C)); // 0270D88A2C48 0x3C InChangingEvent             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.InDeletingEvent                           = GetBool(new IntPtr(p + 0x03D)); // 0270D88A2C68 0x3D InDeletingEvent             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.InCascade                                 = GetBool(new IntPtr(p + 0x03E)); // 0270D88A2C88 0x3E InCascade                   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.LastChangedColumn                         = GetObject<DataColumn>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D88A2CA8 0x40 LastChangedColumn           ( 0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.CountColumnChange                         = GetInt32(new IntPtr(p + 0x048)); // 0270D88A2CC8 0x48 CountColumnChange           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<DataError>(new IntPtr(p + 0x050), ReversePrism.DataModels.DataError.FromPointer); // 0270D88A2CE8 0x50 Error                       ( 000186679B80 ModelClassType DataError DataError DataError Pointer )
            value.RbTreeNodeId                              = GetInt32(new IntPtr(p + 0x058)); // 0270D88A2D08 0x58 RbTreeNodeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x05C)); // 0270D88A2D48 0x5C ObjectID                    ( 0001865F44E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
