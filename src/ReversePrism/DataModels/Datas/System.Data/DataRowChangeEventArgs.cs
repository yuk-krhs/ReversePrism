using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Row                                      00018667D390 ModelClassType DataRow DataRow DataRow Pointer
    // 018 Action                                   00018667DB40 ModelEnumType DataRowAction DataRowAction DataRowAction Int32
    public partial class DataRowChangeEventArgs
    {
        public DataRow?                                 Row                                     { get; set; }
        public DataRowAction                            Action                                  { get; set; }

        public static DataRowChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataRowChangeEventArgs();

            value.Row                                       = GetObject<DataRow>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataRow.FromPointer); // 0270D88D3180 0x10 Row                         ( 00018667D390 ModelClassType DataRow DataRow DataRow Pointer )
            value.Action                                    = (DataRowAction)GetInt32(new IntPtr(p + 0x018)); // 0270D88D31A0 0x18 Action                      ( 00018667DB40 ModelEnumType DataRowAction DataRowAction DataRowAction Int32 )

            return value;
        }
    }
}
