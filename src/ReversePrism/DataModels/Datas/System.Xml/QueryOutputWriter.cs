using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Wrapped                                  ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer
    // 030 InCDataSection                           ModelPrimitiveType bool bool bool Bool
    // 038 lookupCDataElems                         Dictionary`2<XmlQualifiedName, int> IL2CPP_TYPE_GENERICINST
    // 040 BitsCData                                ModelClassType BitStack BitStack BitStack Pointer
    // 048 QnameCData                               ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 050 OutputDocType                            ModelPrimitiveType bool bool bool Bool
    // 051 CheckWellFormedDoc                       ModelPrimitiveType bool bool bool Bool
    // 052 HasDocElem                               ModelPrimitiveType bool bool bool Bool
    // 053 InAttr                                   ModelPrimitiveType bool bool bool Bool
    // 058 SystemId                                 ModelPrimitiveType string string string String
    // 060 PublicId                                 ModelPrimitiveType string string string String
    // 068 Depth                                    ModelPrimitiveType int int int Int32
    public partial class QueryOutputWriter : DataModel
    {
        public XmlRawWriter?                            Wrapped                                 { get; set; }
        public bool                                     InCDataSection                          { get; set; }
        public BitStack?                                BitsCData                               { get; set; }
        public XmlQualifiedName?                        QnameCData                              { get; set; }
        public bool                                     OutputDocType                           { get; set; }
        public bool                                     CheckWellFormedDoc                      { get; set; }
        public bool                                     HasDocElem                              { get; set; }
        public bool                                     InAttr                                  { get; set; }
        public string                                   SystemId                                { get; set; }
        public string                                   PublicId                                { get; set; }
        public int                                      Depth                                   { get; set; }

        public static QueryOutputWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueryOutputWriter() { Pointer= p0 };

            value.Wrapped                                   = GetObject<XmlRawWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlRawWriter.FromPointer); // 0x28 Wrapped                     ( ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer )
            value.InCDataSection                            = GetBool(new IntPtr(p + 0x030)); // 0x30 InCDataSection              ( ModelPrimitiveType bool bool bool Bool )
            value.BitsCData                                 = GetObject<BitStack>(new IntPtr(p + 0x040), ReversePrism.DataModels.BitStack.FromPointer); // 0x40 BitsCData                   ( ModelClassType BitStack BitStack BitStack Pointer )
            value.QnameCData                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x48 QnameCData                  ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.OutputDocType                             = GetBool(new IntPtr(p + 0x050)); // 0x50 OutputDocType               ( ModelPrimitiveType bool bool bool Bool )
            value.CheckWellFormedDoc                        = GetBool(new IntPtr(p + 0x051)); // 0x51 CheckWellFormedDoc          ( ModelPrimitiveType bool bool bool Bool )
            value.HasDocElem                                = GetBool(new IntPtr(p + 0x052)); // 0x52 HasDocElem                  ( ModelPrimitiveType bool bool bool Bool )
            value.InAttr                                    = GetBool(new IntPtr(p + 0x053)); // 0x53 InAttr                      ( ModelPrimitiveType bool bool bool Bool )
            value.SystemId                                  = GetString(new IntPtr(p + 0x058)); // 0x58 SystemId                    ( ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x060)); // 0x60 PublicId                    ( ModelPrimitiveType string string string String )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x068)); // 0x68 Depth                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
