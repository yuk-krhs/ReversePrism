using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 cancellationCallback                     Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 010 Action                                   ModelClassType UnityAction UnityAction UnityAction Pointer
    // 018 UnityEvent                               ModelClassType UnityEvent UnityEvent UnityEvent Pointer
    // 020 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 Registration                             ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 040 IsDisposed                               ModelPrimitiveType bool bool bool Bool
    // 041 CallOnce                                 ModelPrimitiveType bool bool bool Bool
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

            value.Action                                    = GetObject<UnityAction>(new IntPtr(p + 0x010), ReversePrism.DataModels.UnityAction.FromPointer); // 0x10 Action                      ( ModelClassType UnityAction UnityAction UnityAction Pointer )
            value.UnityEvent                                = GetObject<UnityEvent>(new IntPtr(p + 0x018), ReversePrism.DataModels.UnityEvent.FromPointer); // 0x18 UnityEvent                  ( ModelClassType UnityEvent UnityEvent UnityEvent Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0x20 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Registration                              = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x028)); // 0x28 Registration                ( ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )
            value.IsDisposed                                = GetBool(new IntPtr(p + 0x040)); // 0x40 IsDisposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.CallOnce                                  = GetBool(new IntPtr(p + 0x041)); // 0x41 CallOnce                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
