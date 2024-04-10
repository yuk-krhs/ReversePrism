using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 cameraData                               Dictionary`2<string, CameraData> IL2CPP_TYPE_GENERICINST
    // 018 characterData                            Dictionary`2<string, CharacterData> IL2CPP_TYPE_GENERICINST
    public partial class PresetData : DataModel
    {

        public static PresetData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PresetData() { Pointer= p0 };


            return value;
        }
    }
}
