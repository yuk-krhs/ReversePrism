using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 columnContainerUssClassName              string IL2CPP_TYPE_STRING
    // 010 HandleContainerUssClassName              000186674040 ModelPrimitiveType string string string String
    // 018 ReorderableUssClassName                  000186674040 ModelPrimitiveType string string string String
    // 3C8 M_SortingEnabled                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3D0 M_SortedColumns                          000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer
    // 3D8 M_OldSortedColumnStates                  000185D27278 ModelEnumListType List`1<SortedColumnState> List`1<SortedColumnState> List<SortedColumnState> Pointer
    // 3E0 M_SortingUpdatesTemporarilyDisabled      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3E8 M_ViewState                              00018675EED0 ModelClassType ViewState ViewState ViewState Pointer
    // 3F0 M_ApplyingViewState                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3F1 M_DoLayoutScheduled                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 3F8 <columnDataMap>k__BackingField           Dictionary`2<Column, ColumnData> IL2CPP_TYPE_GENERICINST
    // 400 ColumnLayout                             0001865D6A70 ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer
    // 408 ColumnContainer                          0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 410 ResizeHandleContainer                    0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 418 SortDescriptions                         00018652E0F0 ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer
    // 420 Columns                                  0001865D7AD0 ModelClassType Columns Columns Columns Pointer
    // 428 columnResized                            Action`2<int, float> IL2CPP_TYPE_GENERICINST
    // 430 ColumnSortingChanged                     0001866792B0 ModelClassType Action Action Action Pointer
    // 438 contextMenuPopulateEvent                 Action`2<ContextualMenuPopulateEvent, Column> IL2CPP_TYPE_GENERICINST
    // 440 ViewDataRestored                         0001866792B0 ModelClassType Action Action Action Pointer
    public partial class MultiColumnCollectionHeader : DataModel
    {
        public string                                   HandleContainerUssClassName             { get; set; }
        public string                                   ReorderableUssClassName                 { get; set; }
        public bool                                     M_SortingEnabled                        { get; set; }
        public List<SortColumnDescription>?             M_SortedColumns                         { get; set; }
        public List<SortedColumnState>?                 M_OldSortedColumnStates                 { get; set; }
        public bool                                     M_SortingUpdatesTemporarilyDisabled     { get; set; }
        public ViewState?                               M_ViewState                             { get; set; }
        public bool                                     M_ApplyingViewState                     { get; set; }
        public bool                                     M_DoLayoutScheduled                     { get; set; }
        public ColumnLayout?                            ColumnLayout                            { get; set; }
        public VisualElement?                           ColumnContainer                         { get; set; }
        public VisualElement?                           ResizeHandleContainer                   { get; set; }
        public SortColumnDescriptions?                  SortDescriptions                        { get; set; }
        public Columns?                                 Columns                                 { get; set; }
        public Action?                                  ColumnSortingChanged                    { get; set; }
        public Action?                                  ViewDataRestored                        { get; set; }

        public static MultiColumnCollectionHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnCollectionHeader() { Pointer= p0 };

            value.HandleContainerUssClassName               = GetString(new IntPtr(p + 0x010)); // 0245A6862240 0x10 HandleContainerUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ReorderableUssClassName                   = GetString(new IntPtr(p + 0x018)); // 0245A6862260 0x18 ReorderableUssClassName     ( 000186674040 ModelPrimitiveType string string string String )
            value.M_SortingEnabled                          = GetBool(new IntPtr(p + 0x3C8)); // 0245A6862280 0x3C8 M_SortingEnabled            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SortedColumns                           = GetObjectList<SortColumnDescription>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.SortColumnDescription.FromPointer); // 0245A68622A0 0x3D0 M_SortedColumns             ( 000185D0A908 ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer )
            value.M_OldSortedColumnStates                   = GetEnumList<SortedColumnState>(new IntPtr(p + 0x3D8)); // 0245A68622C0 0x3D8 M_OldSortedColumnStates     ( 000185D27278 ModelEnumListType List`1<SortedColumnState> List`1<SortedColumnState> List<SortedColumnState> Pointer )
            value.M_SortingUpdatesTemporarilyDisabled       = GetBool(new IntPtr(p + 0x3E0)); // 0245A68622E0 0x3E0 M_SortingUpdatesTemporarilyDisabled ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ViewState                               = GetObject<ViewState>(new IntPtr(p + 0x3E8), ReversePrism.DataModels.ViewState.FromPointer); // 0245A6862300 0x3E8 M_ViewState                 ( 00018675EED0 ModelClassType ViewState ViewState ViewState Pointer )
            value.M_ApplyingViewState                       = GetBool(new IntPtr(p + 0x3F0)); // 0245A6862320 0x3F0 M_ApplyingViewState         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DoLayoutScheduled                       = GetBool(new IntPtr(p + 0x3F1)); // 0245A6862340 0x3F1 M_DoLayoutScheduled         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ColumnLayout                              = GetObject<ColumnLayout>(new IntPtr(p + 0x400), ReversePrism.DataModels.ColumnLayout.FromPointer); // 0245A6862380 0x400 ColumnLayout                ( 0001865D6A70 ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer )
            value.ColumnContainer                           = GetObject<VisualElement>(new IntPtr(p + 0x408), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A68623A0 0x408 ColumnContainer             ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.ResizeHandleContainer                     = GetObject<VisualElement>(new IntPtr(p + 0x410), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A68623C0 0x410 ResizeHandleContainer       ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.SortDescriptions                          = GetObject<SortColumnDescriptions>(new IntPtr(p + 0x418), ReversePrism.DataModels.SortColumnDescriptions.FromPointer); // 0245A68623E0 0x418 SortDescriptions            ( 00018652E0F0 ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer )
            value.Columns                                   = GetObject<Columns>(new IntPtr(p + 0x420), ReversePrism.DataModels.Columns.FromPointer); // 0245A6862400 0x420 Columns                     ( 0001865D7AD0 ModelClassType Columns Columns Columns Pointer )
            value.ColumnSortingChanged                      = GetObject<Action>(new IntPtr(p + 0x430), ReversePrism.DataModels.Action.FromPointer); // 0245A6862440 0x430 ColumnSortingChanged        ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.ViewDataRestored                          = GetObject<Action>(new IntPtr(p + 0x440), ReversePrism.DataModels.Action.FromPointer); // 0245A6862480 0x440 ViewDataRestored            ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
