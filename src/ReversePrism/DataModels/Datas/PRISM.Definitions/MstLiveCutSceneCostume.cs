using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstLiveCutSceneId                        ModelPrimitiveType int int int Int32
    // 014 MstCostumeId                             ModelPrimitiveType int int int Int32
    public partial class MstLiveCutSceneCostume : DataModel
    {
        public int                                      MstLiveCutSceneId                       { get; set; }
        public int                                      MstCostumeId                            { get; set; }

        public static MstLiveCutSceneCostume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstLiveCutSceneCostume() { Pointer= p0 };

            value.MstLiveCutSceneId                         = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstLiveCutSceneId           ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCostumeId                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
