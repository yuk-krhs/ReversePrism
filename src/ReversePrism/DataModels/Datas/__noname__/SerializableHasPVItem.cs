using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SceneGUID                                0001866722E0 ModelPrimitiveType string string string String
    // 018 HasProbeVolumes                          000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class SerializableHasPVItem : DataModel
    {
        public string                                   SceneGUID                               { get; set; }
        public bool                                     HasProbeVolumes                         { get; set; }

        public static SerializableHasPVItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializableHasPVItem() { Pointer= p0 };

            value.SceneGUID                                 = GetString(new IntPtr(p + 0x010)); // 0246692871E0 0x10 SceneGUID                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.HasProbeVolumes                           = GetBool(new IntPtr(p + 0x018)); // 024669287200 0x18 HasProbeVolumes             ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
