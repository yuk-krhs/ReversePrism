using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OnDispose                                0001866792B0 ModelClassType Action Action Action Pointer
    // 018 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DisposableAction : DataModel
    {
        public Action?                                  OnDispose                               { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static DisposableAction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DisposableAction() { Pointer= p0 };

            value.OnDispose                                 = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 02466BD5F370 0x10 OnDispose                   ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x018)); // 02466BD5F390 0x18 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
