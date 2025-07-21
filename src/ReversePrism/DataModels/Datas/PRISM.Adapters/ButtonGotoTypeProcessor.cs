using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ButtonGotoTypeReference                  ModelClassType IButtonGotoTypeReference IButtonGotoTypeReference IButtonGotoTypeReference Pointer
    public partial class ButtonGotoTypeProcessor : DataModel
    {
        public IButtonGotoTypeReference?                ButtonGotoTypeReference                 { get; set; }

        public static ButtonGotoTypeProcessor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonGotoTypeProcessor() { Pointer= p0 };

            value.ButtonGotoTypeReference                   = GetObject<IButtonGotoTypeReference>(new IntPtr(p + 0x010), ReversePrism.DataModels.IButtonGotoTypeReference.FromPointer); // 0x10 ButtonGotoTypeReference     ( ModelClassType IButtonGotoTypeReference IButtonGotoTypeReference IButtonGotoTypeReference Pointer )

            return value;
        }
    }
}
