using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cancellationCallback                     Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 Action                                   000186712770 ModelClassType UnityAction UnityAction UnityAction Pointer
    // 018 UnityEvent                               0001866A1CF0 ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 Registration                             00018653EBA0 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 040 IsDisposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 CallOnce                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class AsyncUnityEventHandler : DataModel
    {
        public UnityAction?                             Action                                  { get; set; }
        public UnityEvent?                              UnityEvent                              { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CancellationTokenRegistration            Registration                            { get; set; }
        public bool                                     IsDisposed                              { get; set; }
        public bool                                     CallOnce                                { get; set; }

        public static AsyncUnityEventHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncUnityEventHandler() { Pointer= p0 };

            value.Action                                    = GetObject<UnityAction>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityAction.FromPointer); // 024669008E30 0x10 Action                      ( 000186712770 ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.UnityEvent                                = GetObject<UnityEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityEvent.FromPointer); // 024669008E50 0x18 UnityEvent                  ( 0001866A1CF0 ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 024669008E70 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Registration                              = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x028)); // 024669008E90 0x28 Registration                ( 00018653EBA0 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x040)); // 024669008EB0 0x40 IsDisposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CallOnce                                  = GetBool(new IntPtr(p + 0x041)); // 024669008ED0 0x41 CallOnce                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
