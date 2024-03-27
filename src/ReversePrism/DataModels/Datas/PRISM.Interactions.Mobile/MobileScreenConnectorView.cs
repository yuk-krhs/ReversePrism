using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScreenParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 ScreenBuilders                           000185CBF258 ModelClassListType KeyBuilderPair[] KeyBuilderPair[] List<KeyBuilderPair> Pointer
    // 030 screenBuilderDic                         Dictionary`2<int, IMobileScreenBuilder> IL2CPP_TYPE_GENERICINST
    public partial class MobileScreenConnectorView
    {
        public Transform?                               ScreenParent                            { get; set; }
        public List<KeyBuilderPair>?                    ScreenBuilders                          { get; set; }

        public static MobileScreenConnectorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileScreenConnectorView();

            value.ScreenParent                              = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DB11FDD0 0x20 ScreenParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ScreenBuilders                            = GetObjectList<KeyBuilderPair>(new IntPtr(p + 0x028), ReversePrism.DataModels.KeyBuilderPair.FromPointer); // 0270DB11FDF0 0x28 ScreenBuilders              ( 000185CBF258 ModelClassListType KeyBuilderPair[] KeyBuilderPair[] List<KeyBuilderPair> Pointer )

            return value;
        }
    }
}
