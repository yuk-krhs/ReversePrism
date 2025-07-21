using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ScheduledItems                         ModelClassListType List`1<ScheduledItem> List`1<ScheduledItem> List<ScheduledItem> Pointer
    // 018 M_TransactionMode                        ModelPrimitiveType bool bool bool Bool
    // 020 M_ScheduleTransactions                   ModelClassListType List`1<ScheduledItem> List`1<ScheduledItem> List<ScheduledItem> Pointer
    // 028 m_UnscheduleTransactions                 HashSet`1<ScheduledItem> IL2CPP_TYPE_GENERICINST
    // 030 DisableThrottling                        ModelPrimitiveType bool bool bool Bool
    // 034 M_LastUpdatedIndex                       ModelPrimitiveType int int int Int32
    public partial class TimerEventScheduler : DataModel
    {
        public List<ScheduledItem>?                     M_ScheduledItems                        { get; set; }
        public bool                                     M_TransactionMode                       { get; set; }
        public List<ScheduledItem>?                     M_ScheduleTransactions                  { get; set; }
        public bool                                     DisableThrottling                       { get; set; }
        public int                                      M_LastUpdatedIndex                      { get; set; }

        public static TimerEventScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerEventScheduler() { Pointer= p0 };

            value.M_ScheduledItems                          = GetObjectList<ScheduledItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.ScheduledItem.FromPointer); // 0x10 M_ScheduledItems            ( ModelClassListType List`1<ScheduledItem> List`1<ScheduledItem> List<ScheduledItem> Pointer )
            value.M_TransactionMode                         = GetBool(new IntPtr(p + 0x018)); // 0x18 M_TransactionMode           ( ModelPrimitiveType bool bool bool Bool )
            value.M_ScheduleTransactions                    = GetObjectList<ScheduledItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduledItem.FromPointer); // 0x20 M_ScheduleTransactions      ( ModelClassListType List`1<ScheduledItem> List`1<ScheduledItem> List<ScheduledItem> Pointer )
            value.DisableThrottling                         = GetBool(new IntPtr(p + 0x030)); // 0x30 DisableThrottling           ( ModelPrimitiveType bool bool bool Bool )
            value.M_LastUpdatedIndex                        = GetInt32(new IntPtr(p + 0x034)); // 0x34 M_LastUpdatedIndex          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
