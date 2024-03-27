using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Columns                                  000185B78AF0 ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer
    public partial class DataKey
    {
        public List<DataColumn>?                        Columns                                 { get; set; }

        public static DataKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataKey();

            value.Columns                                   = GetObjectList<DataColumn>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataColumn.FromPointer); // 0270D88A3CF8 0x10 Columns                     ( 000185B78AF0 ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer )

            return value;
        }
    }
}
