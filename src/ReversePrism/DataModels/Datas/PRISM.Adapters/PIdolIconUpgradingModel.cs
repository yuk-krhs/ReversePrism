using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CanAwaken                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 CanTraining                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 012 CanSkillLvUp                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PIdolIconUpgradingModel : DataModel
    {
        public bool                                     CanAwaken                               { get; set; }
        public bool                                     CanTraining                             { get; set; }
        public bool                                     CanSkillLvUp                            { get; set; }

        public static PIdolIconUpgradingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolIconUpgradingModel() { Pointer= p0 };

            value.CanAwaken                                 = GetBool(new IntPtr(p + 0x010)); // 02466618F9B8 0x10 CanAwaken                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanTraining                               = GetBool(new IntPtr(p + 0x011)); // 02466618F9D8 0x11 CanTraining                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanSkillLvUp                              = GetBool(new IntPtr(p + 0x012)); // 02466618F9F8 0x12 CanSkillLvUp                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
