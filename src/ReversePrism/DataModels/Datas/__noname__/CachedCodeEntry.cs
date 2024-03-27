using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     00018670BA80 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 018 Previous                                 00018670BA80 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 020 Key                                      0001866C1870 ModelEnumType CachedCodeEntryKey CachedCodeEntryKey CachedCodeEntryKey Int32
    // 038 Code                                     00018663CE50 ModelClassType RegexCode RegexCode RegexCode Pointer
    // 040 Caps                                     0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 Capnames                                 0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 050 Capslist                                 000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 Capsize                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 060 Runnerref                                000186520E60 ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer
    // 068 ReplRef                                  WeakReference`1<RegexReplacement> IL2CPP_TYPE_GENERICINST
    public partial class CachedCodeEntry
    {
        public CachedCodeEntry?                         Next                                    { get; set; }
        public CachedCodeEntry?                         Previous                                { get; set; }
        public CachedCodeEntryKey                       Key                                     { get; set; }
        public RegexCode?                               Code                                    { get; set; }
        public Hashtable?                               Caps                                    { get; set; }
        public Hashtable?                               Capnames                                { get; set; }
        public List<string>?                            Capslist                                { get; set; }
        public int                                      Capsize                                 { get; set; }
        public ExclusiveReference?                      Runnerref                               { get; set; }

        public static CachedCodeEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedCodeEntry();

            value.Next                                      = GetObject<CachedCodeEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0270033F51C8 0x10 Next                        ( 00018670BA80 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.Previous                                  = GetObject<CachedCodeEntry>(new IntPtr(p + 0x018), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0270033F51E8 0x18 Previous                    ( 00018670BA80 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.Key                                       = (CachedCodeEntryKey)GetInt32(new IntPtr(p + 0x020)); // 0270033F5208 0x20 Key                         ( 0001866C1870 ModelEnumType CachedCodeEntryKey CachedCodeEntryKey CachedCodeEntryKey Int32 )
            value.Code                                      = GetObject<RegexCode>(new IntPtr(p + 0x038), ReversePrism.DataModels.RegexCode.FromPointer); // 0270033F5228 0x38 Code                        ( 00018663CE50 ModelClassType RegexCode RegexCode RegexCode Pointer )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0270033F5248 0x40 Caps                        ( 0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capnames                                  = GetObject<Hashtable>(new IntPtr(p + 0x048), ReversePrism.DataModels.Hashtable.FromPointer); // 0270033F5268 0x48 Capnames                    ( 0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capslist                                  = GetStringList(new IntPtr(p + 0x050)); // 0270033F5288 0x50 Capslist                    ( 000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Capsize                                   = GetInt32(new IntPtr(p + 0x058)); // 0270033F52A8 0x58 Capsize                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Runnerref                                 = GetObject<ExclusiveReference>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExclusiveReference.FromPointer); // 0270033F52C8 0x60 Runnerref                   ( 000186520E60 ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer )

            return value;
        }
    }
}
