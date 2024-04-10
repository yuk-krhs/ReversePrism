using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgIcon                                  000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 BtnIcon                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 030 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtLv                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtSkillDetail                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 PotentialLiveSkillEffectViews            000185B9BF00 ModelClassListType PotentialLiveSkillEffectView[] PotentialLiveSkillEffectView[] List<PotentialLiveSkillEffectView> Pointer
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

            value.ImgIcon                                   = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 02466A382438 0x20 ImgIcon                     ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.BtnIcon                                   = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 02466A382458 0x28 BtnIcon                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A382478 0x30 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtLv                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A382498 0x38 TxtLv                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSkillDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3824B8 0x40 TxtSkillDetail              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PotentialLiveSkillEffectViews             = GetObjectList<PotentialLiveSkillEffectView>(new IntPtr(p + 0x048), ReversePrism.DataModels.PotentialLiveSkillEffectView.FromPointer); // 02466A3824D8 0x48 PotentialLiveSkillEffectViews ( 000185B9BF00 ModelClassListType PotentialLiveSkillEffectView[] PotentialLiveSkillEffectView[] List<PotentialLiveSkillEffectView> Pointer )

            return value;
        }
    }
}
