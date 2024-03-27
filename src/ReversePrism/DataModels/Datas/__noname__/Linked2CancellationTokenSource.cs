using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Reg1                                     00018653F370 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    // 058 Reg2                                     00018653F370 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    public partial class Linked2CancellationTokenSource
    {
        public CancellationTokenRegistration            Reg1                                    { get; set; }
        public CancellationTokenRegistration            Reg2                                    { get; set; }

        public static Linked2CancellationTokenSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Linked2CancellationTokenSource();

            value.Reg1                                      = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x040)); // 027004E2DE40 0x40 Reg1                        ( 00018653F370 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )
            value.Reg2                                      = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x058)); // 027004E2DE60 0x58 Reg2                        ( 00018653F370 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
