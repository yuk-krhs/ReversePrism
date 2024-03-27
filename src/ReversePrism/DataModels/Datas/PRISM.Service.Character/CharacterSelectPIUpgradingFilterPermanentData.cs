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
    public partial class CharacterSelectPIUpgradingFilterPermanentData
    {
        public bool                                     CanAwaken                               { get; set; }
        public bool                                     CanTraining                             { get; set; }
        public bool                                     CanSkillLvUp                            { get; set; }

        public static CharacterSelectPIUpgradingFilterPermanentData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectPIUpgradingFilterPermanentData();

            value.CanAwaken                                 = GetBool(new IntPtr(p + 0x010)); // 027003A6BEA8 0x10 CanAwaken                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanTraining                               = GetBool(new IntPtr(p + 0x011)); // 027003A6BEC8 0x11 CanTraining                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CanSkillLvUp                              = GetBool(new IntPtr(p + 0x012)); // 027003A6BEE8 0x12 CanSkillLvUp                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
