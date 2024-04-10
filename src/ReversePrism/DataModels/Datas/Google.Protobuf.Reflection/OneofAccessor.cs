using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 caseDelegate                             Func`2<IMessage, int> IL2CPP_TYPE_GENERICINST
    // 018 clearDelegate                            Action`1<IMessage> IL2CPP_TYPE_GENERICINST
    // 020 Descriptor                               0001866DFA70 ModelClassType OneofDescriptor OneofDescriptor OneofDescriptor Pointer
    public partial class OneofAccessor : DataModel
    {
        public OneofDescriptor?                         Descriptor                              { get; set; }

        public static OneofAccessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OneofAccessor() { Pointer= p0 };

            value.Descriptor                                = GetObject<OneofDescriptor>(new IntPtr(p + 0x020), ReversePrism.DataModels.OneofDescriptor.FromPointer); // 02466A5FD770 0x20 Descriptor                  ( 0001866DFA70 ModelClassType OneofDescriptor OneofDescriptor OneofDescriptor Pointer )

            return value;
        }
    }
}
