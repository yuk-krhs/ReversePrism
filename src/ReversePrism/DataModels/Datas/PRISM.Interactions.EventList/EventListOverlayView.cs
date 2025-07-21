using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 EventTabGroup                            ModelClassType EventListTabGroup EventListTabGroup EventListTabGroup Pointer
    // 030 EventListView                            ModelClassType EventScheduleListView EventScheduleListView EventScheduleListView Pointer
    // 038 CloseButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 onClickEventSchedule                     Subject`1<IEventScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 048 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class EventListOverlayView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public EventListTabGroup?                       EventTabGroup                           { get; set; }
        public EventScheduleListView?                   EventListView                           { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static EventListOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListOverlayView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.EventTabGroup                             = GetObject<EventListTabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventListTabGroup.FromPointer); // 0x28 EventTabGroup               ( ModelClassType EventListTabGroup EventListTabGroup EventListTabGroup Pointer )
            value.EventListView                             = GetObject<EventScheduleListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventScheduleListView.FromPointer); // 0x30 EventListView               ( ModelClassType EventScheduleListView EventScheduleListView EventScheduleListView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x38 CloseButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 0x48 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
