using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 StartFrame                               ModelPrimitiveType int int int Int32
    // 01C EndFrame                                 ModelPrimitiveType int int int Int32
    // 020 Description                              ModelPrimitiveType string string string String
    // 028 FocusTargets                             ModelEnumListType Position[] Position[] List<Position> Pointer
    // 030 IsDolly                                  ModelPrimitiveType bool bool bool Bool
    // 038 Effect                                   ModelPrimitiveType string string string String
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 StartFrame                  ( ModelPrimitiveType int int int Int32 )
            value.EndFrame                                  = GetInt32(new IntPtr(p + 0x01C)); // 0x1C EndFrame                    ( ModelPrimitiveType int int int Int32 )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0x20 Description                 ( ModelPrimitiveType string string string String )
            value.FocusTargets                              = GetEnumList<Position>(new IntPtr(p + 0x028)); // 0x28 FocusTargets                ( ModelEnumListType Position[] Position[] List<Position> Pointer )
            value.IsDolly                                   = GetBool(new IntPtr(p + 0x030)); // 0x30 IsDolly                     ( ModelPrimitiveType bool bool bool Bool )
            value.Effect                                    = GetString(new IntPtr(p + 0x038)); // 0x38 Effect                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
