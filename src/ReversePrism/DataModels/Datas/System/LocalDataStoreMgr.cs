using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 InitialSlotTableSize                     int IL2CPP_TYPE_I4
    // 000 SlotTableDoubleThreshold                 int IL2CPP_TYPE_I4
    // 000 LargeSlotTableSizeIncrease               int IL2CPP_TYPE_I4
    // 010 M_SlotInfoTable                          000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 018 M_FirstAvailableSlot                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_ManagedLocalDataStores                 000185CF0B98 ModelClassListType List`1<LocalDataStore> List`1<LocalDataStore> List<LocalDataStore> Pointer
    // 028 m_KeyToSlotMap                           Dictionary`2<string, LocalDataStoreSlot> IL2CPP_TYPE_GENERICINST
    // 030 M_CookieGenerator                        0001865F7700 ModelPrimitiveType long long long Int64
    public partial class LocalDataStoreMgr : DataModel
    {
        public List<bool>?                              M_SlotInfoTable                         { get; set; }
        public int                                      M_FirstAvailableSlot                    { get; set; }
        public List<LocalDataStore>?                    M_ManagedLocalDataStores                { get; set; }
        public long                                     M_CookieGenerator                       { get; set; }

        public static LocalDataStoreMgr? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalDataStoreMgr() { Pointer= p0 };

            value.M_SlotInfoTable                           = GetBoolList(new IntPtr(p + 0x010)); // 0245A1532360 0x10 M_SlotInfoTable             ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.M_FirstAvailableSlot                      = GetInt32(new IntPtr(p + 0x018)); // 0245A1532380 0x18 M_FirstAvailableSlot        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ManagedLocalDataStores                  = GetObjectList<LocalDataStore>(new IntPtr(p + 0x020), ReversePrism.DataModels.LocalDataStore.FromPointer); // 0245A15323A0 0x20 M_ManagedLocalDataStores    ( 000185CF0B98 ModelClassListType List`1<LocalDataStore> List`1<LocalDataStore> List<LocalDataStore> Pointer )
            value.M_CookieGenerator                         = GetInt64(new IntPtr(p + 0x030)); // 0245A15323E0 0x30 M_CookieGenerator           ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
