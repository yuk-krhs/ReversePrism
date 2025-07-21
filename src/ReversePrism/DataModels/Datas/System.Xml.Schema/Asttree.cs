using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FAxisArray                               ModelClassType ArrayList ArrayList ArrayList Pointer
    // 018 Xpathexpr                                ModelPrimitiveType string string string String
    // 020 IsField                                  ModelPrimitiveType bool bool bool Bool
    // 028 Nsmgr                                    ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    public partial class Asttree : DataModel
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
            var value   = new Asttree() { Pointer= p0 };

            value.FAxisArray                                = GetObject<ArrayList>(new IntPtr(p + 0x010), ReversePrism.DataModels.ArrayList.FromPointer); // 0x10 FAxisArray                  ( ModelClassType ArrayList ArrayList ArrayList Pointer )
            value.Xpathexpr                                 = GetString(new IntPtr(p + 0x018)); // 0x18 Xpathexpr                   ( ModelPrimitiveType string string string String )
            value.IsField                                   = GetBool(new IntPtr(p + 0x020)); // 0x20 IsField                     ( ModelPrimitiveType bool bool bool Bool )
            value.Nsmgr                                     = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x28 Nsmgr                       ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )

            return value;
        }
    }
}
