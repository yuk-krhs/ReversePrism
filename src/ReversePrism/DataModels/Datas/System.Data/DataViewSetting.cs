using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataViewManager                          ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    // 018 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 020 Sort                                     ModelPrimitiveType string string string String
    // 028 RowFilter                                ModelPrimitiveType string string string String
    // 030 RowStateFilter                           ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32
    // 034 ApplyDefaultSort                         ModelPrimitiveType bool bool bool Bool
    public partial class DataViewSetting : DataModel
    {
        public DataViewManager?                         DataViewManager                         { get; set; }
        public DataTable?                               Table                                   { get; set; }
        public string                                   Sort                                    { get; set; }
        public string                                   RowFilter                               { get; set; }
        public DataViewRowState                         RowStateFilter                          { get; set; }
        public bool                                     ApplyDefaultSort                        { get; set; }

        public static DataViewSetting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataViewSetting() { Pointer= p0 };

            value.DataViewManager                           = GetObject<DataViewManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataViewManager.FromPointer); // 0x10 DataViewManager             ( ModelClassType DataViewManager DataViewManager DataViewManager Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataTable.FromPointer); // 0x18 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Sort                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Sort                        ( ModelPrimitiveType string string string String )
            value.RowFilter                                 = GetString(new IntPtr(p + 0x028)); // 0x28 RowFilter                   ( ModelPrimitiveType string string string String )
            value.RowStateFilter                            = (DataViewRowState)GetInt32(new IntPtr(p + 0x030)); // 0x30 RowStateFilter              ( ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32 )
            value.ApplyDefaultSort                          = GetBool(new IntPtr(p + 0x034)); // 0x34 ApplyDefaultSort            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
