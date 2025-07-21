using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                ModelClassType AudienceControllerBehaviour AudienceControllerBehaviour AudienceControllerBehaviour Pointer
    public partial class AudienceControllerClip : DataModel
    {
        public AudienceControllerBehaviour?             Behaviour                               { get; set; }

        public static AudienceControllerClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudienceControllerClip() { Pointer= p0 };

            value.Behaviour                                 = GetObject<AudienceControllerBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.AudienceControllerBehaviour.FromPointer); // 0x18 Behaviour                   ( ModelClassType AudienceControllerBehaviour AudienceControllerBehaviour AudienceControllerBehaviour Pointer )

            return value;
        }
    }
}
