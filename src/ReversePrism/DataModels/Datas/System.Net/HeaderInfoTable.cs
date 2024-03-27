using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 HeaderHashTable                          Hashtable IL2CPP_TYPE_CLASS
    // 008 UnknownHeaderInfo                        HeaderInfo IL2CPP_TYPE_CLASS
    // 010 SingleParser                             0001866AEF60 ModelClassType HeaderParser HeaderParser HeaderParser Pointer
    // 018 MultiParser                              0001866AEF60 ModelClassType HeaderParser HeaderParser HeaderParser Pointer
    public partial class HeaderInfoTable
    {
        public HeaderParser?                            SingleParser                            { get; set; }
        public HeaderParser?                            MultiParser                             { get; set; }

        public static HeaderInfoTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HeaderInfoTable();

            value.SingleParser                              = GetObject<HeaderParser>(new IntPtr(p + 0x010), ReversePrism.DataModels.HeaderParser.FromPointer); // 0270D7A2E348 0x10 SingleParser                ( 0001866AEF60 ModelClassType HeaderParser HeaderParser HeaderParser Pointer )
            value.MultiParser                               = GetObject<HeaderParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.HeaderParser.FromPointer); // 0270D7A2E368 0x18 MultiParser                 ( 0001866AEF60 ModelClassType HeaderParser HeaderParser HeaderParser Pointer )

            return value;
        }
    }
}
