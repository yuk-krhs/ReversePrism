using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IconView                                 ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer
    // 028 IdolSkillIcon                            ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer
    // 030 LiveSkillIcon                            ModelClassType RawImage RawImage RawImage Pointer
    // 038 BtnLiveSkillIcon                         ModelClassType UIButton UIButton UIButton Pointer
    // 040 LiveSkillLvText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 VoDaViMeRankView                         ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer
    // 050 onFIdolDetail                            Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 058 onLiveSkillDetail                        Subject`1<LiveSkillViewModel> IL2CPP_TYPE_GENERICINST
    public partial class UnitMemberView : DataModel
    {
        public PFIdolIconView?                          IconView                                { get; set; }
        public IdolSkillIconView?                       IdolSkillIcon                           { get; set; }
        public RawImage?                                LiveSkillIcon                           { get; set; }
        public UIButton?                                BtnLiveSkillIcon                        { get; set; }
        public UITextMeshProUGUI?                       LiveSkillLvText                         { get; set; }
        public VoDaViMeRankView?                        VoDaViMeRankView                        { get; set; }

        public static UnitMemberView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitMemberView() { Pointer= p0 };

            value.IconView                                  = GetObject<PFIdolIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.PFIdolIconView.FromPointer); // 0x20 IconView                    ( ModelClassType PFIdolIconView PFIdolIconView PFIdolIconView Pointer )
            value.IdolSkillIcon                             = GetObject<IdolSkillIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillIconView.FromPointer); // 0x28 IdolSkillIcon               ( ModelClassType IdolSkillIconView IdolSkillIconView IdolSkillIconView Pointer )
            value.LiveSkillIcon                             = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0x30 LiveSkillIcon               ( ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnLiveSkillIcon                          = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 BtnLiveSkillIcon            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.LiveSkillLvText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 LiveSkillLvText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoDaViMeRankView                          = GetObject<VoDaViMeRankView>(new IntPtr(p + 0x048), ReversePrism.DataModels.VoDaViMeRankView.FromPointer); // 0x48 VoDaViMeRankView            ( ModelClassType VoDaViMeRankView VoDaViMeRankView VoDaViMeRankView Pointer )

            return value;
        }
    }
}
