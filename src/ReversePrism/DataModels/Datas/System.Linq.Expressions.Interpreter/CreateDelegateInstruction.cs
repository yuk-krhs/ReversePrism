using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Creator                                  000186525C60 ModelClassType LightDelegateCreator LightDelegateCreator LightDelegateCreator Pointer
    public partial class CreateDelegateInstruction
    {
        public LightDelegateCreator?                    Creator                                 { get; set; }

        public static CreateDelegateInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateDelegateInstruction();

            value.Creator                                   = GetObject<LightDelegateCreator>(new IntPtr(p + 0x010), ReversePrism.DataModels.LightDelegateCreator.FromPointer); // 0270DA0387B0 0x10 Creator                     ( 000186525C60 ModelClassType LightDelegateCreator LightDelegateCreator LightDelegateCreator Pointer )

            return value;
        }
    }
}
