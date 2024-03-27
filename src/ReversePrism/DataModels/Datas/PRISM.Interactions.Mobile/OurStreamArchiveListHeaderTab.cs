using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TabButton                                0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ParentOn                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OnText                                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ParentOff                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 OffText                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 SortDown                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 SortUp                                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 058 IsSortDown                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamArchiveListHeaderTab
    {
        public UIButton?                                TabButton                               { get; set; }
        public GameObject?                              ParentOn                                { get; set; }
        public UITextMeshProUGUI?                       OnText                                  { get; set; }
        public GameObject?                              ParentOff                               { get; set; }
        public UITextMeshProUGUI?                       OffText                                 { get; set; }
        public GameObject?                              SortDown                                { get; set; }
        public GameObject?                              SortUp                                  { get; set; }
        public bool                                     IsSortDown                              { get; set; }

        public static OurStreamArchiveListHeaderTab? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamArchiveListHeaderTab();

            value.TabButton                                 = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB166158 0x20 TabButton                   ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ParentOn                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB166178 0x28 ParentOn                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OnText                                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB166198 0x30 OnText                      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ParentOff                                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB1661B8 0x38 ParentOff                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OffText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB1661D8 0x40 OffText                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SortDown                                  = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB1661F8 0x48 SortDown                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SortUp                                    = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB166218 0x50 SortUp                      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsSortDown                                = GetBool(new IntPtr(p + 0x058)); // 0270DB166238 0x58 IsSortDown                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
