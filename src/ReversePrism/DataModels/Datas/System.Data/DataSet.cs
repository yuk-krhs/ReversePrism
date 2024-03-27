using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DefaultViewManager                       0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer
    // 028 TableCollection                          000186682E30 ModelClassType DataTableCollection DataTableCollection DataTableCollection Pointer
    // 030 RelationCollection                       00018667CAC0 ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer
    // 038 ExtendedProperties                       0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer
    // 040 DataSetName                              000186671910 ModelPrimitiveType string string string String
    // 048 DatasetPrefix                            000186671910 ModelPrimitiveType string string string String
    // 050 NamespaceURI                             000186671BA0 ModelPrimitiveType string string string String
    // 058 EnforceConstraints                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 CaseSensitive                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 Culture                                  0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 068 CultureUserSet                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 FInReadXml                               000186595210 ModelPrimitiveType bool bool bool Bool
    // 06A FInLoadDiffgram                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 06B FTopLevelTable                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 06C FInitInProgress                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 06D FEnableCascading                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 06E FIsSchemaLoading                         000186595210 ModelPrimitiveType bool bool bool Bool
    // 070 MainTableName                            000186671BA0 ModelPrimitiveType string string string String
    // 078 RemotingFormat                           00018672DA00 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32
    // 080 _defaultViewManagerLock                  <object> IL2CPP_TYPE_OBJECT
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 088 ObjectID                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 008 s_schemaTypeForWSDL                      XmlSchemaComplexType IL2CPP_TYPE_CLASS
    // 08C UseDataSetSchemaOnly                     000186595210 ModelPrimitiveType bool bool bool Bool
    // 08D UdtIsWrapped                             000186595210 ModelPrimitiveType bool bool bool Bool
    // 090 PropertyChanging                         0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer
    // 098 MergeFailed                              0001865FF640 ModelClassType MergeFailedEventHandler MergeFailedEventHandler MergeFailedEventHandler Pointer
    // 0A0 DataRowCreated                           00018667F5C0 ModelClassType DataRowCreatedEventHandler DataRowCreatedEventHandler DataRowCreatedEventHandler Pointer
    // 0A8 ClearFunctionCalled                      000186681170 ModelClassType DataSetClearEventhandler DataSetClearEventhandler DataSetClearEventhandler Pointer
    public partial class DataSet
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
            var value   = new DataSet();

            value.DefaultViewManager                        = GetObject<DataViewManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataViewManager.FromPointer); // 0270060599B8 0x20 DefaultViewManager          ( 0001866861A0 ModelClassType DataViewManager DataViewManager DataViewManager Pointer )
            value.TableCollection                           = GetObject<DataTableCollection>(new IntPtr(p + 0x028), ReversePrism.DataModels.DataTableCollection.FromPointer); // 0270060599D8 0x28 TableCollection             ( 000186682E30 ModelClassType DataTableCollection DataTableCollection DataTableCollection Pointer )
            value.RelationCollection                        = GetObject<DataRelationCollection>(new IntPtr(p + 0x030), ReversePrism.DataModels.DataRelationCollection.FromPointer); // 0270060599F8 0x30 RelationCollection          ( 00018667CAC0 ModelClassType DataRelationCollection DataRelationCollection DataRelationCollection Pointer )
            value.ExtendedProperties                        = GetObject<PropertyCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.PropertyCollection.FromPointer); // 027006059A18 0x38 ExtendedProperties          ( 0001865D2A60 ModelClassType PropertyCollection PropertyCollection PropertyCollection Pointer )
            value.DataSetName                               = GetString(new IntPtr(p + 0x040)); // 027006059A38 0x40 DataSetName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.DatasetPrefix                             = GetString(new IntPtr(p + 0x048)); // 027006059A58 0x48 DatasetPrefix               ( 000186671910 ModelPrimitiveType string string string String )
            value.NamespaceURI                              = GetString(new IntPtr(p + 0x050)); // 027006059A78 0x50 NamespaceURI                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.EnforceConstraints                        = GetBool(new IntPtr(p + 0x058)); // 027006059A98 0x58 EnforceConstraints          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CaseSensitive                             = GetBool(new IntPtr(p + 0x059)); // 027006059AB8 0x59 CaseSensitive               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Culture                                   = GetObject<CultureInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.CultureInfo.FromPointer); // 027006059AD8 0x60 Culture                     ( 0001865B47C0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.CultureUserSet                            = GetBool(new IntPtr(p + 0x068)); // 027006059AF8 0x68 CultureUserSet              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FInReadXml                                = GetBool(new IntPtr(p + 0x069)); // 027006059B18 0x69 FInReadXml                  ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FInLoadDiffgram                           = GetBool(new IntPtr(p + 0x06A)); // 027006059B38 0x6A FInLoadDiffgram             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FTopLevelTable                            = GetBool(new IntPtr(p + 0x06B)); // 027006059B58 0x6B FTopLevelTable              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FInitInProgress                           = GetBool(new IntPtr(p + 0x06C)); // 027006059B78 0x6C FInitInProgress             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FEnableCascading                          = GetBool(new IntPtr(p + 0x06D)); // 027006059B98 0x6D FEnableCascading            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.FIsSchemaLoading                          = GetBool(new IntPtr(p + 0x06E)); // 027006059BB8 0x6E FIsSchemaLoading            ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.MainTableName                             = GetString(new IntPtr(p + 0x070)); // 027006059BD8 0x70 MainTableName               ( 000186671BA0 ModelPrimitiveType string string string String )
            value.RemotingFormat                            = (SerializationFormat)GetInt32(new IntPtr(p + 0x078)); // 027006059BF8 0x78 RemotingFormat              ( 00018672DA00 ModelEnumType SerializationFormat SerializationFormat SerializationFormat Int32 )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x088)); // 027006059C58 0x88 ObjectID                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UseDataSetSchemaOnly                      = GetBool(new IntPtr(p + 0x08C)); // 027006059C98 0x8C UseDataSetSchemaOnly        ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.UdtIsWrapped                              = GetBool(new IntPtr(p + 0x08D)); // 027006059CB8 0x8D UdtIsWrapped                ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.PropertyChanging                          = GetObject<PropertyChangedEventHandler>(new IntPtr(p + 0x090), ReversePrism.DataModels.PropertyChangedEventHandler.FromPointer); // 027006059CD8 0x90 PropertyChanging            ( 0001865D1C20 ModelClassType PropertyChangedEventHandler PropertyChangedEventHandler PropertyChangedEventHandler Pointer )
            value.MergeFailed                               = GetObject<MergeFailedEventHandler>(new IntPtr(p + 0x098), ReversePrism.DataModels.MergeFailedEventHandler.FromPointer); // 027006059CF8 0x98 MergeFailed                 ( 0001865FF640 ModelClassType MergeFailedEventHandler MergeFailedEventHandler MergeFailedEventHandler Pointer )
            value.DataRowCreated                            = GetObject<DataRowCreatedEventHandler>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.DataRowCreatedEventHandler.FromPointer); // 027006059D18 0xA0 DataRowCreated              ( 00018667F5C0 ModelClassType DataRowCreatedEventHandler DataRowCreatedEventHandler DataRowCreatedEventHandler Pointer )
            value.ClearFunctionCalled                       = GetObject<DataSetClearEventhandler>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.DataSetClearEventhandler.FromPointer); // 027006059D38 0xA8 ClearFunctionCalled         ( 000186681170 ModelClassType DataSetClearEventhandler DataSetClearEventhandler DataSetClearEventhandler Pointer )

            return value;
        }
    }
}
