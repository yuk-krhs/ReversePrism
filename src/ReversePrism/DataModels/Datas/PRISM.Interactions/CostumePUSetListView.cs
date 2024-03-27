using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtSetName                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 UiGrayOutController                      0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 030 ImgCostumeParts                          000185CAE068 ModelClassListType UIRawImage[] UIRawImage[] List<UIRawImage> Pointer
    // 038 GoEmptyAccessories                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 Buttons                                  000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    public partial class CostumePUSetListView
    {
        public UITextMeshProUGUI?                       TxtSetName                              { get; set; }
        public UIGrayOutController?                     UiGrayOutController                     { get; set; }
        public List<UIRawImage>?                        ImgCostumeParts                         { get; set; }
        public List<GameObject>?                        GoEmptyAccessories                      { get; set; }
        public List<UIButton>?                          Buttons                                 { get; set; }

        public static CostumePUSetListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePUSetListView();

            value.TxtSetName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A6E38 0x20 TxtSetName                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UiGrayOutController                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0270DA2A6E58 0x28 UiGrayOutController         ( 0001866EA450 ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.ImgCostumeParts                           = GetObjectList<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA2A6E78 0x30 ImgCostumeParts             ( 000185CAE068 ModelClassListType UIRawImage[] UIRawImage[] List<UIRawImage> Pointer )
            value.GoEmptyAccessories                        = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA2A6E98 0x38 GoEmptyAccessories          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Buttons                                   = GetObjectList<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA2A6EB8 0x40 Buttons                     ( 000185CADC58 ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )

            return value;
        }
    }
}
