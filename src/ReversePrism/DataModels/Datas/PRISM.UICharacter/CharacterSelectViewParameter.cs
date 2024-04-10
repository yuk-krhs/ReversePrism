using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001865A75C0 ModelEnumType CharacterType CharacterType CharacterType Int32
    public partial class CharacterSelectViewParameter : DataModel
    {
        public CharacterType                            Type                                    { get; set; }

        public static CharacterSelectViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectViewParameter() { Pointer= p0 };

            value.Type                                      = (CharacterType)GetInt32(new IntPtr(p + 0x010)); // 024665E20FF0 0x10 Type                        ( 0001865A75C0 ModelEnumType CharacterType CharacterType CharacterType Int32 )

            return value;
        }
    }
}
