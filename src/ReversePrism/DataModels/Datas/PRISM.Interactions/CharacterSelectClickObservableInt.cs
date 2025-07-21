using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 TapNotAvailable                          ModelPrimitiveType bool bool bool Bool
    // 059 SimpleIcon                               ModelPrimitiveType bool bool bool Bool
    // 05A AlbumIcon                                ModelPrimitiveType bool bool bool Bool
    public partial class CharacterSelectClickObservableInt : DataModel
    {
        public bool                                     TapNotAvailable                         { get; set; }
        public bool                                     SimpleIcon                              { get; set; }
        public bool                                     AlbumIcon                               { get; set; }

        public static CharacterSelectClickObservableInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectClickObservableInt() { Pointer= p0 };

            value.TapNotAvailable                           = GetBool(new IntPtr(p + 0x058)); // 0x58 TapNotAvailable             ( ModelPrimitiveType bool bool bool Bool )
            value.SimpleIcon                                = GetBool(new IntPtr(p + 0x059)); // 0x59 SimpleIcon                  ( ModelPrimitiveType bool bool bool Bool )
            value.AlbumIcon                                 = GetBool(new IntPtr(p + 0x05A)); // 0x5A AlbumIcon                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
