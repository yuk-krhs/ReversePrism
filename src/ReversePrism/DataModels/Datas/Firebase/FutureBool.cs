using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 SwigCPtr                                 ModelEnumType HandleRef HandleRef HandleRef Int32
    // 000 Callbacks                                Dictionary`2<int, Action> IL2CPP_TYPE_GENERICINST
    // 008 CallbackIndex                            int IL2CPP_TYPE_I4
    // 010 CallbackLock                             <object> IL2CPP_TYPE_OBJECT
    // 038 callbackData                             <int> IL2CPP_TYPE_I
    // 040 SWIG_CompletionCB                        ModelClassType SWIG_CompletionDelegate SWIG_CompletionDelegate SWIG_CompletionDelegate Pointer
    public partial class FutureBool : DataModel
    {
        public HandleRef                                SwigCPtr                                { get; set; }
        public SWIG_CompletionDelegate?                 SWIG_CompletionCB                       { get; set; }

        public static FutureBool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FutureBool() { Pointer= p0 };

            value.SwigCPtr                                  = (HandleRef)GetInt32(new IntPtr(p + 0x028)); // 0x28 SwigCPtr                    ( ModelEnumType HandleRef HandleRef HandleRef Int32 )
            value.SWIG_CompletionCB                         = GetObject<SWIG_CompletionDelegate>(new IntPtr(p + 0x040), ReversePrism.DataModels.SWIG_CompletionDelegate.FromPointer); // 0x40 SWIG_CompletionCB           ( ModelClassType SWIG_CompletionDelegate SWIG_CompletionDelegate SWIG_CompletionDelegate Pointer )

            return value;
        }
    }
}
