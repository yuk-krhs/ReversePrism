using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 Text                                     000186671910 ModelPrimitiveType string string string String
    // 020 IsCansel                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 Sec                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 LocalY                                   0001866656B0 ModelPrimitiveType float float float Single
    public partial class ProduceTutorialShowInfoTextEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public string                                   Text                                    { get; set; }
        public bool                                     IsCansel                                { get; set; }
        public int                                      Sec                                     { get; set; }
        public float                                    LocalY                                  { get; set; }

        public static ProduceTutorialShowInfoTextEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowInfoTextEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D3EF38 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0270D5D3EF58 0x18 Text                        ( 000186671910 ModelPrimitiveType string string string String )
            value.IsCansel                                  = GetBool(new IntPtr(p + 0x020)); // 0270D5D3EF78 0x20 IsCansel                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Sec                                       = GetInt32(new IntPtr(p + 0x024)); // 0270D5D3EF98 0x24 Sec                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LocalY                                    = GetSingle(new IntPtr(p + 0x028)); // 0270D5D3EFB8 0x28 LocalY                      ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
