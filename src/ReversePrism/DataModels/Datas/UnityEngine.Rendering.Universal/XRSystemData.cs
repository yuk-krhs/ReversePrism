using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Shaders                                  ModelClassType ShaderResources ShaderResources ShaderResources Pointer
    public partial class XRSystemData : DataModel
    {
        public ShaderResources?                         Shaders                                 { get; set; }

        public static XRSystemData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XRSystemData() { Pointer= p0 };

            value.Shaders                                   = GetObject<ShaderResources>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShaderResources.FromPointer); // 0x18 Shaders                     ( ModelClassType ShaderResources ShaderResources ShaderResources Pointer )

            return value;
        }
    }
}
