using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataViewManager                          0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    public partial class DataViewManagerListItemTypeDescriptor : DataModel
    {
        public DataViewManager?                         DataViewManager                         { get; set; }

        public static DataViewManagerListItemTypeDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataViewManagerListItemTypeDescriptor() { Pointer= p0 };

            value.DataViewManager                           = GetObject<DataViewManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataViewManager.FromPointer); // 0246689922E8 0x10 DataViewManager             ( 0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer )

            return value;
        }
    }
}
