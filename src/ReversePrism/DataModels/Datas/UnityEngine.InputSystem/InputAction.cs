using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   000186671BA0 ModelPrimitiveType string string string String
    // 018 M_Type                                   0001866F80A0 ModelEnumType InputActionType InputActionType InputActionType Int32
    // 020 M_ExpectedControlType                    000186671BA0 ModelPrimitiveType string string string String
    // 028 M_Id                                     000186671BA0 ModelPrimitiveType string string string String
    // 030 M_Processors                             000186671BA0 ModelPrimitiveType string string string String
    // 038 M_Interactions                           000186671BA0 ModelPrimitiveType string string string String
    // 040 M_SingletonActionBindings                000185B8BFC0 ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer
    // 048 M_Flags                                  00018661D690 ModelEnumType ActionFlags ActionFlags ActionFlags Int32
    // 050 m_BindingMask                            Nullable`1<InputBinding> IL2CPP_TYPE_GENERICINST
    // 0B0 M_BindingsStartIndex                     0001865F5530 ModelPrimitiveType int int int Int32
    // 0B4 M_BindingsCount                          0001865F5530 ModelPrimitiveType int int int Int32
    // 0B8 M_ControlStartIndex                      0001865F5530 ModelPrimitiveType int int int Int32
    // 0BC M_ControlCount                           0001865F5530 ModelPrimitiveType int int int Int32
    // 0C0 M_ActionIndexInState                     0001865F5530 ModelPrimitiveType int int int Int32
    // 0C8 M_ActionMap                              0001866F6080 ModelClassType InputActionMap InputActionMap InputActionMap Pointer
    // 0D0 m_OnStarted                              CallbackArray`1<Action`1<CallbackContext>> IL2CPP_TYPE_GENERICINST
    // 120 m_OnCanceled                             CallbackArray`1<Action`1<CallbackContext>> IL2CPP_TYPE_GENERICINST
    // 170 m_OnPerformed                            CallbackArray`1<Action`1<CallbackContext>> IL2CPP_TYPE_GENERICINST
    public partial class InputAction : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public InputActionType                          M_Type                                  { get; set; }
        public string                                   M_ExpectedControlType                   { get; set; }
        public string                                   M_Id                                    { get; set; }
        public string                                   M_Processors                            { get; set; }
        public string                                   M_Interactions                          { get; set; }
        public List<InputBinding>?                      M_SingletonActionBindings               { get; set; }
        public ActionFlags                              M_Flags                                 { get; set; }
        public int                                      M_BindingsStartIndex                    { get; set; }
        public int                                      M_BindingsCount                         { get; set; }
        public int                                      M_ControlStartIndex                     { get; set; }
        public int                                      M_ControlCount                          { get; set; }
        public int                                      M_ActionIndexInState                    { get; set; }
        public InputActionMap?                          M_ActionMap                             { get; set; }

        public static InputAction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputAction() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0246676A55F0 0x10 M_Name                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Type                                    = (InputActionType)GetInt32(new IntPtr(p + 0x018)); // 0246676A5610 0x18 M_Type                      ( 0001866F80A0 ModelEnumType InputActionType InputActionType InputActionType Int32 )
            value.M_ExpectedControlType                     = GetString(new IntPtr(p + 0x020)); // 0246676A5630 0x20 M_ExpectedControlType       ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Id                                      = GetString(new IntPtr(p + 0x028)); // 0246676A5650 0x28 M_Id                        ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Processors                              = GetString(new IntPtr(p + 0x030)); // 0246676A5670 0x30 M_Processors                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_Interactions                            = GetString(new IntPtr(p + 0x038)); // 0246676A5690 0x38 M_Interactions              ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_SingletonActionBindings                 = GetEnumList<InputBinding>(new IntPtr(p + 0x040)); // 0246676A56B0 0x40 M_SingletonActionBindings   ( 000185B8BFC0 ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer )
            value.M_Flags                                   = (ActionFlags)GetInt32(new IntPtr(p + 0x048)); // 0246676A56D0 0x48 M_Flags                     ( 00018661D690 ModelEnumType ActionFlags ActionFlags ActionFlags Int32 )
            value.M_BindingsStartIndex                      = GetInt32(new IntPtr(p + 0x0B0)); // 0246676A5710 0xB0 M_BindingsStartIndex        ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_BindingsCount                           = GetInt32(new IntPtr(p + 0x0B4)); // 0246676A5730 0xB4 M_BindingsCount             ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_ControlStartIndex                       = GetInt32(new IntPtr(p + 0x0B8)); // 0246676A5750 0xB8 M_ControlStartIndex         ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_ControlCount                            = GetInt32(new IntPtr(p + 0x0BC)); // 0246676A5770 0xBC M_ControlCount              ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_ActionIndexInState                      = GetInt32(new IntPtr(p + 0x0C0)); // 0246676A5790 0xC0 M_ActionIndexInState        ( 0001865F5530 ModelPrimitiveType int int int Int32 )
            value.M_ActionMap                               = GetObject<InputActionMap>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.InputActionMap.FromPointer); // 0246676A57B0 0xC8 M_ActionMap                 ( 0001866F6080 ModelClassType InputActionMap InputActionMap InputActionMap Pointer )

            return value;
        }
    }
}
