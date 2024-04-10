using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DelaySign                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class AssemblyDelaySignAttribute : DataModel
    {
        public bool                                     DelaySign                               { get; set; }

        public static AssemblyDelaySignAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyDelaySignAttribute() { Pointer= p0 };

            value.DelaySign                                 = GetBool(new IntPtr(p + 0x010)); // 024666D38960 0x10 DelaySign                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
