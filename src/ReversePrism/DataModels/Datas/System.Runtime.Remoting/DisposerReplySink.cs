using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer
    // 018 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class DisposerReplySink
    {
        public IMessageSink?                            Next                                    { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static DisposerReplySink? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisposerReplySink();

            value.Next                                      = GetObject<IMessageSink>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMessageSink.FromPointer); // 0270D6BB9328 0x10 Next                        ( 0001865B0830 ModelClassType IMessageSink IMessageSink IMessageSink Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D6BB9348 0x18 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
