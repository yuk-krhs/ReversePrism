using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchemaSet                                ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer
    // 018 DsElement                                ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
    // 020 Ds                                       ModelClassType DataSet DataSet DataSet Pointer
    // 028 SchemaName                               ModelPrimitiveType string string string String
    // 030 ColumnExpressions                        ModelClassType ArrayList ArrayList ArrayList Pointer
    // 038 ConstraintNodes                          ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 RefTables                                ModelClassType ArrayList ArrayList ArrayList Pointer
    // 048 ComplexTypes                             ModelClassType ArrayList ArrayList ArrayList Pointer
    // 050 Annotations                              ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 058 Elements                                 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 060 Attributes                               ModelClassType Hashtable Hashtable Hashtable Pointer
    // 068 ElementsTable                            ModelClassType Hashtable Hashtable Hashtable Pointer
    // 070 AttributeGroups                          ModelClassType Hashtable Hashtable Hashtable Pointer
    // 078 SchemaTypes                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 080 Expressions                              ModelClassType Hashtable Hashtable Hashtable Pointer
    // 088 _tableDictionary                         Dictionary`2<DataTable, List`1<DataTable>> IL2CPP_TYPE_GENERICINST
    // 090 UdSimpleTypes                            ModelClassType Hashtable Hashtable Hashtable Pointer
    // 098 ExistingSimpleTypeMap                    ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0A0 FromInference                            ModelPrimitiveType bool bool bool Bool
    // 000 s_mapNameTypeXsd                         NameType[] IL2CPP_TYPE_SZARRAY
    public partial class XSDSchema : DataModel
    {
        public XmlSchemaSet?                            SchemaSet                               { get; set; }
        public XmlSchemaElement?                        DsElement                               { get; set; }
        public DataSet?                                 Ds                                      { get; set; }
        public string                                   SchemaName                              { get; set; }
        public ArrayList?                               ColumnExpressions                       { get; set; }
        public Hashtable?                               ConstraintNodes                         { get; set; }
        public ArrayList?                               RefTables                               { get; set; }
        public ArrayList?                               ComplexTypes                            { get; set; }
        public XmlSchemaObjectCollection?               Annotations                             { get; set; }
        public XmlSchemaObjectCollection?               Elements                                { get; set; }
        public Hashtable?                               Attributes                              { get; set; }
        public Hashtable?                               ElementsTable                           { get; set; }
        public Hashtable?                               AttributeGroups                         { get; set; }
        public Hashtable?                               SchemaTypes                             { get; set; }
        public Hashtable?                               Expressions                             { get; set; }
        public Hashtable?                               UdSimpleTypes                           { get; set; }
        public Hashtable?                               ExistingSimpleTypeMap                   { get; set; }
        public bool                                     FromInference                           { get; set; }

        public static XSDSchema? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XSDSchema() { Pointer= p0 };

            value.SchemaSet                                 = GetObject<XmlSchemaSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaSet.FromPointer); // 0x10 SchemaSet                   ( ModelClassType XmlSchemaSet XmlSchemaSet XmlSchemaSet Pointer )
            value.DsElement                                 = GetObject<XmlSchemaElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 0x18 DsElement                   ( ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )
            value.Ds                                        = GetObject<DataSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.DataSet.FromPointer); // 0x20 Ds                          ( ModelClassType DataSet DataSet DataSet Pointer )
            value.SchemaName                                = GetString(new IntPtr(p + 0x028)); // 0x28 SchemaName                  ( ModelPrimitiveType string string string String )
            value.ColumnExpressions                         = GetObject<ArrayList>(new IntPtr(p + 0x030), ReversePrism.DataModels.ArrayList.FromPointer); // 0x30 ColumnExpressions           ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ConstraintNodes                           = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 ConstraintNodes             ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.RefTables                                 = GetObject<ArrayList>(new IntPtr(p + 0x040), ReversePrism.DataModels.ArrayList.FromPointer); // 0x40 RefTables                   ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.ComplexTypes                              = GetObject<ArrayList>(new IntPtr(p + 0x048), ReversePrism.DataModels.ArrayList.FromPointer); // 0x48 ComplexTypes                ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Annotations                               = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x50 Annotations                 ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Elements                                  = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x58 Elements                    ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.Attributes                                = GetObject<Hashtable>(new IntPtr(p + 0x060), ReversePrism.DataModels.Hashtable.FromPointer); // 0x60 Attributes                  ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ElementsTable                             = GetObject<Hashtable>(new IntPtr(p + 0x068), ReversePrism.DataModels.Hashtable.FromPointer); // 0x68 ElementsTable               ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.AttributeGroups                           = GetObject<Hashtable>(new IntPtr(p + 0x070), ReversePrism.DataModels.Hashtable.FromPointer); // 0x70 AttributeGroups             ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.SchemaTypes                               = GetObject<Hashtable>(new IntPtr(p + 0x078), ReversePrism.DataModels.Hashtable.FromPointer); // 0x78 SchemaTypes                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Expressions                               = GetObject<Hashtable>(new IntPtr(p + 0x080), ReversePrism.DataModels.Hashtable.FromPointer); // 0x80 Expressions                 ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.UdSimpleTypes                             = GetObject<Hashtable>(new IntPtr(p + 0x090), ReversePrism.DataModels.Hashtable.FromPointer); // 0x90 UdSimpleTypes               ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.ExistingSimpleTypeMap                     = GetObject<Hashtable>(new IntPtr(p + 0x098), ReversePrism.DataModels.Hashtable.FromPointer); // 0x98 ExistingSimpleTypeMap       ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.FromInference                             = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 FromInference               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
