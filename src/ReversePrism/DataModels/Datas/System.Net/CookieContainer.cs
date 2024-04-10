using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HeaderInfo                               HeaderVariantInfo[] IL2CPP_TYPE_SZARRAY
    // 010 M_domainTable                            0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 M_maxCookieSize                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_maxCookies                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_maxCookiesPerDomain                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 M_count                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_fqdnMyDomain                           000186671910 ModelPrimitiveType string string string String
    public partial class CookieContainer : DataModel
    {
        public Hashtable?                               M_domainTable                           { get; set; }
        public int                                      M_maxCookieSize                         { get; set; }
        public int                                      M_maxCookies                            { get; set; }
        public int                                      M_maxCookiesPerDomain                   { get; set; }
        public int                                      M_count                                 { get; set; }
        public string                                   M_fqdnMyDomain                          { get; set; }

        public static CookieContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CookieContainer() { Pointer= p0 };

            value.M_domainTable                             = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 024667A97368 0x10 M_domainTable               ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.M_maxCookieSize                           = GetInt32(new IntPtr(p + 0x018)); // 024667A97388 0x18 M_maxCookieSize             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_maxCookies                              = GetInt32(new IntPtr(p + 0x01C)); // 024667A973A8 0x1C M_maxCookies                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_maxCookiesPerDomain                     = GetInt32(new IntPtr(p + 0x020)); // 024667A973C8 0x20 M_maxCookiesPerDomain       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_count                                   = GetInt32(new IntPtr(p + 0x024)); // 024667A973E8 0x24 M_count                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_fqdnMyDomain                            = GetString(new IntPtr(p + 0x028)); // 024667A97408 0x28 M_fqdnMyDomain              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
