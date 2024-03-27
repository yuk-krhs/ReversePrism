using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TopicStartGasha                          string IL2CPP_TYPE_STRING
    // 000 TopicStartEvent                          string IL2CPP_TYPE_STRING
    // 000 TopicStartSeason                         string IL2CPP_TYPE_STRING
    // 000 TopicBow                                 string IL2CPP_TYPE_STRING
    // 000 MaxRetryCount                            int IL2CPP_TYPE_I4
    // 010 MyToken                                  000186671910 ModelPrimitiveType string string string String
    // 018 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 firebaseInitialized                      IObservable`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class FCMHandler
    {
        public string                                   MyToken                                 { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static FCMHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FCMHandler();

            value.MyToken                                   = GetString(new IntPtr(p + 0x010)); // 0270DBF10A50 0x10 MyToken                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270DBF10A70 0x18 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
