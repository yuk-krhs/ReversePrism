using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Executor                                 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    // 018 Opponent                                 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    public partial class InGameExecActionResult : DataModel
    {
        public InGamePlayerExecActionResult?            Executor                                { get; set; }
        public InGamePlayerExecActionResult?            Opponent                                { get; set; }

        public static InGameExecActionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameExecActionResult() { Pointer= p0 };

            value.Executor                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x010), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0x10 Executor                    ( ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )
            value.Opponent                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0x18 Opponent                    ( ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )

            return value;
        }
    }
}
