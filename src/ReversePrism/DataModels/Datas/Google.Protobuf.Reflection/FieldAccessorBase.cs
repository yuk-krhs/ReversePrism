using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 getValueDelegate                         Func`2<IMessage, <object>> IL2CPP_TYPE_GENERICINST
    // 018 Descriptor                               000186571FF0 ModelClassType FieldDescriptor FieldDescriptor FieldDescriptor Pointer
    public partial class FieldAccessorBase
    {
        public FieldDescriptor?                         Descriptor                              { get; set; }

        public static FieldAccessorBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldAccessorBase();

            value.Descriptor                                = GetObject<FieldDescriptor>(new IntPtr(p + 0x018), ReversePrism.DataModels.FieldDescriptor.FromPointer); // 0270D0D4EFE8 0x18 Descriptor                  ( 000186571FF0 ModelClassType FieldDescriptor FieldDescriptor FieldDescriptor Pointer )

            return value;
        }
    }
}
