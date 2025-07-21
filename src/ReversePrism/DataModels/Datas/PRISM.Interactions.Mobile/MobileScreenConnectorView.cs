using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScreenParent                             ModelClassType Transform Transform Transform Pointer
    // 028 ScreenBuilders                           ModelClassListType KeyBuilderPair[] KeyBuilderPair[] List<KeyBuilderPair> Pointer
    // 030 screenBuilderDic                         Dictionary`2<int, IMobileScreenBuilder> IL2CPP_TYPE_GENERICINST
    public partial class MobileScreenConnectorView : DataModel
    {
        public Transform?                               ScreenParent                            { get; set; }
        public List<KeyBuilderPair>?                    ScreenBuilders                          { get; set; }

        public static MobileScreenConnectorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileScreenConnectorView() { Pointer= p0 };

            value.ScreenParent                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ScreenParent                ( ModelClassType Transform Transform Transform Pointer )
            value.ScreenBuilders                            = GetObjectList<KeyBuilderPair>(new IntPtr(p + 0x028), ReversePrism.DataModels.KeyBuilderPair.FromPointer); // 0x28 ScreenBuilders              ( ModelClassListType KeyBuilderPair[] KeyBuilderPair[] List<KeyBuilderPair> Pointer )

            return value;
        }
    }
}
