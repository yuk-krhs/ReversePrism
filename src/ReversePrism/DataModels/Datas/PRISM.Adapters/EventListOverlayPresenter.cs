using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 Model                                    00018675C9E0 ModelClassType EventListOverlayModel EventListOverlayModel EventListOverlayModel Pointer
    // 020 View                                     000186765140 ModelClassType IEventListOverlayView IEventListOverlayView IEventListOverlayView Pointer
    // 028 saveData                                 SavableJsonObject`1<EventListSaveData> IL2CPP_TYPE_GENERICINST
    // 030 IsJumpView                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EventListOverlayPresenter
    {
        public CompositeDisposable?                     Disposable                              { get; set; }
        public EventListOverlayModel?                   Model                                   { get; set; }
        public IEventListOverlayView?                   View                                    { get; set; }
        public bool                                     IsJumpView                              { get; set; }

        public static EventListOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListOverlayPresenter();

            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D629FE18 0x10 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Model                                     = GetObject<EventListOverlayModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventListOverlayModel.FromPointer); // 0270D629FE38 0x18 Model                       ( 00018675C9E0 ModelClassType EventListOverlayModel EventListOverlayModel EventListOverlayModel Pointer )
            value.View                                      = GetObject<IEventListOverlayView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IEventListOverlayView.FromPointer); // 0270D629FE58 0x20 View                        ( 000186765140 ModelClassType IEventListOverlayView IEventListOverlayView IEventListOverlayView Pointer )
            value.IsJumpView                                = GetBool(new IntPtr(p + 0x030)); // 0270D629FE98 0x30 IsJumpView                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
