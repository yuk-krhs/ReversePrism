using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsSkipIdolSkillCutIn                     000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceIngameViewModel
    {
        public bool                                     IsSkipIdolSkillCutIn                    { get; set; }

        public static ProduceIngameViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIngameViewModel();

            value.IsSkipIdolSkillCutIn                      = GetBool(new IntPtr(p + 0x010)); // 0270D507CE90 0x10 IsSkipIdolSkillCutIn        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
