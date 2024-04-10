using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 StageName                                000186671910 ModelPrimitiveType string string string String
    // 028 StageSwitchCondition                     000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 030 Stage                                    0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 040 IsViewPaused                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsLoading                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StageView : DataModel
    {
        public string                                   StageName                               { get; set; }
        public List<string>?                            StageSwitchCondition                    { get; set; }
        public GameObject?                              Stage                                   { get; set; }
        public bool                                     IsViewPaused                            { get; set; }
        public bool                                     IsLoading                               { get; set; }

        public static StageView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StageView() { Pointer= p0 };

            value.StageName                                 = GetString(new IntPtr(p + 0x020)); // 024664FC4938 0x20 StageName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.StageSwitchCondition                      = GetStringList(new IntPtr(p + 0x028)); // 024664FC4958 0x28 StageSwitchCondition        ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Stage                                     = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 024664FC4978 0x30 Stage                       ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x040)); // 024664FC49B8 0x40 IsViewPaused                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLoading                                 = GetBool(new IntPtr(p + 0x041)); // 024664FC49D8 0x41 IsLoading                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
