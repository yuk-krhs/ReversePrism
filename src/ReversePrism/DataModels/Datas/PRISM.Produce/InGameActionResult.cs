using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Executor                                 0001866D65D0 ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer
    // 018 Opponent                                 0001866D65D0 ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer
    public partial class InGameActionResult
    {
        public InGamePlayerActionResult?                Executor                                { get; set; }
        public InGamePlayerActionResult?                Opponent                                { get; set; }

        public static InGameActionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameActionResult();

            value.Executor                                  = GetObject<InGamePlayerActionResult>(new IntPtr(p + 0x010), ReversePrism.DataModels.InGamePlayerActionResult.FromPointer); // 0270D5A8D200 0x10 Executor                    ( 0001866D65D0 ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer )
            value.Opponent                                  = GetObject<InGamePlayerActionResult>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGamePlayerActionResult.FromPointer); // 0270D5A8D220 0x18 Opponent                    ( 0001866D65D0 ModelClassType InGamePlayerActionResult InGamePlayerActionResult InGamePlayerActionResult Pointer )

            return value;
        }
    }
}
