using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kInvalidIndex                            int IL2CPP_TYPE_I4
    // 010 Maps                                     000185B8BDE0 ModelClassListType InputActionMap[] InputActionMap[] List<InputActionMap> Pointer
    // 018 Controls                                 000185B8C5B0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 020 Interactions                             000185B877E0 ModelClassListType IInputInteraction[] IInputInteraction[] List<IInputInteraction> Pointer
    // 028 Processors                               000185B8CF70 ModelClassListType InputProcessor[] InputProcessor[] List<InputProcessor> Pointer
    // 030 Composites                               000185B8C2D0 ModelClassListType InputBindingComposite[] InputBindingComposite[] List<InputBindingComposite> Pointer
    // 038 TotalProcessorCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 Memory                                   000186622640 ModelEnumType UnmanagedMemory UnmanagedMemory UnmanagedMemory Int32
    // 0C0 M_OnBeforeUpdateHooked                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C1 M_OnAfterUpdateHooked                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C2 M_InProcessControlStateChange            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C8 M_CurrentlyProcessingThisEvent           0001865EF0C0 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32
    // 0D0 M_OnBeforeUpdateDelegate                 0001866792B0 ModelClassType Action Action Action Pointer
    // 0D8 M_OnAfterUpdateDelegate                  0001866792B0 ModelClassType Action Action Action Pointer
    // 000 s_GlobalState                            GlobalState IL2CPP_TYPE_VALUETYPE
    public partial class InputActionState
    {
        public List<InputActionMap>?                    Maps                                    { get; set; }
        public List<InputControl>?                      Controls                                { get; set; }
        public List<IInputInteraction>?                 Interactions                            { get; set; }
        public List<InputProcessor>?                    Processors                              { get; set; }
        public List<InputBindingComposite>?             Composites                              { get; set; }
        public int                                      TotalProcessorCount                     { get; set; }
        public UnmanagedMemory                          Memory                                  { get; set; }
        public bool                                     M_OnBeforeUpdateHooked                  { get; set; }
        public bool                                     M_OnAfterUpdateHooked                   { get; set; }
        public bool                                     M_InProcessControlStateChange           { get; set; }
        public InputEventPtr                            M_CurrentlyProcessingThisEvent          { get; set; }
        public Action?                                  M_OnBeforeUpdateDelegate                { get; set; }
        public Action?                                  M_OnAfterUpdateDelegate                 { get; set; }

        public static InputActionState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputActionState();

            value.Maps                                      = GetObjectList<InputActionMap>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionMap.FromPointer); // 0270001E4DA0 0x10 Maps                        ( 000185B8BDE0 ModelClassListType InputActionMap[] InputActionMap[] List<InputActionMap> Pointer )
            value.Controls                                  = GetObjectList<InputControl>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputControl.FromPointer); // 0270001E4DC0 0x18 Controls                    ( 000185B8C5B0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.Interactions                              = GetObjectList<IInputInteraction>(new IntPtr(p + 0x020), ReversePrism.DataModels.IInputInteraction.FromPointer); // 0270001E4DE0 0x20 Interactions                ( 000185B877E0 ModelClassListType IInputInteraction[] IInputInteraction[] List<IInputInteraction> Pointer )
            value.Processors                                = GetObjectList<InputProcessor>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputProcessor.FromPointer); // 0270001E4E00 0x28 Processors                  ( 000185B8CF70 ModelClassListType InputProcessor[] InputProcessor[] List<InputProcessor> Pointer )
            value.Composites                                = GetObjectList<InputBindingComposite>(new IntPtr(p + 0x030), ReversePrism.DataModels.InputBindingComposite.FromPointer); // 0270001E4E20 0x30 Composites                  ( 000185B8C2D0 ModelClassListType InputBindingComposite[] InputBindingComposite[] List<InputBindingComposite> Pointer )
            value.TotalProcessorCount                       = GetInt32(new IntPtr(p + 0x038)); // 0270001E4E40 0x38 TotalProcessorCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Memory                                    = (UnmanagedMemory)GetInt32(new IntPtr(p + 0x040)); // 0270001E4E60 0x40 Memory                      ( 000186622640 ModelEnumType UnmanagedMemory UnmanagedMemory UnmanagedMemory Int32 )
            value.M_OnBeforeUpdateHooked                    = GetBool(new IntPtr(p + 0x0C0)); // 0270001E4E80 0xC0 M_OnBeforeUpdateHooked      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_OnAfterUpdateHooked                     = GetBool(new IntPtr(p + 0x0C1)); // 0270001E4EA0 0xC1 M_OnAfterUpdateHooked       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_InProcessControlStateChange             = GetBool(new IntPtr(p + 0x0C2)); // 0270001E4EC0 0xC2 M_InProcessControlStateChange ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentlyProcessingThisEvent            = (InputEventPtr)GetInt32(new IntPtr(p + 0x0C8)); // 0270001E4EE0 0xC8 M_CurrentlyProcessingThisEvent ( 0001865EF0C0 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32 )
            value.M_OnBeforeUpdateDelegate                  = GetObject<Action>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.Action.FromPointer); // 0270001E4F00 0xD0 M_OnBeforeUpdateDelegate    ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.M_OnAfterUpdateDelegate                   = GetObject<Action>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.Action.FromPointer); // 0270001E4F20 0xD8 M_OnAfterUpdateDelegate     ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
