using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneGUID                                0001866722E0 ModelPrimitiveType string string string String
    // 018 Bounds                                   000186599AF0 ModelEnumType Bounds Bounds Bounds Int32
    public partial class SerializableBoundItem : DataModel
    {
        public string                                   SceneGUID                               { get; set; }
        public Bounds                                   Bounds                                  { get; set; }

        public static SerializableBoundItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializableBoundItem() { Pointer= p0 };

            value.SceneGUID                                 = GetString(new IntPtr(p + 0x010)); // 0246692871A0 0x10 SceneGUID                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Bounds                                    = (Bounds)GetInt32(new IntPtr(p + 0x018)); // 0246692871C0 0x18 Bounds                      ( 000186599AF0 ModelEnumType Bounds Bounds Bounds Int32 )

            return value;
        }
    }
}
