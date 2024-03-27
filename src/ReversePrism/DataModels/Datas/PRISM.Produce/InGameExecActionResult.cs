using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Executor                                 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    // 018 Opponent                                 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    public partial class InGameExecActionResult
    {
        public InGamePlayerExecActionResult?            Executor                                { get; set; }
        public InGamePlayerExecActionResult?            Opponent                                { get; set; }

        public static InGameExecActionResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InGameExecActionResult();

            value.Executor                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x010), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0270D59D4928 0x10 Executor                    ( 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )
            value.Opponent                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0270D59D4948 0x18 Opponent                    ( 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )

            return value;
        }
    }
}
