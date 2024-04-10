using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 TapNotAvailable                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 SimpleIcon                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 052 AlbumIcon                                000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.TapNotAvailable                           = GetBool(new IntPtr(p + 0x050)); // 02466A283760 0x50 TapNotAvailable             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SimpleIcon                                = GetBool(new IntPtr(p + 0x051)); // 02466A283780 0x51 SimpleIcon                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AlbumIcon                                 = GetBool(new IntPtr(p + 0x052)); // 02466A2837A0 0x52 AlbumIcon                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
