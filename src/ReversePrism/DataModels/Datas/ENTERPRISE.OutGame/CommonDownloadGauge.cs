using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DownloadUI                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 PercentageText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 IsUIVisible                              ModelPrimitiveType bool bool bool Bool
    // 031 IsInternalVisible                        ModelPrimitiveType bool bool bool Bool
    public partial class CommonDownloadGauge : DataModel
    {
        public GameObject?                              DownloadUI                              { get; set; }
        public UITextMeshProUGUI?                       PercentageText                          { get; set; }
        public bool                                     IsUIVisible                             { get; set; }
        public bool                                     IsInternalVisible                       { get; set; }

        public static CommonDownloadGauge? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonDownloadGauge() { Pointer= p0 };

            value.DownloadUI                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 DownloadUI                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PercentageText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 PercentageText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IsUIVisible                               = GetBool(new IntPtr(p + 0x030)); // 0x30 IsUIVisible                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsInternalVisible                         = GetBool(new IntPtr(p + 0x031)); // 0x31 IsInternalVisible           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
