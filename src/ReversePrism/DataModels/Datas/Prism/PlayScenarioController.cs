using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceTopBgmVolumeAdjuster              ModelClassType ProduceTopBgmVolumeAdjuster ProduceTopBgmVolumeAdjuster ProduceTopBgmVolumeAdjuster Pointer
    // 018 Model3dLoader                            ModelClassType Model3dLoaderForPlayScenarioController Model3dLoaderForPlayScenarioController Model3dLoaderForPlayScenarioController Pointer
    public partial class PlayScenarioController : DataModel
    {
        public ProduceTopBgmVolumeAdjuster?             ProduceTopBgmVolumeAdjuster             { get; set; }
        public Model3dLoaderForPlayScenarioController?  Model3dLoader                           { get; set; }

        public static PlayScenarioController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayScenarioController() { Pointer= p0 };

            value.ProduceTopBgmVolumeAdjuster               = GetObject<ProduceTopBgmVolumeAdjuster>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceTopBgmVolumeAdjuster.FromPointer); // 0x10 ProduceTopBgmVolumeAdjuster ( ModelClassType ProduceTopBgmVolumeAdjuster ProduceTopBgmVolumeAdjuster ProduceTopBgmVolumeAdjuster Pointer )
            value.Model3dLoader                             = GetObject<Model3dLoaderForPlayScenarioController>(new IntPtr(p + 0x018), ReversePrism.DataModels.Model3dLoaderForPlayScenarioController.FromPointer); // 0x18 Model3dLoader               ( ModelClassType Model3dLoaderForPlayScenarioController Model3dLoaderForPlayScenarioController Model3dLoaderForPlayScenarioController Pointer )

            return value;
        }
    }
}
