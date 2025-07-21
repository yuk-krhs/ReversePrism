using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Executor                                 ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer
    // 018 Opponent                                 ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer
    public partial class InGameActionResult : DataModel
    {
        public InGamePlayerActionResult?                Executor                                { get; set; }
        public InGamePlayerActionResult?                Opponent                                { get; set; }

        public static InGameActionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameActionResult() { Pointer= p0 };

            value.Executor                                  = GetObject<InGamePlayerActionResult>(new IntPtr(p + 0x010), ReversePrism.DataModels.InGamePlayerActionResult.FromPointer); // 0x10 Executor                    ( ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer )
            value.Opponent                                  = GetObject<InGamePlayerActionResult>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGamePlayerActionResult.FromPointer); // 0x18 Opponent                    ( ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer )

            return value;
        }
    }
}
