using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 Text                                     ModelPrimitiveType string string string String
    // 020 IsCansel                                 ModelPrimitiveType bool bool bool Bool
    // 024 Sec                                      ModelPrimitiveType int int int Int32
    // 028 LocalY                                   ModelPrimitiveType float float float Single
    public partial class ProduceTutorialShowInfoTextEvent : DataModel
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
            var value   = new ProduceTutorialShowInfoTextEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Text                        ( ModelPrimitiveType string string string String )
            value.IsCansel                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsCansel                    ( ModelPrimitiveType bool bool bool Bool )
            value.Sec                                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 Sec                         ( ModelPrimitiveType int int int Int32 )
            value.LocalY                                    = GetSingle(new IntPtr(p + 0x028)); // 0x28 LocalY                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
