using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 018 Previous                                 ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer
    // 020 Key                                      ModelEnumType CachedCodeEntryKey CachedCodeEntryKey CachedCodeEntryKey Int32
    // 038 Code                                     ModelClassType RegexCode RegexCode RegexCode Pointer
    // 040 Caps                                     ModelClassType Hashtable Hashtable Hashtable Pointer
    // 048 Capnames                                 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 050 Capslist                                 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 058 Capsize                                  ModelPrimitiveType int int int Int32
    // 060 Runnerref                                ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer
    // 068 ReplRef                                  WeakReference`1<RegexReplacement> IL2CPP_TYPE_GENERICINST
    public partial class CachedCodeEntry : DataModel
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
            var value   = new CachedCodeEntry() { Pointer= p0 };

            value.Next                                      = GetObject<CachedCodeEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0x10 Next                        ( ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.Previous                                  = GetObject<CachedCodeEntry>(new IntPtr(p + 0x018), ReversePrism.DataModels.CachedCodeEntry.FromPointer); // 0x18 Previous                    ( ModelClassType CachedCodeEntry CachedCodeEntry CachedCodeEntry Pointer )
            value.Key                                       = (CachedCodeEntryKey)GetInt32(new IntPtr(p + 0x020)); // 0x20 Key                         ( ModelEnumType CachedCodeEntryKey CachedCodeEntryKey CachedCodeEntryKey Int32 )
            value.Code                                      = GetObject<RegexCode>(new IntPtr(p + 0x038), ReversePrism.DataModels.RegexCode.FromPointer); // 0x38 Code                        ( ModelClassType RegexCode RegexCode RegexCode Pointer )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x040), ReversePrism.DataModels.Hashtable.FromPointer); // 0x40 Caps                        ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capnames                                  = GetObject<Hashtable>(new IntPtr(p + 0x048), ReversePrism.DataModels.Hashtable.FromPointer); // 0x48 Capnames                    ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Capslist                                  = GetStringList(new IntPtr(p + 0x050)); // 0x50 Capslist                    ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Capsize                                   = GetInt32(new IntPtr(p + 0x058)); // 0x58 Capsize                     ( ModelPrimitiveType int int int Int32 )
            value.Runnerref                                 = GetObject<ExclusiveReference>(new IntPtr(p + 0x060), ReversePrism.DataModels.ExclusiveReference.FromPointer); // 0x60 Runnerref                   ( ModelClassType ExclusiveReference ExclusiveReference ExclusiveReference Pointer )

            return value;
        }
    }
}
