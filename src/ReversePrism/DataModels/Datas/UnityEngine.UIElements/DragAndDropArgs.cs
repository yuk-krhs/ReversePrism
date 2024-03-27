using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <target>k__BackingField                  <object> IL2CPP_TYPE_OBJECT
    // 018 InsertAtIndex                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C ParentId                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ChildIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 DragAndDropPosition                      0001866F4940 ModelEnumType DragAndDropPosition DragAndDropPosition DragAndDropPosition Int32
    // 028 DragAndDropData                          0001866F4480 ModelClassType DragAndDropData DragAndDropData DragAndDropData Pointer
    public partial class DragAndDropArgs
    {
        public int                                      InsertAtIndex                           { get; set; }
        public int                                      ParentId                                { get; set; }
        public int                                      ChildIndex                              { get; set; }
        public DragAndDropPosition                      DragAndDropPosition                     { get; set; }
        public DragAndDropData?                         DragAndDropData                         { get; set; }

        public static DragAndDropArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DragAndDropArgs();

            value.InsertAtIndex                             = GetInt32(new IntPtr(p + 0x018)); // 027006755488 0x18 InsertAtIndex               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParentId                                  = GetInt32(new IntPtr(p + 0x01C)); // 0270067554A8 0x1C ParentId                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ChildIndex                                = GetInt32(new IntPtr(p + 0x020)); // 0270067554C8 0x20 ChildIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DragAndDropPosition                       = (DragAndDropPosition)GetInt32(new IntPtr(p + 0x024)); // 0270067554E8 0x24 DragAndDropPosition         ( 0001866F4940 ModelEnumType DragAndDropPosition DragAndDropPosition DragAndDropPosition Int32 )
            value.DragAndDropData                           = GetObject<DragAndDropData>(new IntPtr(p + 0x028), ReversePrism.DataModels.DragAndDropData.FromPointer); // 027006755508 0x28 DragAndDropData             ( 0001866F4480 ModelClassType DragAndDropData DragAndDropData DragAndDropData Pointer )

            return value;
        }
    }
}
