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
    // 010 HandleContainerUssClassName              ModelPrimitiveType string string string String
    // 018 ReorderableUssClassName                  ModelPrimitiveType string string string String
    // 3C8 M_SortingEnabled                         ModelPrimitiveType bool bool bool Bool
    // 3D0 M_SortedColumns                          ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer
    // 3D8 M_SortDescriptions                       ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer
    // 3E0 M_OldSortedColumnStates                  ModelEnumListType List`1<SortedColumnState> List`1<SortedColumnState> List<SortedColumnState> Pointer
    // 3E8 M_SortingUpdatesTemporarilyDisabled      ModelPrimitiveType bool bool bool Bool
    // 3F0 M_ViewState                              ModelClassType ViewState ViewState ViewState Pointer
    // 3F8 M_ApplyingViewState                      ModelPrimitiveType bool bool bool Bool
    // 3F9 M_DoLayoutScheduled                      ModelPrimitiveType bool bool bool Bool
    // 400 <columnDataMap>k__BackingField           Dictionary`2<Column, ColumnData> IL2CPP_TYPE_GENERICINST
    // 408 ColumnLayout                             ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer
    // 410 ColumnContainer                          ModelClassType VisualElement VisualElement VisualElement Pointer
    // 418 ResizeHandleContainer                    ModelClassType VisualElement VisualElement VisualElement Pointer
    // 420 Columns                                  ModelClassType Columns Columns Columns Pointer
    // 428 columnResized                            Action`2<int, float> IL2CPP_TYPE_GENERICINST
    // 430 ColumnSortingChanged                     ModelClassType Action Action Action Pointer
    // 438 contextMenuPopulateEvent                 Action`2<ContextualMenuPopulateEvent, Column> IL2CPP_TYPE_GENERICINST
    // 440 ViewDataRestored                         ModelClassType Action Action Action Pointer
    public partial class MultiColumnCollectionHeader : DataModel
    {
        public string                                   HandleContainerUssClassName             { get; set; }
        public string                                   ReorderableUssClassName                 { get; set; }
        public bool                                     M_SortingEnabled                        { get; set; }
        public List<SortColumnDescription>?             M_SortedColumns                         { get; set; }
        public SortColumnDescriptions?                  M_SortDescriptions                      { get; set; }
        public List<SortedColumnState>?                 M_OldSortedColumnStates                 { get; set; }
        public bool                                     M_SortingUpdatesTemporarilyDisabled     { get; set; }
        public ViewState?                               M_ViewState                             { get; set; }
        public bool                                     M_ApplyingViewState                     { get; set; }
        public bool                                     M_DoLayoutScheduled                     { get; set; }
        public ColumnLayout?                            ColumnLayout                            { get; set; }
        public VisualElement?                           ColumnContainer                         { get; set; }
        public VisualElement?                           ResizeHandleContainer                   { get; set; }
        public Columns?                                 Columns                                 { get; set; }
        public Action?                                  ColumnSortingChanged                    { get; set; }
        public Action?                                  ViewDataRestored                        { get; set; }

        public static MultiColumnCollectionHeader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnCollectionHeader() { Pointer= p0 };

            value.HandleContainerUssClassName               = GetString(new IntPtr(p + 0x010)); // 0x10 HandleContainerUssClassName ( ModelPrimitiveType string string string String )
            value.ReorderableUssClassName                   = GetString(new IntPtr(p + 0x018)); // 0x18 ReorderableUssClassName     ( ModelPrimitiveType string string string String )
            value.M_SortingEnabled                          = GetBool(new IntPtr(p + 0x3C8)); // 0x3C8 M_SortingEnabled            ( ModelPrimitiveType bool bool bool Bool )
            value.M_SortedColumns                           = GetObjectList<SortColumnDescription>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.SortColumnDescription.FromPointer); // 0x3D0 M_SortedColumns             ( ModelClassListType List`1<SortColumnDescription> List`1<SortColumnDescription> List<SortColumnDescription> Pointer )
            value.M_SortDescriptions                        = GetObject<SortColumnDescriptions>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.SortColumnDescriptions.FromPointer); // 0x3D8 M_SortDescriptions          ( ModelClassType SortColumnDescriptions SortColumnDescriptions SortColumnDescriptions Pointer )
            value.M_OldSortedColumnStates                   = GetEnumList<SortedColumnState>(new IntPtr(p + 0x3E0)); // 0x3E0 M_OldSortedColumnStates     ( ModelEnumListType List`1<SortedColumnState> List`1<SortedColumnState> List<SortedColumnState> Pointer )
            value.M_SortingUpdatesTemporarilyDisabled       = GetBool(new IntPtr(p + 0x3E8)); // 0x3E8 M_SortingUpdatesTemporarilyDisabled ( ModelPrimitiveType bool bool bool Bool )
            value.M_ViewState                               = GetObject<ViewState>(new IntPtr(p + 0x3F0), ReversePrism.DataModels.ViewState.FromPointer); // 0x3F0 M_ViewState                 ( ModelClassType ViewState ViewState ViewState Pointer )
            value.M_ApplyingViewState                       = GetBool(new IntPtr(p + 0x3F8)); // 0x3F8 M_ApplyingViewState         ( ModelPrimitiveType bool bool bool Bool )
            value.M_DoLayoutScheduled                       = GetBool(new IntPtr(p + 0x3F9)); // 0x3F9 M_DoLayoutScheduled         ( ModelPrimitiveType bool bool bool Bool )
            value.ColumnLayout                              = GetObject<ColumnLayout>(new IntPtr(p + 0x408), ReversePrism.DataModels.ColumnLayout.FromPointer); // 0x408 ColumnLayout                ( ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer )
            value.ColumnContainer                           = GetObject<VisualElement>(new IntPtr(p + 0x410), ReversePrism.DataModels.VisualElement.FromPointer); // 0x410 ColumnContainer             ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.ResizeHandleContainer                     = GetObject<VisualElement>(new IntPtr(p + 0x418), ReversePrism.DataModels.VisualElement.FromPointer); // 0x418 ResizeHandleContainer       ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.Columns                                   = GetObject<Columns>(new IntPtr(p + 0x420), ReversePrism.DataModels.Columns.FromPointer); // 0x420 Columns                     ( ModelClassType Columns Columns Columns Pointer )
            value.ColumnSortingChanged                      = GetObject<Action>(new IntPtr(p + 0x430), ReversePrism.DataModels.Action.FromPointer); // 0x430 ColumnSortingChanged        ( ModelClassType Action Action Action Pointer )
            value.ViewDataRestored                          = GetObject<Action>(new IntPtr(p + 0x440), ReversePrism.DataModels.Action.FromPointer); // 0x440 ViewDataRestored            ( ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
