using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_allowedTypes                           HashSet`1<Type> IL2CPP_TYPE_GENERICINST
    // 010 m_allowedTypes                           HashSet`1<Type> IL2CPP_TYPE_GENERICINST
    // 018 M_previousScope                          ModelClassType Scope Scope Scope Pointer
    public partial class Scope : DataModel
    {
        public Scope?                                   M_previousScope                         { get; set; }

        public static Scope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scope() { Pointer= p0 };

            value.M_previousScope                           = GetObject<Scope>(new IntPtr(p + 0x018), ReversePrism.DataModels.Scope.FromPointer); // 0x18 M_previousScope             ( ModelClassType Scope Scope Scope Pointer )

            return value;
        }
    }
}
