using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseRegistry                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 BypassOnLocal                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 012 M_EnableAutoproxy                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 ProxyAddress                             0001866A4270 ModelClassType Uri Uri Uri Pointer
    // 020 BypassList                               00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 028 Credentials                              000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer
    // 030 RegExBypassList                          000185CA0618 ModelClassListType Regex[] Regex[] List<Regex> Pointer
    // 038 ProxyHostAddresses                       0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 M_ScriptEngine                           000186729BA0 ModelClassType AutoWebProxyScriptEngine AutoWebProxyScriptEngine AutoWebProxyScriptEngine Pointer
    public partial class WebProxy
    {
        public bool                                     UseRegistry                             { get; set; }
        public bool                                     BypassOnLocal                           { get; set; }
        public bool                                     M_EnableAutoproxy                       { get; set; }
        public Uri?                                     ProxyAddress                            { get; set; }
        public ArrayList?                               BypassList                              { get; set; }
        public ICredentials?                            Credentials                             { get; set; }
        public List<Regex>?                             RegExBypassList                         { get; set; }
        public Hashtable?                               ProxyHostAddresses                      { get; set; }
        public AutoWebProxyScriptEngine?                M_ScriptEngine                          { get; set; }

        public static WebProxy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebProxy();

            value.UseRegistry                               = GetBool(new IntPtr(p + 0x010)); // 0270D7A5A110 0x10 UseRegistry                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BypassOnLocal                             = GetBool(new IntPtr(p + 0x011)); // 0270D7A5A130 0x11 BypassOnLocal               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_EnableAutoproxy                         = GetBool(new IntPtr(p + 0x012)); // 0270D7A5A150 0x12 M_EnableAutoproxy           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProxyAddress                              = GetObject<Uri>(new IntPtr(p + 0x018), ReversePrism.DataModels.Uri.FromPointer); // 0270D7A5A170 0x18 ProxyAddress                ( 0001866A4270 ModelClassType Uri Uri Uri Pointer )
            value.BypassList                                = GetObject<ArrayList>(new IntPtr(p + 0x020), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D7A5A190 0x20 BypassList                  ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Credentials                               = GetObject<ICredentials>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICredentials.FromPointer); // 0270D7A5A1B0 0x28 Credentials                 ( 000186745960 ModelClassType ICredentials ICredentials ICredentials Pointer )
            value.RegExBypassList                           = GetObjectList<Regex>(new IntPtr(p + 0x030), ReversePrism.DataModels.Regex.FromPointer); // 0270D7A5A1D0 0x30 RegExBypassList             ( 000185CA0618 ModelClassListType Regex[] Regex[] List<Regex> Pointer )
            value.ProxyHostAddresses                        = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7A5A1F0 0x38 ProxyHostAddresses          ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.M_ScriptEngine                            = GetObject<AutoWebProxyScriptEngine>(new IntPtr(p + 0x040), ReversePrism.DataModels.AutoWebProxyScriptEngine.FromPointer); // 0270D7A5A210 0x40 M_ScriptEngine              ( 000186729BA0 ModelClassType AutoWebProxyScriptEngine AutoWebProxyScriptEngine AutoWebProxyScriptEngine Pointer )

            return value;
        }
    }
}
