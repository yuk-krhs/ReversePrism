using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Type                                     ModelPrimitiveType string string string String
    // 020 Id                                       ModelPrimitiveType string string string String
    // 028 ExpectedControlType                      ModelPrimitiveType string string string String
    // 030 ExpectedControlLayout                    ModelPrimitiveType string string string String
    // 038 Processors                               ModelPrimitiveType string string string String
    // 040 Interactions                             ModelPrimitiveType string string string String
    // 048 PassThrough                              ModelPrimitiveType bool bool bool Bool
    // 049 InitialStateCheck                        ModelPrimitiveType bool bool bool Bool
    // 050 Bindings                                 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer
    public partial class ReadActionJson : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   Type                                    { get; set; }
        public string                                   Id                                      { get; set; }
        public string                                   ExpectedControlType                     { get; set; }
        public string                                   ExpectedControlLayout                   { get; set; }
        public string                                   Processors                              { get; set; }
        public string                                   Interactions                            { get; set; }
        public bool                                     PassThrough                             { get; set; }
        public bool                                     InitialStateCheck                       { get; set; }
        public List<BindingJson>?                       Bindings                                { get; set; }

        public static ReadActionJson? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadActionJson() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Id                          ( ModelPrimitiveType string string string String )
            value.ExpectedControlType                       = GetString(new IntPtr(p + 0x028)); // 0x28 ExpectedControlType         ( ModelPrimitiveType string string string String )
            value.ExpectedControlLayout                     = GetString(new IntPtr(p + 0x030)); // 0x30 ExpectedControlLayout       ( ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x038)); // 0x38 Processors                  ( ModelPrimitiveType string string string String )
            value.Interactions                              = GetString(new IntPtr(p + 0x040)); // 0x40 Interactions                ( ModelPrimitiveType string string string String )
            value.PassThrough                               = GetBool(new IntPtr(p + 0x048)); // 0x48 PassThrough                 ( ModelPrimitiveType bool bool bool Bool )
            value.InitialStateCheck                         = GetBool(new IntPtr(p + 0x049)); // 0x49 InitialStateCheck           ( ModelPrimitiveType bool bool bool Bool )
            value.Bindings                                  = GetEnumList<BindingJson>(new IntPtr(p + 0x050)); // 0x50 Bindings                    ( ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer )

            return value;
        }
    }
}
