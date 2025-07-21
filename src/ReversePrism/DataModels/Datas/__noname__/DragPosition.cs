using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InsertAtIndex                            ModelPrimitiveType int int int Int32
    // 014 ParentId                                 ModelPrimitiveType int int int Int32
    // 018 ChildIndex                               ModelPrimitiveType int int int Int32
    // 020 RecycledItem                             ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer
    // 028 DropPosition                             ModelEnumType DragAndDropPosition DragAndDropPosition DragAndDropPosition Int32
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

            value.InsertAtIndex                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 InsertAtIndex               ( ModelPrimitiveType int int int Int32 )
            value.ParentId                                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 ParentId                    ( ModelPrimitiveType int int int Int32 )
            value.ChildIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 ChildIndex                  ( ModelPrimitiveType int int int Int32 )
            value.RecycledItem                              = GetObject<ReusableCollectionItem>(new IntPtr(p + 0x020), ReversePrism.DataModels.ReusableCollectionItem.FromPointer); // 0x20 RecycledItem                ( ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer )
            value.DropPosition                              = (DragAndDropPosition)GetInt32(new IntPtr(p + 0x028)); // 0x28 DropPosition                ( ModelEnumType DragAndDropPosition DragAndDropPosition DragAndDropPosition Int32 )

            return value;
        }
    }
}
