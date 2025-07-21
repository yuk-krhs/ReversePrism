using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF s_activeScope                            Scope IL2CPP_TYPE_CLASS
    // 010 M_instanceScope                          ModelClassType Scope Scope Scope Pointer
    public partial class TypeLimiter : DataModel
    {
        public Scope?                                   M_instanceScope                         { get; set; }

        public static TypeLimiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeLimiter() { Pointer= p0 };

            value.M_instanceScope                           = GetObject<Scope>(new IntPtr(p + 0x010), ReversePrism.DataModels.Scope.FromPointer); // 0x10 M_instanceScope             ( ModelClassType Scope Scope Scope Pointer )

            return value;
        }
    }
}
