using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CautionEffect                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 LifeZeroEffect                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 InvulnerableEffect                       0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 RecoveryEffect                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 IsSkillActiveArray                       000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class LiveFullScreenEffectView : DataModel
    {
        public GameObject?                              CautionEffect                           { get; set; }
        public GameObject?                              LifeZeroEffect                          { get; set; }
        public GameObject?                              InvulnerableEffect                      { get; set; }
        public GameObject?                              RecoveryEffect                          { get; set; }
        public List<bool>?                              IsSkillActiveArray                      { get; set; }

        public static LiveFullScreenEffectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveFullScreenEffectView() { Pointer= p0 };

            value.CautionEffect                             = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0246650A35D8 0x20 CautionEffect               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.LifeZeroEffect                            = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0246650A35F8 0x28 LifeZeroEffect              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.InvulnerableEffect                        = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0246650A3618 0x30 InvulnerableEffect          ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.RecoveryEffect                            = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0246650A3638 0x38 RecoveryEffect              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsSkillActiveArray                        = GetBoolList(new IntPtr(p + 0x040)); // 0246650A3658 0x40 IsSkillActiveArray          ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
