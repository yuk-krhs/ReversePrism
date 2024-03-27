using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Info                                     00018657F6C0 ModelClassType XPathNodeInfoAtom XPathNodeInfoAtom XPathNodeInfoAtom Pointer
    // 018 IdxSibling                               000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01A IdxParent                                000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01C IdxSimilar                               000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 01E PosOffset                                000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16
    // 020 Props                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 028 Value                                    000186671910 ModelPrimitiveType string string string String
    public partial class XPathNode
    {
        public XPathNodeInfoAtom?                       Info                                    { get; set; }
        public ushort                                   IdxSibling                              { get; set; }
        public ushort                                   IdxParent                               { get; set; }
        public ushort                                   IdxSimilar                              { get; set; }
        public ushort                                   PosOffset                               { get; set; }
        public uint                                     Props                                   { get; set; }
        public string                                   Value                                   { get; set; }

        public static XPathNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XPathNode();

            value.Info                                      = GetObject<XPathNodeInfoAtom>(new IntPtr(p + 0x010), ReversePrism.DataModels.XPathNodeInfoAtom.FromPointer); // 0270D7498118 0x10 Info                        ( 00018657F6C0 ModelClassType XPathNodeInfoAtom XPathNodeInfoAtom XPathNodeInfoAtom Pointer )
            value.IdxSibling                                = GetUInt16(new IntPtr(p + 0x018)); // 0270D7498138 0x18 IdxSibling                  ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.IdxParent                                 = GetUInt16(new IntPtr(p + 0x01A)); // 0270D7498158 0x1A IdxParent                   ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.IdxSimilar                                = GetUInt16(new IntPtr(p + 0x01C)); // 0270D7498178 0x1C IdxSimilar                  ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.PosOffset                                 = GetUInt16(new IntPtr(p + 0x01E)); // 0270D7498198 0x1E PosOffset                   ( 000186696AE0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Props                                     = GetUInt32(new IntPtr(p + 0x020)); // 0270D74981B8 0x20 Props                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Value                                     = GetString(new IntPtr(p + 0x028)); // 0270D74981D8 0x28 Value                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
