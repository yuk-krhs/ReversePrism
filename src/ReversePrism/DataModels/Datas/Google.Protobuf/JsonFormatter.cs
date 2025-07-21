using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AnyTypeUrlField                          string IL2CPP_TYPE_STRING
    // 000 AnyDiagnosticValueField                  string IL2CPP_TYPE_STRING
    // 000 AnyWellKnownTypeValueField               string IL2CPP_TYPE_STRING
    // 000 NameValueSeparator                       string IL2CPP_TYPE_STRING
    // 000 ValueSeparator                           string IL2CPP_TYPE_STRING
    // 000 MultilineValueSeparator                  string IL2CPP_TYPE_STRING
    // 000 ObjectOpenBracket                        char IL2CPP_TYPE_CHAR
    // 000 ObjectCloseBracket                       char IL2CPP_TYPE_CHAR
    // 000 ListBracketOpen                          char IL2CPP_TYPE_CHAR
    // 000 ListBracketClose                         char IL2CPP_TYPE_CHAR
    // 000 <Default>k__BackingField                 JsonFormatter IL2CPP_TYPE_CLASS
    // 008 diagnosticFormatter                      JsonFormatter IL2CPP_TYPE_CLASS
    // 010 CommonRepresentations                    ModelPrimitiveListType string[] string[] List<string> Pointer
    // 010 Settings                                 ModelClassType Settings Settings Settings Pointer
    // 000 Hex                                      string IL2CPP_TYPE_STRING
    public partial class JsonFormatter : DataModel
    {
        public List<string>?                            CommonRepresentations                   { get; set; }
        public Settings?                                Settings                                { get; set; }

        public static JsonFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatter() { Pointer= p0 };

            value.CommonRepresentations                     = GetStringList(new IntPtr(p + 0x010)); // 0x10 CommonRepresentations       ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Settings                                  = GetObject<Settings>(new IntPtr(p + 0x010), ReversePrism.DataModels.Settings.FromPointer); // 0x10 Settings                    ( ModelClassType Settings Settings Settings Pointer )

            return value;
        }
    }
}
