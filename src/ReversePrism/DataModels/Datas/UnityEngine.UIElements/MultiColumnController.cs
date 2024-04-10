using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_BoundColumnVePropertyName              PropertyName IL2CPP_TYPE_VALUETYPE
    // 004 bindableElementPropertyName              PropertyName IL2CPP_TYPE_VALUETYPE
    // 008 baseUssClassName                         string IL2CPP_TYPE_STRING
    // 010 K_HeaderContainerViewDataKey             0001866738F0 ModelPrimitiveType string string string String
    // 018 HeaderContainerUssClassName              000186674040 ModelPrimitiveType string string string String
    // 020 RowContainerUssClassName                 000186674040 ModelPrimitiveType string string string String
    // 028 CellUssClassName                         000186674040 ModelPrimitiveType string string string String
    // 030 CellLabelUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 038 K_HeaderViewDataKey                      0001866738F0 ModelPrimitiveType string string string String
    // 010 ColumnSortingChanged                     0001866792B0 ModelClassType Action Action Action Pointer
    // 018 headerContextMenuPopulateEvent           Action`2<ContextualMenuPopulateEvent, Column> IL2CPP_TYPE_GENERICINST
    // 020 M_View                                   000186745380 ModelClassType BaseVerticalCollectionView BaseVerticalCollectionView BaseVerticalCollectionView Pointer
    // 028 M_HeaderContainer                        0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 030 M_MultiColumnHeader                      00018665DB30 ModelClassType MultiColumnCollectionHeader MultiColumnCollectionHeader MultiColumnCollectionHeader Pointer
    public partial class MultiColumnController : DataModel
    {
        public string                                   K_HeaderContainerViewDataKey            { get; set; }
        public string                                   HeaderContainerUssClassName             { get; set; }
        public string                                   RowContainerUssClassName                { get; set; }
        public string                                   CellUssClassName                        { get; set; }
        public string                                   CellLabelUssClassName                   { get; set; }
        public string                                   K_HeaderViewDataKey                     { get; set; }
        public Action?                                  ColumnSortingChanged                    { get; set; }
        public BaseVerticalCollectionView?              M_View                                  { get; set; }
        public VisualElement?                           M_HeaderContainer                       { get; set; }
        public MultiColumnCollectionHeader?             M_MultiColumnHeader                     { get; set; }

        public static MultiColumnController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnController() { Pointer= p0 };

            value.K_HeaderContainerViewDataKey              = GetString(new IntPtr(p + 0x010)); // 0245A66EB680 0x10 K_HeaderContainerViewDataKey ( 0001866738F0 ModelPrimitiveType string string string String )
            value.HeaderContainerUssClassName               = GetString(new IntPtr(p + 0x018)); // 0245A66EB6A0 0x18 HeaderContainerUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.RowContainerUssClassName                  = GetString(new IntPtr(p + 0x020)); // 0245A66EB6C0 0x20 RowContainerUssClassName    ( 000186674040 ModelPrimitiveType string string string String )
            value.CellUssClassName                          = GetString(new IntPtr(p + 0x028)); // 0245A66EB6E0 0x28 CellUssClassName            ( 000186674040 ModelPrimitiveType string string string String )
            value.CellLabelUssClassName                     = GetString(new IntPtr(p + 0x030)); // 0245A66EB700 0x30 CellLabelUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.K_HeaderViewDataKey                       = GetString(new IntPtr(p + 0x038)); // 0245A66EB720 0x38 K_HeaderViewDataKey         ( 0001866738F0 ModelPrimitiveType string string string String )
            value.ColumnSortingChanged                      = GetObject<Action>(new IntPtr(p + 0x010), ReversePrism.DataModels.Action.FromPointer); // 0245A66EB740 0x10 ColumnSortingChanged        ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_View                                    = GetObject<BaseVerticalCollectionView>(new IntPtr(p + 0x020), ReversePrism.DataModels.BaseVerticalCollectionView.FromPointer); // 0245A66EB780 0x20 M_View                      ( 000186745380 ModelClassType BaseVerticalCollectionView BaseVerticalCollectionView BaseVerticalCollectionView Pointer )
            value.M_HeaderContainer                         = GetObject<VisualElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66EB7A0 0x28 M_HeaderContainer           ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_MultiColumnHeader                       = GetObject<MultiColumnCollectionHeader>(new IntPtr(p + 0x030), ReversePrism.DataModels.MultiColumnCollectionHeader.FromPointer); // 0245A66EB7C0 0x30 M_MultiColumnHeader         ( 00018665DB30 ModelClassType MultiColumnCollectionHeader MultiColumnCollectionHeader MultiColumnCollectionHeader Pointer )

            return value;
        }
    }
}
