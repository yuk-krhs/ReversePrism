using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Onerep                                   int IL2CPP_TYPE_I4
    // 000 Notonerep                                int IL2CPP_TYPE_I4
    // 000 Setrep                                   int IL2CPP_TYPE_I4
    // 000 Oneloop                                  int IL2CPP_TYPE_I4
    // 000 Notoneloop                               int IL2CPP_TYPE_I4
    // 000 Setloop                                  int IL2CPP_TYPE_I4
    // 000 Onelazy                                  int IL2CPP_TYPE_I4
    // 000 Notonelazy                               int IL2CPP_TYPE_I4
    // 000 Setlazy                                  int IL2CPP_TYPE_I4
    // 000 One                                      int IL2CPP_TYPE_I4
    // 000 Notone                                   int IL2CPP_TYPE_I4
    // 000 Set                                      int IL2CPP_TYPE_I4
    // 000 Multi                                    int IL2CPP_TYPE_I4
    // 000 Ref                                      int IL2CPP_TYPE_I4
    // 000 Bol                                      int IL2CPP_TYPE_I4
    // 000 Eol                                      int IL2CPP_TYPE_I4
    // 000 Boundary                                 int IL2CPP_TYPE_I4
    // 000 Nonboundary                              int IL2CPP_TYPE_I4
    // 000 Beginning                                int IL2CPP_TYPE_I4
    // 000 Start                                    int IL2CPP_TYPE_I4
    // 000 EndZ                                     int IL2CPP_TYPE_I4
    // 000 End                                      int IL2CPP_TYPE_I4
    // 000 Nothing                                  int IL2CPP_TYPE_I4
    // 000 Lazybranch                               int IL2CPP_TYPE_I4
    // 000 Branchmark                               int IL2CPP_TYPE_I4
    // 000 Lazybranchmark                           int IL2CPP_TYPE_I4
    // 000 Nullcount                                int IL2CPP_TYPE_I4
    // 000 Setcount                                 int IL2CPP_TYPE_I4
    // 000 Branchcount                              int IL2CPP_TYPE_I4
    // 000 Lazybranchcount                          int IL2CPP_TYPE_I4
    // 000 Nullmark                                 int IL2CPP_TYPE_I4
    // 000 Setmark                                  int IL2CPP_TYPE_I4
    // 000 Capturemark                              int IL2CPP_TYPE_I4
    // 000 Getmark                                  int IL2CPP_TYPE_I4
    // 000 Setjump                                  int IL2CPP_TYPE_I4
    // 000 Backjump                                 int IL2CPP_TYPE_I4
    // 000 Forejump                                 int IL2CPP_TYPE_I4
    // 000 Testref                                  int IL2CPP_TYPE_I4
    // 000 Goto                                     int IL2CPP_TYPE_I4
    // 000 Prune                                    int IL2CPP_TYPE_I4
    // 000 Stop                                     int IL2CPP_TYPE_I4
    // 000 ECMABoundary                             int IL2CPP_TYPE_I4
    // 000 NonECMABoundary                          int IL2CPP_TYPE_I4
    // 000 Mask                                     int IL2CPP_TYPE_I4
    // 000 Rtl                                      int IL2CPP_TYPE_I4
    // 000 Back                                     int IL2CPP_TYPE_I4
    // 000 Back2                                    int IL2CPP_TYPE_I4
    // 000 Ci                                       int IL2CPP_TYPE_I4
    // 010 Codes                                    000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 Strings                                  000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 TrackCount                               0001865F4940 ModelPrimitiveType int int int Int32
    // 028 Caps                                     0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 030 CapSize                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 038 FCPrefix                                 Nullable`1<RegexPrefix> IL2CPP_TYPE_GENERICINST
    // 050 BMPrefix                                 00018663C230 ModelClassType RegexBoyerMoore RegexBoyerMoore RegexBoyerMoore Pointer
    // 058 Anchors                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 05C RightToLeft                              000186596AF0 ModelPrimitiveType bool bool bool Bool
    public partial class RegexCode
    {
        public List<int>?                               Codes                                   { get; set; }
        public List<string>?                            Strings                                 { get; set; }
        public int                                      TrackCount                              { get; set; }
        public Hashtable?                               Caps                                    { get; set; }
        public int                                      CapSize                                 { get; set; }
        public RegexBoyerMoore?                         BMPrefix                                { get; set; }
        public int                                      Anchors                                 { get; set; }
        public bool                                     RightToLeft                             { get; set; }

        public static RegexCode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexCode();

            value.Codes                                     = GetInt32List(new IntPtr(p + 0x010)); // 027003423EE0 0x10 Codes                       ( 000185B7DC00 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Strings                                   = GetStringList(new IntPtr(p + 0x018)); // 027003423F00 0x18 Strings                     ( 000185B81FB0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.TrackCount                                = GetInt32(new IntPtr(p + 0x020)); // 027003423F20 0x20 TrackCount                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Caps                                      = GetObject<Hashtable>(new IntPtr(p + 0x028), ReversePrism.DataModels.Hashtable.FromPointer); // 027003423F40 0x28 Caps                        ( 0001865DF650 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.CapSize                                   = GetInt32(new IntPtr(p + 0x030)); // 027003423F60 0x30 CapSize                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.BMPrefix                                  = GetObject<RegexBoyerMoore>(new IntPtr(p + 0x050), ReversePrism.DataModels.RegexBoyerMoore.FromPointer); // 027003423FA0 0x50 BMPrefix                    ( 00018663C230 ModelClassType RegexBoyerMoore RegexBoyerMoore RegexBoyerMoore Pointer )
            value.Anchors                                   = GetInt32(new IntPtr(p + 0x058)); // 027003423FC0 0x58 Anchors                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.RightToLeft                               = GetBool(new IntPtr(p + 0x05C)); // 027003423FE0 0x5C RightToLeft                 ( 000186596AF0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
