using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExecuteEffectDisplayIDs                  000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 018 Executor                                 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    // 020 Opponent                                 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer
    public partial class CardAndSkillExecResult
    {
        public List<int>?                               ExecuteEffectDisplayIDs                 { get; set; }
        public InGamePlayerExecActionResult?            Executor                                { get; set; }
        public InGamePlayerExecActionResult?            Opponent                                { get; set; }

        public static CardAndSkillExecResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CardAndSkillExecResult();

            value.ExecuteEffectDisplayIDs                   = GetInt32List(new IntPtr(p + 0x010)); // 0270D59BC658 0x10 ExecuteEffectDisplayIDs     ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Executor                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x018), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0270D59BC678 0x18 Executor                    ( 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )
            value.Opponent                                  = GetObject<InGamePlayerExecActionResult>(new IntPtr(p + 0x020), ReversePrism.DataModels.InGamePlayerExecActionResult.FromPointer); // 0270D59BC698 0x20 Opponent                    ( 0001866D6F30 ModelClassType InGamePlayerExecActionResult InGamePlayerExecActionResult InGamePlayerExecActionResult Pointer )

            return value;
        }
    }
}
