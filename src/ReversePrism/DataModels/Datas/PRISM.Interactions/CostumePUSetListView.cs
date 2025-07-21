using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtSetName                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 UiGrayOutController                      ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer
    // 030 ImgCostumeParts                          ModelClassListType UIRawImage[] UIRawImage[] List<UIRawImage> Pointer
    // 038 GoEmptyAccessories                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 Buttons                                  ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer
    public partial class CostumePUSetListView : DataModel
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
            var value   = new CostumePUSetListView() { Pointer= p0 };

            value.TxtSetName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtSetName                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UiGrayOutController                       = GetObject<UIGrayOutController>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIGrayOutController.FromPointer); // 0x28 UiGrayOutController         ( ModelClassType UIGrayOutController UIGrayOutController UIGrayOutController Pointer )
            value.ImgCostumeParts                           = GetObjectList<UIRawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x30 ImgCostumeParts             ( ModelClassListType UIRawImage[] UIRawImage[] List<UIRawImage> Pointer )
            value.GoEmptyAccessories                        = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 GoEmptyAccessories          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Buttons                                   = GetObjectList<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 Buttons                     ( ModelClassListType UIButton[] UIButton[] List<UIButton> Pointer )

            return value;
        }
    }
}
