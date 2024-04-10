using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 InputStream                              000186670990 ModelClassType Stream Stream Stream Pointer
    // 020 InputBytes                               000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 InputByteCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 InputbaseUri                             0001866A4730 ModelClassType Uri Uri Uri Pointer
    // 038 InputUriStr                              0001866722E0 ModelPrimitiveType string string string String
    // 040 InputUriResolver                         0001865ABE90 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 048 InputContext                             0001865A8300 ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer
    // 050 InputTextReader                          000186645020 ModelClassType TextReader TextReader TextReader Pointer
    // 058 InitType                                 000186743DB0 ModelEnumType InitInputType InitInputType InitInputType Int32
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

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 024667438470 0x10 UseAsync                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.InputStream                               = GetObject<Stream>(new IntPtr(p + 0x018), ReversePrism.DataModels.Stream.FromPointer); // 024667438490 0x18 InputStream                 ( 000186670990 ModelClassType Stream Stream Stream Pointer )
            value.InputBytes                                = GetSByteList(new IntPtr(p + 0x020)); // 0246674384B0 0x20 InputBytes                  ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.InputByteCount                            = GetInt32(new IntPtr(p + 0x028)); // 0246674384D0 0x28 InputByteCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.InputbaseUri                              = GetObject<Uri>(new IntPtr(p + 0x030), ReversePrism.DataModels.Uri.FromPointer); // 0246674384F0 0x30 InputbaseUri                ( 0001866A4730 ModelClassType Uri Uri Uri Pointer )
            value.InputUriStr                               = GetString(new IntPtr(p + 0x038)); // 024667438510 0x38 InputUriStr                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.InputUriResolver                          = GetObject<XmlResolver>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlResolver.FromPointer); // 024667438530 0x40 InputUriResolver            ( 0001865ABE90 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.InputContext                              = GetObject<XmlParserContext>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlParserContext.FromPointer); // 024667438550 0x48 InputContext                ( 0001865A8300 ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer )
            value.InputTextReader                           = GetObject<TextReader>(new IntPtr(p + 0x050), ReversePrism.DataModels.TextReader.FromPointer); // 024667438570 0x50 InputTextReader             ( 000186645020 ModelClassType TextReader TextReader TextReader Pointer )
            value.InitType                                  = (InitInputType)GetInt32(new IntPtr(p + 0x058)); // 024667438590 0x58 InitType                    ( 000186743DB0 ModelEnumType InitInputType InitInputType InitInputType Int32 )

            return value;
        }
    }
}
