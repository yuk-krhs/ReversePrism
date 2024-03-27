using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Idols                                    000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 028 SupportMemberInfo                        000186585AF0 ModelEnumType LiveSupportMemberInfo LiveSupportMemberInfo LiveSupportMemberInfo Int32
    public partial class LiveUnit
    {
        public string                                   Name                                    { get; set; }
        public int                                      Id                                      { get; set; }
        public List<LiveIdol>?                          Idols                                   { get; set; }
        public LiveSupportMemberInfo                    SupportMemberInfo                       { get; set; }

        public static LiveUnit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnit();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D50EEEC8 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 0270D50EEEE8 0x18 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Idols                                     = GetObjectList<LiveIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveIdol.FromPointer); // 0270D50EEF08 0x20 Idols                       ( 000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.SupportMemberInfo                         = (LiveSupportMemberInfo)GetInt32(new IntPtr(p + 0x028)); // 0270D50EEF28 0x28 SupportMemberInfo           ( 000186585AF0 ModelEnumType LiveSupportMemberInfo LiveSupportMemberInfo LiveSupportMemberInfo Int32 )

            return value;
        }
    }
}
