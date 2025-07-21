using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PanelList                                ModelClassListType List`1<OneScheduleSelectionContent> List`1<OneScheduleSelectionContent> List<OneScheduleSelectionContent> Pointer
    // 028 onClickSchedulePanelSubject              Subject`1<ValueTuple`2<ScheduleType, int>> IL2CPP_TYPE_GENERICINST
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ScheduleSelectionPanelGroup : DataModel
    {
        public List<OneScheduleSelectionContent>?       PanelList                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ScheduleSelectionPanelGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleSelectionPanelGroup() { Pointer= p0 };

            value.PanelList                                 = GetObjectList<OneScheduleSelectionContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.OneScheduleSelectionContent.FromPointer); // 0x20 PanelList                   ( ModelClassListType List`1<OneScheduleSelectionContent> List`1<OneScheduleSelectionContent> List<OneScheduleSelectionContent> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
