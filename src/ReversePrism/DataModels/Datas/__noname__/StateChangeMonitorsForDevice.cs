using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemoryRegions                            000185CBECE8 ModelEnumListType BitRegion[] BitRegion[] List<BitRegion> Pointer
    // 018 Listeners                                000185CBDD58 ModelEnumListType StateChangeMonitorListener[] StateChangeMonitorListener[] List<StateChangeMonitorListener> Pointer
    // 020 Signalled                                00018670FDA0 ModelEnumType DynamicBitfield DynamicBitfield DynamicBitfield Int32
    // 040 NeedToUpdateOrderingOfMonitors           000186595960 ModelPrimitiveType bool bool bool Bool
    // 041 NeedToCompactArrays                      000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class StateChangeMonitorsForDevice : DataModel
    {
        public List<BitRegion>?                         MemoryRegions                           { get; set; }
        public List<StateChangeMonitorListener>?        Listeners                               { get; set; }
        public DynamicBitfield                          Signalled                               { get; set; }
        public bool                                     NeedToUpdateOrderingOfMonitors          { get; set; }
        public bool                                     NeedToCompactArrays                     { get; set; }

        public static StateChangeMonitorsForDevice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StateChangeMonitorsForDevice() { Pointer= p0 };

            value.MemoryRegions                             = GetEnumList<BitRegion>(new IntPtr(p + 0x010)); // 024667773000 0x10 MemoryRegions               ( 000185CBECE8 ModelEnumListType BitRegion[] BitRegion[] List<BitRegion> Pointer )
            value.Listeners                                 = GetEnumList<StateChangeMonitorListener>(new IntPtr(p + 0x018)); // 024667773020 0x18 Listeners                   ( 000185CBDD58 ModelEnumListType StateChangeMonitorListener[] StateChangeMonitorListener[] List<StateChangeMonitorListener> Pointer )
            value.Signalled                                 = (DynamicBitfield)GetInt32(new IntPtr(p + 0x020)); // 024667773040 0x20 Signalled                   ( 00018670FDA0 ModelEnumType DynamicBitfield DynamicBitfield DynamicBitfield Int32 )
            value.NeedToUpdateOrderingOfMonitors            = GetBool(new IntPtr(p + 0x040)); // 024667773060 0x40 NeedToUpdateOrderingOfMonitors ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeedToCompactArrays                       = GetBool(new IntPtr(p + 0x041)); // 024667773080 0x41 NeedToCompactArrays         ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
