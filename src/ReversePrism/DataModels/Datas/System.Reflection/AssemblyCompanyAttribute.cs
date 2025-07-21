using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Company                                  ModelPrimitiveType string string string String
    public partial class AssemblyCompanyAttribute : DataModel
    {
        public string                                   Company                                 { get; set; }

        public static AssemblyCompanyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssemblyCompanyAttribute() { Pointer= p0 };

            value.Company                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Company                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
