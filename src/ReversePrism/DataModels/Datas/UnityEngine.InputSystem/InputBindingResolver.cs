using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalProcessorCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 TotalCompositeCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 TotalInteractionCount                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Maps                                     000185B8BDE0 ModelClassListType InputActionMap[] InputActionMap[] List<InputActionMap> Pointer
    // 028 Controls                                 000185B8C5B0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer
    // 030 Memory                                   000186622640 ModelEnumType UnmanagedMemory UnmanagedMemory UnmanagedMemory Int32
    // 0B0 Interactions                             000185B877E0 ModelClassListType IInputInteraction[] IInputInteraction[] List<IInputInteraction> Pointer
    // 0B8 Processors                               000185B8CF70 ModelClassListType InputProcessor[] InputProcessor[] List<InputProcessor> Pointer
    // 0C0 Composites                               000185B8C2D0 ModelClassListType InputBindingComposite[] InputBindingComposite[] List<InputBindingComposite> Pointer
    // 0C8 bindingMask                              Nullable`1<InputBinding> IL2CPP_TYPE_GENERICINST
    // 128 M_IsControlOnlyResolve                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 130 M_Parameters                             000185CF5668 ModelEnumListType List`1<NameAndParameters> List`1<NameAndParameters> List<NameAndParameters> Pointer
    public partial class InputBindingResolver
    {
        public int                                      TotalProcessorCount                     { get; set; }
        public int                                      TotalCompositeCount                     { get; set; }
        public int                                      TotalInteractionCount                   { get; set; }
        public List<InputActionMap>?                    Maps                                    { get; set; }
        public List<InputControl>?                      Controls                                { get; set; }
        public UnmanagedMemory                          Memory                                  { get; set; }
        public List<IInputInteraction>?                 Interactions                            { get; set; }
        public List<InputProcessor>?                    Processors                              { get; set; }
        public List<InputBindingComposite>?             Composites                              { get; set; }
        public bool                                     M_IsControlOnlyResolve                  { get; set; }
        public List<NameAndParameters>?                 M_Parameters                            { get; set; }

        public static InputBindingResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputBindingResolver();

            value.TotalProcessorCount                       = GetInt32(new IntPtr(p + 0x010)); // 0270D768B250 0x10 TotalProcessorCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalCompositeCount                       = GetInt32(new IntPtr(p + 0x014)); // 0270D768B270 0x14 TotalCompositeCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalInteractionCount                     = GetInt32(new IntPtr(p + 0x018)); // 0270D768B290 0x18 TotalInteractionCount       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Maps                                      = GetObjectList<InputActionMap>(new IntPtr(p + 0x020), ReversePrism.DataModels.InputActionMap.FromPointer); // 0270D768B2B0 0x20 Maps                        ( 000185B8BDE0 ModelClassListType InputActionMap[] InputActionMap[] List<InputActionMap> Pointer )
            value.Controls                                  = GetObjectList<InputControl>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputControl.FromPointer); // 0270D768B2D0 0x28 Controls                    ( 000185B8C5B0 ModelClassListType InputControl[] InputControl[] List<InputControl> Pointer )
            value.Memory                                    = (UnmanagedMemory)GetInt32(new IntPtr(p + 0x030)); // 0270D768B2F0 0x30 Memory                      ( 000186622640 ModelEnumType UnmanagedMemory UnmanagedMemory UnmanagedMemory Int32 )
            value.Interactions                              = GetObjectList<IInputInteraction>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.IInputInteraction.FromPointer); // 0270D768B310 0xB0 Interactions                ( 000185B877E0 ModelClassListType IInputInteraction[] IInputInteraction[] List<IInputInteraction> Pointer )
            value.Processors                                = GetObjectList<InputProcessor>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.InputProcessor.FromPointer); // 0270D768B330 0xB8 Processors                  ( 000185B8CF70 ModelClassListType InputProcessor[] InputProcessor[] List<InputProcessor> Pointer )
            value.Composites                                = GetObjectList<InputBindingComposite>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.InputBindingComposite.FromPointer); // 0270D768B350 0xC0 Composites                  ( 000185B8C2D0 ModelClassListType InputBindingComposite[] InputBindingComposite[] List<InputBindingComposite> Pointer )
            value.M_IsControlOnlyResolve                    = GetBool(new IntPtr(p + 0x128)); // 0270D768B390 0x128 M_IsControlOnlyResolve      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Parameters                              = GetEnumList<NameAndParameters>(new IntPtr(p + 0x130)); // 0270D768B3B0 0x130 M_Parameters                ( 000185CF5668 ModelEnumListType List`1<NameAndParameters> List`1<NameAndParameters> List<NameAndParameters> Pointer )

            return value;
        }
    }
}
