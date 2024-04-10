using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C EndFrame                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Description                              0001866722E0 ModelPrimitiveType string string string String
    // 028 FocusTargets                             000185CBEC18 ModelEnumListType Position[] Position[] List<Position> Pointer
    // 030 IsDolly                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 Effect                                   0001866722E0 ModelPrimitiveType string string string String
    public partial class TimelineCameraCutData : DataModel
    {
        public string                                   Name                                    { get; set; }
        public int                                      StartFrame                              { get; set; }
        public int                                      EndFrame                                { get; set; }
        public string                                   Description                             { get; set; }
        public List<Position>?                          FocusTargets                            { get; set; }
        public bool                                     IsDolly                                 { get; set; }
        public string                                   Effect                                  { get; set; }

        public static TimelineCameraCutData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimelineCameraCutData() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 024664F0C798 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 024664F0C7B8 0x18 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.EndFrame                                  = GetInt32(new IntPtr(p + 0x01C)); // 024664F0C7D8 0x1C EndFrame                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 024664F0C7F8 0x20 Description                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FocusTargets                              = GetEnumList<Position>(new IntPtr(p + 0x028)); // 024664F0C818 0x28 FocusTargets                ( 000185CBEC18 ModelEnumListType Position[] Position[] List<Position> Pointer )
            value.IsDolly                                   = GetBool(new IntPtr(p + 0x030)); // 024664F0C838 0x30 IsDolly                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Effect                                    = GetString(new IntPtr(p + 0x038)); // 024664F0C858 0x38 Effect                      ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
