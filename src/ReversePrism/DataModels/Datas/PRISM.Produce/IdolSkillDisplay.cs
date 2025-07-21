using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 IconBase                                 ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer
    public partial class IdolSkillDisplay : DataModel
    {
        public IdolSkillIcon?                           IconBase                                { get; set; }

        public static IdolSkillDisplay? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDisplay() { Pointer= p0 };

            value.IconBase                                  = GetObject<IdolSkillIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIcon.FromPointer); // 0x28 IconBase                    ( ModelClassType IdolSkillIcon IdolSkillIcon IdolSkillIcon Pointer )

            return value;
        }
    }
}
