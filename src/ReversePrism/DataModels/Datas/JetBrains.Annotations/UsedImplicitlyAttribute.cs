using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseKindFlags                             0001866D1310 ModelEnumType ImplicitUseKindFlags ImplicitUseKindFlags ImplicitUseKindFlags Int32
    // 014 TargetFlags                              0001866D1AA0 ModelEnumType ImplicitUseTargetFlags ImplicitUseTargetFlags ImplicitUseTargetFlags Int32
    public partial class UsedImplicitlyAttribute
    {
        public ImplicitUseKindFlags                     UseKindFlags                            { get; set; }
        public ImplicitUseTargetFlags                   TargetFlags                             { get; set; }

        public static UsedImplicitlyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UsedImplicitlyAttribute();

            value.UseKindFlags                              = (ImplicitUseKindFlags)GetInt32(new IntPtr(p + 0x010)); // 0270068A6318 0x10 UseKindFlags                ( 0001866D1310 ModelEnumType ImplicitUseKindFlags ImplicitUseKindFlags ImplicitUseKindFlags Int32 )
            value.TargetFlags                               = (ImplicitUseTargetFlags)GetInt32(new IntPtr(p + 0x014)); // 0270068A6338 0x14 TargetFlags                 ( 0001866D1AA0 ModelEnumType ImplicitUseTargetFlags ImplicitUseTargetFlags ImplicitUseTargetFlags Int32 )

            return value;
        }
    }
}
