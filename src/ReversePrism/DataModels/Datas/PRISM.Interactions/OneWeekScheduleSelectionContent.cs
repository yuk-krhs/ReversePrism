using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 WeekDisplayContent                       ModelClassType WeekDisplayContent WeekDisplayContent WeekDisplayContent Pointer
    // 028 OneScheduleSelectionContentList          ModelClassListType List`1<OneScheduleSelectionContent> List`1<OneScheduleSelectionContent> List<OneScheduleSelectionContent> Pointer
    // 030 onTouchSchedule                          Subject`1<ValueTuple`2<ScheduleType, int>> IL2CPP_TYPE_GENERICINST
    // 038 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class OneWeekScheduleSelectionContent : DataModel
    {
        public WeekDisplayContent?                      WeekDisplayContent                      { get; set; }
        public List<OneScheduleSelectionContent>?       OneScheduleSelectionContentList         { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static OneWeekScheduleSelectionContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneWeekScheduleSelectionContent() { Pointer= p0 };

            value.WeekDisplayContent                        = GetObject<WeekDisplayContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.WeekDisplayContent.FromPointer); // 0x20 WeekDisplayContent          ( ModelClassType WeekDisplayContent WeekDisplayContent WeekDisplayContent Pointer )
            value.OneScheduleSelectionContentList           = GetObjectList<OneScheduleSelectionContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.OneScheduleSelectionContent.FromPointer); // 0x28 OneScheduleSelectionContentList ( ModelClassListType List`1<OneScheduleSelectionContent> List`1<OneScheduleSelectionContent> List<OneScheduleSelectionContent> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
