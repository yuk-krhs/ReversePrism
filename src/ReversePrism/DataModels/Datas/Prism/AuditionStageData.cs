using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DataList                                 ModelClassListType List`1<SceneData> List`1<SceneData> List<SceneData> Pointer
    public partial class AuditionStageData : DataModel
    {
        public List<SceneData>?                         DataList                                { get; set; }

        public static AuditionStageData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionStageData() { Pointer= p0 };

            value.DataList                                  = GetObjectList<SceneData>(new IntPtr(p + 0x018), ReversePrism.DataModels.SceneData.FromPointer); // 0x18 DataList                    ( ModelClassListType List`1<SceneData> List`1<SceneData> List<SceneData> Pointer )

            return value;
        }
    }
}
