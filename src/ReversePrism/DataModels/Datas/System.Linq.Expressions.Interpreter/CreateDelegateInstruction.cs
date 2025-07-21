using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Creator                                  ModelClassType LightDelegateCreator LightDelegateCreator LightDelegateCreator Pointer
    public partial class CreateDelegateInstruction : DataModel
    {
        public LightDelegateCreator?                    Creator                                 { get; set; }

        public static CreateDelegateInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CreateDelegateInstruction() { Pointer= p0 };

            value.Creator                                   = GetObject<LightDelegateCreator>(new IntPtr(p + 0x010), ReversePrism.DataModels.LightDelegateCreator.FromPointer); // 0x10 Creator                     ( ModelClassType LightDelegateCreator LightDelegateCreator LightDelegateCreator Pointer )

            return value;
        }
    }
}
