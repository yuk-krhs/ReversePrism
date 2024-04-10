using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 M_DragStartIndex                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C M_CurrentIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 M_SelectionHeight                        0001866656B0 ModelPrimitiveType float float float Single
    // 084 M_LocalOffsetOnStart                     0001866656B0 ModelPrimitiveType float float float Single
    // 088 M_CurrentPointerPosition                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 098 M_Item                                   000186679C70 ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer
    // 0A0 M_OffsetItem                             000186679C70 ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer
    // 0A8 IsDragging                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ListViewDraggerAnimated : DataModel
    {
        public int                                      M_DragStartIndex                        { get; set; }
        public int                                      M_CurrentIndex                          { get; set; }
        public float                                    M_SelectionHeight                       { get; set; }
        public float                                    M_LocalOffsetOnStart                    { get; set; }
        public Vector3                                  M_CurrentPointerPosition                { get; set; }
        public ReusableCollectionItem?                  M_Item                                  { get; set; }
        public ReusableCollectionItem?                  M_OffsetItem                            { get; set; }
        public bool                                     IsDragging                              { get; set; }

        public static ListViewDraggerAnimated? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListViewDraggerAnimated() { Pointer= p0 };

            value.M_DragStartIndex                          = GetInt32(new IntPtr(p + 0x078)); // 0245A6719250 0x78 M_DragStartIndex            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_CurrentIndex                            = GetInt32(new IntPtr(p + 0x07C)); // 0245A6719270 0x7C M_CurrentIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SelectionHeight                         = GetSingle(new IntPtr(p + 0x080)); // 0245A6719290 0x80 M_SelectionHeight           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_LocalOffsetOnStart                      = GetSingle(new IntPtr(p + 0x084)); // 0245A67192B0 0x84 M_LocalOffsetOnStart        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_CurrentPointerPosition                  = (Vector3)GetInt32(new IntPtr(p + 0x088)); // 0245A67192D0 0x88 M_CurrentPointerPosition    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_Item                                    = GetObject<ReusableCollectionItem>(new IntPtr(p + 0x098), ReversePrism.DataModels.ReusableCollectionItem.FromPointer); // 0245A67192F0 0x98 M_Item                      ( 000186679C70 ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer )
            value.M_OffsetItem                              = GetObject<ReusableCollectionItem>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ReusableCollectionItem.FromPointer); // 0245A6719310 0xA0 M_OffsetItem                ( 000186679C70 ModelClassType ReusableCollectionItem ReusableCollectionItem ReusableCollectionItem Pointer )
            value.IsDragging                                = GetBool(new IntPtr(p + 0x0A8)); // 0245A6719330 0xA8 IsDragging                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
