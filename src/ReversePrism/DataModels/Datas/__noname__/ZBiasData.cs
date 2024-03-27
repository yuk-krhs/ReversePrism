using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Smr                                      000186514880 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer
    // 018 Id                                       0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ZBiasData
    {
        public SkinnedMeshRenderer?                     Smr                                     { get; set; }
        public int                                      Id                                      { get; set; }

        public static ZBiasData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ZBiasData();

            value.Smr                                       = GetObject<SkinnedMeshRenderer>(new IntPtr(p + 0x010), ReversePrism.DataModels.SkinnedMeshRenderer.FromPointer); // 027006A02DA8 0x10 Smr                         ( 000186514880 ModelClassType SkinnedMeshRenderer SkinnedMeshRenderer SkinnedMeshRenderer Pointer )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 027006A02DC8 0x18 Id                          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
