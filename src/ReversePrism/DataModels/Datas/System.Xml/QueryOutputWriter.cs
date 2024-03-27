using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Wrapped                                  0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer
    // 030 InCDataSection                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 lookupCDataElems                         Dictionary`2<XmlQualifiedName, int> IL2CPP_TYPE_GENERICINST
    // 040 BitsCData                                000186763960 ModelClassType BitStack BitStack BitStack Pointer
    // 048 QnameCData                               0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 050 OutputDocType                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 CheckWellFormedDoc                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 052 HasDocElem                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 053 InAttr                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 SystemId                                 000186671910 ModelPrimitiveType string string string String
    // 060 PublicId                                 000186671910 ModelPrimitiveType string string string String
    // 068 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class QueryOutputWriter
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
            var value   = new QueryOutputWriter();

            value.Wrapped                                   = GetObject<XmlRawWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlRawWriter.FromPointer); // 0270D7378180 0x28 Wrapped                     ( 0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer )
            value.InCDataSection                            = GetBool(new IntPtr(p + 0x030)); // 0270D73781A0 0x30 InCDataSection              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BitsCData                                 = GetObject<BitStack>(new IntPtr(p + 0x040), ReversePrism.DataModels.BitStack.FromPointer); // 0270D73781E0 0x40 BitsCData                   ( 000186763960 ModelClassType BitStack BitStack BitStack Pointer )
            value.QnameCData                                = GetObject<XmlQualifiedName>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D7378200 0x48 QnameCData                  ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.OutputDocType                             = GetBool(new IntPtr(p + 0x050)); // 0270D7378220 0x50 OutputDocType               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CheckWellFormedDoc                        = GetBool(new IntPtr(p + 0x051)); // 0270D7378240 0x51 CheckWellFormedDoc          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HasDocElem                                = GetBool(new IntPtr(p + 0x052)); // 0270D7378260 0x52 HasDocElem                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.InAttr                                    = GetBool(new IntPtr(p + 0x053)); // 0270D7378280 0x53 InAttr                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SystemId                                  = GetString(new IntPtr(p + 0x058)); // 0270D73782A0 0x58 SystemId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x060)); // 0270D73782C0 0x60 PublicId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x068)); // 0270D73782E0 0x68 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
