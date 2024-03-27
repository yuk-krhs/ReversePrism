using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProducePolicyView                        0001865657E0 ModelClassType ProducePolicyView ProducePolicyView ProducePolicyView Pointer
    public partial class ProducePolicyBuilder
    {
        public ProducePolicyView?                       ProducePolicyView                       { get; set; }

        public static ProducePolicyBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyBuilder();

            value.ProducePolicyView                         = GetObject<ProducePolicyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducePolicyView.FromPointer); // 0270DB5E7238 0x20 ProducePolicyView           ( 0001865657E0 ModelClassType ProducePolicyView ProducePolicyView ProducePolicyView Pointer )

            return value;
        }
    }
}
