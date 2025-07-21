using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DefaultViewManager                       ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    // 028 TableCollection                          ModelClassType DataTableCollection DataTableCollection DataTableCollection Pointer
    // 030 RelationCollection                       ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer
    // 038 ExtendedProperties                       ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 040 DataSetName                              ModelPrimitiveType string string string String
    // 048 DatasetPrefix                            ModelPrimitiveType string string string String
    // 050 NamespaceURI                             ModelPrimitiveType string string string String
    // 058 EnforceConstraints                       ModelPrimitiveType bool bool bool Bool
    // 059 CaseSensitive                            ModelPrimitiveType bool bool bool Bool
    // 060 Culture                                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 068 CultureUserSet                           ModelPrimitiveType bool bool bool Bool
    // 069 FInReadXml                               ModelPrimitiveType bool bool bool Bool
    // 06A FInLoadDiffgram                          ModelPrimitiveType bool bool bool Bool
    // 06B FTopLevelTable                           ModelPrimitiveType bool bool bool Bool
    // 06C FInitInProgress                          ModelPrimitiveType bool bool bool Bool
    // 06D FEnableCascading                         ModelPrimitiveType bool bool bool Bool
    // 06E FIsSchemaLoading                         ModelPrimitiveType bool bool bool Bool
    // 070 MainTableName                            ModelPrimitiveType string string string String
    // 078 RemotingFormat                           ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    // 080 _defaultViewManagerLock                  <object> IL2CPP_TYPE_OBJECT
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 088 ObjectID                                 ModelPrimitiveType int int int Int32
    // 008 s_schemaTypeForWSDL                      XmlSchemaComplexType IL2CPP_TYPE_CLASS
    // 08C UseDataSetSchemaOnly                     ModelPrimitiveType bool bool bool Bool
    // 08D UdtIsWrapped                             ModelPrimitiveType bool bool bool Bool
    // 090 PropertyChanging                         ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    // 098 MergeFailed                              ModelClassType MergeFailedEventHandler MergeFailedEventHandler MergeFailedEventHandler Pointer
    // 0A0 DataRowCreated                           ModelClassType DataRowCreatedEventHandler DataRowCreatedEventHandler DataRowCreatedEventHandler Pointer
    // 0A8 ClearFunctionCalled                      ModelClassType DataSetClearEventhandler DataSetClearEventhandler DataSetClearEventhandler Pointer
    public partial class DataSet : DataModel
    {
        public DataViewManager?                         DefaultViewManager                      { get; set; }
        public DataTableCollection?                     TableCollection                         { get; set; }
        public DataRelationCollection?                  RelationCollection                      { get; set; }
        public PropertyCollection?                      ExtendedProperties                      { get; set; }
        public string                                   DataSetName                             { get; set; }
        public string                                   DatasetPrefix                           { get; set; }
        public string                                   NamespaceURI                            { get; set; }
        public bool                                     EnforceConstraints                      { get; set; }
        public bool                                     CaseSensitive                           { get; set; }
        public CultureInfo?                             Culture                                 { get; set; }
        public bool                                     CultureUserSet                          { get; set; }
        public bool                                     FInReadXml                              { get; set; }
        public bool                                     FInLoadDiffgram                         { get; set; }
        public bool                                     FTopLevelTable                          { get; set; }
        public bool                                     FInitInProgress                         { get; set; }
        public bool                                     FEnableCascading                        { get; set; }
        public bool                                     FIsSchemaLoading                        { get; set; }
        public string                                   MainTableName                           { get; set; }
        public SerializationFormat                      RemotingFormat                          { get; set; }
        public int                                      ObjectID                                { get; set; }
        public bool                                     UseDataSetSchemaOnly                    { get; set; }
        public bool                                     UdtIsWrapped                            { get; set; }
        public PropertyChangedEventHandler?             PropertyChanging                        { get; set; }
        public MergeFailedEventHandler?                 MergeFailed                             { get; set; }
        public DataRowCreatedEventHandler?              DataRowCreated                          { get; set; }
        public DataSetClearEventhandler?                ClearFunctionCalled                     { get; set; }

        public static DataSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DataSet() { Pointer= p0 };

            value.DefaultViewManager                        = GetObject<DataViewManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataViewManager.FromPointer); // 0x20 DefaultViewManager          ( ModelClassType DataViewManager DataViewManager DataViewManager Pointer )
            value.TableCollection                           = GetObject<DataTableCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTableCollection.FromPointer); // 0x28 TableCollection             ( ModelClassType DataTableCollection DataTableCollection DataTableCollection Pointer )
            value.RelationCollection                        = GetObject<DataRelationCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.DataRelationCollection.FromPointer); // 0x30 RelationCollection          ( ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.PropertyCollection.FromPointer); // 0x38 ExtendedProperties          ( ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.DataSetName                               = GetString(new IntPtr(p + 0x040)); // 0x40 DataSetName                 ( ModelPrimitiveType string string string String )
            value.DatasetPrefix                             = GetString(new IntPtr(p + 0x048)); // 0x48 DatasetPrefix               ( ModelPrimitiveType string string string String )
            value.NamespaceURI                              = GetString(new IntPtr(p + 0x050)); // 0x50 NamespaceURI                ( ModelPrimitiveType string string string String )
            value.EnforceConstraints                        = GetBool(new IntPtr(p + 0x058)); // 0x58 EnforceConstraints          ( ModelPrimitiveType bool bool bool Bool )
            value.CaseSensitive                             = GetBool(new IntPtr(p + 0x059)); // 0x59 CaseSensitive               ( ModelPrimitiveType bool bool bool Bool )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x60 Culture                     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.CultureUserSet                            = GetBool(new IntPtr(p + 0x068)); // 0x68 CultureUserSet              ( ModelPrimitiveType bool bool bool Bool )
            value.FInReadXml                                = GetBool(new IntPtr(p + 0x069)); // 0x69 FInReadXml                  ( ModelPrimitiveType bool bool bool Bool )
            value.FInLoadDiffgram                           = GetBool(new IntPtr(p + 0x06A)); // 0x6A FInLoadDiffgram             ( ModelPrimitiveType bool bool bool Bool )
            value.FTopLevelTable                            = GetBool(new IntPtr(p + 0x06B)); // 0x6B FTopLevelTable              ( ModelPrimitiveType bool bool bool Bool )
            value.FInitInProgress                           = GetBool(new IntPtr(p + 0x06C)); // 0x6C FInitInProgress             ( ModelPrimitiveType bool bool bool Bool )
            value.FEnableCascading                          = GetBool(new IntPtr(p + 0x06D)); // 0x6D FEnableCascading            ( ModelPrimitiveType bool bool bool Bool )
            value.FIsSchemaLoading                          = GetBool(new IntPtr(p + 0x06E)); // 0x6E FIsSchemaLoading            ( ModelPrimitiveType bool bool bool Bool )
            value.MainTableName                             = GetString(new IntPtr(p + 0x070)); // 0x70 MainTableName               ( ModelPrimitiveType string string string String )
            value.RemotingFormat                            = (SerializationFormat)GetInt32(new IntPtr(p + 0x078)); // 0x78 RemotingFormat              ( ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x088)); // 0x88 ObjectID                    ( ModelPrimitiveType int int int Int32 )
            value.UseDataSetSchemaOnly                      = GetBool(new IntPtr(p + 0x08C)); // 0x8C UseDataSetSchemaOnly        ( ModelPrimitiveType bool bool bool Bool )
            value.UdtIsWrapped                              = GetBool(new IntPtr(p + 0x08D)); // 0x8D UdtIsWrapped                ( ModelPrimitiveType bool bool bool Bool )
            value.PropertyChanging                          = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x090), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 0x90 PropertyChanging            ( ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )
            value.MergeFailed                               = GetObject<MergeFailedEventHandler>(new IntPtr(p + 0x098), ReversePrism.DataModels.MergeFailedEventHandler.FromPointer); // 0x98 MergeFailed                 ( ModelClassType MergeFailedEventHandler MergeFailedEventHandler MergeFailedEventHandler Pointer )
            value.DataRowCreated                            = GetObject<DataRowCreatedEventHandler>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DataRowCreatedEventHandler.FromPointer); // 0xA0 DataRowCreated              ( ModelClassType DataRowCreatedEventHandler DataRowCreatedEventHandler DataRowCreatedEventHandler Pointer )
            value.ClearFunctionCalled                       = GetObject<DataSetClearEventhandler>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataSetClearEventhandler.FromPointer); // 0xA8 ClearFunctionCalled         ( ModelClassType DataSetClearEventhandler DataSetClearEventhandler DataSetClearEventhandler Pointer )

            return value;
        }
    }
}
