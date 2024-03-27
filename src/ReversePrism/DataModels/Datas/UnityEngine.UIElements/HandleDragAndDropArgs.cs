using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DragAndDropArgs                        0001866F3F80 ModelEnumType DragAndDropArgs DragAndDropArgs DragAndDropArgs Int32
    // 030 Position                                 0001866A9350 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class HandleDragAndDropArgs
    {
        public DragAndDropArgs                          M_DragAndDropArgs                       { get; set; }
        public Vector2                                  Position                                { get; set; }

        public static HandleDragAndDropArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HandleDragAndDropArgs();

            value.M_DragAndDropArgs                         = (DragAndDropArgs)GetInt32(new IntPtr(p + 0x010)); // 027006755F40 0x10 M_DragAndDropArgs           ( 0001866F3F80 ModelEnumType DragAndDropArgs DragAndDropArgs DragAndDropArgs Int32 )
            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 027006755F60 0x30 Position                    ( 0001866A9350 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
