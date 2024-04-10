using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Reg1                                     00018653F370 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32
    public partial class Linked1CancellationTokenSource : DataModel
    {
        public CancellationTokenRegistration            Reg1                                    { get; set; }

        public static Linked1CancellationTokenSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Linked1CancellationTokenSource() { Pointer= p0 };

            value.Reg1                                      = (CancellationTokenRegistration)GetInt32(new IntPtr(p + 0x040)); // 0245A4AC9EF8 0x40 Reg1                        ( 00018653F370 ModelEnumType CancellationTokenRegistration CancellationTokenRegistration CancellationTokenRegistration Int32 )

            return value;
        }
    }
}
