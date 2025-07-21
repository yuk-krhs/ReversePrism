using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_mgr                                    ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer
    // 018 M_slot                                   ModelPrimitiveType int int int Int32
    // 020 M_cookie                                 ModelPrimitiveType long long long Int64
    public partial class LocalDataStoreSlot : DataModel
    {
        public LocalDataStoreMgr?                       M_mgr                                   { get; set; }
        public int                                      M_slot                                  { get; set; }
        public long                                     M_cookie                                { get; set; }

        public static LocalDataStoreSlot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalDataStoreSlot() { Pointer= p0 };

            value.M_mgr                                     = GetObject<LocalDataStoreMgr>(new IntPtr(p + 0x010), ReversePrism.DataModels.LocalDataStoreMgr.FromPointer); // 0x10 M_mgr                       ( ModelClassType LocalDataStoreMgr LocalDataStoreMgr LocalDataStoreMgr Pointer )
            value.M_slot                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_slot                      ( ModelPrimitiveType int int int Int32 )
            value.M_cookie                                  = GetInt64(new IntPtr(p + 0x020)); // 0x20 M_cookie                    ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
