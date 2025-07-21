using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Exception                                ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 018 CalledGet                                ModelPrimitiveType bool bool bool Bool
    public partial class ExceptionHolder : DataModel
    {
        public ExceptionDispatchInfo?                   Exception                               { get; set; }
        public bool                                     CalledGet                               { get; set; }

        public static ExceptionHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionHolder() { Pointer= p0 };

            value.Exception                                 = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0x10 Exception                   ( ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.CalledGet                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 CalledGet                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
