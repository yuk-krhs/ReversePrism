using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TypePropertyName                         string IL2CPP_TYPE_STRING
    // 000 PropertiesPropertyName                   string IL2CPP_TYPE_STRING
    // 000 ItemsPropertyName                        string IL2CPP_TYPE_STRING
    // 000 AdditionalItemsPropertyName              string IL2CPP_TYPE_STRING
    // 000 RequiredPropertyName                     string IL2CPP_TYPE_STRING
    // 000 PatternPropertiesPropertyName            string IL2CPP_TYPE_STRING
    // 000 AdditionalPropertiesPropertyName         string IL2CPP_TYPE_STRING
    // 000 RequiresPropertyName                     string IL2CPP_TYPE_STRING
    // 000 MinimumPropertyName                      string IL2CPP_TYPE_STRING
    // 000 MaximumPropertyName                      string IL2CPP_TYPE_STRING
    // 000 ExclusiveMinimumPropertyName             string IL2CPP_TYPE_STRING
    // 000 ExclusiveMaximumPropertyName             string IL2CPP_TYPE_STRING
    // 000 MinimumItemsPropertyName                 string IL2CPP_TYPE_STRING
    // 000 MaximumItemsPropertyName                 string IL2CPP_TYPE_STRING
    // 000 PatternPropertyName                      string IL2CPP_TYPE_STRING
    // 000 MaximumLengthPropertyName                string IL2CPP_TYPE_STRING
    // 000 MinimumLengthPropertyName                string IL2CPP_TYPE_STRING
    // 000 EnumPropertyName                         string IL2CPP_TYPE_STRING
    // 000 ReadOnlyPropertyName                     string IL2CPP_TYPE_STRING
    // 000 TitlePropertyName                        string IL2CPP_TYPE_STRING
    // 000 DescriptionPropertyName                  string IL2CPP_TYPE_STRING
    // 000 FormatPropertyName                       string IL2CPP_TYPE_STRING
    // 000 DefaultPropertyName                      string IL2CPP_TYPE_STRING
    // 000 TransientPropertyName                    string IL2CPP_TYPE_STRING
    // 000 DivisibleByPropertyName                  string IL2CPP_TYPE_STRING
    // 000 HiddenPropertyName                       string IL2CPP_TYPE_STRING
    // 000 DisallowPropertyName                     string IL2CPP_TYPE_STRING
    // 000 ExtendsPropertyName                      string IL2CPP_TYPE_STRING
    // 000 IdPropertyName                           string IL2CPP_TYPE_STRING
    // 000 UniqueItemsPropertyName                  string IL2CPP_TYPE_STRING
    // 000 OptionValuePropertyName                  string IL2CPP_TYPE_STRING
    // 000 OptionLabelPropertyName                  string IL2CPP_TYPE_STRING
    // 000 JsonSchemaTypeMapping                    IDictionary`2<string, JsonSchemaType> IL2CPP_TYPE_GENERICINST
    public partial class JsonSchemaConstants : DataModel
    {

        public static JsonSchemaConstants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonSchemaConstants() { Pointer= p0 };


            return value;
        }
    }
}
