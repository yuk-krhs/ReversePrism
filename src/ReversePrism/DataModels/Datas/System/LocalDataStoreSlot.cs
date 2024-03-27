using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_mgr                                    0001865A43A0 ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer
    // 018 M_slot                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_cookie                                 0001865F7700 ModelPrimitiveType long long long Int64
    public partial class LocalDataStoreSlot
    {
        public LocalDataStoreMgr?                       M_mgr                                   { get; set; }
        public int                                      M_slot                                  { get; set; }
        public long                                     M_cookie                                { get; set; }

        public static LocalDataStoreSlot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalDataStoreSlot();

            value.M_mgr                                     = GetObject<LocalDataStoreMgr>(new IntPtr(p + 0x010), ReversePrism.DataModels.LocalDataStoreMgr.FromPointer); // 027001539D80 0x10 M_mgr                       ( 0001865A43A0 ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer )
            value.M_slot                                    = GetInt32(new IntPtr(p + 0x018)); // 027001539DA0 0x18 M_slot                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_cookie                                  = GetInt64(new IntPtr(p + 0x020)); // 027001539DC0 0x20 M_cookie                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
