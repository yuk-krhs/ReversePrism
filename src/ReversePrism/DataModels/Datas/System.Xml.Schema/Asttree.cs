using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FAxisArray                               00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 Xpathexpr                                000186671910 ModelPrimitiveType string string string String
    // 020 IsField                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Nsmgr                                    0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    public partial class Asttree
    {
        public ArrayList?                               FAxisArray                              { get; set; }
        public string                                   Xpathexpr                               { get; set; }
        public bool                                     IsField                                 { get; set; }
        public XmlNamespaceManager?                     Nsmgr                                   { get; set; }

        public static Asttree? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Asttree();

            value.FAxisArray                                = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0270D74D5C28 0x10 FAxisArray                  ( 00018658A070 ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Xpathexpr                                 = GetString(new IntPtr(p + 0x018)); // 0270D74D5C48 0x18 Xpathexpr                   ( 000186671910 ModelPrimitiveType string string string String )
            value.IsField                                   = GetBool(new IntPtr(p + 0x020)); // 0270D74D5C68 0x20 IsField                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Nsmgr                                     = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0270D74D5C88 0x28 Nsmgr                       ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )

            return value;
        }
    }
}
