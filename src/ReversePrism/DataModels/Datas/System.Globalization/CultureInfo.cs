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
    // 010 Default_current_culture                  0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 010 M_isReadOnly                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 CultureID                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Parent_lcid                              0001865F5290 ModelPrimitiveType int int int Int32
    // 01C Datetime_index                           0001865F5290 ModelPrimitiveType int int int Int32
    // 020 Number_index                             0001865F5290 ModelPrimitiveType int int int Int32
    // 024 Default_calendar_type                    0001865F5290 ModelPrimitiveType int int int Int32
    // 028 M_useUserOverride                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 NumInfo                                  0001866C0BE0 ModelClassType NumberFormatInfo NumberFormatInfo NumberFormatInfo Pointer
    // 038 DateTimeInfo                             0001865BB310 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer
    // 040 TextInfo                                 00018663DAB0 ModelClassType TextInfo TextInfo TextInfo Pointer
    // 048 M_name                                   000186671BA0 ModelPrimitiveType string string string String
    // 050 Englishname                              0001866742E0 ModelPrimitiveType string string string String
    // 058 Nativename                               0001866742E0 ModelPrimitiveType string string string String
    // 060 Iso3lang                                 0001866742E0 ModelPrimitiveType string string string String
    // 068 Iso2lang                                 0001866742E0 ModelPrimitiveType string string string String
    // 070 Win3lang                                 0001866742E0 ModelPrimitiveType string string string String
    // 078 Territory                                0001866742E0 ModelPrimitiveType string string string String
    // 080 Native_calendar_names                    000185B82390 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 088 CompareInfo                              0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer
    // 090 textinfo_data                            IntPtr IL2CPP_TYPE_PTR
    // 098 M_dataItem                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 Calendar                                 0001865A0F00 ModelClassType Calendar Calendar Calendar Pointer
    // 0A8 Parent_culture                           0001865B5970 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 0B0 Constructed                              0001865974C0 ModelPrimitiveType bool bool bool Bool
    // 0B8 Cached_serialized_form                   000185B7A6C0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 0C0 M_cultureData                            0001866668A0 ModelClassType CultureData CultureData CultureData Pointer
    // 0C8 M_isInherited                            0001865976C0 ModelPrimitiveType bool bool bool Bool
    // 000 InvariantCultureId                       int IL2CPP_TYPE_I4
    // 000 CalendarTypeBits                         int IL2CPP_TYPE_I4
    // 000 LOCALE_INVARIANT                         int IL2CPP_TYPE_I4
    // 000 MSG_READONLY                             string IL2CPP_TYPE_STRING
    // 018 S_DefaultThreadCurrentUICulture          0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 020 S_DefaultThreadCurrentCulture            0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 028 shared_by_number                         Dictionary`2<int, CultureInfo> IL2CPP_TYPE_GENERICINST
    // 030 shared_by_name                           Dictionary`2<string, CultureInfo> IL2CPP_TYPE_GENERICINST
    // 038 S_UserPreferredCultureInfoInAppX         0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer
    // 040 IsTaiwanSku                              000186596FC0 ModelPrimitiveType bool bool bool Bool
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

            value.Default_current_culture                   = GetObject<CultureInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A2E637F0 0x10 Default_current_culture     ( 0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.M_isReadOnly                              = GetBool(new IntPtr(p + 0x010)); // 0245A2E63810 0x10 M_isReadOnly                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CultureID                                 = GetInt32(new IntPtr(p + 0x014)); // 0245A2E63830 0x14 CultureID                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Parent_lcid                               = GetInt32(new IntPtr(p + 0x018)); // 0245A2E63850 0x18 Parent_lcid                 ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.Datetime_index                            = GetInt32(new IntPtr(p + 0x01C)); // 0245A2E63870 0x1C Datetime_index              ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.Number_index                              = GetInt32(new IntPtr(p + 0x020)); // 0245A2E63890 0x20 Number_index                ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.Default_calendar_type                     = GetInt32(new IntPtr(p + 0x024)); // 0245A2E638B0 0x24 Default_calendar_type       ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.M_useUserOverride                         = GetBool(new IntPtr(p + 0x028)); // 0245A2E638D0 0x28 M_useUserOverride           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NumInfo                                   = GetObject<NumberFormatInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.NumberFormatInfo.FromPointer); // 0245A2E638F0 0x30 NumInfo                     ( 0001866C0BE0 ModelClassType NumberFormatInfo NumberFormatInfo NumberFormatInfo Pointer )
            value.DateTimeInfo                              = GetObject<DateTimeFormatInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.DateTimeFormatInfo.FromPointer); // 0245A2E63910 0x38 DateTimeInfo                ( 0001865BB310 ModelClassType DateTimeFormatInfo DateTimeFormatInfo DateTimeFormatInfo Pointer )
            value.TextInfo                                  = GetObject<TextInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.TextInfo.FromPointer); // 0245A2E63930 0x40 TextInfo                    ( 00018663DAB0 ModelClassType TextInfo TextInfo TextInfo Pointer )
            value.M_name                                    = GetString(new IntPtr(p + 0x048)); // 0245A2E63950 0x48 M_name                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Englishname                               = GetString(new IntPtr(p + 0x050)); // 0245A2E63970 0x50 Englishname                 ( 0001866742E0 ModelPrimitiveType string string string String )
            value.Nativename                                = GetString(new IntPtr(p + 0x058)); // 0245A2E63990 0x58 Nativename                  ( 0001866742E0 ModelPrimitiveType string string string String )
            value.Iso3lang                                  = GetString(new IntPtr(p + 0x060)); // 0245A2E639B0 0x60 Iso3lang                    ( 0001866742E0 ModelPrimitiveType string string string String )
            value.Iso2lang                                  = GetString(new IntPtr(p + 0x068)); // 0245A2E639D0 0x68 Iso2lang                    ( 0001866742E0 ModelPrimitiveType string string string String )
            value.Win3lang                                  = GetString(new IntPtr(p + 0x070)); // 0245A2E639F0 0x70 Win3lang                    ( 0001866742E0 ModelPrimitiveType string string string String )
            value.Territory                                 = GetString(new IntPtr(p + 0x078)); // 0245A2E63A10 0x78 Territory                   ( 0001866742E0 ModelPrimitiveType string string string String )
            value.Native_calendar_names                     = GetStringList(new IntPtr(p + 0x080)); // 0245A2E63A30 0x80 Native_calendar_names       ( 000185B82390 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.CompareInfo                               = GetObject<CompareInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.CompareInfo.FromPointer); // 0245A2E63A50 0x88 CompareInfo                 ( 0001865EB460 ModelClassType CompareInfo CompareInfo CompareInfo Pointer )
            value.M_dataItem                                = GetInt32(new IntPtr(p + 0x098)); // 0245A2E63A90 0x98 M_dataItem                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Calendar                                  = GetObject<Calendar>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Calendar.FromPointer); // 0245A2E63AB0 0xA0 Calendar                    ( 0001865A0F00 ModelClassType Calendar Calendar Calendar Pointer )
            value.Parent_culture                            = GetObject<CultureInfo>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A2E63AD0 0xA8 Parent_culture              ( 0001865B5970 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.Constructed                               = GetBool(new IntPtr(p + 0x0B0)); // 0245A2E63AF0 0xB0 Constructed                 ( 0001865974C0 ModelPrimitiveType bool bool bool Bool )
            value.Cached_serialized_form                    = GetSByteList(new IntPtr(p + 0x0B8)); // 0245A2E63B10 0xB8 Cached_serialized_form      ( 000185B7A6C0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_cultureData                             = GetObject<CultureData>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CultureData.FromPointer); // 0245A2E63B30 0xC0 M_cultureData               ( 0001866668A0 ModelClassType CultureData CultureData CultureData Pointer )
            value.M_isInherited                             = GetBool(new IntPtr(p + 0x0C8)); // 0245A2E63B50 0xC8 M_isInherited               ( 0001865976C0 ModelPrimitiveType bool bool bool Bool )
            value.S_DefaultThreadCurrentUICulture           = GetObject<CultureInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A2E63BF0 0x18 S_DefaultThreadCurrentUICulture ( 0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.S_DefaultThreadCurrentCulture             = GetObject<CultureInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A2E63C10 0x20 S_DefaultThreadCurrentCulture ( 0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.S_UserPreferredCultureInfoInAppX          = GetObject<CultureInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.CultureInfo.FromPointer); // 0245A2E63C70 0x38 S_UserPreferredCultureInfoInAppX ( 0001865B4CE0 ModelClassType CultureInfo CultureInfo CultureInfo Pointer )
            value.IsTaiwanSku                               = GetBool(new IntPtr(p + 0x040)); // 0245A2E63C90 0x40 IsTaiwanSku                 ( 000186596FC0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
