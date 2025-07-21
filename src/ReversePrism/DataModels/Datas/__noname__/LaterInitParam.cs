using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 ModelPrimitiveType bool bool bool Bool
    // 018 InputStream                              ModelClassType Stream Stream Stream Pointer
    // 020 InputBytes                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 InputByteCount                           ModelPrimitiveType int int int Int32
    // 030 InputbaseUri                             ModelClassType Uri Uri Uri Pointer
    // 038 InputUriStr                              ModelPrimitiveType string string string String
    // 040 InputUriResolver                         ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 048 InputContext                             ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer
    // 050 InputTextReader                          ModelClassType TextReader TextReader TextReader Pointer
    // 058 InitType                                 ModelEnumType InitInputType InitInputType InitInputType Int32
    public partial class LaterInitParam : DataModel
    {
        public bool                                     UseAsync                                { get; set; }
        public Stream?                                  InputStream                             { get; set; }
        public List<sbyte>?                             InputBytes                              { get; set; }
        public int                                      InputByteCount                          { get; set; }
        public Uri?                                     InputbaseUri                            { get; set; }
        public string                                   InputUriStr                             { get; set; }
        public XmlResolver?                             InputUriResolver                        { get; set; }
        public XmlParserContext?                        InputContext                            { get; set; }
        public TextReader?                              InputTextReader                         { get; set; }
        public InitInputType                            InitType                                { get; set; }

        public static LaterInitParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LaterInitParam() { Pointer= p0 };

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 UseAsync                    ( ModelPrimitiveType bool bool bool Bool )
            value.InputStream                               = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 0x18 InputStream                 ( ModelClassType Stream Stream Stream Pointer )
            value.InputBytes                                = GetSByteList(new IntPtr(p + 0x020)); // 0x20 InputBytes                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.InputByteCount                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 InputByteCount              ( ModelPrimitiveType int int int Int32 )
            value.InputbaseUri                              = GetObject<Uri>(new IntPtr(p + 0x030), ReversePrism.DataModels.Uri.FromPointer); // 0x30 InputbaseUri                ( ModelClassType Uri Uri Uri Pointer )
            value.InputUriStr                               = GetString(new IntPtr(p + 0x038)); // 0x38 InputUriStr                 ( ModelPrimitiveType string string string String )
            value.InputUriResolver                          = GetObject<XmlResolver>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlResolver.FromPointer); // 0x40 InputUriResolver            ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.InputContext                              = GetObject<XmlParserContext>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlParserContext.FromPointer); // 0x48 InputContext                ( ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer )
            value.InputTextReader                           = GetObject<TextReader>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextReader.FromPointer); // 0x50 InputTextReader             ( ModelClassType TextReader TextReader TextReader Pointer )
            value.InitType                                  = (InitInputType)GetInt32(new IntPtr(p + 0x058)); // 0x58 InitType                    ( ModelEnumType InitInputType InitInputType InitInputType Int32 )

            return value;
        }
    }
}
