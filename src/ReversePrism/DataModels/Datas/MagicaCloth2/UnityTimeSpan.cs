using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Stime                                    ModelPrimitiveType float float float Single
    // 01C Etime                                    ModelPrimitiveType float float float Single
    // 020 IsFinish                                 ModelPrimitiveType bool bool bool Bool
    public partial class UnityTimeSpan : DataModel
    {
        public string                                   Name                                    { get; set; }
        public float                                    Stime                                   { get; set; }
        public float                                    Etime                                   { get; set; }
        public bool                                     IsFinish                                { get; set; }

        public static UnityTimeSpan? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityTimeSpan() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Stime                                     = GetSingle(new IntPtr(p + 0x018)); // 0x18 Stime                       ( ModelPrimitiveType float float float Single )
            value.Etime                                     = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Etime                       ( ModelPrimitiveType float float float Single )
            value.IsFinish                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 IsFinish                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
