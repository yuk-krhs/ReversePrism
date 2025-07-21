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
    // 010 S_cacheCount                             ModelPrimitiveType int int int Int32
    // 018 S_cacheFirst                             ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 020 S_cacheLast                              ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 028 S_maximumMatchTimeout                    ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 000 DefaultMatchTimeout_ConfigKeyName        string IL2CPP_TYPE_STRING
    // 030 S_defaultMatchTimeout                    ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 038 InfiniteMatchTimeout                     ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 010 InternalMatchTimeout                     ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 000 MaxOptionShift                           int IL2CPP_TYPE_I4
    // 018 Pattern                                  ModelPrimitiveType string string string String
    // 020 Roptions                                 ModelEnumType RegexOptions RegexOptions RegexOptions Int32
    // 028 Factory                                  ModelClassType RegexRunnerFactory RegexRunnerFactory RegexRunnerFactory Pointer
    // 030 Caps                                     ModelClassType Hashtable Hashtable Hashtable Pointer
    // 038 Capnames                                 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 040 Capslist                                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 048 Capsize                                  ModelPrimitiveType int int int Int32
    // 050 Runnerref                                ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer
    // 058 _replref                                 WeakReference`1<RegexReplacement> IL2CPP_TYPE_GENERICINST
    // 060 Code                                     ModelClassType RegexCode RegexCode RegexCode Pointer
    // 068 RefsInitialized                          ModelPrimitiveType bool bool bool Bool
    public partial class Regex : DataModel
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
            var value   = new Regex() { Pointer= p0 };

            value.S_cacheCount                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 S_cacheCount                ( ModelPrimitiveType int int int Int32 )
            value.S_cacheFirst                              = GetObject<CachedCodeEntry>(new IntPtr(p + 0x018), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0x18 S_cacheFirst                ( ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.S_cacheLast                               = GetObject<CachedCodeEntry>(new IntPtr(p + 0x020), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0x20 S_cacheLast                 ( ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.S_maximumMatchTimeout                     = (TimeSpan)GetInt32(new IntPtr(p + 0x028)); // 0x28 S_maximumMatchTimeout       ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.S_defaultMatchTimeout                     = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 0x30 S_defaultMatchTimeout       ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.InfiniteMatchTimeout                      = (TimeSpan)GetInt32(new IntPtr(p + 0x038)); // 0x38 InfiniteMatchTimeout        ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.InternalMatchTimeout                      = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0x10 InternalMatchTimeout        ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.Pattern                                   = GetString(new IntPtr(p + 0x018)); // 0x18 Pattern                     ( ModelPrimitiveType string string string String )
            value.Roptions                                  = (RegexOptions)GetInt32(new IntPtr(p + 0x020)); // 0x20 Roptions                    ( ModelEnumType RegexOptions RegexOptions RegexOptions Int32 )
            value.Factory                                   = GetObject<RegexRunnerFactory>(new IntPtr(p + 0x028), ReversePrism.DataModels.RegexRunnerFactory.FromPointer); // 0x28 Factory                     ( ModelClassType RegexRunnerFactory RegexRunnerFactory RegexRunnerFactory Pointer )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x030), ReversePrism.DataModels.Hashtable.FromPointer); // 0x30 Caps                        ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capnames                                  = GetObject<Hashtable>(new IntPtr(p + 0x038), ReversePrism.DataModels.Hashtable.FromPointer); // 0x38 Capnames                    ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capslist                                  = GetStringList(new IntPtr(p + 0x040)); // 0x40 Capslist                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Capsize                                   = GetInt32(new IntPtr(p + 0x048)); // 0x48 Capsize                     ( ModelPrimitiveType int int int Int32 )
            value.Runnerref                                 = GetObject<ExclusiveReference>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExclusiveReference.FromPointer); // 0x50 Runnerref                   ( ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer )
            value.Code                                      = GetObject<RegexCode>(new IntPtr(p + 0x060), ReversePrism.DataModels.RegexCode.FromPointer); // 0x60 Code                        ( ModelClassType RegexCode RegexCode RegexCode Pointer )
            value.RefsInitialized                           = GetBool(new IntPtr(p + 0x068)); // 0x68 RefsInitialized             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
