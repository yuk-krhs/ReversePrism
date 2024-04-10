using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   0001866AADB0 ModelClassType Transform Transform Transform Pointer
    public partial class AsChildInstantiator : DataModel
    {
        public Transform?                               Parent                                  { get; set; }

        public static AsChildInstantiator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsChildInstantiator() { Pointer= p0 };

            value.Parent                                    = GetObject<Transform>(new IntPtr(p + 0x010), ReversePrism.DataModels.Transform.FromPointer); // 02466B5D3E40 0x10 Parent                      ( 0001866AADB0 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
