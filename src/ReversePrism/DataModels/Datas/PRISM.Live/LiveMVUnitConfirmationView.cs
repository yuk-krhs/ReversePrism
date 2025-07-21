using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 ToggleRenderingDynamicRangeButton        ModelClassType UIButton UIButton UIButton Pointer
    // 060 RenderingDynamicRangeTexts               ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class LiveMVUnitConfirmationView : DataModel
    {
        public UIButton?                                ToggleRenderingDynamicRangeButton       { get; set; }
        public List<GameObject>?                        RenderingDynamicRangeTexts              { get; set; }

        public static LiveMVUnitConfirmationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationView() { Pointer= p0 };

            value.ToggleRenderingDynamicRangeButton         = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 ToggleRenderingDynamicRangeButton ( ModelClassType UIButton UIButton UIButton Pointer )
            value.RenderingDynamicRangeTexts                = GetObjectList<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 RenderingDynamicRangeTexts  ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
