using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NoneViaConstructor                       LazyHelper IL2CPP_TYPE_CLASS
    // 008 NoneViaFactory                           LazyHelper IL2CPP_TYPE_CLASS
    // 010 PublicationOnlyViaConstructor            00018650F0A0 ModelClassType LazyHelper LazyHelper LazyHelper Pointer
    // 018 PublicationOnlyViaFactory                00018650F0A0 ModelClassType LazyHelper LazyHelper LazyHelper Pointer
    // 020 PublicationOnlyWaitForOtherThreadToPublish 00018650F0A0 ModelClassType LazyHelper LazyHelper LazyHelper Pointer
    // 010 State                                    00018650FAB0 ModelEnumType LazyState LazyState LazyState Int32
    // 018 ExceptionDispatch                        0001865CC020 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    public partial class LazyHelper : DataModel
    {
        public LazyHelper?                              PublicationOnlyViaConstructor           { get; set; }
        public LazyHelper?                              PublicationOnlyViaFactory               { get; set; }
        public LazyHelper?                              PublicationOnlyWaitForOtherThreadToPublish { get; set; }
        public LazyState                                State                                   { get; set; }
        public ExceptionDispatchInfo?                   ExceptionDispatch                       { get; set; }

        public static LazyHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LazyHelper() { Pointer= p0 };

            value.PublicationOnlyViaConstructor             = GetObject<LazyHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.LazyHelper.FromPointer); // 0245A3CA9388 0x10 PublicationOnlyViaConstructor ( 00018650F0A0 ModelClassType LazyHelper LazyHelper LazyHelper Pointer )
            value.PublicationOnlyViaFactory                 = GetObject<LazyHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.LazyHelper.FromPointer); // 0245A3CA93A8 0x18 PublicationOnlyViaFactory   ( 00018650F0A0 ModelClassType LazyHelper LazyHelper LazyHelper Pointer )
            value.PublicationOnlyWaitForOtherThreadToPublish = GetObject<LazyHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.LazyHelper.FromPointer); // 0245A3CA93C8 0x20 PublicationOnlyWaitForOtherThreadToPublish ( 00018650F0A0 ModelClassType LazyHelper LazyHelper LazyHelper Pointer )
            value.State                                     = (LazyState)GetInt32(new IntPtr(p + 0x010)); // 0245A3CA93E8 0x10 State                       ( 00018650FAB0 ModelEnumType LazyState LazyState LazyState Int32 )
            value.ExceptionDispatch                         = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0245A3CA9408 0x18 ExceptionDispatch           ( 0001865CC020 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )

            return value;
        }
    }
}
