using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 EventTabGroup                            00018675DFB0 ModelClassType EventListTabGroup EventListTabGroup EventListTabGroup Pointer
    // 030 EventListView                            0001867649E0 ModelClassType EventScheduleListView EventScheduleListView EventScheduleListView Pointer
    // 038 CloseButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 040 onClickEventSchedule                     Subject`1<IEventScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 048 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 050 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class EventListOverlayView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public EventListTabGroup?                       EventTabGroup                           { get; set; }
        public EventScheduleListView?                   EventListView                           { get; set; }
        public ButtonBase?                              CloseButton                             { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static EventListOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListOverlayView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466BF354B0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.EventTabGroup                             = GetObject<EventListTabGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.EventListTabGroup.FromPointer); // 02466BF354D0 0x28 EventTabGroup               ( 00018675DFB0 ModelClassType EventListTabGroup EventListTabGroup EventListTabGroup Pointer )
            value.EventListView                             = GetObject<EventScheduleListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.EventScheduleListView.FromPointer); // 02466BF354F0 0x30 EventListView               ( 0001867649E0 ModelClassType EventScheduleListView EventScheduleListView EventScheduleListView Pointer )
            value.CloseButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466BF35510 0x38 CloseButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDisposable.FromPointer); // 02466BF35550 0x48 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x050), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466BF35570 0x50 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
