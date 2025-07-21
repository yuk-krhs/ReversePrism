using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PlayerIndex                              ModelPrimitiveType int int int Int32
    // 024 AutoEnableInputs                         ModelPrimitiveType bool bool bool Bool
    // 028 XYAxis                                   ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 030 ZAxis                                    ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 000 NUM_AXES                                 int IL2CPP_TYPE_I4
    // 038 M_cachedActions                          ModelClassListType InputAction[] InputAction[] List<InputAction> Pointer
    public partial class CinemachineInputProvider : DataModel
    {
        public int                                      PlayerIndex                             { get; set; }
        public bool                                     AutoEnableInputs                        { get; set; }
        public InputActionReference?                    XYAxis                                  { get; set; }
        public InputActionReference?                    ZAxis                                   { get; set; }
        public List<InputAction>?                       M_cachedActions                         { get; set; }

        public static CinemachineInputProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineInputProvider() { Pointer= p0 };

            value.PlayerIndex                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 PlayerIndex                 ( ModelPrimitiveType int int int Int32 )
            value.AutoEnableInputs                          = GetBool(new IntPtr(p + 0x024)); // 0x24 AutoEnableInputs            ( ModelPrimitiveType bool bool bool Bool )
            value.XYAxis                                    = GetObject<InputActionReference>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputActionReference.FromPointer); // 0x28 XYAxis                      ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.ZAxis                                     = GetObject<InputActionReference>(new IntPtr(p + 0x030), ReversePrism.DataModels.InputActionReference.FromPointer); // 0x30 ZAxis                       ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_cachedActions                           = GetObjectList<InputAction>(new IntPtr(p + 0x038), ReversePrism.DataModels.InputAction.FromPointer); // 0x38 M_cachedActions             ( ModelClassListType InputAction[] InputAction[] List<InputAction> Pointer )

            return value;
        }
    }
}
