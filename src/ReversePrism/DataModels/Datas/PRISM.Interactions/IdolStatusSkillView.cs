using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolSkillIconView                        0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 028 VoDaViMeView                             000186532700 ModelClassType VoDaViMeWithAdditionalView VoDaViMeWithAdditionalView VoDaViMeWithAdditionalView Pointer
    // 030 onSkillIconOrder                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolStatusSkillView
    {
        public IdolSkillIconView?                       IdolSkillIconView                       { get; set; }
        public VoDaViMeWithAdditionalView?              VoDaViMeView                            { get; set; }

        public static IdolStatusSkillView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolStatusSkillView();

            value.IdolSkillIconView                         = GetObject<IdolSkillIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0270DA34F298 0x20 IdolSkillIconView           ( 0001866BD790 ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.VoDaViMeView                              = GetObject<VoDaViMeWithAdditionalView>(new IntPtr(p + 0x028), ReversePrism.DataModels.VoDaViMeWithAdditionalView.FromPointer); // 0270DA34F2B8 0x28 VoDaViMeView                ( 000186532700 ModelClassType VoDaViMeWithAdditionalView VoDaViMeWithAdditionalView VoDaViMeWithAdditionalView Pointer )

            return value;
        }
    }
}
