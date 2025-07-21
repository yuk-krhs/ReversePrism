using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Radius                                   ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer
    public partial class MagicaSphereColliderParam : DataModel
    {
        public BodyParamFloatProperty?                  Radius                                  { get; set; }

        public static MagicaSphereColliderParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MagicaSphereColliderParam() { Pointer= p0 };

            value.Radius                                    = GetObject<BodyParamFloatProperty>(new IntPtr(p + 0x068), ReversePrism.DataModels.BodyParamFloatProperty.FromPointer); // 0x68 Radius                      ( ModelClassType BodyParamFloatProperty BodyParamFloatProperty BodyParamFloatProperty Pointer )

            return value;
        }
    }
}
