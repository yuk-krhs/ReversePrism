using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PendingPointerCapture                  ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer
    // 018 M_PointerCapture                         ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer
    // 020 M_ShouldSendCompatibilityMouseEvents     ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class PointerDispatchState : DataModel
    {
        public List<IEventHandler>?                     M_PendingPointerCapture                 { get; set; }
        public List<IEventHandler>?                     M_PointerCapture                        { get; set; }
        public List<bool>?                              M_ShouldSendCompatibilityMouseEvents    { get; set; }

        public static PointerDispatchState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerDispatchState() { Pointer= p0 };

            value.M_PendingPointerCapture                   = GetObjectList<IEventHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEventHandler.FromPointer); // 0x10 M_PendingPointerCapture     ( ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer )
            value.M_PointerCapture                          = GetObjectList<IEventHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEventHandler.FromPointer); // 0x18 M_PointerCapture            ( ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer )
            value.M_ShouldSendCompatibilityMouseEvents      = GetBoolList(new IntPtr(p + 0x020)); // 0x20 M_ShouldSendCompatibilityMouseEvents ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
