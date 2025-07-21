using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MessagingHandler                         ModelClassType IMessagingHandler IMessagingHandler IMessagingHandler Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 AllActivated                             ModelPrimitiveType bool bool bool Bool
    public partial class ServerMessageFilter : DataModel
    {
        public IMessagingHandler?                       MessagingHandler                        { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     AllActivated                            { get; set; }

        public static ServerMessageFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerMessageFilter() { Pointer= p0 };

            value.MessagingHandler                          = GetObject<IMessagingHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessagingHandler.FromPointer); // 0x10 MessagingHandler            ( ModelClassType IMessagingHandler IMessagingHandler IMessagingHandler Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.AllActivated                              = GetBool(new IntPtr(p + 0x020)); // 0x20 AllActivated                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
