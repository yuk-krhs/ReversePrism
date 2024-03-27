using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 InvokeControllerCallback                 0001866792B0 ModelClassType Action Action Action Pointer
    // 058 End2EndActivityTracingEnabled            000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EtwProvider
    {
        public Action?                                  InvokeControllerCallback                { get; set; }
        public bool                                     End2EndActivityTracingEnabled           { get; set; }

        public static EtwProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtwProvider();

            value.InvokeControllerCallback                  = GetObject<Action>(new IntPtr(p + 0x050), ReversePrism.DataModels.Action.FromPointer); // 027004D05A10 0x50 InvokeControllerCallback    ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.End2EndActivityTracingEnabled             = GetBool(new IntPtr(p + 0x058)); // 027004D05A30 0x58 End2EndActivityTracingEnabled ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
