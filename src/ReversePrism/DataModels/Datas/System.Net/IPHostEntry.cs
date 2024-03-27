using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HostName                                 000186671910 ModelPrimitiveType string string string String
    // 018 Aliases                                  000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 AddressList                              000185B88130 ModelClassListType IPAddress[] IPAddress[] List<IPAddress> Pointer
    // 028 IsTrustedHost                            000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class IPHostEntry
    {
        public string                                   HostName                                { get; set; }
        public List<string>?                            Aliases                                 { get; set; }
        public List<IPAddress>?                         AddressList                             { get; set; }
        public bool                                     IsTrustedHost                           { get; set; }

        public static IPHostEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IPHostEntry();

            value.HostName                                  = GetString(new IntPtr(p + 0x010)); // 0270D7A2B8A0 0x10 HostName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Aliases                                   = GetStringList(new IntPtr(p + 0x018)); // 0270D7A2B8C0 0x18 Aliases                     ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AddressList                               = GetObjectList<IPAddress>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7A2B8E0 0x20 AddressList                 ( 000185B88130 ModelClassListType IPAddress[] IPAddress[] List<IPAddress> Pointer )
            value.IsTrustedHost                             = GetBool(new IntPtr(p + 0x028)); // 0270D7A2B900 0x28 IsTrustedHost               ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
