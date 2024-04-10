using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 AdvUI                                    000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer
    // 098 IsAlreadyDisplayedHowToPlay              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProducePolicyConnector : DataModel
    {
        public ADVUI?                                   AdvUI                                   { get; set; }
        public bool                                     IsAlreadyDisplayedHowToPlay             { get; set; }

        public static ProducePolicyConnector? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePolicyConnector() { Pointer= p0 };

            value.AdvUI                                     = GetObject<ADVUI>(new IntPtr(p + 0x090), ReversePrism.DataModels.ADVUI.FromPointer); // 02466A1D5230 0x90 AdvUI                       ( 000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer )
            value.IsAlreadyDisplayedHowToPlay               = GetBool(new IntPtr(p + 0x098)); // 02466A1D5250 0x98 IsAlreadyDisplayedHowToPlay ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
