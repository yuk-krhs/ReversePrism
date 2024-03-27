using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PendingPointerCapture                  000185B867B0 ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer
    // 018 M_PointerCapture                         000185B867B0 ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer
    // 020 M_ShouldSendCompatibilityMouseEvents     000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class PointerDispatchState
    {
        public List<IEventHandler>?                     M_PendingPointerCapture                 { get; set; }
        public List<IEventHandler>?                     M_PointerCapture                        { get; set; }
        public List<bool>?                              M_ShouldSendCompatibilityMouseEvents    { get; set; }

        public static PointerDispatchState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerDispatchState();

            value.M_PendingPointerCapture                   = GetObjectList<IEventHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEventHandler.FromPointer); // 0270067E0E50 0x10 M_PendingPointerCapture     ( 000185B867B0 ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer )
            value.M_PointerCapture                          = GetObjectList<IEventHandler>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEventHandler.FromPointer); // 0270067E0E70 0x18 M_PointerCapture            ( 000185B867B0 ModelClassListType IEventHandler[] IEventHandler[] List<IEventHandler> Pointer )
            value.M_ShouldSendCompatibilityMouseEvents      = GetBoolList(new IntPtr(p + 0x020)); // 0270067E0E90 0x20 M_ShouldSendCompatibilityMouseEvents ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
