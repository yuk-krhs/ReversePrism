using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ImgSkillIcon                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 028 GoInheritanceIcon                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtSKillDetail                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class SupportSkillContentView : DataModel
    {
        public RawImage?                                ImgSkillIcon                            { get; set; }
        public GameObject?                              GoInheritanceIcon                       { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public UITextMeshProUGUI?                       TxtSKillDetail                          { get; set; }

        public static SupportSkillContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillContentView() { Pointer= p0 };

            value.ImgSkillIcon                              = GetObject<RawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.RawImage.FromPointer); // 024665E1F1F8 0x20 ImgSkillIcon                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.GoInheritanceIcon                         = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024665E1F218 0x28 GoInheritanceIcon           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E1F238 0x30 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSKillDetail                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665E1F258 0x38 TxtSKillDetail              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
