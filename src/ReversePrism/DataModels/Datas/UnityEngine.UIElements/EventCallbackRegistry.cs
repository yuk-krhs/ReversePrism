using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_ListPool                               EventCallbackListPool IL2CPP_TYPE_CLASS
    // 010 M_Callbacks                              000186750810 ModelClassType EventCallbackList EventCallbackList EventCallbackList Pointer
    // 018 M_TemporaryCallbacks                     000186750810 ModelClassType EventCallbackList EventCallbackList EventCallbackList Pointer
    // 020 M_IsInvoking                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class EventCallbackRegistry
    {
        public EventCallbackList?                       M_Callbacks                             { get; set; }
        public EventCallbackList?                       M_TemporaryCallbacks                    { get; set; }
        public int                                      M_IsInvoking                            { get; set; }

        public static EventCallbackRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventCallbackRegistry();

            value.M_Callbacks                               = GetObject<EventCallbackList>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventCallbackList.FromPointer); // 027006767378 0x10 M_Callbacks                 ( 000186750810 ModelClassType EventCallbackList EventCallbackList EventCallbackList Pointer )
            value.M_TemporaryCallbacks                      = GetObject<EventCallbackList>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventCallbackList.FromPointer); // 027006767398 0x18 M_TemporaryCallbacks        ( 000186750810 ModelClassType EventCallbackList EventCallbackList EventCallbackList Pointer )
            value.M_IsInvoking                              = GetInt32(new IntPtr(p + 0x020)); // 0270067673B8 0x20 M_IsInvoking                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
