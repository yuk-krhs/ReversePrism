using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HostName                                 ModelPrimitiveType string string string String
    // 018 Aliases                                  ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 AddressList                              ModelClassListType IPAddress[] IPAddress[] List<IPAddress> Pointer
    // 028 IsTrustedHost                            ModelPrimitiveType bool bool bool Bool
    public partial class IPHostEntry : DataModel
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
            var value   = new IPHostEntry() { Pointer= p0 };

            value.HostName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 HostName                    ( ModelPrimitiveType string string string String )
            value.Aliases                                   = GetStringList(new IntPtr(p + 0x018)); // 0x18 Aliases                     ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.AddressList                               = GetObjectList<IPAddress>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPAddress.FromPointer); // 0x20 AddressList                 ( ModelClassListType IPAddress[] IPAddress[] List<IPAddress> Pointer )
            value.IsTrustedHost                             = GetBool(new IntPtr(p + 0x028)); // 0x28 IsTrustedHost               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
