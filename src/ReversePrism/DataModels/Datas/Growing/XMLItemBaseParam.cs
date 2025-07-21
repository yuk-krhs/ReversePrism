using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LinkUrl                                  ModelPrimitiveType string string string String
    // 018 Align                                    ModelEnumType Align Align Align Int32
    // 01C ItemType                                 ModelEnumType ItemType ItemType ItemType Int32
    public partial class XMLItemBaseParam : DataModel
    {
        public string                                   LinkUrl                                 { get; set; }
        public Align                                    Align                                   { get; set; }
        public ItemType                                 ItemType                                { get; set; }

        public static XMLItemBaseParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XMLItemBaseParam() { Pointer= p0 };

            value.LinkUrl                                   = GetString(new IntPtr(p + 0x010)); // 0x10 LinkUrl                     ( ModelPrimitiveType string string string String )
            value.Align                                     = (Align)GetInt32(new IntPtr(p + 0x018)); // 0x18 Align                       ( ModelEnumType Align Align Align Int32 )
            value.ItemType                                  = (ItemType)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ItemType                    ( ModelEnumType ItemType ItemType ItemType Int32 )

            return value;
        }
    }
}
