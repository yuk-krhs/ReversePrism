using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 HasFinally                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 TryHandler                               0001866B4640 ModelClassType TryCatchFinallyHandler TryCatchFinallyHandler TryCatchFinallyHandler Pointer
    public partial class EnterTryCatchFinallyInstruction
    {
        public bool                                     HasFinally                              { get; set; }
        public TryCatchFinallyHandler?                  TryHandler                              { get; set; }

        public static EnterTryCatchFinallyInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnterTryCatchFinallyInstruction();

            value.HasFinally                                = GetBool(new IntPtr(p + 0x018)); // 0270D9FA4578 0x18 HasFinally                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.TryHandler                                = GetObject<TryCatchFinallyHandler>(new IntPtr(p + 0x020), ReversePrism.DataModels.TryCatchFinallyHandler.FromPointer); // 0270D9FA4598 0x20 TryHandler                  ( 0001866B4640 ModelClassType TryCatchFinallyHandler TryCatchFinallyHandler TryCatchFinallyHandler Pointer )

            return value;
        }
    }
}
