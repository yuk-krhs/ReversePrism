using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionStartIndex                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ActionCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ControlStartIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ControlCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 BindingStartIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 BindingCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 InteractionStartIndex                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C InteractionCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 ProcessorStartIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 ProcessorCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 CompositeStartIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C CompositeCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ActionMapIndices
    {
        public int                                      ActionStartIndex                        { get; set; }
        public int                                      ActionCount                             { get; set; }
        public int                                      ControlStartIndex                       { get; set; }
        public int                                      ControlCount                            { get; set; }
        public int                                      BindingStartIndex                       { get; set; }
        public int                                      BindingCount                            { get; set; }
        public int                                      InteractionStartIndex                   { get; set; }
        public int                                      InteractionCount                        { get; set; }
        public int                                      ProcessorStartIndex                     { get; set; }
        public int                                      ProcessorCount                          { get; set; }
        public int                                      CompositeStartIndex                     { get; set; }
        public int                                      CompositeCount                          { get; set; }

        public static ActionMapIndices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionMapIndices();

            value.ActionStartIndex                          = GetInt32(new IntPtr(p + 0x010)); // 0270D7674588 0x10 ActionStartIndex            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ActionCount                               = GetInt32(new IntPtr(p + 0x014)); // 0270D76745A8 0x14 ActionCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ControlStartIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0270D76745C8 0x18 ControlStartIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ControlCount                              = GetInt32(new IntPtr(p + 0x01C)); // 0270D76745E8 0x1C ControlCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BindingStartIndex                         = GetInt32(new IntPtr(p + 0x020)); // 0270D7674608 0x20 BindingStartIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BindingCount                              = GetInt32(new IntPtr(p + 0x024)); // 0270D7674628 0x24 BindingCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.InteractionStartIndex                     = GetInt32(new IntPtr(p + 0x028)); // 0270D7674648 0x28 InteractionStartIndex       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.InteractionCount                          = GetInt32(new IntPtr(p + 0x02C)); // 0270D7674668 0x2C InteractionCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProcessorStartIndex                       = GetInt32(new IntPtr(p + 0x030)); // 0270D7674688 0x30 ProcessorStartIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProcessorCount                            = GetInt32(new IntPtr(p + 0x034)); // 0270D76746A8 0x34 ProcessorCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CompositeStartIndex                       = GetInt32(new IntPtr(p + 0x038)); // 0270D76746C8 0x38 CompositeStartIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CompositeCount                            = GetInt32(new IntPtr(p + 0x03C)); // 0270D76746E8 0x3C CompositeCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
