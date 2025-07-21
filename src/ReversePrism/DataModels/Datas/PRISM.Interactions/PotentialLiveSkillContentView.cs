using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgIcon                                  ModelClassType RawImage RawImage RawImage Pointer
    // 028 BtnIcon                                  ModelClassType UIButton UIButton UIButton Pointer
    // 030 TxtSkillName                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtLv                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtSkillDetail                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 PotentialLiveSkillEffectViews            ModelClassListType PotentialLiveSkillEffectView[] PotentialLiveSkillEffectView[] List<PotentialLiveSkillEffectView> Pointer
    // 050 onLiveSkillDetail                        Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class PotentialLiveSkillContentView : DataModel
    {
        public RawImage?                                ImgIcon                                 { get; set; }
        public UIButton?                                BtnIcon                                 { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public UITextMeshProUGUI?                       TxtLv                                   { get; set; }
        public UITextMeshProUGUI?                       TxtSkillDetail                          { get; set; }
        public List<PotentialLiveSkillEffectView>?      PotentialLiveSkillEffectViews           { get; set; }

        public static PotentialLiveSkillContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialLiveSkillContentView() { Pointer= p0 };

            value.ImgIcon                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 0x20 ImgIcon                     ( ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnIcon                                   = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 BtnIcon                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtSkillName                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtLv                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSkillDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtSkillDetail              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PotentialLiveSkillEffectViews             = GetObjectList<PotentialLiveSkillEffectView>(new IntPtr(p + 0x048), ReversePrism.DataModels.PotentialLiveSkillEffectView.FromPointer); // 0x48 PotentialLiveSkillEffectViews ( ModelClassListType PotentialLiveSkillEffectView[] PotentialLiveSkillEffectView[] List<PotentialLiveSkillEffectView> Pointer )

            return value;
        }
    }
}
