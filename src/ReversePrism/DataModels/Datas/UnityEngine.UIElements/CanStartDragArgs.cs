using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DraggedElement                           0001866B39A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 Id                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 020 selectedIds                              IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    public partial class CanStartDragArgs
    {
        public VisualElement?                           DraggedElement                          { get; set; }
        public int                                      Id                                      { get; set; }

        public static CanStartDragArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CanStartDragArgs();

            value.DraggedElement                            = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 027006755948 0x10 DraggedElement              ( 0001866B39A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 027006755968 0x18 Id                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
