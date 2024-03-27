using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Column                                   0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 Row                                      00018667D390 ModelClassType DataRow DataRow DataRow Pointer
    // 020 <ProposedValue>k__BackingField           <object> IL2CPP_TYPE_OBJECT
    public partial class DataColumnChangeEventArgs
    {
        public DataColumn?                              Column                                  { get; set; }
        public DataRow?                                 Row                                     { get; set; }

        public static DataColumnChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataColumnChangeEventArgs();

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D88B7590 0x10 Column                      ( 0001866759E0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Row                                       = GetObject<DataRow>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataRow.FromPointer); // 0270D88B75B0 0x18 Row                         ( 00018667D390 ModelClassType DataRow DataRow DataRow Pointer )

            return value;
        }
    }
}
