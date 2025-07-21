using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DataViewManager                          ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    // 028 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 030 Locked                                   ModelPrimitiveType bool bool bool Bool
    // 038 Index                                    ModelClassType Index Index Index Pointer
    // 040 _findIndexes                             Dictionary`2<string, Index> IL2CPP_TYPE_GENERICINST
    // 048 Sort                                     ModelPrimitiveType string string string String
    // 050 _comparison                              Comparison`1<DataRow> IL2CPP_TYPE_GENERICINST
    // 058 RowFilter                                ModelClassType IFilter IFilter IFilter Pointer
    // 060 RecordStates                             ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32
    // 064 ShouldOpen                               ModelPrimitiveType bool bool bool Bool
    // 065 Open                                     ModelPrimitiveType bool bool bool Bool
    // 066 AllowNew                                 ModelPrimitiveType bool bool bool Bool
    // 067 AllowEdit                                ModelPrimitiveType bool bool bool Bool
    // 068 AllowDelete                              ModelPrimitiveType bool bool bool Bool
    // 069 ApplyDefaultSort                         ModelPrimitiveType bool bool bool Bool
    // 070 AddNewRow                                ModelClassType DataRow DataRow DataRow Pointer
    // 078 AddNewMoved                              ModelClassType ListChangedEventArgs ListChangedEventArgs ListChangedEventArgs Pointer
    // 080 OnListChanged                            ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer
    // 000 s_resetEventArgs                         ListChangedEventArgs IL2CPP_TYPE_CLASS
    // 088 DelayedSort                              ModelPrimitiveType string string string String
    // 090 DelayedRecordStates                      ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32
    // 094 FInitInProgress                          ModelPrimitiveType bool bool bool Bool
    // 095 FEndInitInProgress                       ModelPrimitiveType bool bool bool Bool
    // 098 _rowViewCache                            Dictionary`2<DataRow, DataRowView> IL2CPP_TYPE_GENERICINST
    // 0A0 _rowViewBuffer                           Dictionary`2<DataRow, DataRowView> IL2CPP_TYPE_GENERICINST
    // 0A8 DvListener                               ModelClassType DataViewListener DataViewListener DataViewListener Pointer
    // 008 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 0B0 ObjectID                                 ModelPrimitiveType int int int Int32
    public partial class DataView : DataModel
    {
        public DataViewManager?                         DataViewManager                         { get; set; }
        public DataTable?                               Table                                   { get; set; }
        public bool                                     Locked                                  { get; set; }
        public Index?                                   Index                                   { get; set; }
        public string                                   Sort                                    { get; set; }
        public IFilter?                                 RowFilter                               { get; set; }
        public DataViewRowState                         RecordStates                            { get; set; }
        public bool                                     ShouldOpen                              { get; set; }
        public bool                                     Open                                    { get; set; }
        public bool                                     AllowNew                                { get; set; }
        public bool                                     AllowEdit                               { get; set; }
        public bool                                     AllowDelete                             { get; set; }
        public bool                                     ApplyDefaultSort                        { get; set; }
        public DataRow?                                 AddNewRow                               { get; set; }
        public ListChangedEventArgs?                    AddNewMoved                             { get; set; }
        public ListChangedEventHandler?                 OnListChanged                           { get; set; }
        public string                                   DelayedSort                             { get; set; }
        public DataViewRowState                         DelayedRecordStates                     { get; set; }
        public bool                                     FInitInProgress                         { get; set; }
        public bool                                     FEndInitInProgress                      { get; set; }
        public DataViewListener?                        DvListener                              { get; set; }
        public int                                      ObjectID                                { get; set; }

        public static DataView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataView() { Pointer= p0 };

            value.DataViewManager                           = GetObject<DataViewManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataViewManager.FromPointer); // 0x20 DataViewManager             ( ModelClassType DataViewManager DataViewManager DataViewManager Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTable.FromPointer); // 0x28 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.Locked                                    = GetBool(new IntPtr(p + 0x030)); // 0x30 Locked                      ( ModelPrimitiveType bool bool bool Bool )
            value.Index                                     = GetObject<Index>(new IntPtr(p + 0x038), ReversePrism.DataModels.Index.FromPointer); // 0x38 Index                       ( ModelClassType Index Index Index Pointer )
            value.Sort                                      = GetString(new IntPtr(p + 0x048)); // 0x48 Sort                        ( ModelPrimitiveType string string string String )
            value.RowFilter                                 = GetObject<IFilter>(new IntPtr(p + 0x058), ReversePrism.DataModels.IFilter.FromPointer); // 0x58 RowFilter                   ( ModelClassType IFilter IFilter IFilter Pointer )
            value.RecordStates                              = (DataViewRowState)GetInt32(new IntPtr(p + 0x060)); // 0x60 RecordStates                ( ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32 )
            value.ShouldOpen                                = GetBool(new IntPtr(p + 0x064)); // 0x64 ShouldOpen                  ( ModelPrimitiveType bool bool bool Bool )
            value.Open                                      = GetBool(new IntPtr(p + 0x065)); // 0x65 Open                        ( ModelPrimitiveType bool bool bool Bool )
            value.AllowNew                                  = GetBool(new IntPtr(p + 0x066)); // 0x66 AllowNew                    ( ModelPrimitiveType bool bool bool Bool )
            value.AllowEdit                                 = GetBool(new IntPtr(p + 0x067)); // 0x67 AllowEdit                   ( ModelPrimitiveType bool bool bool Bool )
            value.AllowDelete                               = GetBool(new IntPtr(p + 0x068)); // 0x68 AllowDelete                 ( ModelPrimitiveType bool bool bool Bool )
            value.ApplyDefaultSort                          = GetBool(new IntPtr(p + 0x069)); // 0x69 ApplyDefaultSort            ( ModelPrimitiveType bool bool bool Bool )
            value.AddNewRow                                 = GetObject<DataRow>(new IntPtr(p + 0x070), ReversePrism.DataModels.DataRow.FromPointer); // 0x70 AddNewRow                   ( ModelClassType DataRow DataRow DataRow Pointer )
            value.AddNewMoved                               = GetObject<ListChangedEventArgs>(new IntPtr(p + 0x078), ReversePrism.DataModels.ListChangedEventArgs.FromPointer); // 0x78 AddNewMoved                 ( ModelClassType ListChangedEventArgs ListChangedEventArgs ListChangedEventArgs Pointer )
            value.OnListChanged                             = GetObject<ListChangedEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.ListChangedEventHandler.FromPointer); // 0x80 OnListChanged               ( ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer )
            value.DelayedSort                               = GetString(new IntPtr(p + 0x088)); // 0x88 DelayedSort                 ( ModelPrimitiveType string string string String )
            value.DelayedRecordStates                       = (DataViewRowState)GetInt32(new IntPtr(p + 0x090)); // 0x90 DelayedRecordStates         ( ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32 )
            value.FInitInProgress                           = GetBool(new IntPtr(p + 0x094)); // 0x94 FInitInProgress             ( ModelPrimitiveType bool bool bool Bool )
            value.FEndInitInProgress                        = GetBool(new IntPtr(p + 0x095)); // 0x95 FEndInitInProgress          ( ModelPrimitiveType bool bool bool Bool )
            value.DvListener                                = GetObject<DataViewListener>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataViewListener.FromPointer); // 0xA8 DvListener                  ( ModelClassType DataViewListener DataViewListener DataViewListener Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 ObjectID                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
