using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 IsFinished                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05C TimeLimit                                0001866656B0 ModelPrimitiveType float float float Single
    // 060 EventTime                                0001865B9520 ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class ViewAnnouncer : DataModel
    {
        public bool                                     IsFinished                              { get; set; }
        public float                                    TimeLimit                               { get; set; }
        public DateTime                                 EventTime                               { get; set; }

        public static ViewAnnouncer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ViewAnnouncer() { Pointer= p0 };

            value.IsFinished                                = GetBool(new IntPtr(p + 0x058)); // 0245A42BE5C8 0x58 IsFinished                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TimeLimit                                 = GetSingle(new IntPtr(p + 0x05C)); // 0245A42BE5E8 0x5C TimeLimit                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.EventTime                                 = GetDateTime(new IntPtr(p + 0x060)); // 0245A42BE608 0x60 EventTime                   ( 0001865B9520 ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
