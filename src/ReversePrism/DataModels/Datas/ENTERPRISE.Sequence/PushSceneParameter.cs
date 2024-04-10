using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Loader                                   000186624390 ModelClassType ISceneLoader ISceneLoader ISceneLoader Pointer
    // 028 Reactivator                              000186624840 ModelClassType ISceneReactivator ISceneReactivator ISceneReactivator Pointer
    public partial class PushSceneParameter : DataModel
    {
        public ISceneLoader?                            Loader                                  { get; set; }
        public ISceneReactivator?                       Reactivator                             { get; set; }

        public static PushSceneParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PushSceneParameter() { Pointer= p0 };

            value.Loader                                    = GetObject<ISceneLoader>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISceneLoader.FromPointer); // 02466B734AF0 0x20 Loader                      ( 000186624390 ModelClassType ISceneLoader ISceneLoader ISceneLoader Pointer )
            value.Reactivator                               = GetObject<ISceneReactivator>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISceneReactivator.FromPointer); // 02466B734B10 0x28 Reactivator                 ( 000186624840 ModelClassType ISceneReactivator ISceneReactivator ISceneReactivator Pointer )

            return value;
        }
    }
}
