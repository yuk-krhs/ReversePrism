using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Async_callback                           0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    // 018 async_state                              <object> IL2CPP_TYPE_OBJECT
    // 020 Wait_handle                              00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 028 Completed_synchronously                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 Completed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class IOAsyncResult : DataModel
    {
        public AsyncCallback?                           Async_callback                          { get; set; }
        public ManualResetEvent?                        Wait_handle                             { get; set; }
        public bool                                     Completed_synchronously                 { get; set; }
        public bool                                     Completed                               { get; set; }

        public static IOAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IOAsyncResult() { Pointer= p0 };

            value.Async_callback                            = GetObject<AsyncCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncCallback.FromPointer); // 0246679EECF8 0x10 Async_callback              ( 0001866EDF20 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )
            value.Wait_handle                               = GetObject<ManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0246679EED38 0x20 Wait_handle                 ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.Completed_synchronously                   = GetBool(new IntPtr(p + 0x028)); // 0246679EED58 0x28 Completed_synchronously     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Completed                                 = GetBool(new IntPtr(p + 0x029)); // 0246679EED78 0x29 Completed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
