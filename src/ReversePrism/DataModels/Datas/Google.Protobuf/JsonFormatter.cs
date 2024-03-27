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
    // 000 TypeUrlPrefix                            string IL2CPP_TYPE_STRING
    // 000 NameValueSeparator                       string IL2CPP_TYPE_STRING
    // 000 PropertySeparator                        string IL2CPP_TYPE_STRING
    // 000 <Default>k__BackingField                 JsonFormatter IL2CPP_TYPE_CLASS
    // 008 diagnosticFormatter                      JsonFormatter IL2CPP_TYPE_CLASS
    // 010 CommonRepresentations                    000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 010 Settings                                 0001866623A0 ModelClassType Settings Settings Settings Pointer
    // 000 Hex                                      string IL2CPP_TYPE_STRING
    public partial class JsonFormatter
    {
        public List<string>?                            CommonRepresentations                   { get; set; }
        public Settings?                                Settings                                { get; set; }

        public static JsonFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonFormatter();

            value.CommonRepresentations                     = GetStringList(new IntPtr(p + 0x010)); // 0270D0D13318 0x10 CommonRepresentations       ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Settings                                  = GetObject<Settings>(new IntPtr(p + 0x010), ReversePrism.DataModels.Settings.FromPointer); // 0270D0D13338 0x10 Settings                    ( 0001866623A0 ModelClassType Settings Settings Settings Pointer )

            return value;
        }
    }
}
