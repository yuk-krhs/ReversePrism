using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 IsFinished                               ModelPrimitiveType bool bool bool Bool
    // 054 TimeLimit                                ModelPrimitiveType float float float Single
    // 058 EventTime                                ModelPrimitiveType DateTime DateTime DateTime DateTime
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

            value.IsFinished                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsFinished                  ( ModelPrimitiveType bool bool bool Bool )
            value.TimeLimit                                 = GetSingle(new IntPtr(p + 0x054)); // 0x54 TimeLimit                   ( ModelPrimitiveType float float float Single )
            value.EventTime                                 = GetDateTime(new IntPtr(p + 0x058)); // 0x58 EventTime                   ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
