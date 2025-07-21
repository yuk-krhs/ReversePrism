using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 InvokeControllerCallback                 ModelClassType Action Action Action Pointer
    // 058 End2EndActivityTracingEnabled            ModelPrimitiveType bool bool bool Bool
    public partial class EtwProvider : DataModel
    {
        public Action?                                  InvokeControllerCallback                { get; set; }
        public bool                                     End2EndActivityTracingEnabled           { get; set; }

        public static EtwProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtwProvider() { Pointer= p0 };

            value.InvokeControllerCallback                  = GetObject<Action>(new IntPtr(p + 0x050), ReversePrism.DataModels.Action.FromPointer); // 0x50 InvokeControllerCallback    ( ModelClassType Action Action Action Pointer )
            value.End2EndActivityTracingEnabled             = GetBool(new IntPtr(p + 0x058)); // 0x58 End2EndActivityTracingEnabled ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
