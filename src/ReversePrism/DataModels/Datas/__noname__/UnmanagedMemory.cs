using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 basePtr                                  IntPtr IL2CPP_TYPE_PTR
    // 018 MapCount                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ActionCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 InteractionCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 BindingCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 ControlCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C CompositeCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 actionStates                             IntPtr IL2CPP_TYPE_PTR
    // 038 bindingStates                            IntPtr IL2CPP_TYPE_PTR
    // 040 interactionStates                        IntPtr IL2CPP_TYPE_PTR
    // 048 controlMagnitudes                        IntPtr IL2CPP_TYPE_PTR
    // 050 compositeMagnitudes                      IntPtr IL2CPP_TYPE_PTR
    // 058 enabledControls                          IntPtr IL2CPP_TYPE_PTR
    // 060 actionBindingIndicesAndCounts            IntPtr IL2CPP_TYPE_PTR
    // 068 actionBindingIndices                     IntPtr IL2CPP_TYPE_PTR
    // 070 controlIndexToBindingIndex               IntPtr IL2CPP_TYPE_PTR
    // 078 controlGroupingAndComplexity             IntPtr IL2CPP_TYPE_PTR
    // 080 ControlGroupingInitialized               000186595960 ModelPrimitiveType bool bool bool Bool
    // 088 mapIndices                               IntPtr IL2CPP_TYPE_PTR
    public partial class UnmanagedMemory
    {
        public int                                      MapCount                                { get; set; }
        public int                                      ActionCount                             { get; set; }
        public int                                      InteractionCount                        { get; set; }
        public int                                      BindingCount                            { get; set; }
        public int                                      ControlCount                            { get; set; }
        public int                                      CompositeCount                          { get; set; }
        public bool                                     ControlGroupingInitialized              { get; set; }

        public static UnmanagedMemory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnmanagedMemory();

            value.MapCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0270001E4F80 0x18 MapCount                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ActionCount                               = GetInt32(new IntPtr(p + 0x01C)); // 0270001E4FA0 0x1C ActionCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.InteractionCount                          = GetInt32(new IntPtr(p + 0x020)); // 0270001E4FC0 0x20 InteractionCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BindingCount                              = GetInt32(new IntPtr(p + 0x024)); // 0270001E4FE0 0x24 BindingCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ControlCount                              = GetInt32(new IntPtr(p + 0x028)); // 0270001E5000 0x28 ControlCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CompositeCount                            = GetInt32(new IntPtr(p + 0x02C)); // 0270001E5020 0x2C CompositeCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ControlGroupingInitialized                = GetBool(new IntPtr(p + 0x080)); // 0270001E5180 0x80 ControlGroupingInitialized  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
