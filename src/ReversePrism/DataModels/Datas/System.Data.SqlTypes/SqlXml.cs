using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_sqlReaderDelegate                      Func`4<Stream, XmlReaderSettings, XmlParserContext, XmlReader> IL2CPP_TYPE_GENERICINST
    // 008 s_defaultXmlReaderSettings               XmlReaderSettings IL2CPP_TYPE_CLASS
    // 010 S_defaultXmlReaderSettingsCloseInput     ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer
    // 018 S_createSqlReaderMethodInfo              ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 010 CreateSqlReaderMethodInfo                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 FNotNull                                 ModelPrimitiveType bool bool bool Bool
    // 020 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 028 FirstCreateReader                        ModelPrimitiveType bool bool bool Bool
    public partial class SqlXml : DataModel
    {
        public XmlReaderSettings?                       S_defaultXmlReaderSettingsCloseInput    { get; set; }
        public MethodInfo?                              S_createSqlReaderMethodInfo             { get; set; }
        public MethodInfo?                              CreateSqlReaderMethodInfo               { get; set; }
        public bool                                     FNotNull                                { get; set; }
        public Stream?                                  Stream                                  { get; set; }
        public bool                                     FirstCreateReader                       { get; set; }

        public static SqlXml? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlXml() { Pointer= p0 };

            value.S_defaultXmlReaderSettingsCloseInput      = GetObject<XmlReaderSettings>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlReaderSettings.FromPointer); // 0x10 S_defaultXmlReaderSettingsCloseInput ( ModelClassType XmlReaderSettings XmlReaderSettings XmlReaderSettings Pointer )
            value.S_createSqlReaderMethodInfo               = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x18 S_createSqlReaderMethodInfo ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.CreateSqlReaderMethodInfo                 = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x10 CreateSqlReaderMethodInfo   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.FNotNull                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 FNotNull                    ( ModelPrimitiveType bool bool bool Bool )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x020), ReversePrism.DataModels.Stream.FromPointer); // 0x20 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.FirstCreateReader                         = GetBool(new IntPtr(p + 0x028)); // 0x28 FirstCreateReader           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
