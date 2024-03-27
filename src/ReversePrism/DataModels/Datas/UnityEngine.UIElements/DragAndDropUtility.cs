using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_MakeDragAndDropClientFunc              Func`1<IDragAndDrop> IL2CPP_TYPE_GENERICINST
    // 008 s_DragAndDropEditor                      IDragAndDrop IL2CPP_TYPE_CLASS
    // 010 S_DragAndDropPlayMode                    0001867569C0 ModelClassType IDragAndDrop IDragAndDrop IDragAndDrop Pointer
    public partial class DragAndDropUtility
    {
        public IDragAndDrop?                            S_DragAndDropPlayMode                   { get; set; }

        public static DragAndDropUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DragAndDropUtility();

            value.S_DragAndDropPlayMode                     = GetObject<IDragAndDrop>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDragAndDrop.FromPointer); // 027006753AC8 0x10 S_DragAndDropPlayMode       ( 0001867569C0 ModelClassType IDragAndDrop IDragAndDrop IDragAndDrop Pointer )

            return value;
        }
    }
}
