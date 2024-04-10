using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InsertAtIndex                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ParentId                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ChildIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 RecycledItem                             000186679EE0 ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer
    // 028 DropPosition                             0001866F4B90 ModelEnumType DragAndDropPosition DragAndDropPosition DragAndDropPosition Int32
    public partial class DragPosition : DataModel
    {
        public int                                      InsertAtIndex                           { get; set; }
        public int                                      ParentId                                { get; set; }
        public int                                      ChildIndex                              { get; set; }
        public ReusableCollectionItem?                  RecycledItem                            { get; set; }
        public DragAndDropPosition                      DropPosition                            { get; set; }

        public static DragPosition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DragPosition() { Pointer= p0 };

            value.InsertAtIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0245A6718118 0x10 InsertAtIndex               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ParentId                                  = GetInt32(new IntPtr(p + 0x014)); // 0245A6718138 0x14 ParentId                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ChildIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0245A6718158 0x18 ChildIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.RecycledItem                              = GetObject<ReusableCollectionItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ReusableCollectionItem.FromPointer); // 0245A6718178 0x20 RecycledItem                ( 000186679EE0 ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer )
            value.DropPosition                              = (DragAndDropPosition)GetInt32(new IntPtr(p + 0x028)); // 0245A6718198 0x28 DropPosition                ( 0001866F4B90 ModelEnumType DragAndDropPosition DragAndDropPosition DragAndDropPosition Int32 )

            return value;
        }
    }
}
