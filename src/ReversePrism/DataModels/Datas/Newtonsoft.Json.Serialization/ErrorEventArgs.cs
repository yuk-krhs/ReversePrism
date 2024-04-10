using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <CurrentObject>k__BackingField           <object> IL2CPP_TYPE_OBJECT
    // 018 ErrorContext                             000186744AD0 ModelClassType ErrorContext ErrorContext ErrorContext Pointer
    public partial class ErrorEventArgs : DataModel
    {
        public ErrorContext?                            ErrorContext                            { get; set; }

        public static ErrorEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorEventArgs() { Pointer= p0 };

            value.ErrorContext                              = GetObject<ErrorContext>(new IntPtr(p + 0x018), ReversePrism.DataModels.ErrorContext.FromPointer); // 0246686FC0B8 0x18 ErrorContext                ( 000186744AD0 ModelClassType ErrorContext ErrorContext ErrorContext Pointer )

            return value;
        }
    }
}
