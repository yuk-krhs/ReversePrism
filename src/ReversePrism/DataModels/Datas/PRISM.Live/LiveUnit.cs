using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Id                                       ModelPrimitiveType int int int Int32
    // 020 Idols                                    ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 028 SupportMemberInfo                        ModelEnumType LiveSupportMemberInfo LiveSupportMemberInfo LiveSupportMemberInfo Int32
    // 070 IsSummer                                 ModelPrimitiveType bool bool bool Bool
    public partial class LiveUnit : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      Id                                      { get; set; }
        public List<LiveIdol>?                          Idols                                   { get; set; }
        public LiveSupportMemberInfo                    SupportMemberInfo                       { get; set; }
        public bool                                     IsSummer                                { get; set; }

        public static LiveUnit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnit() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Id                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Id                          ( ModelPrimitiveType int int int Int32 )
            value.Idols                                     = GetObjectList<LiveIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveIdol.FromPointer); // 0x20 Idols                       ( ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.SupportMemberInfo                         = (LiveSupportMemberInfo)GetInt32(new IntPtr(p + 0x028)); // 0x28 SupportMemberInfo           ( ModelEnumType LiveSupportMemberInfo LiveSupportMemberInfo LiveSupportMemberInfo Int32 )
            value.IsSummer                                  = GetBool(new IntPtr(p + 0x070)); // 0x70 IsSummer                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
