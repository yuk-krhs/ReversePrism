using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MemoryRegions                            ModelEnumListType BitRegion[] BitRegion[] List<BitRegion> Pointer
    // 018 Listeners                                ModelEnumListType StateChangeMonitorListener[] StateChangeMonitorListener[] List<StateChangeMonitorListener> Pointer
    // 020 Signalled                                ModelEnumType DynamicBitfield DynamicBitfield DynamicBitfield Int32
    // 040 NeedToUpdateOrderingOfMonitors           ModelPrimitiveType bool bool bool Bool
    // 041 NeedToCompactArrays                      ModelPrimitiveType bool bool bool Bool
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

            value.MemoryRegions                             = GetEnumList<BitRegion>(new IntPtr(p + 0x010)); // 0x10 MemoryRegions               ( ModelEnumListType BitRegion[] BitRegion[] List<BitRegion> Pointer )
            value.Listeners                                 = GetEnumList<StateChangeMonitorListener>(new IntPtr(p + 0x018)); // 0x18 Listeners                   ( ModelEnumListType StateChangeMonitorListener[] StateChangeMonitorListener[] List<StateChangeMonitorListener> Pointer )
            value.Signalled                                 = (DynamicBitfield)GetInt32(new IntPtr(p + 0x020)); // 0x20 Signalled                   ( ModelEnumType DynamicBitfield DynamicBitfield DynamicBitfield Int32 )
            value.NeedToUpdateOrderingOfMonitors            = GetBool(new IntPtr(p + 0x040)); // 0x40 NeedToUpdateOrderingOfMonitors ( ModelPrimitiveType bool bool bool Bool )
            value.NeedToCompactArrays                       = GetBool(new IntPtr(p + 0x041)); // 0x41 NeedToCompactArrays         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
