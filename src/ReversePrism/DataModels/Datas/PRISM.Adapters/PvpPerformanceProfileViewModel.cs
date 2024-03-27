using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866736C0 ModelPrimitiveType string string string String
    // 018 Ranking                                  0001865F4940 ModelPrimitiveType int int int Int32
    // 020 AchievementIds                           000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 028 ProduceIdolId                            0001865F4940 ModelPrimitiveType int int int Int32
    public partial class PvpPerformanceProfileViewModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Ranking                                 { get; set; }
        public List<int>?                               AchievementIds                          { get; set; }
        public int                                      ProduceIdolId                           { get; set; }

        public static PvpPerformanceProfileViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpPerformanceProfileViewModel();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D66BA188 0x10 Name                        ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Ranking                                   = GetInt32(new IntPtr(p + 0x018)); // 0270D66BA1A8 0x18 Ranking                     ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.AchievementIds                            = GetInt32List(new IntPtr(p + 0x020)); // 0270D66BA1C8 0x20 AchievementIds              ( 000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.ProduceIdolId                             = GetInt32(new IntPtr(p + 0x028)); // 0270D66BA1E8 0x28 ProduceIdolId               ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
