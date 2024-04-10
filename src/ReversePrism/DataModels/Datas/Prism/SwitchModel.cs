using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SwitchID                                 000186671910 ModelPrimitiveType string string string String
    // 028 SwitchUnitData                           000185CC3AE8 ModelClassListType SwitchUnitData[] SwitchUnitData[] List<SwitchUnitData> Pointer
    // 030 SwitchMaterialRenderer                   000185CA0CE8 ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer
    // 038 Texture                                  000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 040 CurrentUnitNo                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 ResetFlag                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    public partial class SwitchModel : DataModel
    {
        public string                                   SwitchID                                { get; set; }
        public List<SwitchUnitData>?                    SwitchUnitData                          { get; set; }
        public List<Renderer>?                          SwitchMaterialRenderer                  { get; set; }
        public List<Texture2D>?                         Texture                                 { get; set; }
        public int                                      CurrentUnitNo                           { get; set; }
        public bool                                     ResetFlag                               { get; set; }
        public Character?                               Character                               { get; set; }

        public static SwitchModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchModel() { Pointer= p0 };

            value.SwitchID                                  = GetString(new IntPtr(p + 0x020)); // 0245A69CE660 0x20 SwitchID                    ( 000186671910 ModelPrimitiveType string string string String )
            value.SwitchUnitData                            = GetObjectList<SwitchUnitData>(new IntPtr(p + 0x028), ReversePrism.DataModels.SwitchUnitData.FromPointer); // 0245A69CE680 0x28 SwitchUnitData              ( 000185CC3AE8 ModelClassListType SwitchUnitData[] SwitchUnitData[] List<SwitchUnitData> Pointer )
            value.SwitchMaterialRenderer                    = GetObjectList<Renderer>(new IntPtr(p + 0x030), ReversePrism.DataModels.Renderer.FromPointer); // 0245A69CE6A0 0x30 SwitchMaterialRenderer      ( 000185CA0CE8 ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer )
            value.Texture                                   = GetObjectList<Texture2D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A69CE6C0 0x38 Texture                     ( 000185CAB1C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.CurrentUnitNo                             = GetInt32(new IntPtr(p + 0x040)); // 0245A69CE6E0 0x40 CurrentUnitNo               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResetFlag                                 = GetBool(new IntPtr(p + 0x044)); // 0245A69CE700 0x44 ResetFlag                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x048), ReversePrism.DataModels.Character.FromPointer); // 0245A69CE720 0x48 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )

            return value;
        }
    }
}
