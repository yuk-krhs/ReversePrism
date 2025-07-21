using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DataSet                                  ModelClassType DataSet DataSet DataSet Pointer
    // 028 DefaultView                              ModelClassType DataView DataView DataView Pointer
    // 030 NextRowID                                ModelPrimitiveType long long long Int64
    // 038 RowCollection                            ModelClassType DataRowCollection DataRowCollection DataRowCollection Pointer
    // 040 ColumnCollection                         ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer
    // 048 ConstraintCollection                     ModelClassType ConstraintCollection ConstraintCollection ConstraintCollection Pointer
    // 050 ElementColumnCount                       ModelPrimitiveType int int int Int32
    // 058 ParentRelationsCollection                ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer
    // 060 ChildRelationsCollection                 ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer
    // 068 RecordManager                            ModelClassType RecordManager RecordManager RecordManager Pointer
    // 070 Indexes                                  ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer
    // 078 ShadowIndexes                            ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer
    // 080 ShadowCount                              ModelPrimitiveType int int int Int32
    // 088 ExtendedProperties                       ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 090 TableName                                ModelPrimitiveType string string string String
    // 098 TableNamespace                           ModelPrimitiveType string string string String
    // 0A0 TablePrefix                              ModelPrimitiveType string string string String
    // 0A8 DisplayExpression                        ModelClassType DataExpression DataExpression DataExpression Pointer
    // 0B0 FNestedInDataset                         ModelPrimitiveType bool bool bool Bool
    // 0B8 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 0C0 CultureUserSet                           ModelPrimitiveType bool bool bool Bool
    // 0C8 CompareInfo                              ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 0D0 CompareFlags                             ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    // 0D8 FormatProvider                           ModelClassType IFormatProvider IFormatProvider IFormatProvider Pointer
    // 0E0 HashCodeProvider                         ModelClassType StringComparer StringComparer StringComparer Pointer
    // 0E8 CaseSensitive                            ModelPrimitiveType bool bool bool Bool
    // 0E9 CaseSensitiveUserSet                     ModelPrimitiveType bool bool bool Bool
    // 0F0 EncodedTableName                         ModelPrimitiveType string string string String
    // 0F8 XmlText                                  ModelClassType DataColumn DataColumn DataColumn Pointer
    // 100 ColUnique                                ModelClassType DataColumn DataColumn DataColumn Pointer
    // 108 MinOccurs                                ModelEnumType Decimal Decimal Decimal Int32
    // 118 MaxOccurs                                ModelEnumType Decimal Decimal Decimal Int32
    // 128 RepeatableElement                        ModelPrimitiveType bool bool bool Bool
    // 130 _typeName                                <object> IL2CPP_TYPE_OBJECT
    // 138 PrimaryKey                               ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer
    // 140 PrimaryIndex                             ModelEnumListType IndexField[] IndexField[] List<IndexField> Pointer
    // 148 DelayedSetPrimaryKey                     ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer
    // 150 LoadIndex                                ModelClassType Index Index Index Pointer
    // 158 LoadIndexwithOriginalAdded               ModelClassType Index Index Index Pointer
    // 160 LoadIndexwithCurrentDeleted              ModelClassType Index Index Index Pointer
    // 168 SuspendIndexEvents                       ModelPrimitiveType int int int Int32
    // 16C InDataLoad                               ModelPrimitiveType bool bool bool Bool
    // 16D SchemaLoading                            ModelPrimitiveType bool bool bool Bool
    // 16E EnforceConstraints                       ModelPrimitiveType bool bool bool Bool
    // 16F SuspendEnforceConstraints                ModelPrimitiveType bool bool bool Bool
    // 170 FInitInProgress                          ModelPrimitiveType bool bool bool Bool
    // 171 InLoad                                   ModelPrimitiveType bool bool bool Bool
    // 172 FInLoadDiffgram                          ModelPrimitiveType bool bool bool Bool
    // 173 IsTypedDataTable                         ModelPrimitiveType sbyte sbyte sbyte SByte
    // 178 EmptyDataRowArray                        ModelClassListType DataRow[] DataRow[] List<DataRow> Pointer
    // 180 PropertyDescriptorCollectionCache        ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer
    // 188 NestedParentRelations                    ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer
    // 190 DependentColumns                         ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer
    // 198 MergingData                              ModelPrimitiveType bool bool bool Bool
    // 1A0 OnRowChangedDelegate                     ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1A8 OnRowChangingDelegate                    ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1B0 OnRowDeletingDelegate                    ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1B8 OnRowDeletedDelegate                     ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer
    // 1C0 OnColumnChangedDelegate                  ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer
    // 1C8 OnColumnChangingDelegate                 ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer
    // 1D0 OnTableClearingDelegate                  ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer
    // 1D8 OnTableClearedDelegate                   ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer
    // 1E0 OnTableNewRowDelegate                    ModelClassType DataTableNewRowEventHandler DataTableNewRowEventHandler DataTableNewRowEventHandler Pointer
    // 1E8 OnPropertyChangingDelegate               ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    // 1F0 RowBuilder                               ModelClassType DataRowBuilder DataRowBuilder DataRowBuilder Pointer
    // 1F8 DelayedViews                             ModelClassListType List`1<DataView> List`1<DataView> List<DataView> Pointer
    // 200 DataViewListeners                        ModelClassListType List`1<DataViewListener> List`1<DataViewListener> List<DataViewListener> Pointer
    // 208 RowDiffId                                ModelClassType Hashtable Hashtable Hashtable Pointer
    // 210 IndexesLock                              ModelClassType ReaderWriterLockSlim ReaderWriterLockSlim ReaderWriterLockSlim Pointer
    // 218 UkColumnPositionForInference             ModelPrimitiveType int int int Int32
    // 21C RemotingFormat                           ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 220 ObjectID                                 ModelPrimitiveType int int int Int32
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

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataSet.FromPointer); // 0x20 DataSet                     ( ModelClassType DataSet DataSet DataSet Pointer )
            value.DefaultView                               = GetObject<DataView>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataView.FromPointer); // 0x28 DefaultView                 ( ModelClassType DataView DataView DataView Pointer )
            value.NextRowID                                 = GetInt64(new IntPtr(p + 0x030)); // 0x30 NextRowID                   ( ModelPrimitiveType long long long Int64 )
            value.RowCollection                             = GetObject<DataRowCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.DataRowCollection.FromPointer); // 0x38 RowCollection               ( ModelClassType DataRowCollection DataRowCollection DataRowCollection Pointer )
            value.ColumnCollection                          = GetObject<DataColumnCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.DataColumnCollection.FromPointer); // 0x40 ColumnCollection            ( ModelClassType DataColumnCollection DataColumnCollection DataColumnCollection Pointer )
            value.ConstraintCollection                      = GetObject<ConstraintCollection>(new IntPtr(p + 0x048), ReversePrism.DataModels.ConstraintCollection.FromPointer); // 0x48 ConstraintCollection        ( ModelClassType ConstraintCollection ConstraintCollection ConstraintCollection Pointer )
            value.ElementColumnCount                        = GetInt32(new IntPtr(p + 0x050)); // 0x50 ElementColumnCount          ( ModelPrimitiveType int int int Int32 )
            value.ParentRelationsCollection                 = GetObject<DataRelationCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.DataRelationCollection.FromPointer); // 0x58 ParentRelationsCollection   ( ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer )
            value.ChildRelationsCollection                  = GetObject<DataRelationCollection>(new IntPtr(p + 0x060), ReversePrism.DataModels.DataRelationCollection.FromPointer); // 0x60 ChildRelationsCollection    ( ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer )
            value.RecordManager                             = GetObject<RecordManager>(new IntPtr(p + 0x068), ReversePrism.DataModels.RecordManager.FromPointer); // 0x68 RecordManager               ( ModelClassType RecordManager RecordManager RecordManager Pointer )
            value.Indexes                                   = GetObjectList<Index>(new IntPtr(p + 0x070), ReversePrism.DataModels.Index.FromPointer); // 0x70 Indexes                     ( ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer )
            value.ShadowIndexes                             = GetObjectList<Index>(new IntPtr(p + 0x078), ReversePrism.DataModels.Index.FromPointer); // 0x78 ShadowIndexes               ( ModelClassListType List`1<Index> List`1<Index> List<Index> Pointer )
            value.ShadowCount                               = GetInt32(new IntPtr(p + 0x080)); // 0x80 ShadowCount                 ( ModelPrimitiveType int int int Int32 )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x088), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0x88 ExtendedProperties          ( ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.TableName                                 = GetString(new IntPtr(p + 0x090)); // 0x90 TableName                   ( ModelPrimitiveType string string string String )
            value.TableNamespace                            = GetString(new IntPtr(p + 0x098)); // 0x98 TableNamespace              ( ModelPrimitiveType string string string String )
            value.TablePrefix                               = GetString(new IntPtr(p + 0x0A0)); // 0xA0 TablePrefix                 ( ModelPrimitiveType string string string String )
            value.DisplayExpression                         = GetObject<DataExpression>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataExpression.FromPointer); // 0xA8 DisplayExpression           ( ModelClassType DataExpression DataExpression DataExpression Pointer )
            value.FNestedInDataset                          = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 FNestedInDataset            ( ModelPrimitiveType bool bool bool Bool )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.CultureInfo.FromPointer); // 0xB8 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.CultureUserSet                            = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 CultureUserSet              ( ModelPrimitiveType bool bool bool Bool )
            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CompareInfo.FromPointer); // 0xC8 CompareInfo                 ( ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.CompareFlags                              = (CompareOptions)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 CompareFlags                ( ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )
            value.FormatProvider                            = GetObject<IFormatProvider>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.IFormatProvider.FromPointer); // 0xD8 FormatProvider              ( ModelClassType IFormatProvider IFormatProvider IFormatProvider Pointer )
            value.HashCodeProvider                          = GetObject<StringComparer>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.StringComparer.FromPointer); // 0xE0 HashCodeProvider            ( ModelClassType StringComparer StringComparer StringComparer Pointer )
            value.CaseSensitive                             = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 CaseSensitive               ( ModelPrimitiveType bool bool bool Bool )
            value.CaseSensitiveUserSet                      = GetBool(new IntPtr(p + 0x0E9)); // 0xE9 CaseSensitiveUserSet        ( ModelPrimitiveType bool bool bool Bool )
            value.EncodedTableName                          = GetString(new IntPtr(p + 0x0F0)); // 0xF0 EncodedTableName            ( ModelPrimitiveType string string string String )
            value.XmlText                                   = GetObject<DataColumn>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.DataColumn.FromPointer); // 0xF8 XmlText                     ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.ColUnique                                 = GetObject<DataColumn>(new IntPtr(p + 0x100), ReversePrism.DataModels.DataColumn.FromPointer); // 0x100 ColUnique                   ( ModelClassType DataColumn DataColumn DataColumn Pointer )
            value.MinOccurs                                 = (Decimal)GetInt32(new IntPtr(p + 0x108)); // 0x108 MinOccurs                   ( ModelEnumType Decimal Decimal Decimal Int32 )
            value.MaxOccurs                                 = (Decimal)GetInt32(new IntPtr(p + 0x118)); // 0x118 MaxOccurs                   ( ModelEnumType Decimal Decimal Decimal Int32 )
            value.RepeatableElement                         = GetBool(new IntPtr(p + 0x128)); // 0x128 RepeatableElement           ( ModelPrimitiveType bool bool bool Bool )
            value.PrimaryKey                                = GetObject<UniqueConstraint>(new IntPtr(p + 0x138), ReversePrism.DataModels.UniqueConstraint.FromPointer); // 0x138 PrimaryKey                  ( ModelClassType UniqueConstraint UniqueConstraint UniqueConstraint Pointer )
            value.PrimaryIndex                              = GetEnumList<IndexField>(new IntPtr(p + 0x140)); // 0x140 PrimaryIndex                ( ModelEnumListType IndexField[] IndexField[] List<IndexField> Pointer )
            value.DelayedSetPrimaryKey                      = GetObjectList<DataColumn>(new IntPtr(p + 0x148), ReversePrism.DataModels.DataColumn.FromPointer); // 0x148 DelayedSetPrimaryKey        ( ModelClassListType DataColumn[] DataColumn[] List<DataColumn> Pointer )
            value.LoadIndex                                 = GetObject<Index>(new IntPtr(p + 0x150), ReversePrism.DataModels.Index.FromPointer); // 0x150 LoadIndex                   ( ModelClassType Index Index Index Pointer )
            value.LoadIndexwithOriginalAdded                = GetObject<Index>(new IntPtr(p + 0x158), ReversePrism.DataModels.Index.FromPointer); // 0x158 LoadIndexwithOriginalAdded  ( ModelClassType Index Index Index Pointer )
            value.LoadIndexwithCurrentDeleted               = GetObject<Index>(new IntPtr(p + 0x160), ReversePrism.DataModels.Index.FromPointer); // 0x160 LoadIndexwithCurrentDeleted ( ModelClassType Index Index Index Pointer )
            value.SuspendIndexEvents                        = GetInt32(new IntPtr(p + 0x168)); // 0x168 SuspendIndexEvents          ( ModelPrimitiveType int int int Int32 )
            value.InDataLoad                                = GetBool(new IntPtr(p + 0x16C)); // 0x16C InDataLoad                  ( ModelPrimitiveType bool bool bool Bool )
            value.SchemaLoading                             = GetBool(new IntPtr(p + 0x16D)); // 0x16D SchemaLoading               ( ModelPrimitiveType bool bool bool Bool )
            value.EnforceConstraints                        = GetBool(new IntPtr(p + 0x16E)); // 0x16E EnforceConstraints          ( ModelPrimitiveType bool bool bool Bool )
            value.SuspendEnforceConstraints                 = GetBool(new IntPtr(p + 0x16F)); // 0x16F SuspendEnforceConstraints   ( ModelPrimitiveType bool bool bool Bool )
            value.FInitInProgress                           = GetBool(new IntPtr(p + 0x170)); // 0x170 FInitInProgress             ( ModelPrimitiveType bool bool bool Bool )
            value.InLoad                                    = GetBool(new IntPtr(p + 0x171)); // 0x171 InLoad                      ( ModelPrimitiveType bool bool bool Bool )
            value.FInLoadDiffgram                           = GetBool(new IntPtr(p + 0x172)); // 0x172 FInLoadDiffgram             ( ModelPrimitiveType bool bool bool Bool )
            value.IsTypedDataTable                          = GetSByte(new IntPtr(p + 0x173)); // 0x173 IsTypedDataTable            ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.EmptyDataRowArray                         = GetObjectList<DataRow>(new IntPtr(p + 0x178), ReversePrism.DataModels.DataRow.FromPointer); // 0x178 EmptyDataRowArray           ( ModelClassListType DataRow[] DataRow[] List<DataRow> Pointer )
            value.PropertyDescriptorCollectionCache         = GetObject<PropertyDescriptorCollection>(new IntPtr(p + 0x180), ReversePrism.DataModels.PropertyDescriptorCollection.FromPointer); // 0x180 PropertyDescriptorCollectionCache ( ModelClassType PropertyDescriptorCollection PropertyDescriptorCollection PropertyDescriptorCollection Pointer )
            value.NestedParentRelations                     = GetObjectList<DataRelation>(new IntPtr(p + 0x188), ReversePrism.DataModels.DataRelation.FromPointer); // 0x188 NestedParentRelations       ( ModelClassListType DataRelation[] DataRelation[] List<DataRelation> Pointer )
            value.DependentColumns                          = GetObjectList<DataColumn>(new IntPtr(p + 0x190), ReversePrism.DataModels.DataColumn.FromPointer); // 0x190 DependentColumns            ( ModelClassListType List`1<DataColumn> List`1<DataColumn> List<DataColumn> Pointer )
            value.MergingData                               = GetBool(new IntPtr(p + 0x198)); // 0x198 MergingData                 ( ModelPrimitiveType bool bool bool Bool )
            value.OnRowChangedDelegate                      = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0x1A0 OnRowChangedDelegate        ( ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnRowChangingDelegate                     = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0x1A8 OnRowChangingDelegate       ( ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnRowDeletingDelegate                     = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0x1B0 OnRowDeletingDelegate       ( ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnRowDeletedDelegate                      = GetObject<DataRowChangeEventHandler>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.DataRowChangeEventHandler.FromPointer); // 0x1B8 OnRowDeletedDelegate        ( ModelClassType DataRowChangeEventHandler DataRowChangeEventHandler DataRowChangeEventHandler Pointer )
            value.OnColumnChangedDelegate                   = GetObject<DataColumnChangeEventHandler>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.DataColumnChangeEventHandler.FromPointer); // 0x1C0 OnColumnChangedDelegate     ( ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer )
            value.OnColumnChangingDelegate                  = GetObject<DataColumnChangeEventHandler>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.DataColumnChangeEventHandler.FromPointer); // 0x1C8 OnColumnChangingDelegate    ( ModelClassType DataColumnChangeEventHandler DataColumnChangeEventHandler DataColumnChangeEventHandler Pointer )
            value.OnTableClearingDelegate                   = GetObject<DataTableClearEventHandler>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.DataTableClearEventHandler.FromPointer); // 0x1D0 OnTableClearingDelegate     ( ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer )
            value.OnTableClearedDelegate                    = GetObject<DataTableClearEventHandler>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.DataTableClearEventHandler.FromPointer); // 0x1D8 OnTableClearedDelegate      ( ModelClassType DataTableClearEventHandler DataTableClearEventHandler DataTableClearEventHandler Pointer )
            value.OnTableNewRowDelegate                     = GetObject<DataTableNewRowEventHandler>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.DataTableNewRowEventHandler.FromPointer); // 0x1E0 OnTableNewRowDelegate       ( ModelClassType DataTableNewRowEventHandler DataTableNewRowEventHandler DataTableNewRowEventHandler Pointer )
            value.OnPropertyChangingDelegate                = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0x1E8 OnPropertyChangingDelegate  ( ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )
            value.RowBuilder                                = GetObject<DataRowBuilder>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.DataRowBuilder.FromPointer); // 0x1F0 RowBuilder                  ( ModelClassType DataRowBuilder DataRowBuilder DataRowBuilder Pointer )
            value.DelayedViews                              = GetObjectList<DataView>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.DataView.FromPointer); // 0x1F8 DelayedViews                ( ModelClassListType List`1<DataView> List`1<DataView> List<DataView> Pointer )
            value.DataViewListeners                         = GetObjectList<DataViewListener>(new IntPtr(p + 0x200), ReversePrism.DataModels.DataViewListener.FromPointer); // 0x200 DataViewListeners           ( ModelClassListType List`1<DataViewListener> List`1<DataViewListener> List<DataViewListener> Pointer )
            value.RowDiffId                                 = GetObject<Hashtable>(new IntPtr(p + 0x208), ReversePrism.DataModels.Hashtable.FromPointer); // 0x208 RowDiffId                   ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.IndexesLock                               = GetObject<ReaderWriterLockSlim>(new IntPtr(p + 0x210), ReversePrism.DataModels.ReaderWriterLockSlim.FromPointer); // 0x210 IndexesLock                 ( ModelClassType ReaderWriterLockSlim ReaderWriterLockSlim ReaderWriterLockSlim Pointer )
            value.UkColumnPositionForInference              = GetInt32(new IntPtr(p + 0x218)); // 0x218 UkColumnPositionForInference ( ModelPrimitiveType int int int Int32 )
            value.RemotingFormat                            = (SerializationFormat)GetInt32(new IntPtr(p + 0x21C)); // 0x21C RemotingFormat              ( ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x220)); // 0x220 ObjectID                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
