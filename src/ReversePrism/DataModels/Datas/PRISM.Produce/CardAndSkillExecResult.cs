using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExecuteEffectDisplayIDs                  ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 Executor                                 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    // 020 Opponent                                 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    public partial class CardAndSkillExecResult : DataModel
    {
        public List<int>?                               ExecuteEffectDisplayIDs                 { get; set; }
        public InGamePlayerExecActionResult?            Executor                                { get; set; }
        public InGamePlayerExecActionResult?            Opponent                                { get; set; }

        public static CardAndSkillExecResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardAndSkillExecResult() { Pointer= p0 };

            value.ExecuteEffectDisplayIDs                   = GetInt32List(new IntPtr(p + 0x010)); // 0x10 ExecuteEffectDisplayIDs     ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Executor                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0x18 Executor                    ( ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )
            value.Opponent                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0x20 Opponent                    ( ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )

            return value;
        }
    }
}
