using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DataViewSettingsCollection               000186687770 ModelClassType DataViewSettingCollection DataViewSettingCollection DataViewSettingCollection Pointer
    // 028 NViews                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 000 s_notSupported                           NotSupportedException IL2CPP_TYPE_CLASS
    public partial class DataViewManager : DataModel
    {
        public DataViewSettingCollection?               DataViewSettingsCollection              { get; set; }
        public int                                      NViews                                  { get; set; }

        public static DataViewManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataViewManager() { Pointer= p0 };

            value.DataViewSettingsCollection                = GetObject<DataViewSettingCollection>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataViewSettingCollection.FromPointer); // 02466893F170 0x20 DataViewSettingsCollection  ( 000186687770 ModelClassType DataViewSettingCollection DataViewSettingCollection DataViewSettingCollection Pointer )
            value.NViews                                    = GetInt32(new IntPtr(p + 0x028)); // 02466893F190 0x28 NViews                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
