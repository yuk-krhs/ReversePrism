using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DefaultState                             0001866558A0 ModelEnumType TextureParameterDefault TextureParameterDefault TextureParameterDefault Int32
    public partial class TextureParameter
    {
        public TextureParameterDefault                  DefaultState                            { get; set; }

        public static TextureParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextureParameter();

            value.DefaultState                              = (TextureParameterDefault)GetInt32(new IntPtr(p + 0x020)); // 027006120D00 0x20 DefaultState                ( 0001866558A0 ModelEnumType TextureParameterDefault TextureParameterDefault TextureParameterDefault Int32 )

            return value;
        }
    }
}
