using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ItemName                                 ModelPrimitiveType string string string String
    // 018 ItemType                                 ModelPrimitiveType string string string String
    // 020 ItemAmount                               ModelPrimitiveType long long long Int64
    public partial class Item : DataModel
    {
        public string                                   ItemName                                { get; set; }
        public string                                   ItemType                                { get; set; }
        public long                                     ItemAmount                              { get; set; }

        public static Item? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Item() { Pointer= p0 };

            value.ItemName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 ItemName                    ( ModelPrimitiveType string string string String )
            value.ItemType                                  = GetString(new IntPtr(p + 0x018)); // 0x18 ItemType                    ( ModelPrimitiveType string string string String )
            value.ItemAmount                                = GetInt64(new IntPtr(p + 0x020)); // 0x20 ItemAmount                  ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
