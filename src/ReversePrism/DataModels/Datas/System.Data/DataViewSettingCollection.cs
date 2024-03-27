using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataViewManager                          000186686430 ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    // 018 List                                     0001865DF1C0 ModelClassType Hashtable Hashtable Hashtable Pointer
    public partial class DataViewSettingCollection
    {
        public DataViewManager?                         DataViewManager                         { get; set; }
        public Hashtable?                               List                                    { get; set; }

        public static DataViewSettingCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataViewSettingCollection();

            value.DataViewManager                           = GetObject<DataViewManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataViewManager.FromPointer); // 0270D8926438 0x10 DataViewManager             ( 000186686430 ModelClassType DataViewManager DataViewManager DataViewManager Pointer )
            value.List                                      = GetObject<Hashtable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D8926458 0x18 List                        ( 0001865DF1C0 ModelClassType Hashtable Hashtable Hashtable Pointer )

            return value;
        }
    }
}
