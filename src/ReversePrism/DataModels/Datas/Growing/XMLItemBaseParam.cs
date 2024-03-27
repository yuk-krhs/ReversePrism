using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LinkUrl                                  000186672F10 ModelPrimitiveType string string string String
    // 018 Align                                    000186722780 ModelEnumType Align Align Align Int32
    // 01C ItemType                                 00018671F660 ModelEnumType ItemType ItemType ItemType Int32
    public partial class XMLItemBaseParam
    {
        public string                                   LinkUrl                                 { get; set; }
        public Align                                    Align                                   { get; set; }
        public ItemType                                 ItemType                                { get; set; }

        public static XMLItemBaseParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLItemBaseParam();

            value.LinkUrl                                   = GetString(new IntPtr(p + 0x010)); // 0270D4B3C9E0 0x10 LinkUrl                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.Align                                     = (Align)GetInt32(new IntPtr(p + 0x018)); // 0270D4B3CA00 0x18 Align                       ( 000186722780 ModelEnumType Align Align Align Int32 )
            value.ItemType                                  = (ItemType)GetInt32(new IntPtr(p + 0x01C)); // 0270D4B3CA20 0x1C ItemType                    ( 00018671F660 ModelEnumType ItemType ItemType ItemType Int32 )

            return value;
        }
    }
}
