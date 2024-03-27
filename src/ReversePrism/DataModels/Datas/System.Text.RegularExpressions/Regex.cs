using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CacheDictionarySwitchLimit               int IL2CPP_TYPE_I4
    // 000 s_cacheSize                              int IL2CPP_TYPE_I4
    // 008 s_cache                                  Dictionary`2<CachedCodeEntryKey, CachedCodeEntry> IL2CPP_TYPE_GENERICINST
    // 010 S_cacheCount                             0001865F38E0 ModelPrimitiveType int int int Int32
    // 018 S_cacheFirst                             00018670BD10 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 020 S_cacheLast                              00018670BD10 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 028 S_maximumMatchTimeout                    00018668BA00 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 000 DefaultMatchTimeout_ConfigKeyName        string IL2CPP_TYPE_STRING
    // 030 S_defaultMatchTimeout                    00018668BC50 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 038 InfiniteMatchTimeout                     00018668BEB0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 010 InternalMatchTimeout                     00018668AD90 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 000 MaxOptionShift                           int IL2CPP_TYPE_I4
    // 018 Pattern                                  000186672090 ModelPrimitiveType string string string String
    // 020 Roptions                                 00018663EE20 ModelEnumType RegexOptions RegexOptions RegexOptions Int32
    // 028 Factory                                  000186640BF0 ModelClassType RegexRunnerFactory RegexRunnerFactory RegexRunnerFactory Pointer
    // 030 Caps                                     0001865DEA60 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 Capnames                                 0001865DEA60 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 Capslist                                 000185B818A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 Capsize                                  0001865F3400 ModelPrimitiveType int int int Int32
    // 050 Runnerref                                000186520B90 ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer
    // 058 _replref                                 WeakReference`1<RegexReplacement> IL2CPP_TYPE_GENERICINST
    // 060 Code                                     00018663CC00 ModelClassType RegexCode RegexCode RegexCode Pointer
    // 068 RefsInitialized                          000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class Regex
    {
        public int                                      S_cacheCount                            { get; set; }
        public CachedCodeEntry?                         S_cacheFirst                            { get; set; }
        public CachedCodeEntry?                         S_cacheLast                             { get; set; }
        public TimeSpan                                 S_maximumMatchTimeout                   { get; set; }
        public TimeSpan                                 S_defaultMatchTimeout                   { get; set; }
        public TimeSpan                                 InfiniteMatchTimeout                    { get; set; }
        public TimeSpan                                 InternalMatchTimeout                    { get; set; }
        public string                                   Pattern                                 { get; set; }
        public RegexOptions                             Roptions                                { get; set; }
        public RegexRunnerFactory?                      Factory                                 { get; set; }
        public Hashtable?                               Caps                                    { get; set; }
        public Hashtable?                               Capnames                                { get; set; }
        public List<string>?                            Capslist                                { get; set; }
        public int                                      Capsize                                 { get; set; }
        public ExclusiveReference?                      Runnerref                               { get; set; }
        public RegexCode?                               Code                                    { get; set; }
        public bool                                     RefsInitialized                         { get; set; }

        public static Regex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Regex();

            value.S_cacheCount                              = GetInt32(new IntPtr(p + 0x010)); // 0270033D0E50 0x10 S_cacheCount                ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.S_cacheFirst                              = GetObject<CachedCodeEntry>(new IntPtr(p + 0x018), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0270033D0E70 0x18 S_cacheFirst                ( 00018670BD10 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.S_cacheLast                               = GetObject<CachedCodeEntry>(new IntPtr(p + 0x020), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0270033D0E90 0x20 S_cacheLast                 ( 00018670BD10 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.S_maximumMatchTimeout                     = (TimeSpan)GetInt32(new IntPtr(p + 0x028)); // 0270033D0EB0 0x28 S_maximumMatchTimeout       ( 00018668BA00 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.S_defaultMatchTimeout                     = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 0270033D0EF0 0x30 S_defaultMatchTimeout       ( 00018668BC50 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.InfiniteMatchTimeout                      = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 0270033D0F10 0x38 InfiniteMatchTimeout        ( 00018668BEB0 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.InternalMatchTimeout                      = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0270033D0F30 0x10 InternalMatchTimeout        ( 00018668AD90 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Pattern                                   = GetString(new IntPtr(p + 0x018)); // 0270033D0F70 0x18 Pattern                     ( 000186672090 ModelPrimitiveType string string string String )
            value.Roptions                                  = (RegexOptions)GetInt32(new IntPtr(p + 0x020)); // 0270033D0F90 0x20 Roptions                    ( 00018663EE20 ModelEnumType RegexOptions RegexOptions RegexOptions Int32 )
            value.Factory                                   = GetObject<RegexRunnerFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.RegexRunnerFactory.FromPointer); // 0270033D0FB0 0x28 Factory                     ( 000186640BF0 ModelClassType RegexRunnerFactory RegexRunnerFactory RegexRunnerFactory Pointer )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 0270033D0FD0 0x30 Caps                        ( 0001865DEA60 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capnames                                  = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0270033D0FF0 0x38 Capnames                    ( 0001865DEA60 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capslist                                  = GetStringList(new IntPtr(p + 0x040)); // 0270033D1010 0x40 Capslist                    ( 000185B818A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Capsize                                   = GetInt32(new IntPtr(p + 0x048)); // 0270033D1030 0x48 Capsize                     ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runnerref                                 = GetObject<ExclusiveReference>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExclusiveReference.FromPointer); // 0270033D1050 0x50 Runnerref                   ( 000186520B90 ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer )
            value.Code                                      = GetObject<RegexCode>(new IntPtr(p + 0x060), ReversePrism.DataModels.RegexCode.FromPointer); // 0270033D1090 0x60 Code                        ( 00018663CC00 ModelClassType RegexCode RegexCode RegexCode Pointer )
            value.RefsInitialized                           = GetBool(new IntPtr(p + 0x068)); // 0270033D10B0 0x68 RefsInitialized             ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
