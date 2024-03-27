using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSetup                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ApplicationDataManager
    {
        public bool                                     IsSetup                                 { get; set; }

        public static ApplicationDataManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ApplicationDataManager();

            value.IsSetup                                   = GetBool(new IntPtr(p + 0x010)); // 0270D0E85530 0x10 IsSetup                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
