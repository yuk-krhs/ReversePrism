using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SwitchID                                 ModelPrimitiveType string string string String
    // 028 SwitchUnitData                           ModelClassListType SwitchUnitData[] SwitchUnitData[] List<SwitchUnitData> Pointer
    // 030 SwitchMaterialRenderer                   ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer
    // 038 Texture                                  ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 040 CurrentUnitNo                            ModelPrimitiveType int int int Int32
    // 044 ResetFlag                                ModelPrimitiveType bool bool bool Bool
    // 048 Character                                ModelClassType Character Character Character Pointer
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

            value.SwitchID                                  = GetString(new IntPtr(p + 0x020)); // 0x20 SwitchID                    ( ModelPrimitiveType string string string String )
            value.SwitchUnitData                            = GetObjectList<SwitchUnitData>(new IntPtr(p + 0x028), ReversePrism.DataModels.SwitchUnitData.FromPointer); // 0x28 SwitchUnitData              ( ModelClassListType SwitchUnitData[] SwitchUnitData[] List<SwitchUnitData> Pointer )
            value.SwitchMaterialRenderer                    = GetObjectList<Renderer>(new IntPtr(p + 0x030), ReversePrism.DataModels.Renderer.FromPointer); // 0x30 SwitchMaterialRenderer      ( ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer )
            value.Texture                                   = GetObjectList<Texture2D>(new IntPtr(p + 0x038), ReversePrism.DataModels.Texture2D.FromPointer); // 0x38 Texture                     ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.CurrentUnitNo                             = GetInt32(new IntPtr(p + 0x040)); // 0x40 CurrentUnitNo               ( ModelPrimitiveType int int int Int32 )
            value.ResetFlag                                 = GetBool(new IntPtr(p + 0x044)); // 0x44 ResetFlag                   ( ModelPrimitiveType bool bool bool Bool )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x048), ReversePrism.DataModels.Character.FromPointer); // 0x48 Character                   ( ModelClassType Character Character Character Pointer )

            return value;
        }
    }
}
