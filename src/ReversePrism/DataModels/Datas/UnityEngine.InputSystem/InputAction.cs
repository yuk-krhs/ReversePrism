using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Type                                   ModelEnumType InputActionType InputActionType InputActionType Int32
    // 020 M_ExpectedControlType                    ModelPrimitiveType string string string String
    // 028 M_Id                                     ModelPrimitiveType string string string String
    // 030 M_Processors                             ModelPrimitiveType string string string String
    // 038 M_Interactions                           ModelPrimitiveType string string string String
    // 040 M_SingletonActionBindings                ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer
    // 048 M_Flags                                  ModelEnumType ActionFlags ActionFlags ActionFlags Int32
    // 050 m_BindingMask                            Nullable`1<InputBinding> IL2CPP_TYPE_GENERICINST
    // 0B0 M_BindingsStartIndex                     ModelPrimitiveType int int int Int32
    // 0B4 M_BindingsCount                          ModelPrimitiveType int int int Int32
    // 0B8 M_ControlStartIndex                      ModelPrimitiveType int int int Int32
    // 0BC M_ControlCount                           ModelPrimitiveType int int int Int32
    // 0C0 M_ActionIndexInState                     ModelPrimitiveType int int int Int32
    // 0C8 M_ActionMap                              ModelClassType InputActionMap InputActionMap InputActionMap Pointer
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

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Type                                    = (InputActionType)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_Type                      ( ModelEnumType InputActionType InputActionType InputActionType Int32 )
            value.M_ExpectedControlType                     = GetString(new IntPtr(p + 0x020)); // 0x20 M_ExpectedControlType       ( ModelPrimitiveType string string string String )
            value.M_Id                                      = GetString(new IntPtr(p + 0x028)); // 0x28 M_Id                        ( ModelPrimitiveType string string string String )
            value.M_Processors                              = GetString(new IntPtr(p + 0x030)); // 0x30 M_Processors                ( ModelPrimitiveType string string string String )
            value.M_Interactions                            = GetString(new IntPtr(p + 0x038)); // 0x38 M_Interactions              ( ModelPrimitiveType string string string String )
            value.M_SingletonActionBindings                 = GetEnumList<InputBinding>(new IntPtr(p + 0x040)); // 0x40 M_SingletonActionBindings   ( ModelEnumListType InputBinding[] InputBinding[] List<InputBinding> Pointer )
            value.M_Flags                                   = (ActionFlags)GetInt32(new IntPtr(p + 0x048)); // 0x48 M_Flags                     ( ModelEnumType ActionFlags ActionFlags ActionFlags Int32 )
            value.M_BindingsStartIndex                      = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_BindingsStartIndex        ( ModelPrimitiveType int int int Int32 )
            value.M_BindingsCount                           = GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 M_BindingsCount             ( ModelPrimitiveType int int int Int32 )
            value.M_ControlStartIndex                       = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_ControlStartIndex         ( ModelPrimitiveType int int int Int32 )
            value.M_ControlCount                            = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC M_ControlCount              ( ModelPrimitiveType int int int Int32 )
            value.M_ActionIndexInState                      = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 M_ActionIndexInState        ( ModelPrimitiveType int int int Int32 )
            value.M_ActionMap                               = GetObject<InputActionMap>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.InputActionMap.FromPointer); // 0xC8 M_ActionMap                 ( ModelClassType InputActionMap InputActionMap InputActionMap Pointer )

            return value;
        }
    }
}
