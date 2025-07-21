using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataSet                                  ModelClassType DataSet DataSet DataSet Pointer
    // 018 NodeToSchemaMap                          ModelClassType XmlToDatasetMap XmlToDatasetMap XmlToDatasetMap Pointer
    // 020 NodeToRowMap                             ModelClassType Hashtable Hashtable Hashtable Pointer
    // 028 ChildRowsStack                           ModelClassType Stack Stack Stack Pointer
    // 030 HtableExcludedNS                         ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 FIsXdr                                   ModelPrimitiveType bool bool bool Bool
    // 039 IsDiffgram                               ModelPrimitiveType bool bool bool Bool
    // 040 TopMostNode                              ModelClassType XmlElement XmlElement XmlElement Pointer
    // 048 IgnoreSchema                             ModelPrimitiveType bool bool bool Bool
    // 050 DataTable                                ModelClassType DataTable DataTable DataTable Pointer
    // 058 IsTableLevel                             ModelPrimitiveType bool bool bool Bool
    // 059 FromInference                            ModelPrimitiveType bool bool bool Bool
    // 060 DataReader                               ModelClassType XmlReader XmlReader XmlReader Pointer
    // 068 _XSD_XMLNS_NS                            <object> IL2CPP_TYPE_OBJECT
    // 070 _XDR_SCHEMA                              <object> IL2CPP_TYPE_OBJECT
    // 078 _XDRNS                                   <object> IL2CPP_TYPE_OBJECT
    // 080 _SQL_SYNC                                <object> IL2CPP_TYPE_OBJECT
    // 088 _UPDGNS                                  <object> IL2CPP_TYPE_OBJECT
    // 090 _XSD_SCHEMA                              <object> IL2CPP_TYPE_OBJECT
    // 098 _XSDNS                                   <object> IL2CPP_TYPE_OBJECT
    // 0A0 _DFFNS                                   <object> IL2CPP_TYPE_OBJECT
    // 0A8 _MSDNS                                   <object> IL2CPP_TYPE_OBJECT
    // 0B0 _DIFFID                                  <object> IL2CPP_TYPE_OBJECT
    // 0B8 _HASCHANGES                              <object> IL2CPP_TYPE_OBJECT
    // 0C0 _ROWORDER                                <object> IL2CPP_TYPE_OBJECT
    public partial class XmlDataLoader : DataModel
    {
        public DataSet?                                 DataSet                                 { get; set; }
        public XmlToDatasetMap?                         NodeToSchemaMap                         { get; set; }
        public Hashtable?                               NodeToRowMap                            { get; set; }
        public Stack?                                   ChildRowsStack                          { get; set; }
        public Hashtable?                               HtableExcludedNS                        { get; set; }
        public bool                                     FIsXdr                                  { get; set; }
        public bool                                     IsDiffgram                              { get; set; }
        public XmlElement?                              TopMostNode                             { get; set; }
        public bool                                     IgnoreSchema                            { get; set; }
        public DataTable?                               DataTable                               { get; set; }
        public bool                                     IsTableLevel                            { get; set; }
        public bool                                     FromInference                           { get; set; }
        public XmlReader?                               DataReader                              { get; set; }

        public static XmlDataLoader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDataLoader() { Pointer= p0 };

            value.DataSet                                   = GetObject<DataSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataSet.FromPointer); // 0x10 DataSet                     ( ModelClassType DataSet DataSet DataSet Pointer )
            value.NodeToSchemaMap                           = GetObject<XmlToDatasetMap>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlToDatasetMap.FromPointer); // 0x18 NodeToSchemaMap             ( ModelClassType XmlToDatasetMap XmlToDatasetMap XmlToDatasetMap Pointer )
            value.NodeToRowMap                              = GetObject<Hashtable>(new IntPtr(p + 0x020), ReversePrism.DataModels.Hashtable.FromPointer); // 0x20 NodeToRowMap                ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ChildRowsStack                            = GetObject<Stack>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stack.FromPointer); // 0x28 ChildRowsStack              ( ModelClassType Stack Stack Stack Pointer )
            value.HtableExcludedNS                          = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 0x30 HtableExcludedNS            ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.FIsXdr                                    = GetBool(new IntPtr(p + 0x038)); // 0x38 FIsXdr                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsDiffgram                                = GetBool(new IntPtr(p + 0x039)); // 0x39 IsDiffgram                  ( ModelPrimitiveType bool bool bool Bool )
            value.TopMostNode                               = GetObject<XmlElement>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlElement.FromPointer); // 0x40 TopMostNode                 ( ModelClassType XmlElement XmlElement XmlElement Pointer )
            value.IgnoreSchema                              = GetBool(new IntPtr(p + 0x048)); // 0x48 IgnoreSchema                ( ModelPrimitiveType bool bool bool Bool )
            value.DataTable                                 = GetObject<DataTable>(new IntPtr(p + 0x050), ReversePrism.DataModels.DataTable.FromPointer); // 0x50 DataTable                   ( ModelClassType DataTable DataTable DataTable Pointer )
            value.IsTableLevel                              = GetBool(new IntPtr(p + 0x058)); // 0x58 IsTableLevel                ( ModelPrimitiveType bool bool bool Bool )
            value.FromInference                             = GetBool(new IntPtr(p + 0x059)); // 0x59 FromInference               ( ModelPrimitiveType bool bool bool Bool )
            value.DataReader                                = GetObject<XmlReader>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlReader.FromPointer); // 0x60 DataReader                  ( ModelClassType XmlReader XmlReader XmlReader Pointer )

            return value;
        }
    }
}
