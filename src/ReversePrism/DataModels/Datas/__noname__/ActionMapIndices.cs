using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ActionStartIndex                         ModelPrimitiveType int int int Int32
    // 014 ActionCount                              ModelPrimitiveType int int int Int32
    // 018 ControlStartIndex                        ModelPrimitiveType int int int Int32
    // 01C ControlCount                             ModelPrimitiveType int int int Int32
    // 020 BindingStartIndex                        ModelPrimitiveType int int int Int32
    // 024 BindingCount                             ModelPrimitiveType int int int Int32
    // 028 InteractionStartIndex                    ModelPrimitiveType int int int Int32
    // 02C InteractionCount                         ModelPrimitiveType int int int Int32
    // 030 ProcessorStartIndex                      ModelPrimitiveType int int int Int32
    // 034 ProcessorCount                           ModelPrimitiveType int int int Int32
    // 038 CompositeStartIndex                      ModelPrimitiveType int int int Int32
    // 03C CompositeCount                           ModelPrimitiveType int int int Int32
    public partial class ActionMapIndices : DataModel
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
            var value   = new ActionMapIndices() { Pointer= p0 };

            value.ActionStartIndex                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 ActionStartIndex            ( ModelPrimitiveType int int int Int32 )
            value.ActionCount                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 ActionCount                 ( ModelPrimitiveType int int int Int32 )
            value.ControlStartIndex                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 ControlStartIndex           ( ModelPrimitiveType int int int Int32 )
            value.ControlCount                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ControlCount                ( ModelPrimitiveType int int int Int32 )
            value.BindingStartIndex                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 BindingStartIndex           ( ModelPrimitiveType int int int Int32 )
            value.BindingCount                              = GetInt32(new IntPtr(p + 0x024)); // 0x24 BindingCount                ( ModelPrimitiveType int int int Int32 )
            value.InteractionStartIndex                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 InteractionStartIndex       ( ModelPrimitiveType int int int Int32 )
            value.InteractionCount                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C InteractionCount            ( ModelPrimitiveType int int int Int32 )
            value.ProcessorStartIndex                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 ProcessorStartIndex         ( ModelPrimitiveType int int int Int32 )
            value.ProcessorCount                            = GetInt32(new IntPtr(p + 0x034)); // 0x34 ProcessorCount              ( ModelPrimitiveType int int int Int32 )
            value.CompositeStartIndex                       = GetInt32(new IntPtr(p + 0x038)); // 0x38 CompositeStartIndex         ( ModelPrimitiveType int int int Int32 )
            value.CompositeCount                            = GetInt32(new IntPtr(p + 0x03C)); // 0x3C CompositeCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
