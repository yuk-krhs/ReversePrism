using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 018 Columns                                  ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer
    // 020 OldRecord                                ModelPrimitiveType int int int Int32
    // 024 NewRecord                                ModelPrimitiveType int int int Int32
    // 028 TempRecord                               ModelPrimitiveType int int int Int32
    // 030 RowID                                    ModelPrimitiveType long long long Int64
    // 038 Action                                   ModelEnumType DataRowAction DataRowAction DataRowAction Int32
    // 03C InChangingEvent                          ModelPrimitiveType bool bool bool Bool
    // 03D InDeletingEvent                          ModelPrimitiveType bool bool bool Bool
    // 03E InCascade                                ModelPrimitiveType bool bool bool Bool
    // 040 LastChangedColumn                        ModelClassType DataColumn DataColumn DataColumn Pointer
    // 048 CountColumnChange                        ModelPrimitiveType int int int Int32
    // 050 Error                                    ModelClassType DataError DataError DataError Pointer
    // 058 RbTreeNodeId                             ModelPrimitiveType int int int Int32
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 05C ObjectID                                 ModelPrimitiveType int int int Int32
    public partial class DataRow : DataModel
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
            var value   = new DataRow() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0x10 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Columns                                   = GetObject<DataColumnCollection>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataColumnCollection.FromPointer); // 0x18 Columns                     ( ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer )
            value.OldRecord                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 OldRecord                   ( ModelPrimitiveType int int int Int32 )
            value.NewRecord                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 NewRecord                   ( ModelPrimitiveType int int int Int32 )
            value.TempRecord                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 TempRecord                  ( ModelPrimitiveType int int int Int32 )
            value.RowID                                     = GetInt64(new IntPtr(p + 0x030)); // 0x30 RowID                       ( ModelPrimitiveType long long long Int64 )
            value.Action                                    = (DataRowAction)GetInt32(new IntPtr(p + 0x038)); // 0x38 Action                      ( ModelEnumType DataRowAction DataRowAction DataRowAction Int32 )
            value.InChangingEvent                           = GetBool(new IntPtr(p + 0x03C)); // 0x3C InChangingEvent             ( ModelPrimitiveType bool bool bool Bool )
            value.InDeletingEvent                           = GetBool(new IntPtr(p + 0x03D)); // 0x3D InDeletingEvent             ( ModelPrimitiveType bool bool bool Bool )
            value.InCascade                                 = GetBool(new IntPtr(p + 0x03E)); // 0x3E InCascade                   ( ModelPrimitiveType bool bool bool Bool )
            value.LastChangedColumn                         = GetObject<DataColumn>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumn.FromPointer); // 0x40 LastChangedColumn           ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.CountColumnChange                         = GetInt32(new IntPtr(p + 0x048)); // 0x48 CountColumnChange           ( ModelPrimitiveType int int int Int32 )
            value.Error                                     = GetObject<DataError>(new IntPtr(p + 0x050), ReversePrism.DataModels.DataError.FromPointer); // 0x50 Error                       ( ModelClassType DataError DataError DataError Pointer )
            value.RbTreeNodeId                              = GetInt32(new IntPtr(p + 0x058)); // 0x58 RbTreeNodeId                ( ModelPrimitiveType int int int Int32 )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x05C)); // 0x5C ObjectID                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
