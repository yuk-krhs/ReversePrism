using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Table                                  Dictionary`2<string, UriParser> IL2CPP_TYPE_GENERICINST
    // 008 m_TempTable                              Dictionary`2<string, UriParser> IL2CPP_TYPE_GENERICINST
    // 010 M_Flags                                  0001867483E0 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    // 014 M_UpdatableFlags                         0001867483E0 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    // 018 M_UpdatableFlagsUsed                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01C M_Port                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_Scheme                                 000186671910 ModelPrimitiveType string string string String
    // 010 HttpUri                                  0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 018 HttpsUri                                 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 020 WsUri                                    0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 028 WssUri                                   0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 030 FtpUri                                   0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 038 FileUri                                  0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 040 GopherUri                                0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 048 NntpUri                                  0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 050 NewsUri                                  0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 058 MailToUri                                0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 060 UuidUri                                  0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 068 TelnetUri                                0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 070 LdapUri                                  0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 078 NetTcpUri                                0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 080 NetPipeUri                               0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 088 VsMacrosUri                              0001866A6220 ModelClassType UriParser UriParser UriParser Pointer
    // 090 S_QuirksVersion                          0001866C09A0 ModelEnumType UriQuirksVersion UriQuirksVersion UriQuirksVersion Int32
    // 094 HttpSyntaxFlags                          000186748600 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    // 098 FileSyntaxFlags                          000186748600 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    public partial class UriParser : DataModel
    {
        public UriSyntaxFlags                           M_Flags                                 { get; set; }
        public UriSyntaxFlags                           M_UpdatableFlags                        { get; set; }
        public bool                                     M_UpdatableFlagsUsed                    { get; set; }
        public int                                      M_Port                                  { get; set; }
        public string                                   M_Scheme                                { get; set; }
        public UriParser?                               HttpUri                                 { get; set; }
        public UriParser?                               HttpsUri                                { get; set; }
        public UriParser?                               WsUri                                   { get; set; }
        public UriParser?                               WssUri                                  { get; set; }
        public UriParser?                               FtpUri                                  { get; set; }
        public UriParser?                               FileUri                                 { get; set; }
        public UriParser?                               GopherUri                               { get; set; }
        public UriParser?                               NntpUri                                 { get; set; }
        public UriParser?                               NewsUri                                 { get; set; }
        public UriParser?                               MailToUri                               { get; set; }
        public UriParser?                               UuidUri                                 { get; set; }
        public UriParser?                               TelnetUri                               { get; set; }
        public UriParser?                               LdapUri                                 { get; set; }
        public UriParser?                               NetTcpUri                               { get; set; }
        public UriParser?                               NetPipeUri                              { get; set; }
        public UriParser?                               VsMacrosUri                             { get; set; }
        public UriQuirksVersion                         S_QuirksVersion                         { get; set; }
        public UriSyntaxFlags                           HttpSyntaxFlags                         { get; set; }
        public UriSyntaxFlags                           FileSyntaxFlags                         { get; set; }

        public static UriParser? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UriParser() { Pointer= p0 };

            value.M_Flags                                   = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x010)); // 0245A4C577E0 0x10 M_Flags                     ( 0001867483E0 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )
            value.M_UpdatableFlags                          = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x014)); // 0245A4C57800 0x14 M_UpdatableFlags            ( 0001867483E0 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )
            value.M_UpdatableFlagsUsed                      = GetBool(new IntPtr(p + 0x018)); // 0245A4C57820 0x18 M_UpdatableFlagsUsed        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Port                                    = GetInt32(new IntPtr(p + 0x01C)); // 0245A4C57840 0x1C M_Port                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_Scheme                                  = GetString(new IntPtr(p + 0x020)); // 0245A4C57860 0x20 M_Scheme                    ( 000186671910 ModelPrimitiveType string string string String )
            value.HttpUri                                   = GetObject<UriParser>(new IntPtr(p + 0x010), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57880 0x10 HttpUri                     ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.HttpsUri                                  = GetObject<UriParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C578A0 0x18 HttpsUri                    ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.WsUri                                     = GetObject<UriParser>(new IntPtr(p + 0x020), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C578C0 0x20 WsUri                       ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.WssUri                                    = GetObject<UriParser>(new IntPtr(p + 0x028), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C578E0 0x28 WssUri                      ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.FtpUri                                    = GetObject<UriParser>(new IntPtr(p + 0x030), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57900 0x30 FtpUri                      ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.FileUri                                   = GetObject<UriParser>(new IntPtr(p + 0x038), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57920 0x38 FileUri                     ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.GopherUri                                 = GetObject<UriParser>(new IntPtr(p + 0x040), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57940 0x40 GopherUri                   ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.NntpUri                                   = GetObject<UriParser>(new IntPtr(p + 0x048), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57960 0x48 NntpUri                     ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.NewsUri                                   = GetObject<UriParser>(new IntPtr(p + 0x050), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57980 0x50 NewsUri                     ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.MailToUri                                 = GetObject<UriParser>(new IntPtr(p + 0x058), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C579A0 0x58 MailToUri                   ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.UuidUri                                   = GetObject<UriParser>(new IntPtr(p + 0x060), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C579C0 0x60 UuidUri                     ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.TelnetUri                                 = GetObject<UriParser>(new IntPtr(p + 0x068), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C579E0 0x68 TelnetUri                   ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.LdapUri                                   = GetObject<UriParser>(new IntPtr(p + 0x070), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57A00 0x70 LdapUri                     ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.NetTcpUri                                 = GetObject<UriParser>(new IntPtr(p + 0x078), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57A20 0x78 NetTcpUri                   ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.NetPipeUri                                = GetObject<UriParser>(new IntPtr(p + 0x080), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57A40 0x80 NetPipeUri                  ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.VsMacrosUri                               = GetObject<UriParser>(new IntPtr(p + 0x088), ReversePrism.DataModels.UriParser.FromPointer); // 0245A4C57A60 0x88 VsMacrosUri                 ( 0001866A6220 ModelClassType UriParser UriParser UriParser Pointer )
            value.S_QuirksVersion                           = (UriQuirksVersion)GetInt32(new IntPtr(p + 0x090)); // 0245A4C57A80 0x90 S_QuirksVersion             ( 0001866C09A0 ModelEnumType UriQuirksVersion UriQuirksVersion UriQuirksVersion Int32 )
            value.HttpSyntaxFlags                           = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x094)); // 0245A4C57AA0 0x94 HttpSyntaxFlags             ( 000186748600 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )
            value.FileSyntaxFlags                           = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x098)); // 0245A4C57AC0 0x98 FileSyntaxFlags             ( 000186748600 ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )

            return value;
        }
    }
}
