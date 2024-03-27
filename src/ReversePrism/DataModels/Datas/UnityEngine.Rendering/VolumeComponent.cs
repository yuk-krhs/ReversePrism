using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Active                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 020 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 028 ParameterList                            000185D1C6D8 ModelClassListType List`1<VolumeParameter> List`1<VolumeParameter> List<VolumeParameter> Pointer
    // 030 m_ParameterReadOnlyCollection            ReadOnlyCollection`1<VolumeParameter> IL2CPP_TYPE_GENERICINST
    public partial class VolumeComponent
    {
        public bool                                     Active                                  { get; set; }
        public string                                   DisplayName                             { get; set; }
        public List<VolumeParameter>?                   ParameterList                           { get; set; }

        public static VolumeComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VolumeComponent();

            value.Active                                    = GetBool(new IntPtr(p + 0x018)); // 0270D9158E28 0x18 Active                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.DisplayName                               = GetString(new IntPtr(p + 0x020)); // 0270D9158E48 0x20 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ParameterList                             = GetObjectList<VolumeParameter>(new IntPtr(p + 0x028), ReversePrism.DataModels.VolumeParameter.FromPointer); // 0270D9158E68 0x28 ParameterList               ( 000185D1C6D8 ModelClassListType List`1<VolumeParameter> List`1<VolumeParameter> List<VolumeParameter> Pointer )

            return value;
        }
    }
}
