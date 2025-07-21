using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DraggedElement                           ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 selectedIds                              IEnumerable`1<int> IL2CPP_TYPE_GENERICINST
    // 020 StartDragArgs                            ModelEnumType StartDragArgs StartDragArgs StartDragArgs Int32
    public partial class SetupDragAndDropArgs : DataModel
    {
        public VisualElement?                           DraggedElement                          { get; set; }
        public StartDragArgs                            StartDragArgs                           { get; set; }

        public static SetupDragAndDropArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetupDragAndDropArgs() { Pointer= p0 };

            value.DraggedElement                            = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 DraggedElement              ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.StartDragArgs                             = (StartDragArgs)GetInt32(new IntPtr(p + 0x020)); // 0x20 StartDragArgs               ( ModelEnumType StartDragArgs StartDragArgs StartDragArgs Int32 )

            return value;
        }
    }
}
