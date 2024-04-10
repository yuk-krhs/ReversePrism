using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reason                                   000186671910 ModelPrimitiveType string string string String
    public partial class ExcludeFromBurstCompatTestingAttribute : DataModel
    {
        public string                                   Reason                                  { get; set; }

        public static ExcludeFromBurstCompatTestingAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExcludeFromBurstCompatTestingAttribute() { Pointer= p0 };

            value.Reason                                    = GetString(new IntPtr(p + 0x010)); // 024669A57260 0x10 Reason                      ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
