using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SchemeOnlyFlags                          UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 m_Table                                  Dictionary`2<string, UriParser> IL2CPP_TYPE_GENERICINST
    // 008 m_TempTable                              Dictionary`2<string, UriParser> IL2CPP_TYPE_GENERICINST
    // 010 M_Flags                                  ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    // 014 M_UpdatableFlags                         ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    // 018 M_UpdatableFlagsUsed                     ModelPrimitiveType bool bool bool Bool
    // 000 c_UpdatableFlags                         UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 01C M_Port                                   ModelPrimitiveType int int int Int32
    // 020 M_Scheme                                 ModelPrimitiveType string string string String
    // 000 NoDefaultPort                            int IL2CPP_TYPE_I4
    // 000 c_InitialTableSize                       int IL2CPP_TYPE_I4
    // 010 HttpUri                                  ModelClassType UriParser UriParser UriParser Pointer
    // 018 HttpsUri                                 ModelClassType UriParser UriParser UriParser Pointer
    // 020 WsUri                                    ModelClassType UriParser UriParser UriParser Pointer
    // 028 WssUri                                   ModelClassType UriParser UriParser UriParser Pointer
    // 030 FtpUri                                   ModelClassType UriParser UriParser UriParser Pointer
    // 038 FileUri                                  ModelClassType UriParser UriParser UriParser Pointer
    // 040 GopherUri                                ModelClassType UriParser UriParser UriParser Pointer
    // 048 NntpUri                                  ModelClassType UriParser UriParser UriParser Pointer
    // 050 NewsUri                                  ModelClassType UriParser UriParser UriParser Pointer
    // 058 MailToUri                                ModelClassType UriParser UriParser UriParser Pointer
    // 060 UuidUri                                  ModelClassType UriParser UriParser UriParser Pointer
    // 068 TelnetUri                                ModelClassType UriParser UriParser UriParser Pointer
    // 070 LdapUri                                  ModelClassType UriParser UriParser UriParser Pointer
    // 078 NetTcpUri                                ModelClassType UriParser UriParser UriParser Pointer
    // 080 NetPipeUri                               ModelClassType UriParser UriParser UriParser Pointer
    // 088 VsMacrosUri                              ModelClassType UriParser UriParser UriParser Pointer
    // 090 S_QuirksVersion                          ModelEnumType UriQuirksVersion UriQuirksVersion UriQuirksVersion Int32
    // 000 c_MaxCapacity                            int IL2CPP_TYPE_I4
    // 000 UnknownV1SyntaxFlags                     UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 094 HttpSyntaxFlags                          ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    // 000 FtpSyntaxFlags                           UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 098 FileSyntaxFlags                          ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32
    // 000 VsmacrosSyntaxFlags                      UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 GopherSyntaxFlags                        UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 NewsSyntaxFlags                          UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 NntpSyntaxFlags                          UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 TelnetSyntaxFlags                        UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 LdapSyntaxFlags                          UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 MailtoSyntaxFlags                        UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 NetPipeSyntaxFlags                       UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
    // 000 NetTcpSyntaxFlags                        UriSyntaxFlags IL2CPP_TYPE_VALUETYPE
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

            value.M_Flags                                   = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Flags                     ( ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )
            value.M_UpdatableFlags                          = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_UpdatableFlags            ( ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )
            value.M_UpdatableFlagsUsed                      = GetBool(new IntPtr(p + 0x018)); // 0x18 M_UpdatableFlagsUsed        ( ModelPrimitiveType bool bool bool Bool )
            value.M_Port                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Port                      ( ModelPrimitiveType int int int Int32 )
            value.M_Scheme                                  = GetString(new IntPtr(p + 0x020)); // 0x20 M_Scheme                    ( ModelPrimitiveType string string string String )
            value.HttpUri                                   = GetObject<UriParser>(new IntPtr(p + 0x010), ReversePrism.DataModels.UriParser.FromPointer); // 0x10 HttpUri                     ( ModelClassType UriParser UriParser UriParser Pointer )
            value.HttpsUri                                  = GetObject<UriParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.UriParser.FromPointer); // 0x18 HttpsUri                    ( ModelClassType UriParser UriParser UriParser Pointer )
            value.WsUri                                     = GetObject<UriParser>(new IntPtr(p + 0x020), ReversePrism.DataModels.UriParser.FromPointer); // 0x20 WsUri                       ( ModelClassType UriParser UriParser UriParser Pointer )
            value.WssUri                                    = GetObject<UriParser>(new IntPtr(p + 0x028), ReversePrism.DataModels.UriParser.FromPointer); // 0x28 WssUri                      ( ModelClassType UriParser UriParser UriParser Pointer )
            value.FtpUri                                    = GetObject<UriParser>(new IntPtr(p + 0x030), ReversePrism.DataModels.UriParser.FromPointer); // 0x30 FtpUri                      ( ModelClassType UriParser UriParser UriParser Pointer )
            value.FileUri                                   = GetObject<UriParser>(new IntPtr(p + 0x038), ReversePrism.DataModels.UriParser.FromPointer); // 0x38 FileUri                     ( ModelClassType UriParser UriParser UriParser Pointer )
            value.GopherUri                                 = GetObject<UriParser>(new IntPtr(p + 0x040), ReversePrism.DataModels.UriParser.FromPointer); // 0x40 GopherUri                   ( ModelClassType UriParser UriParser UriParser Pointer )
            value.NntpUri                                   = GetObject<UriParser>(new IntPtr(p + 0x048), ReversePrism.DataModels.UriParser.FromPointer); // 0x48 NntpUri                     ( ModelClassType UriParser UriParser UriParser Pointer )
            value.NewsUri                                   = GetObject<UriParser>(new IntPtr(p + 0x050), ReversePrism.DataModels.UriParser.FromPointer); // 0x50 NewsUri                     ( ModelClassType UriParser UriParser UriParser Pointer )
            value.MailToUri                                 = GetObject<UriParser>(new IntPtr(p + 0x058), ReversePrism.DataModels.UriParser.FromPointer); // 0x58 MailToUri                   ( ModelClassType UriParser UriParser UriParser Pointer )
            value.UuidUri                                   = GetObject<UriParser>(new IntPtr(p + 0x060), ReversePrism.DataModels.UriParser.FromPointer); // 0x60 UuidUri                     ( ModelClassType UriParser UriParser UriParser Pointer )
            value.TelnetUri                                 = GetObject<UriParser>(new IntPtr(p + 0x068), ReversePrism.DataModels.UriParser.FromPointer); // 0x68 TelnetUri                   ( ModelClassType UriParser UriParser UriParser Pointer )
            value.LdapUri                                   = GetObject<UriParser>(new IntPtr(p + 0x070), ReversePrism.DataModels.UriParser.FromPointer); // 0x70 LdapUri                     ( ModelClassType UriParser UriParser UriParser Pointer )
            value.NetTcpUri                                 = GetObject<UriParser>(new IntPtr(p + 0x078), ReversePrism.DataModels.UriParser.FromPointer); // 0x78 NetTcpUri                   ( ModelClassType UriParser UriParser UriParser Pointer )
            value.NetPipeUri                                = GetObject<UriParser>(new IntPtr(p + 0x080), ReversePrism.DataModels.UriParser.FromPointer); // 0x80 NetPipeUri                  ( ModelClassType UriParser UriParser UriParser Pointer )
            value.VsMacrosUri                               = GetObject<UriParser>(new IntPtr(p + 0x088), ReversePrism.DataModels.UriParser.FromPointer); // 0x88 VsMacrosUri                 ( ModelClassType UriParser UriParser UriParser Pointer )
            value.S_QuirksVersion                           = (UriQuirksVersion)GetInt32(new IntPtr(p + 0x090)); // 0x90 S_QuirksVersion             ( ModelEnumType UriQuirksVersion UriQuirksVersion UriQuirksVersion Int32 )
            value.HttpSyntaxFlags                           = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x094)); // 0x94 HttpSyntaxFlags             ( ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )
            value.FileSyntaxFlags                           = (UriSyntaxFlags)GetInt32(new IntPtr(p + 0x098)); // 0x98 FileSyntaxFlags             ( ModelEnumType UriSyntaxFlags UriSyntaxFlags UriSyntaxFlags Int32 )

            return value;
        }
    }
}
