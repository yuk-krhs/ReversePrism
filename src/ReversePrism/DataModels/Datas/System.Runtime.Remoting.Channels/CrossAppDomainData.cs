using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _ContextID                               <object> IL2CPP_TYPE_OBJECT
    // 018 DomainID                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 ProcessGuid                              000186671910 ModelPrimitiveType string string string String
    public partial class CrossAppDomainData
    {
        public int                                      DomainID                                { get; set; }
        public string                                   ProcessGuid                             { get; set; }

        public static CrossAppDomainData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CrossAppDomainData();

            value.DomainID                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D6BE5058 0x18 DomainID                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProcessGuid                               = GetString(new IntPtr(p + 0x020)); // 0270D6BE5078 0x20 ProcessGuid                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
