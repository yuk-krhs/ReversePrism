using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Info                                     ModelClassType XPathNodeInfoAtom XPathNodeInfoAtom XPathNodeInfoAtom Pointer
    // 018 IdxSibling                               ModelPrimitiveType ushort ushort ushort UInt16
    // 01A IdxParent                                ModelPrimitiveType ushort ushort ushort UInt16
    // 01C IdxSimilar                               ModelPrimitiveType ushort ushort ushort UInt16
    // 01E PosOffset                                ModelPrimitiveType ushort ushort ushort UInt16
    // 020 Props                                    ModelPrimitiveType uint uint uint UInt32
    // 028 Value                                    ModelPrimitiveType string string string String
    public partial class XPathNode : DataModel
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
            var value   = new XPathNode() { Pointer= p0 };

            value.Info                                      = GetObject<XPathNodeInfoAtom>(new IntPtr(p + 0x010), ReversePrism.DataModels.XPathNodeInfoAtom.FromPointer); // 0x10 Info                        ( ModelClassType XPathNodeInfoAtom XPathNodeInfoAtom XPathNodeInfoAtom Pointer )
            value.IdxSibling                                = GetUInt16(new IntPtr(p + 0x018)); // 0x18 IdxSibling                  ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.IdxParent                                 = GetUInt16(new IntPtr(p + 0x01A)); // 0x1A IdxParent                   ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.IdxSimilar                                = GetUInt16(new IntPtr(p + 0x01C)); // 0x1C IdxSimilar                  ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.PosOffset                                 = GetUInt16(new IntPtr(p + 0x01E)); // 0x1E PosOffset                   ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Props                                     = GetUInt32(new IntPtr(p + 0x020)); // 0x20 Props                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Value                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Value                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
