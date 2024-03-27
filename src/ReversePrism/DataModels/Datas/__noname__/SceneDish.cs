using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Loader                                   000186624390 ModelClassType ISceneLoader ISceneLoader ISceneLoader Pointer
    // 018 Reactivator                              000186624840 ModelClassType ISceneReactivator ISceneReactivator ISceneReactivator Pointer
    public partial class SceneDish
    {
        public ISceneLoader?                            Loader                                  { get; set; }
        public ISceneReactivator?                       Reactivator                             { get; set; }

        public static SceneDish? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SceneDish();

            value.Loader                                    = GetObject<ISceneLoader>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISceneLoader.FromPointer); // 027003EECDF8 0x10 Loader                      ( 000186624390 ModelClassType ISceneLoader ISceneLoader ISceneLoader Pointer )
            value.Reactivator                               = GetObject<ISceneReactivator>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISceneReactivator.FromPointer); // 027003EECE18 0x18 Reactivator                 ( 000186624840 ModelClassType ISceneReactivator ISceneReactivator ISceneReactivator Pointer )

            return value;
        }
    }
}
