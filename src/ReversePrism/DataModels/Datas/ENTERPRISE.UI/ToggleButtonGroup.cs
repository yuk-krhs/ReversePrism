using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LastSelectedIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 ForceNotifyWhenSameIndexSelected         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 Mode                                     0001866232A0 ModelEnumType SelectionMode SelectionMode SelectionMode Int32
    // 030 ButtonList                               000185D153A8 ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer
    // 038 onChangeToggle                           Action`1<int> IL2CPP_TYPE_GENERICINST
    // 040 ButtonRoot                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 ButtonPrefab                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class ToggleButtonGroup : DataModel
    {
        public int                                      LastSelectedIndex                       { get; set; }
        public bool                                     ForceNotifyWhenSameIndexSelected        { get; set; }
        public SelectionMode                            Mode                                    { get; set; }
        public List<ToggleButton>?                      ButtonList                              { get; set; }
        public Transform?                               ButtonRoot                              { get; set; }
        public GameObject?                              ButtonPrefab                            { get; set; }

        public static ToggleButtonGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ToggleButtonGroup() { Pointer= p0 };

            value.LastSelectedIndex                         = GetInt32(new IntPtr(p + 0x020)); // 024664F35C78 0x20 LastSelectedIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ForceNotifyWhenSameIndexSelected          = GetBool(new IntPtr(p + 0x024)); // 024664F35C98 0x24 ForceNotifyWhenSameIndexSelected ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Mode                                      = (SelectionMode)GetInt32(new IntPtr(p + 0x028)); // 024664F35CB8 0x28 Mode                        ( 0001866232A0 ModelEnumType SelectionMode SelectionMode SelectionMode Int32 )
            value.ButtonList                                = GetObjectList<ToggleButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.ToggleButton.FromPointer); // 024664F35CD8 0x30 ButtonList                  ( 000185D153A8 ModelClassListType List`1<ToggleButton> List`1<ToggleButton> List<ToggleButton> Pointer )
            value.ButtonRoot                                = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 024664F35D18 0x40 ButtonRoot                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ButtonPrefab                              = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 024664F35D38 0x48 ButtonPrefab                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
