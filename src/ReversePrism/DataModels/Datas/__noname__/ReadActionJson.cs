using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Type                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 Id                                       0001866722E0 ModelPrimitiveType string string string String
    // 028 ExpectedControlType                      0001866722E0 ModelPrimitiveType string string string String
    // 030 ExpectedControlLayout                    0001866722E0 ModelPrimitiveType string string string String
    // 038 Processors                               0001866722E0 ModelPrimitiveType string string string String
    // 040 Interactions                             0001866722E0 ModelPrimitiveType string string string String
    // 048 PassThrough                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 049 InitialStateCheck                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 Bindings                                 000185CBC468 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer
    public partial class ReadActionJson
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
            var value   = new ReadActionJson();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D764F7F8 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0270D764F818 0x18 Type                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Id                                        = GetString(new IntPtr(p + 0x020)); // 0270D764F838 0x20 Id                          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ExpectedControlType                       = GetString(new IntPtr(p + 0x028)); // 0270D764F858 0x28 ExpectedControlType         ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ExpectedControlLayout                     = GetString(new IntPtr(p + 0x030)); // 0270D764F878 0x30 ExpectedControlLayout       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Processors                                = GetString(new IntPtr(p + 0x038)); // 0270D764F898 0x38 Processors                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Interactions                              = GetString(new IntPtr(p + 0x040)); // 0270D764F8B8 0x40 Interactions                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PassThrough                               = GetBool(new IntPtr(p + 0x048)); // 0270D764F8D8 0x48 PassThrough                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.InitialStateCheck                         = GetBool(new IntPtr(p + 0x049)); // 0270D764F8F8 0x49 InitialStateCheck           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Bindings                                  = GetEnumList<BindingJson>(new IntPtr(p + 0x050)); // 0270D764F918 0x50 Bindings                    ( 000185CBC468 ModelEnumListType BindingJson[] BindingJson[] List<BindingJson> Pointer )

            return value;
        }
    }
}
