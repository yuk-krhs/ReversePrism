using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemParent                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 RareItemFrame                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 Item                                     00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 038 NormalRewardEffect                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 RareRewardEffect                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 RareRewardLoopEffect                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 IsRare                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class LiveResultRewardItem : DataModel
    {
        public GameObject?                              ItemParent                              { get; set; }
        public GameObject?                              RareItemFrame                           { get; set; }
        public RewardItem?                              Item                                    { get; set; }
        public GameObject?                              NormalRewardEffect                      { get; set; }
        public GameObject?                              RareRewardEffect                        { get; set; }
        public GameObject?                              RareRewardLoopEffect                    { get; set; }
        public bool                                     IsRare                                  { get; set; }

        public static LiveResultRewardItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultRewardItem() { Pointer= p0 };

            value.ItemParent                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0246652A6138 0x20 ItemParent                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RareItemFrame                             = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0246652A6158 0x28 RareItemFrame               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Item                                      = GetObject<RewardItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.RewardItem.FromPointer); // 0246652A6178 0x30 Item                        ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.NormalRewardEffect                        = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246652A6198 0x38 NormalRewardEffect          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RareRewardEffect                          = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0246652A61B8 0x40 RareRewardEffect            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RareRewardLoopEffect                      = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0246652A61D8 0x48 RareRewardLoopEffect        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsRare                                    = GetBool(new IntPtr(p + 0x050)); // 0246652A61F8 0x50 IsRare                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
