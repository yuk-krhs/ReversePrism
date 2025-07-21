using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Column                                   ModelClassType DataColumn DataColumn DataColumn Pointer
    // 018 Row                                      ModelClassType DataRow DataRow DataRow Pointer
    // 020 <ProposedValue>k__BackingField           <object> IL2CPP_TYPE_OBJECT
    public partial class DataColumnChangeEventArgs : DataModel
    {
        public DataColumn?                              Column                                  { get; set; }
        public DataRow?                                 Row                                     { get; set; }

        public static DataColumnChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataColumnChangeEventArgs() { Pointer= p0 };

            value.Column                                    = GetObject<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0x10 Column                      ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.Row                                       = GetObject<DataRow>(new IntPtr(p + 0x018), ReversePrism.DataModels.DataRow.FromPointer); // 0x18 Row                         ( ModelClassType DataRow DataRow DataRow Pointer )

            return value;
        }
    }
}
