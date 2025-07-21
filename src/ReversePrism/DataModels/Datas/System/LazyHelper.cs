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
    // 010 PublicationOnlyViaConstructor            ModelClassType LazyHelper LazyHelper LazyHelper Pointer
    // 018 PublicationOnlyViaFactory                ModelClassType LazyHelper LazyHelper LazyHelper Pointer
    // 020 PublicationOnlyWaitForOtherThreadToPublish ModelClassType LazyHelper LazyHelper LazyHelper Pointer
    // 010 State                                    ModelEnumType LazyState LazyState LazyState Int32
    // 018 ExceptionDispatch                        ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
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

            value.PublicationOnlyViaConstructor             = GetObject<LazyHelper>(new IntPtr(p + 0x010), ReversePrism.DataModels.LazyHelper.FromPointer); // 0x10 PublicationOnlyViaConstructor ( ModelClassType LazyHelper LazyHelper LazyHelper Pointer )
            value.PublicationOnlyViaFactory                 = GetObject<LazyHelper>(new IntPtr(p + 0x018), ReversePrism.DataModels.LazyHelper.FromPointer); // 0x18 PublicationOnlyViaFactory   ( ModelClassType LazyHelper LazyHelper LazyHelper Pointer )
            value.PublicationOnlyWaitForOtherThreadToPublish = GetObject<LazyHelper>(new IntPtr(p + 0x020), ReversePrism.DataModels.LazyHelper.FromPointer); // 0x20 PublicationOnlyWaitForOtherThreadToPublish ( ModelClassType LazyHelper LazyHelper LazyHelper Pointer )
            value.State                                     = (LazyState)GetInt32(new IntPtr(p + 0x010)); // 0x10 State                       ( ModelEnumType LazyState LazyState LazyState Int32 )
            value.ExceptionDispatch                         = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0x18 ExceptionDispatch           ( ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )

            return value;
        }
    }
}
