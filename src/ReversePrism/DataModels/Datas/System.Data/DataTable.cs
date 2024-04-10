using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DataSet                                  000186680790 ModelClassType DataSet DataSet DataSet Pointer
    // 028 DefaultView                              000186685570 ModelClassType DataView DataView DataView Pointer
    // 030 NextRowID                                0001865F79C0 ModelPrimitiveType long long long Int64
    // 038 RowCollection                            00018667F0E0 ModelClassType DataRowCollection DataRowCollection DataRowCollection Pointer
    // 040 ColumnCollection                         000186677270 ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer
    // 048 ConstraintCollection                     00018660CF30 ModelClassType ConstraintCollection ConstraintCollection ConstraintCollection Pointer
    // 050 ElementColumnCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 058 ParentRelationsCollection                00018667C870 ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer
    // 060 ChildRelationsCollection                 00018667C870 ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer
    // 068 RecordManager                            00018662A110 ModelClassType RecordManager RecordManager RecordManager Pointer
    // 070 Indexes                                  000185CEB918 ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer
    // 078 ShadowIndexes                            000185CEB868 ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer
    // 080 ShadowCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 ExtendedProperties                       0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 090 TableName                                000186671910 ModelPrimitiveType string string string String
    // 098 TableNamespace                           000186671BA0 ModelPrimitiveType string string string String
    // 0A0 TablePrefix                              000186671910 ModelPrimitiveType string string string String
    // 0A8 DisplayExpression                        00018667A570 ModelClassType DataExpression DataExpression DataExpression Pointer
    // 0B0 FNestedInDataset                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 0B8 Culture                                  0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 0C0 CultureUserSet                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C8 CompareInfo                              0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 0D0 CompareFlags                             0001865EBFA0 ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    // 0D8 FormatProvider                           000186517B50 ModelClassType IFormatProvider IFormatProvider IFormatProvider Pointer
    // 0E0 HashCodeProvider                         0001865BB470 ModelClassType StringComparer StringComparer StringComparer Pointer
    // 0E8 CaseSensitive                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0E9 CaseSensitiveUserSet                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0F0 EncodedTableName                         000186671BA0 ModelPrimitiveType string string string String
    // 0F8 XmlText                                  000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 100 ColUnique                                000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer
    // 108 MinOccurs                                0001865C0BC0 ModelEnumType Decimal Decimal Decimal Int32
    // 118 MaxOccurs                                0001865C0BC0 ModelEnumType Decimal Decimal Decimal Int32
    // 128 RepeatableElement                        000186595210 ModelPrimitiveType bool bool bool Bool
    // 130 _typeName                                <object> IL2CPP_TYPE_OBJECT
    // 138 PrimaryKey                               00018670A970 ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer
    // 140 PrimaryIndex                             000185B8B660 ModelEnumListType IndexField[] IndexField[] List<IndexField> Pointer
    // 148 DelayedSetPrimaryKey                     000185B789A0 ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer
    // 150 LoadIndex                                0001866DFE20 ModelClassType Index Index Index Pointer
    // 158 LoadIndexwithOriginalAdded               0001866DFE20 ModelClassType Index Index Index Pointer
    // 160 LoadIndexwithCurrentDeleted              0001866DFE20 ModelClassType Index Index Index Pointer
    // 168 SuspendIndexEvents                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 16C InDataLoad                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 16D SchemaLoading                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 16E EnforceConstraints                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 16F SuspendEnforceConstraints                000186595210 ModelPrimitiveType bool bool bool Bool
    // 170 FInitInProgress                          000186595730 ModelPrimitiveType bool bool bool Bool
    // 171 InLoad                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 172 FInLoadDiffgram                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 173 IsTypedDataTable                         00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 178 EmptyDataRowArray                        000185B79150 ModelClassListType DataRow[] DataRow[] List<DataRow> Pointer
    // 180 PropertyDescriptorCollectionCache        0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer
    // 188 NestedParentRelations                    000185B78F10 ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer
    // 190 DependentColumns                         000185CD5CF8 ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer
    // 198 MergingData                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1A0 OnRowChangedDelegate                     00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1A8 OnRowChangingDelegate                    00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1B0 OnRowDeletingDelegate                    00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1B8 OnRowDeletedDelegate                     00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1C0 OnColumnChangedDelegate                  000186676B20 ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer
    // 1C8 OnColumnChangingDelegate                 000186676B20 ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer
    // 1D0 OnTableClearingDelegate                  000186682950 ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer
    // 1D8 OnTableClearedDelegate                   000186682950 ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer
    // 1E0 OnTableNewRowDelegate                    000186683800 ModelClassType DataTableNewRowEventHandler DataTableNewRowEventHandler DataTableNewRowEventHandler Pointer
    // 1E8 OnPropertyChangingDelegate               0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    // 1F0 RowBuilder                               00018667E4F0 ModelClassType DataRowBuilder DataRowBuilder DataRowBuilder Pointer
    // 1F8 DelayedViews                             000185CD6658 ModelClassListType List`1<DataView> List`1<DataView> List<DataView> Pointer
    // 200 DataViewListeners                        000185CD6918 ModelClassListType List`1<DataViewListener> List`1<DataViewListener> List<DataViewListener> Pointer
    // 208 RowDiffId                                0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 210 IndexesLock                              00018661FF80 ModelClassType ReaderWriterLockSlim ReaderWriterLockSlim ReaderWriterLockSlim Pointer
    // 218 UkColumnPositionForInference             0001865F2F90 ModelPrimitiveType int int int Int32
    // 21C RemotingFormat                           00018672DA00 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 220 ObjectID                                 0001865F4260 ModelPrimitiveType int int int Int32
    public partial class DataTable : DataModel
    {
        public DataSet?                                 DataSet                                 { get; set; }
        public DataView?                                DefaultView                             { get; set; }
        public long                                     NextRowID                               { get; set; }
        public DataRowCollection?                       RowCollection                           { get; set; }
        public DataColumnCollection?                    ColumnCollection                        { get; set; }
        public ConstraintCollection?                    ConstraintCollection                    { get; set; }
        public int                                      ElementColumnCount                      { get; set; }
        public DataRelationCollection?                  ParentRelationsCollection               { get; set; }
        public DataRelationCollection?                  ChildRelationsCollection                { get; set; }
        public RecordManager?                           RecordManager                           { get; set; }
        public List<Index>?                             Indexes                                 { get; set; }
        public List<Index>?                             ShadowIndexes                           { get; set; }
        public int                                      ShadowCount                             { get; set; }
        public PropertyCollection?                      ExtendedProperties                      { get; set; }
        public string                                   TableName                               { get; set; }
        public string                                   TableNamespace                          { get; set; }
        public string                                   TablePrefix                             { get; set; }
        public DataExpression?                          DisplayExpression                       { get; set; }
        public bool                                     FNestedInDataset                        { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }
        public bool                                     CultureUserSet                          { get; set; }
        public CompareInfo?                             CompareInfo                             { get; set; }
        public CompareOptions                           CompareFlags                            { get; set; }
        public IFormatProvider?                         FormatProvider                          { get; set; }
        public StringComparer?                          HashCodeProvider                        { get; set; }
        public bool                                     CaseSensitive                           { get; set; }
        public bool                                     CaseSensitiveUserSet                    { get; set; }
        public string                                   EncodedTableName                        { get; set; }
        public DataColumn?                              XmlText                                 { get; set; }
        public DataColumn?                              ColUnique                               { get; set; }
        public Decimal                                  MinOccurs                               { get; set; }
        public Decimal                                  MaxOccurs                               { get; set; }
        public bool                                     RepeatableElement                       { get; set; }
        public UniqueConstraint?                        PrimaryKey                              { get; set; }
        public List<IndexField>?                        PrimaryIndex                            { get; set; }
        public List<DataColumn>?                        DelayedSetPrimaryKey                    { get; set; }
        public Index?                                   LoadIndex                               { get; set; }
        public Index?                                   LoadIndexwithOriginalAdded              { get; set; }
        public Index?                                   LoadIndexwithCurrentDeleted             { get; set; }
        public int                                      SuspendIndexEvents                      { get; set; }
        public bool                                     InDataLoad                              { get; set; }
        public bool                                     SchemaLoading                           { get; set; }
        public bool                                     EnforceConstraints                      { get; set; }
        public bool                                     SuspendEnforceConstraints               { get; set; }
        public bool                                     FInitInProgress                         { get; set; }
        public bool                                     InLoad                                  { get; set; }
        public bool                                     FInLoadDiffgram                         { get; set; }
        public sbyte                                    IsTypedDataTable                        { get; set; }
        public List<DataRow>?                           EmptyDataRowArray                       { get; set; }
        public PropertyDescriptorCollection?            PropertyDescriptorCollectionCache       { get; set; }
        public List<DataRelation>?                      NestedParentRelations                   { get; set; }
        public List<DataColumn>?                        DependentColumns                        { get; set; }
        public bool                                     MergingData                             { get; set; }
        public DataRowChangeEventHandler?               OnRowChangedDelegate                    { get; set; }
        public DataRowChangeEventHandler?               OnRowChangingDelegate                   { get; set; }
        public DataRowChangeEventHandler?               OnRowDeletingDelegate                   { get; set; }
        public DataRowChangeEventHandler?               OnRowDeletedDelegate                    { get; set; }
        public DataColumnChangeEventHandler?            OnColumnChangedDelegate                 { get; set; }
        public DataColumnChangeEventHandler?            OnColumnChangingDelegate                { get; set; }
        public DataTableClearEventHandler?              OnTableClearingDelegate                 { get; set; }
        public DataTableClearEventHandler?              OnTableClearedDelegate                  { get; set; }
        public DataTableNewRowEventHandler?             OnTableNewRowDelegate                   { get; set; }
        public PropertyChangedEventHandler?             OnPropertyChangingDelegate              { get; set; }
        public DataRowBuilder?                          RowBuilder                              { get; set; }
        public List<DataView>?                          DelayedViews                            { get; set; }
        public List<DataViewListener>?                  DataViewListeners                       { get; set; }
        public Hashtable?                               RowDiffId                               { get; set; }
        public ReaderWriterLockSlim?                    IndexesLock                             { get; set; }
        public int                                      UkColumnPositionForInference            { get; set; }
        public SerializationFormat                      RemotingFormat                          { get; set; }
        public int                                      ObjectID                                { get; set; }

        public static DataTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataTable() { Pointer= p0 };

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataSet.FromPointer); // 0245A60395D8 0x20 DataSet                     ( 000186680790 ModelClassType DataSet DataSet DataSet Pointer )
            value.DefaultView                               = GetObject<DataView>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataView.FromPointer); // 0245A60395F8 0x28 DefaultView                 ( 000186685570 ModelClassType DataView DataView DataView Pointer )
            value.NextRowID                                 = GetInt64(new IntPtr(p + 0x030)); // 0245A6039618 0x30 NextRowID                   ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.RowCollection                             = GetObject<DataRowCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataRowCollection.FromPointer); // 0245A6039638 0x38 RowCollection               ( 00018667F0E0 ModelClassType DataRowCollection DataRowCollection DataRowCollection Pointer )
            value.ColumnCollection                          = GetObject<DataColumnCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumnCollection.FromPointer); // 0245A6039658 0x40 ColumnCollection            ( 000186677270 ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer )
            value.ConstraintCollection                      = GetObject<ConstraintCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.ConstraintCollection.FromPointer); // 0245A6039678 0x48 ConstraintCollection        ( 00018660CF30 ModelClassType ConstraintCollection ConstraintCollection ConstraintCollection Pointer )
            value.ElementColumnCount                        = GetInt32(new IntPtr(p + 0x050)); // 0245A6039698 0x50 ElementColumnCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParentRelationsCollection                 = GetObject<DataRelationCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.DataRelationCollection.FromPointer); // 0245A60396B8 0x58 ParentRelationsCollection   ( 00018667C870 ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer )
            value.ChildRelationsCollection                  = GetObject<DataRelationCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.DataRelationCollection.FromPointer); // 0245A60396D8 0x60 ChildRelationsCollection    ( 00018667C870 ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer )
            value.RecordManager                             = GetObject<RecordManager>(new IntPtr(p + 0x068), ReversePrism.DataModels.RecordManager.FromPointer); // 0245A60396F8 0x68 RecordManager               ( 00018662A110 ModelClassType RecordManager RecordManager RecordManager Pointer )
            value.Indexes                                   = GetObjectList<Index>(new IntPtr(p + 0x070), ReversePrism.DataModels.Index.FromPointer); // 0245A6039718 0x70 Indexes                     ( 000185CEB918 ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer )
            value.ShadowIndexes                             = GetObjectList<Index>(new IntPtr(p + 0x078), ReversePrism.DataModels.Index.FromPointer); // 0245A6039738 0x78 ShadowIndexes               ( 000185CEB868 ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer )
            value.ShadowCount                               = GetInt32(new IntPtr(p + 0x080)); // 0245A6039758 0x80 ShadowCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x088), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0245A6039778 0x88 ExtendedProperties          ( 0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.TableName                                 = GetString(new IntPtr(p + 0x090)); // 0245A6039798 0x90 TableName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.TableNamespace                            = GetString(new IntPtr(p + 0x098)); // 0245A60397B8 0x98 TableNamespace              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.TablePrefix                               = GetString(new IntPtr(p + 0x0A0)); // 0245A60397D8 0xA0 TablePrefix                 ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayExpression                         = GetObject<DataExpression>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataExpression.FromPointer); // 0245A60397F8 0xA8 DisplayExpression           ( 00018667A570 ModelClassType DataExpression DataExpression DataExpression Pointer )
            value.FNestedInDataset                          = GetBool(new IntPtr(p + 0x0B0)); // 0245A6039818 0xB0 FNestedInDataset            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A6039838 0xB8 Culture                     ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.CultureUserSet                            = GetBool(new IntPtr(p + 0x0C0)); // 0245A6039858 0xC0 CultureUserSet              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CompareInfo.FromPointer); // 0245A6039878 0xC8 CompareInfo                 ( 0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.CompareFlags                              = (CompareOptions)GetInt32(new IntPtr(p + 0x0D0)); // 0245A6039898 0xD0 CompareFlags                ( 0001865EBFA0 ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )
            value.FormatProvider                            = GetObject<IFormatProvider>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IFormatProvider.FromPointer); // 0245A60398B8 0xD8 FormatProvider              ( 000186517B50 ModelClassType IFormatProvider IFormatProvider IFormatProvider Pointer )
            value.HashCodeProvider                          = GetObject<StringComparer>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.StringComparer.FromPointer); // 0245A60398D8 0xE0 HashCodeProvider            ( 0001865BB470 ModelClassType StringComparer StringComparer StringComparer Pointer )
            value.CaseSensitive                             = GetBool(new IntPtr(p + 0x0E8)); // 0245A60398F8 0xE8 CaseSensitive               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CaseSensitiveUserSet                      = GetBool(new IntPtr(p + 0x0E9)); // 0245A6039918 0xE9 CaseSensitiveUserSet        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EncodedTableName                          = GetString(new IntPtr(p + 0x0F0)); // 0245A6039938 0xF0 EncodedTableName            ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XmlText                                   = GetObject<DataColumn>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.DataColumn.FromPointer); // 0245A6039958 0xF8 XmlText                     ( 000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.ColUnique                                 = GetObject<DataColumn>(new IntPtr(p + 0x100), ReversePrism.DataModels.DataColumn.FromPointer); // 0245A6039978 0x100 ColUnique                   ( 000186675CB0 ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.MinOccurs                                 = (Decimal)GetInt32(new IntPtr(p + 0x108)); // 0245A6039998 0x108 MinOccurs                   ( 0001865C0BC0 ModelEnumType Decimal Decimal Decimal Int32 )
            value.MaxOccurs                                 = (Decimal)GetInt32(new IntPtr(p + 0x118)); // 0245A60399B8 0x118 MaxOccurs                   ( 0001865C0BC0 ModelEnumType Decimal Decimal Decimal Int32 )
            value.RepeatableElement                         = GetBool(new IntPtr(p + 0x128)); // 0245A60399D8 0x128 RepeatableElement           ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PrimaryKey                                = GetObject<UniqueConstraint>(new IntPtr(p + 0x138), ReversePrism.DataModels.UniqueConstraint.FromPointer); // 0245A6039A18 0x138 PrimaryKey                  ( 00018670A970 ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer )
            value.PrimaryIndex                              = GetEnumList<IndexField>(new IntPtr(p + 0x140)); // 0245A6039A38 0x140 PrimaryIndex                ( 000185B8B660 ModelEnumListType IndexField[] IndexField[] List<IndexField> Pointer )
            value.DelayedSetPrimaryKey                      = GetObjectList<DataColumn>(new IntPtr(p + 0x148), ReversePrism.DataModels.DataColumn.FromPointer); // 0245A6039A58 0x148 DelayedSetPrimaryKey        ( 000185B789A0 ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer )
            value.LoadIndex                                 = GetObject<Index>(new IntPtr(p + 0x150), ReversePrism.DataModels.Index.FromPointer); // 0245A6039A78 0x150 LoadIndex                   ( 0001866DFE20 ModelClassType Index Index Index Pointer )
            value.LoadIndexwithOriginalAdded                = GetObject<Index>(new IntPtr(p + 0x158), ReversePrism.DataModels.Index.FromPointer); // 0245A6039A98 0x158 LoadIndexwithOriginalAdded  ( 0001866DFE20 ModelClassType Index Index Index Pointer )
            value.LoadIndexwithCurrentDeleted               = GetObject<Index>(new IntPtr(p + 0x160), ReversePrism.DataModels.Index.FromPointer); // 0245A6039AB8 0x160 LoadIndexwithCurrentDeleted ( 0001866DFE20 ModelClassType Index Index Index Pointer )
            value.SuspendIndexEvents                        = GetInt32(new IntPtr(p + 0x168)); // 0245A6039AD8 0x168 SuspendIndexEvents          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InDataLoad                                = GetBool(new IntPtr(p + 0x16C)); // 0245A6039AF8 0x16C InDataLoad                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SchemaLoading                             = GetBool(new IntPtr(p + 0x16D)); // 0245A6039B18 0x16D SchemaLoading               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.EnforceConstraints                        = GetBool(new IntPtr(p + 0x16E)); // 0245A6039B38 0x16E EnforceConstraints          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SuspendEnforceConstraints                 = GetBool(new IntPtr(p + 0x16F)); // 0245A6039B58 0x16F SuspendEnforceConstraints   ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FInitInProgress                           = GetBool(new IntPtr(p + 0x170)); // 0245A6039B78 0x170 FInitInProgress             ( 000186595730 ModelPrimitiveType bool bool bool Bool )
            value.InLoad                                    = GetBool(new IntPtr(p + 0x171)); // 0245A6039B98 0x171 InLoad                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FInLoadDiffgram                           = GetBool(new IntPtr(p + 0x172)); // 0245A6039BB8 0x172 FInLoadDiffgram             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsTypedDataTable                          = GetSByte(new IntPtr(p + 0x173)); // 0245A6039BD8 0x173 IsTypedDataTable            ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.EmptyDataRowArray                         = GetObjectList<DataRow>(new IntPtr(p + 0x178), ReversePrism.DataModels.DataRow.FromPointer); // 0245A6039BF8 0x178 EmptyDataRowArray           ( 000185B79150 ModelClassListType DataRow[] DataRow[] List<DataRow> Pointer )
            value.PropertyDescriptorCollectionCache         = GetObject<PropertyDescriptorCollection>(new IntPtr(p + 0x180), ReversePrism.DataModels.PropertyDescriptorCollection.FromPointer); // 0245A6039C18 0x180 PropertyDescriptorCollectionCache ( 0001865D3470 ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer )
            value.NestedParentRelations                     = GetObjectList<DataRelation>(new IntPtr(p + 0x188), ReversePrism.DataModels.DataRelation.FromPointer); // 0245A6039C38 0x188 NestedParentRelations       ( 000185B78F10 ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer )
            value.DependentColumns                          = GetObjectList<DataColumn>(new IntPtr(p + 0x190), ReversePrism.DataModels.DataColumn.FromPointer); // 0245A6039C58 0x190 DependentColumns            ( 000185CD5CF8 ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer )
            value.MergingData                               = GetBool(new IntPtr(p + 0x198)); // 0245A6039C78 0x198 MergingData                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OnRowChangedDelegate                      = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0245A6039C98 0x1A0 OnRowChangedDelegate        ( 00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnRowChangingDelegate                     = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0245A6039CB8 0x1A8 OnRowChangingDelegate       ( 00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnRowDeletingDelegate                     = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0245A6039CD8 0x1B0 OnRowDeletingDelegate       ( 00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnRowDeletedDelegate                      = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0245A6039CF8 0x1B8 OnRowDeletedDelegate        ( 00018667EC00 ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnColumnChangedDelegate                   = GetObject<DataColumnChangeEventHandler>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.DataColumnChangeEventHandler.FromPointer); // 0245A6039D18 0x1C0 OnColumnChangedDelegate     ( 000186676B20 ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer )
            value.OnColumnChangingDelegate                  = GetObject<DataColumnChangeEventHandler>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.DataColumnChangeEventHandler.FromPointer); // 0245A6039D38 0x1C8 OnColumnChangingDelegate    ( 000186676B20 ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer )
            value.OnTableClearingDelegate                   = GetObject<DataTableClearEventHandler>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.DataTableClearEventHandler.FromPointer); // 0245A6039D58 0x1D0 OnTableClearingDelegate     ( 000186682950 ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer )
            value.OnTableClearedDelegate                    = GetObject<DataTableClearEventHandler>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.DataTableClearEventHandler.FromPointer); // 0245A6039D78 0x1D8 OnTableClearedDelegate      ( 000186682950 ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer )
            value.OnTableNewRowDelegate                     = GetObject<DataTableNewRowEventHandler>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.DataTableNewRowEventHandler.FromPointer); // 0245A6039D98 0x1E0 OnTableNewRowDelegate       ( 000186683800 ModelClassType DataTableNewRowEventHandler DataTableNewRowEventHandler DataTableNewRowEventHandler Pointer )
            value.OnPropertyChangingDelegate                = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0245A6039DB8 0x1E8 OnPropertyChangingDelegate  ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )
            value.RowBuilder                                = GetObject<DataRowBuilder>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.DataRowBuilder.FromPointer); // 0245A6039DD8 0x1F0 RowBuilder                  ( 00018667E4F0 ModelClassType DataRowBuilder DataRowBuilder DataRowBuilder Pointer )
            value.DelayedViews                              = GetObjectList<DataView>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.DataView.FromPointer); // 0245A6039DF8 0x1F8 DelayedViews                ( 000185CD6658 ModelClassListType List`1<DataView> List`1<DataView> List<DataView> Pointer )
            value.DataViewListeners                         = GetObjectList<DataViewListener>(new IntPtr(p + 0x200), ReversePrism.DataModels.DataViewListener.FromPointer); // 0245A6039E18 0x200 DataViewListeners           ( 000185CD6918 ModelClassListType List`1<DataViewListener> List`1<DataViewListener> List<DataViewListener> Pointer )
            value.RowDiffId                                 = GetObject<Hashtable>(new IntPtr(p + 0x208), ReversePrism.DataModels.Hashtable.FromPointer); // 0245A6039E38 0x208 RowDiffId                   ( 0001865DE5A0 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IndexesLock                               = GetObject<ReaderWriterLockSlim>(new IntPtr(p + 0x210), ReversePrism.DataModels.ReaderWriterLockSlim.FromPointer); // 0245A6039E58 0x210 IndexesLock                 ( 00018661FF80 ModelClassType ReaderWriterLockSlim ReaderWriterLockSlim ReaderWriterLockSlim Pointer )
            value.UkColumnPositionForInference              = GetInt32(new IntPtr(p + 0x218)); // 0245A6039E78 0x218 UkColumnPositionForInference ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.RemotingFormat                            = (SerializationFormat)GetInt32(new IntPtr(p + 0x21C)); // 0245A6039E98 0x21C RemotingFormat              ( 00018672DA00 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x220)); // 0245A6039ED8 0x220 ObjectID                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
