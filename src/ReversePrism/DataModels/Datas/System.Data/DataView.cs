using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DataViewManager                          0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    // 028 Table                                    0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer
    // 030 Locked                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Index                                    0001866DFE20 ModelClassType Index Index Index Pointer
    // 040 _findIndexes                             Dictionary`2<string, Index> IL2CPP_TYPE_GENERICINST
    // 048 Sort                                     000186671910 ModelPrimitiveType string string string String
    // 050 _comparison                              Comparison`1<DataRow> IL2CPP_TYPE_GENERICINST
    // 058 RowFilter                                00018650B8F0 ModelClassType IFilter IFilter IFilter Pointer
    // 060 RecordStates                             000186686B80 ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32
    // 064 ShouldOpen                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 065 Open                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 066 AllowNew                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 067 AllowEdit                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 AllowDelete                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 ApplyDefaultSort                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 AddNewRow                                00018667D160 ModelClassType DataRow DataRow DataRow Pointer
    // 078 AddNewMoved                              000186535BC0 ModelClassType ListChangedEventArgs ListChangedEventArgs ListChangedEventArgs Pointer
    // 080 OnListChanged                            0001865365F0 ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer
    // 000 s_resetEventArgs                         ListChangedEventArgs IL2CPP_TYPE_CLASS
    // 088 DelayedSort                              000186671910 ModelPrimitiveType string string string String
    // 090 DelayedRecordStates                      000186686B80 ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32
    // 094 FInitInProgress                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 095 FEndInitInProgress                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 _rowViewCache                            Dictionary`2<DataRow, DataRowView> IL2CPP_TYPE_GENERICINST
    // 0A0 _rowViewBuffer                           Dictionary`2<DataRow, DataRowView> IL2CPP_TYPE_GENERICINST
    // 0A8 DvListener                               000186685CC0 ModelClassType DataViewListener DataViewListener DataViewListener Pointer
    // 008 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 0B0 ObjectID                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class DataView
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
            var value   = new DataView();

            value.DataViewManager                           = GetObject<DataViewManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataViewManager.FromPointer); // 0270D88DA060 0x20 DataViewManager             ( 0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer )
            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTable.FromPointer); // 0270D88DA080 0x28 Table                       ( 0001865B7E00 ModelClassType DataTable DataTable DataTable Pointer )
            value.Locked                                    = GetBool(new IntPtr(p + 0x030)); // 0270D88DA0A0 0x30 Locked                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Index                                     = GetObject<Index>(new IntPtr(p + 0x038), ReversePrism.DataModels.Index.FromPointer); // 0270D88DA0C0 0x38 Index                       ( 0001866DFE20 ModelClassType Index Index Index Pointer )
            value.Sort                                      = GetString(new IntPtr(p + 0x048)); // 0270D88DA100 0x48 Sort                        ( 000186671910 ModelPrimitiveType string string string String )
            value.RowFilter                                 = GetObject<IFilter>(new IntPtr(p + 0x058), ReversePrism.DataModels.IFilter.FromPointer); // 0270D88DA140 0x58 RowFilter                   ( 00018650B8F0 ModelClassType IFilter IFilter IFilter Pointer )
            value.RecordStates                              = (DataViewRowState)GetInt32(new IntPtr(p + 0x060)); // 0270D88DA160 0x60 RecordStates                ( 000186686B80 ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32 )
            value.ShouldOpen                                = GetBool(new IntPtr(p + 0x064)); // 0270D88DA180 0x64 ShouldOpen                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Open                                      = GetBool(new IntPtr(p + 0x065)); // 0270D88DA1A0 0x65 Open                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowNew                                  = GetBool(new IntPtr(p + 0x066)); // 0270D88DA1C0 0x66 AllowNew                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowEdit                                 = GetBool(new IntPtr(p + 0x067)); // 0270D88DA1E0 0x67 AllowEdit                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllowDelete                               = GetBool(new IntPtr(p + 0x068)); // 0270D88DA200 0x68 AllowDelete                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ApplyDefaultSort                          = GetBool(new IntPtr(p + 0x069)); // 0270D88DA220 0x69 ApplyDefaultSort            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AddNewRow                                 = GetObject<DataRow>(new IntPtr(p + 0x070), ReversePrism.DataModels.DataRow.FromPointer); // 0270D88DA240 0x70 AddNewRow                   ( 00018667D160 ModelClassType DataRow DataRow DataRow Pointer )
            value.AddNewMoved                               = GetObject<ListChangedEventArgs>(new IntPtr(p + 0x078), ReversePrism.DataModels.ListChangedEventArgs.FromPointer); // 0270D88DA260 0x78 AddNewMoved                 ( 000186535BC0 ModelClassType ListChangedEventArgs ListChangedEventArgs ListChangedEventArgs Pointer )
            value.OnListChanged                             = GetObject<ListChangedEventHandler>(new IntPtr(p + 0x080), ReversePrism.DataModels.ListChangedEventHandler.FromPointer); // 0270D88DA280 0x80 OnListChanged               ( 0001865365F0 ModelClassType ListChangedEventHandler ListChangedEventHandler ListChangedEventHandler Pointer )
            value.DelayedSort                               = GetString(new IntPtr(p + 0x088)); // 0270D88DA2C0 0x88 DelayedSort                 ( 000186671910 ModelPrimitiveType string string string String )
            value.DelayedRecordStates                       = (DataViewRowState)GetInt32(new IntPtr(p + 0x090)); // 0270D88DA2E0 0x90 DelayedRecordStates         ( 000186686B80 ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32 )
            value.FInitInProgress                           = GetBool(new IntPtr(p + 0x094)); // 0270D88DA300 0x94 FInitInProgress             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FEndInitInProgress                        = GetBool(new IntPtr(p + 0x095)); // 0270D88DA320 0x95 FEndInitInProgress          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DvListener                                = GetObject<DataViewListener>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataViewListener.FromPointer); // 0270D88DA380 0xA8 DvListener                  ( 000186685CC0 ModelClassType DataViewListener DataViewListener DataViewListener Pointer )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x0B0)); // 0270D88DA3C0 0xB0 ObjectID                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
