using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseKindFlags                             ModelEnumType ImplicitUseKindFlags ImplicitUseKindFlags ImplicitUseKindFlags Int32
    // 014 TargetFlags                              ModelEnumType ImplicitUseTargetFlags ImplicitUseTargetFlags ImplicitUseTargetFlags Int32
    public partial class UsedImplicitlyAttribute : DataModel
    {
        public ImplicitUseKindFlags                     UseKindFlags                            { get; set; }
        public ImplicitUseTargetFlags                   TargetFlags                             { get; set; }

        public static UsedImplicitlyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsedImplicitlyAttribute() { Pointer= p0 };

            value.UseKindFlags                              = (ImplicitUseKindFlags)GetInt32(new IntPtr(p + 0x010)); // 0x10 UseKindFlags                ( ModelEnumType ImplicitUseKindFlags ImplicitUseKindFlags ImplicitUseKindFlags Int32 )
            value.TargetFlags                               = (ImplicitUseTargetFlags)GetInt32(new IntPtr(p + 0x014)); // 0x14 TargetFlags                 ( ModelEnumType ImplicitUseTargetFlags ImplicitUseTargetFlags ImplicitUseTargetFlags Int32 )

            return value;
        }
    }
}
