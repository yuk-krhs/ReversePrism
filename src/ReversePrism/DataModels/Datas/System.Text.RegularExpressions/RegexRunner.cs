using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Runtextbeg                               0001865F3400 ModelPrimitiveType int int int Int32
    // 014 Runtextend                               0001865F3400 ModelPrimitiveType int int int Int32
    // 018 Runtextstart                             0001865F3400 ModelPrimitiveType int int int Int32
    // 020 Runtext                                  000186672090 ModelPrimitiveType string string string String
    // 028 Runtextpos                               0001865F3400 ModelPrimitiveType int int int Int32
    // 030 Runtrack                                 000185B7D4A0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 Runtrackpos                              0001865F3400 ModelPrimitiveType int int int Int32
    // 040 Runstack                                 000185B7D4A0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 048 Runstackpos                              0001865F3400 ModelPrimitiveType int int int Int32
    // 050 Runcrawl                                 000185B7D4A0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 Runcrawlpos                              0001865F3400 ModelPrimitiveType int int int Int32
    // 05C Runtrackcount                            0001865F3400 ModelPrimitiveType int int int Int32
    // 060 Runmatch                                 0001865DC790 ModelClassType Match Match Match Pointer
    // 068 Runregex                                 00018663B3D0 ModelClassType Regex Regex Regex Pointer
    // 070 Timeout                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 IgnoreTimeout                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 TimeoutOccursAt                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TimeoutCheckFrequency                    int IL2CPP_TYPE_I4
    // 07C TimeoutChecksToSkip                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RegexRunner : DataModel
    {
        public int                                      Runtextbeg                              { get; set; }
        public int                                      Runtextend                              { get; set; }
        public int                                      Runtextstart                            { get; set; }
        public string                                   Runtext                                 { get; set; }
        public int                                      Runtextpos                              { get; set; }
        public List<int>?                               Runtrack                                { get; set; }
        public int                                      Runtrackpos                             { get; set; }
        public List<int>?                               Runstack                                { get; set; }
        public int                                      Runstackpos                             { get; set; }
        public List<int>?                               Runcrawl                                { get; set; }
        public int                                      Runcrawlpos                             { get; set; }
        public int                                      Runtrackcount                           { get; set; }
        public Match?                                   Runmatch                                { get; set; }
        public Regex?                                   Runregex                                { get; set; }
        public int                                      Timeout                                 { get; set; }
        public bool                                     IgnoreTimeout                           { get; set; }
        public int                                      TimeoutOccursAt                         { get; set; }
        public int                                      TimeoutChecksToSkip                     { get; set; }

        public static RegexRunner? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexRunner() { Pointer= p0 };

            value.Runtextbeg                                = GetInt32(new IntPtr(p + 0x010)); // 0245A01EB5D0 0x10 Runtextbeg                  ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runtextend                                = GetInt32(new IntPtr(p + 0x014)); // 0245A01EB5F0 0x14 Runtextend                  ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runtextstart                              = GetInt32(new IntPtr(p + 0x018)); // 0245A01EB610 0x18 Runtextstart                ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runtext                                   = GetString(new IntPtr(p + 0x020)); // 0245A01EB630 0x20 Runtext                     ( 000186672090 ModelPrimitiveType string string string String )
            value.Runtextpos                                = GetInt32(new IntPtr(p + 0x028)); // 0245A01EB650 0x28 Runtextpos                  ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runtrack                                  = GetInt32List(new IntPtr(p + 0x030)); // 0245A01EB670 0x30 Runtrack                    ( 000185B7D4A0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Runtrackpos                               = GetInt32(new IntPtr(p + 0x038)); // 0245A01EB690 0x38 Runtrackpos                 ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runstack                                  = GetInt32List(new IntPtr(p + 0x040)); // 0245A01EB6B0 0x40 Runstack                    ( 000185B7D4A0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Runstackpos                               = GetInt32(new IntPtr(p + 0x048)); // 0245A01EB6D0 0x48 Runstackpos                 ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runcrawl                                  = GetInt32List(new IntPtr(p + 0x050)); // 0245A01EB6F0 0x50 Runcrawl                    ( 000185B7D4A0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Runcrawlpos                               = GetInt32(new IntPtr(p + 0x058)); // 0245A01EB710 0x58 Runcrawlpos                 ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runtrackcount                             = GetInt32(new IntPtr(p + 0x05C)); // 0245A01EB730 0x5C Runtrackcount               ( 0001865F3400 ModelPrimitiveType int int int Int32 )
            value.Runmatch                                  = GetObject<Match>(new IntPtr(p + 0x060), ReversePrism.DataModels.Match.FromPointer); // 0245A01EB750 0x60 Runmatch                    ( 0001865DC790 ModelClassType Match Match Match Pointer )
            value.Runregex                                  = GetObject<Regex>(new IntPtr(p + 0x068), ReversePrism.DataModels.Regex.FromPointer); // 0245A01EB770 0x68 Runregex                    ( 00018663B3D0 ModelClassType Regex Regex Regex Pointer )
            value.Timeout                                   = GetInt32(new IntPtr(p + 0x070)); // 0245A01EB790 0x70 Timeout                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IgnoreTimeout                             = GetBool(new IntPtr(p + 0x074)); // 0245A01EB7B0 0x74 IgnoreTimeout               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TimeoutOccursAt                           = GetInt32(new IntPtr(p + 0x078)); // 0245A01EB7D0 0x78 TimeoutOccursAt             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TimeoutChecksToSkip                       = GetInt32(new IntPtr(p + 0x07C)); // 0245A01EB810 0x7C TimeoutChecksToSkip         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
