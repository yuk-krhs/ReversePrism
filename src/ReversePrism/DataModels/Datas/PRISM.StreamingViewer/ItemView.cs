using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 ItemPath                                 000186671910 ModelPrimitiveType string string string String
    // 028 Item                                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 AcceSMP                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 HandLocalPosition                        0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 HandLocalRotation                        000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 058 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 060 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ItemView
    {
        public string                                   ItemPath                                { get; set; }
        public GameObject?                              Item                                    { get; set; }
        public Transform?                               AcceSMP                                 { get; set; }
        public Vector3                                  HandLocalPosition                       { get; set; }
        public Quaternion                               HandLocalRotation                       { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static ItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemView();

            value.ItemPath                                  = GetString(new IntPtr(p + 0x020)); // 0270D4F487D8 0x20 ItemPath                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Item                                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4F487F8 0x28 Item                        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AcceSMP                                   = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270D4F48818 0x30 AcceSMP                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.HandLocalPosition                         = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0270D4F48838 0x38 HandLocalPosition           ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HandLocalRotation                         = (Quaternion)GetInt32(new IntPtr(p + 0x044)); // 0270D4F48858 0x44 HandLocalRotation           ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x060)); // 0270D4F48898 0x60 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
