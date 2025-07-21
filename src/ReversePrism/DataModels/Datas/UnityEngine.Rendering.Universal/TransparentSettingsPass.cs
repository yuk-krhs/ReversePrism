using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_shouldReceiveShadows                   ModelPrimitiveType bool bool bool Bool
    // 000 m_ProfilerTag                            string IL2CPP_TYPE_STRING
    // 000 m_ProfilingSampler                       ProfilingSampler IL2CPP_TYPE_CLASS
    public partial class TransparentSettingsPass : DataModel
    {
        public bool                                     M_shouldReceiveShadows                  { get; set; }

        public static TransparentSettingsPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransparentSettingsPass() { Pointer= p0 };

            value.M_shouldReceiveShadows                    = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 M_shouldReceiveShadows      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
