using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Character                                ModelClassType Character Character Character Pointer
    // 028 CharaIndex                               ModelPrimitiveType int int int Int32
    public partial class AttachCharacterObject : DataModel
    {
        public Character?                               Character                               { get; set; }
        public int                                      CharaIndex                              { get; set; }

        public static AttachCharacterObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttachCharacterObject() { Pointer= p0 };

            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x020), ReversePrism.DataModels.Character.FromPointer); // 0x20 Character                   ( ModelClassType Character Character Character Pointer )
            value.CharaIndex                                = GetInt32(new IntPtr(p + 0x028)); // 0x28 CharaIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
