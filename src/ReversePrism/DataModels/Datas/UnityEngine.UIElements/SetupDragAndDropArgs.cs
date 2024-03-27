using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DraggedElement                           0001866B39A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 selectedIds                              IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 020 StartDragArgs                            000186570E90 ModelEnumType StartDragArgs StartDragArgs StartDragArgs Int32
    public partial class SetupDragAndDropArgs
    {
        public VisualElement?                           DraggedElement                          { get; set; }
        public StartDragArgs                            StartDragArgs                           { get; set; }

        public static SetupDragAndDropArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetupDragAndDropArgs();

            value.DraggedElement                            = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 027006755A20 0x10 DraggedElement              ( 0001866B39A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.StartDragArgs                             = (StartDragArgs)GetInt32(new IntPtr(p + 0x020)); // 027006755A60 0x20 StartDragArgs               ( 000186570E90 ModelEnumType StartDragArgs StartDragArgs StartDragArgs Int32 )

            return value;
        }
    }
}
