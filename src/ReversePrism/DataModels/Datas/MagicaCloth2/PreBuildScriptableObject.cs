using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 SharePreBuildDataList                    ModelClassListType List`1<SharePreBuildData> List`1<SharePreBuildData> List<SharePreBuildData> Pointer
    public partial class PreBuildScriptableObject : DataModel
    {
        public List<SharePreBuildData>?                 SharePreBuildDataList                   { get; set; }

        public static PreBuildScriptableObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PreBuildScriptableObject() { Pointer= p0 };

            value.SharePreBuildDataList                     = GetObjectList<SharePreBuildData>(new IntPtr(p + 0x018), ReversePrism.DataModels.SharePreBuildData.FromPointer); // 0x18 SharePreBuildDataList       ( ModelClassListType List`1<SharePreBuildData> List`1<SharePreBuildData> List<SharePreBuildData> Pointer )

            return value;
        }
    }
}
