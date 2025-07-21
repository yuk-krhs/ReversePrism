using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Active                                 ModelPrimitiveType bool bool bool Bool
    public partial class ScriptableRendererFeature : DataModel
    {
        public bool                                     M_Active                                { get; set; }

        public static ScriptableRendererFeature? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptableRendererFeature() { Pointer= p0 };

            value.M_Active                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 M_Active                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
