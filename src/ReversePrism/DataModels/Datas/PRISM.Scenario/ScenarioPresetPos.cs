using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 presetData                               Dictionary`2<string, PresetData> IL2CPP_TYPE_GENERICINST
    // 008 presetList                               List`1<string> IL2CPP_TYPE_GENERICINST
    // 000 camDataName                              string IL2CPP_TYPE_STRING
    // 000 charaDataName                            string IL2CPP_TYPE_STRING
    // 000 camIndexName                             string IL2CPP_TYPE_STRING
    // 000 charaIndexName                           string IL2CPP_TYPE_STRING
    // 000 skitIndexName                            string IL2CPP_TYPE_STRING
    public partial class ScenarioPresetPos
    {

        public static ScenarioPresetPos? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioPresetPos();


            return value;
        }
    }
}
