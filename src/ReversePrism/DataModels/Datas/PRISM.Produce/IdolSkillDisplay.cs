using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IconBase                                 0001866BCF80 ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer
    public partial class IdolSkillDisplay
    {
        public IdolSkillIcon?                           IconBase                                { get; set; }

        public static IdolSkillDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDisplay();

            value.IconBase                                  = GetObject<IdolSkillIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIcon.FromPointer); // 0270D5C7C578 0x28 IconBase                    ( 0001866BCF80 ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer )

            return value;
        }
    }
}
