using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 invariant_culture_info                   CultureInfo IL2CPP_TYPE_CLASS
    // 008 shared_table_lock                        <object> IL2CPP_TYPE_OBJECT
    // 010 Default_current_culture                  ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 010 M_isReadOnly                             ModelPrimitiveType bool bool bool Bool
    // 014 CultureID                                ModelPrimitiveType int int int Int32
    // 018 Parent_lcid                              ModelPrimitiveType int int int Int32
    // 01C Datetime_index                           ModelPrimitiveType int int int Int32
    // 020 Number_index                             ModelPrimitiveType int int int Int32
    // 024 Default_calendar_type                    ModelPrimitiveType int int int Int32
    // 028 M_useUserOverride                        ModelPrimitiveType bool bool bool Bool
    // 030 NumInfo                                  ModelClassType NumberFormatInfo NumberFormatInfo NumberFormatInfo Pointer
    // 038 DateTimeInfo                             ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
    // 040 TextInfo                                 ModelClassType TextInfo TextInfo TextInfo Pointer
    // 048 M_name                                   ModelPrimitiveType string string string String
    // 050 Englishname                              ModelPrimitiveType string string string String
    // 058 Nativename                               ModelPrimitiveType string string string String
    // 060 Iso3lang                                 ModelPrimitiveType string string string String
    // 068 Iso2lang                                 ModelPrimitiveType string string string String
    // 070 Win3lang                                 ModelPrimitiveType string string string String
    // 078 Territory                                ModelPrimitiveType string string string String
    // 080 Native_calendar_names                    ModelPrimitiveListType string[] string[] List<string> Pointer
    // 088 CompareInfo                              ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 090 textinfo_data                            IntPtr IL2CPP_TYPE_PTR
    // 098 M_dataItem                               ModelPrimitiveType int int int Int32
    // 0A0 Calendar                                 ModelClassType Calendar Calendar Calendar Pointer
    // 0A8 Parent_culture                           ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 0B0 Constructed                              ModelPrimitiveType bool bool bool Bool
    // 0B8 Cached_serialized_form                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0C0 M_cultureData                            ModelClassType CultureData CultureData CultureData Pointer
    // 0C8 M_isInherited                            ModelPrimitiveType bool bool bool Bool
    // 000 InvariantCultureId                       int IL2CPP_TYPE_I4
    // 000 CalendarTypeBits                         int IL2CPP_TYPE_I4
    // 000 LOCALE_INVARIANT                         int IL2CPP_TYPE_I4
    // 000 MSG_READONLY                             string IL2CPP_TYPE_STRING
    // 018 S_DefaultThreadCurrentUICulture          ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 020 S_DefaultThreadCurrentCulture            ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 028 shared_by_number                         Dictionary`2<int, CultureInfo> IL2CPP_TYPE_GENERICINST
    // 030 shared_by_name                           Dictionary`2<string, CultureInfo> IL2CPP_TYPE_GENERICINST
    // 038 S_UserPreferredCultureInfoInAppX         ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 040 IsTaiwanSku                              ModelPrimitiveType bool bool bool Bool
    public partial class CultureInfo : DataModel
    {
        public CultureInfo?                             Default_current_culture                 { get; set; }
        public bool                                     M_isReadOnly                            { get; set; }
        public int                                      CultureID                               { get; set; }
        public int                                      Parent_lcid                             { get; set; }
        public int                                      Datetime_index                          { get; set; }
        public int                                      Number_index                            { get; set; }
        public int                                      Default_calendar_type                   { get; set; }
        public bool                                     M_useUserOverride                       { get; set; }
        public NumberFormatInfo?                        NumInfo                                 { get; set; }
        public DateTimeFormatInfo?                      DateTimeInfo                            { get; set; }
        public TextInfo?                                TextInfo                                { get; set; }
        public string                                   M_name                                  { get; set; }
        public string                                   Englishname                             { get; set; }
        public string                                   Nativename                              { get; set; }
        public string                                   Iso3lang                                { get; set; }
        public string                                   Iso2lang                                { get; set; }
        public string                                   Win3lang                                { get; set; }
        public string                                   Territory                               { get; set; }
        public List<string>?                            Native_calendar_names                   { get; set; }
        public CompareInfo?                             CompareInfo                             { get; set; }
        public int                                      M_dataItem                              { get; set; }
        public Calendar?                                Calendar                                { get; set; }
        public CultureInfo?                             Parent_culture                          { get; set; }
        public bool                                     Constructed                             { get; set; }
        public List<sbyte>?                             Cached_serialized_form                  { get; set; }
        public CultureData?                             M_cultureData                           { get; set; }
        public bool                                     M_isInherited                           { get; set; }
        public CultureInfo?                             S_DefaultThreadCurrentUICulture         { get; set; }
        public CultureInfo?                             S_DefaultThreadCurrentCulture           { get; set; }
        public CultureInfo?                             S_UserPreferredCultureInfoInAppX        { get; set; }
        public bool                                     IsTaiwanSku                             { get; set; }

        public static CultureInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CultureInfo() { Pointer= p0 };

            value.Default_current_culture                   = GetObject<CultureInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x10 Default_current_culture     ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.M_isReadOnly                              = GetBool(new IntPtr(p + 0x010)); // 0x10 M_isReadOnly                ( ModelPrimitiveType bool bool bool Bool )
            value.CultureID                                 = GetInt32(new IntPtr(p + 0x014)); // 0x14 CultureID                   ( ModelPrimitiveType int int int Int32 )
            value.Parent_lcid                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 Parent_lcid                 ( ModelPrimitiveType int int int Int32 )
            value.Datetime_index                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Datetime_index              ( ModelPrimitiveType int int int Int32 )
            value.Number_index                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 Number_index                ( ModelPrimitiveType int int int Int32 )
            value.Default_calendar_type                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Default_calendar_type       ( ModelPrimitiveType int int int Int32 )
            value.M_useUserOverride                         = GetBool(new IntPtr(p + 0x028)); // 0x28 M_useUserOverride           ( ModelPrimitiveType bool bool bool Bool )
            value.NumInfo                                   = GetObject<NumberFormatInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.NumberFormatInfo.FromPointer); // 0x30 NumInfo                     ( ModelClassType NumberFormatInfo NumberFormatInfo NumberFormatInfo Pointer )
            value.DateTimeInfo                              = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0x38 DateTimeInfo                ( ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )
            value.TextInfo                                  = GetObject<TextInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextInfo.FromPointer); // 0x40 TextInfo                    ( ModelClassType TextInfo TextInfo TextInfo Pointer )
            value.M_name                                    = GetString(new IntPtr(p + 0x048)); // 0x48 M_name                      ( ModelPrimitiveType string string string String )
            value.Englishname                               = GetString(new IntPtr(p + 0x050)); // 0x50 Englishname                 ( ModelPrimitiveType string string string String )
            value.Nativename                                = GetString(new IntPtr(p + 0x058)); // 0x58 Nativename                  ( ModelPrimitiveType string string string String )
            value.Iso3lang                                  = GetString(new IntPtr(p + 0x060)); // 0x60 Iso3lang                    ( ModelPrimitiveType string string string String )
            value.Iso2lang                                  = GetString(new IntPtr(p + 0x068)); // 0x68 Iso2lang                    ( ModelPrimitiveType string string string String )
            value.Win3lang                                  = GetString(new IntPtr(p + 0x070)); // 0x70 Win3lang                    ( ModelPrimitiveType string string string String )
            value.Territory                                 = GetString(new IntPtr(p + 0x078)); // 0x78 Territory                   ( ModelPrimitiveType string string string String )
            value.Native_calendar_names                     = GetStringList(new IntPtr(p + 0x080)); // 0x80 Native_calendar_names       ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.CompareInfo.FromPointer); // 0x88 CompareInfo                 ( ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.M_dataItem                                = GetInt32(new IntPtr(p + 0x098)); // 0x98 M_dataItem                  ( ModelPrimitiveType int int int Int32 )
            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Calendar.FromPointer); // 0xA0 Calendar                    ( ModelClassType Calendar Calendar Calendar Pointer )
            value.Parent_culture                            = GetObject<CultureInfo>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CultureInfo.FromPointer); // 0xA8 Parent_culture              ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Constructed                               = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 Constructed                 ( ModelPrimitiveType bool bool bool Bool )
            value.Cached_serialized_form                    = GetSByteList(new IntPtr(p + 0x0B8)); // 0xB8 Cached_serialized_form      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_cultureData                             = GetObject<CultureData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CultureData.FromPointer); // 0xC0 M_cultureData               ( ModelClassType CultureData CultureData CultureData Pointer )
            value.M_isInherited                             = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 M_isInherited               ( ModelPrimitiveType bool bool bool Bool )
            value.S_DefaultThreadCurrentUICulture           = GetObject<CultureInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x18 S_DefaultThreadCurrentUICulture ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.S_DefaultThreadCurrentCulture             = GetObject<CultureInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x20 S_DefaultThreadCurrentCulture ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.S_UserPreferredCultureInfoInAppX          = GetObject<CultureInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.CultureInfo.FromPointer); // 0x38 S_UserPreferredCultureInfoInAppX ( ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.IsTaiwanSku                               = GetBool(new IntPtr(p + 0x040)); // 0x40 IsTaiwanSku                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
