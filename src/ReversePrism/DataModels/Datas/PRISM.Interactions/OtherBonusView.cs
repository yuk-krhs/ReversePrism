using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 ContentPrefab                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 OtherBonusContentViews                   000185B99160 ModelClassListType OtherBonusContentView[] OtherBonusContentView[] List<OtherBonusContentView> Pointer
    public partial class OtherBonusView
    {
        public Transform?                               ContentParent                           { get; set; }
        public GameObject?                              ContentPrefab                           { get; set; }
        public List<OtherBonusContentView>?             OtherBonusContentViews                  { get; set; }

        public static OtherBonusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusView();

            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DA3177F8 0x20 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ContentPrefab                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA317818 0x28 ContentPrefab               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.OtherBonusContentViews                    = GetObjectList<OtherBonusContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.OtherBonusContentView.FromPointer); // 0270DA317838 0x30 OtherBonusContentViews      ( 000185B99160 ModelClassListType OtherBonusContentView[] OtherBonusContentView[] List<OtherBonusContentView> Pointer )

            return value;
        }
    }
}
