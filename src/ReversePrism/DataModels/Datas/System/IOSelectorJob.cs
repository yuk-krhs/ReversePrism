using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Operation                                0001865C64A0 ModelEnumType IOOperation IOOperation IOOperation Int32
    // 018 Callback                                 0001865C4A40 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer
    // 020 State                                    0001865C53D0 ModelClassType IOAsyncResult IOAsyncResult IOAsyncResult Pointer
    public partial class IOSelectorJob
    {
        public IOOperation                              Operation                               { get; set; }
        public IOAsyncCallback?                         Callback                                { get; set; }
        public IOAsyncResult?                           State                                   { get; set; }

        public static IOSelectorJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IOSelectorJob();

            value.Operation                                 = (IOOperation)GetInt32(new IntPtr(p + 0x010)); // 0270D7986E60 0x10 Operation                   ( 0001865C64A0 ModelEnumType IOOperation IOOperation IOOperation Int32 )
            value.Callback                                  = GetObject<IOAsyncCallback>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOAsyncCallback.FromPointer); // 0270D7986E80 0x18 Callback                    ( 0001865C4A40 ModelClassType IOAsyncCallback IOAsyncCallback IOAsyncCallback Pointer )
            value.State                                     = GetObject<IOAsyncResult>(new IntPtr(p + 0x020), ReversePrism.DataModels.IOAsyncResult.FromPointer); // 0270D7986EA0 0x20 State                       ( 0001865C53D0 ModelClassType IOAsyncResult IOAsyncResult IOAsyncResult Pointer )

            return value;
        }
    }
}
