using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataViewManager                          0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    // 018 Table                                    0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    // 020 Sort                                     000186671910 ModelPrimitiveType string string string String
    // 028 RowFilter                                000186671910 ModelPrimitiveType string string string String
    // 030 RowStateFilter                           000186686B80 ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32
    // 034 ApplyDefaultSort                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DataViewSetting
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
            var value   = new DataViewSetting();

            value.DataViewManager                           = GetObject<DataViewManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataViewManager.FromPointer); // 0270D8926528 0x10 DataViewManager             ( 0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataTable.FromPointer); // 0270D8926548 0x18 Table                       ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )
            value.Sort                                      = GetString(new IntPtr(p + 0x020)); // 0270D8926568 0x20 Sort                        ( 000186671910 ModelPrimitiveType string string string String )
            value.RowFilter                                 = GetString(new IntPtr(p + 0x028)); // 0270D8926588 0x28 RowFilter                   ( 000186671910 ModelPrimitiveType string string string String )
            value.RowStateFilter                            = (DataViewRowState)GetInt32(new IntPtr(p + 0x030)); // 0270D89265A8 0x30 RowStateFilter              ( 000186686B80 ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32 )
            value.ApplyDefaultSort                          = GetBool(new IntPtr(p + 0x034)); // 0270D89265C8 0x34 ApplyDefaultSort            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
