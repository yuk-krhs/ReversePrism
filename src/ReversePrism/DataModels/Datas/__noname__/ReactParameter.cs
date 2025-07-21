using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parameter                                ModelEnumType Parameter Parameter Parameter Int32
    // 03C Type                                     ModelEnumType ReactType ReactType ReactType Int32
    // 040 EnablePausingCue                         ModelPrimitiveType bool bool bool Bool
    public partial class ReactParameter : DataModel
    {
        public Parameter                                Parameter                               { get; set; }
        public ReactType                                Type                                    { get; set; }
        public bool                                     EnablePausingCue                        { get; set; }

        public static ReactParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReactParameter() { Pointer= p0 };

            value.Parameter                                 = (Parameter)GetInt32(new IntPtr(p + 0x010)); // 0x10 Parameter                   ( ModelEnumType Parameter Parameter Parameter Int32 )
            value.Type                                      = (ReactType)GetInt32(new IntPtr(p + 0x03C)); // 0x3C Type                        ( ModelEnumType ReactType ReactType ReactType Int32 )
            value.EnablePausingCue                          = GetBool(new IntPtr(p + 0x040)); // 0x40 EnablePausingCue            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
