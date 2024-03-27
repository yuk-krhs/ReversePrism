using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    0001865B8520 ModelClassType DataTable DataTable DataTable Pointer
    // 018 List                                     0001865796B0 ModelClassType DataRowTree DataRowTree DataRowTree Pointer
    // 020 NullInList                               0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class DataRowCollection
    {
        public DataTable?                               Table                                   { get; set; }
        public DataRowTree?                             List                                    { get; set; }
        public int                                      NullInList                              { get; set; }

        public static DataRowCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRowCollection();

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88D36B0 0x10 Table                       ( 0001865B8520 ModelClassType DataTable DataTable DataTable Pointer )
            value.List                                      = GetObject<DataRowTree>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataRowTree.FromPointer); // 0270D88D36D0 0x18 List                        ( 0001865796B0 ModelClassType DataRowTree DataRowTree DataRowTree Pointer )
            value.NullInList                                = GetInt32(new IntPtr(p + 0x020)); // 0270D88D36F0 0x20 NullInList                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
