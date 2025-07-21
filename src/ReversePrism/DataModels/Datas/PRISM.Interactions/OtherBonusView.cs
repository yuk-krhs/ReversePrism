using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentParent                            ModelClassType Transform Transform Transform Pointer
    // 028 ContentPrefab                            ModelClassType GameObject GameObject GameObject Pointer
    // 030 IdolSkillContentView                     ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer
    // 038 LiveSkillContentView                     ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer
    // 040 NewDressContentView                      ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer
    // 048 DressOrderContentView                    ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer
    // 050 GetItemContentView                       ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer
    public partial class OtherBonusView : DataModel
    {
        public Transform?                               ContentParent                           { get; set; }
        public GameObject?                              ContentPrefab                           { get; set; }
        public OtherBonusContentView?                   IdolSkillContentView                    { get; set; }
        public OtherBonusContentView?                   LiveSkillContentView                    { get; set; }
        public OtherBonusContentView?                   NewDressContentView                     { get; set; }
        public OtherBonusContentView?                   DressOrderContentView                   { get; set; }
        public OtherBonusContentView?                   GetItemContentView                      { get; set; }

        public static OtherBonusView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OtherBonusView() { Pointer= p0 };

            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 ContentParent               ( ModelClassType Transform Transform Transform Pointer )
            value.ContentPrefab                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 ContentPrefab               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IdolSkillContentView                      = GetObject<OtherBonusContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.OtherBonusContentView.FromPointer); // 0x30 IdolSkillContentView        ( ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer )
            value.LiveSkillContentView                      = GetObject<OtherBonusContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.OtherBonusContentView.FromPointer); // 0x38 LiveSkillContentView        ( ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer )
            value.NewDressContentView                       = GetObject<OtherBonusContentView>(new IntPtr(p + 0x040), ReversePrism.DataModels.OtherBonusContentView.FromPointer); // 0x40 NewDressContentView         ( ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer )
            value.DressOrderContentView                     = GetObject<OtherBonusContentView>(new IntPtr(p + 0x048), ReversePrism.DataModels.OtherBonusContentView.FromPointer); // 0x48 DressOrderContentView       ( ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer )
            value.GetItemContentView                        = GetObject<OtherBonusContentView>(new IntPtr(p + 0x050), ReversePrism.DataModels.OtherBonusContentView.FromPointer); // 0x50 GetItemContentView          ( ModelClassType OtherBonusContentView OtherBonusContentView OtherBonusContentView Pointer )

            return value;
        }
    }
}
